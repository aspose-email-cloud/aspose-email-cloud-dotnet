using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Client;
using Aspose.Email.Cloud.Sdk.Model;
using Aspose.Email.Cloud.Sdk.Model.Requests;
using Aspose.Email.Cloud.Sdk.Tests.Utils;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Tests
{
    [TestFixture]
    public class TestsFixture
    {
        private const string StorageName = "First Storage";
        private const string BcrAiTestFilePath = "TestData/test_single_0001.png";
        private EmailApi emailApi;
        private string folder;

        /// <summary>
        /// EmailApi setup.
        /// Uses ConfigurationHelper to get appKey, appSid and apiBaseUrl.
        /// This data can be configured using:
        /// - NUnit test parameters (command line "--params" or from runsettings file
        /// - Environment Variables
        /// - Add fields to appsettings.json 
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            folder = Guid.NewGuid().ToString();
            var configurationHelper = ConfigurationHelper.Get(TestContext.Parameters);
            var apiConfiguration = new Configuration
            {
                ApiVersion = "v3.0",
                ApiBaseUrl =
                    configurationHelper.GetValue("apiBaseUrl", "https://api-qa.aspose.cloud"),
                AppKey = configurationHelper.GetValue("appKey", string.Empty),
                AppSid = configurationHelper.GetValue("appSid", string.Empty),
                AuthUrl = configurationHelper.GetValue<string>("authUrl", null)
            };
            emailApi = new EmailApi(apiConfiguration);
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            var existRequest = new ObjectExistsRequest(folder, StorageName);
            var folderExist = await emailApi.ObjectExistsAsync(existRequest);
            if (folderExist.Exists == true && folderExist.IsFolder == true)
            {
                var deleteRequest = new DeleteFolderRequest(folder, StorageName, true);
                emailApi.DeleteFolder(deleteRequest);
            }
        }

        /// <summary>
        /// Synchronous API call test
        /// </summary>
        [Test]
        [Pipeline]
        public async Task SyncTest()
        {
            var calendarFile = await CreateCalendar();
            var request = new GetCalendarRequest(calendarFile, folder, StorageName);
            var calendar = emailApi.GetCalendar(request);
            Assert.AreEqual("CALENDAR", calendar.Name);
        }

        /// <summary>
        /// HierarchicalObject serialization and deserialization test.
        /// This test checks that BaseObject.Type field filled automatically by SDK
        /// and properly used in serialization and deserialization
        /// </summary>
        [Test]
        [Pipeline]
        public async Task HierarchicalTest()
        {
            var calendarFile = await CreateCalendar();
            var calendar = await emailApi.GetCalendarAsync(
                new GetCalendarRequest(calendarFile, folder, StorageName));
            Assert.AreEqual("CALENDAR", calendar.Name);
            Assert.GreaterOrEqual(
                calendar.InternalProperties
                    .Count(property => property.GetType() == typeof(PrimitiveObject)),
                1);
            Assert.GreaterOrEqual(
                calendar.InternalProperties
                    .Count(property => property.GetType() == typeof(HierarchicalObject)),
                1);
        }

        /// <summary>
        /// System.IO.Stream support test
        /// </summary>
        [Test]
        [Pipeline]
        public async Task StreamTest()
        {
            var calendarFile = await CreateCalendar();
            var newFileName = $"{Guid.NewGuid().ToString()}.ics";
            var newPath = $"{folder}/{newFileName}";
            using (var stream = await emailApi.DownloadFileAsync(
                new DownloadFileRequest($"{folder}/{calendarFile}", StorageName)))
            {
                var uploadRequest = new UploadFileRequest(newPath, stream, StorageName);
                await emailApi.UploadFileAsync(uploadRequest);
            }

            var newFileExist = await emailApi.ObjectExistsAsync(
                new ObjectExistsRequest(newPath, StorageName));
            Assert.IsTrue(newFileExist.Exists);
            Assert.IsFalse(newFileExist.IsFolder);
        }

        /// <summary>
        /// Contact format specified as Enum, but SDK represents it as a string.
        /// Test checks that value parsing works properly
        /// </summary>
        [Test]
        [Pipeline]
        public async Task ContactFormatTest()
        {
            foreach (var format in new[] {"vcard", "msg"})
            {
                var extension = format == "vcard" ? ".vcf" : ".msg";
                var name = $"{Guid.NewGuid().ToString()}{extension}";
                await emailApi.CreateContactAsync(new CreateContactRequest(format, name,
                    new HierarchicalObjectRequest(
                        new HierarchicalObject("CONTACT", null, new List<BaseObject>()),
                        new StorageFolderLocation(StorageName, folder))));
                var contactExist = await IsFileExist(name);
                Assert.IsTrue(contactExist);
            }
        }

        /// <summary>
        /// Test DateTime serialization and deserialization.
        /// Checks that SDK and Backend do not change DateTime during processing.
        /// In most cases developer should carefully serialize and deserialize DateTime
        /// </summary>
        [Test]
        [Pipeline]
        public async Task DateTimeTest()
        {
            var startDate = DateTime.UtcNow.Date.AddDays(1).AddHours(12);
            var calendarFile = await CreateCalendar(startDate);
            var calendar =
                await emailApi.GetCalendarAsync(new GetCalendarRequest(calendarFile, folder,
                    StorageName));
            var startDateProperty = calendar.InternalProperties
                .First(property => property.Name == "STARTDATE");
            var factStartDate = DateTime
                .Parse(((PrimitiveObject) startDateProperty).Value)
                .ToUniversalTime();
            Assert.AreEqual(startDate, factStartDate);
        }

        /// <summary>
        /// Test name gender detection
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameGenderizeTest()
        {
            var result =
                await emailApi.AiNameGenderizeAsync(new AiNameGenderizeRequest("John Cane"));
            Assert.GreaterOrEqual(result.Value.Count, 1);
            Assert.True(result.Value.Any(item => item.Gender == "Male"));
        }

        /// <summary>
        /// Test name formatting
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameFormatTest()
        {
            var result = await emailApi.AiNameFormatAsync(
                new AiNameFormatRequest("Mr. John Michael Cane", format: "%t%L%f%m"));
            Assert.AreEqual("Mr. Cane J. M.", result.Name);
        }

        /// <summary>
        /// Name match test.
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameMatchTest()
        {
            const string first = "John Michael Cane";
            const string second = "Cane J.";
            var result = await emailApi.AiNameMatchAsync(
                new AiNameMatchRequest(first, second));
            Assert.True(result.Similarity > 0.5);
        }

        [Test]
        [Pipeline]
        public async Task AiNameExpandTest()
        {
            const string name = "Smith Bobby";
            var result = await emailApi.AiNameExpandAsync(
                new AiNameExpandRequest(name));
            var expandedNames = result.Names
                .Select(weightedName => weightedName.Name)
                .ToList();
            Assert.Contains("Mr. Smith", expandedNames);
            Assert.Contains("B. Smith", expandedNames);
        }

        /// <summary>
        /// Name complete test
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameCompleteTest()
        {
            const string prefix = "Dav";
            var result = await emailApi.AiNameCompleteAsync(
                new AiNameCompleteRequest(prefix));
            var names = result.Names
                .Select(weightedName => $"{prefix}{weightedName.Name}")
                .ToList();
            Assert.Contains("David", names);
            Assert.Contains("Dave", names);
            Assert.Contains("Davis", names);
        }

        [Test]
        [Pipeline]
        public async Task AiNameParseEmailAddressTest()
        {
            const string address = "john-cane@gmail.com";
            var result = await emailApi.AiNameParseEmailAddressAsync(
                new AiNameParseEmailAddressRequest(address));
            var extractedValues = result.Value
                .SelectMany(value => value.Name)
                .ToList();
            var givenName = extractedValues.First(value => value.Category == "GivenName");
            var surName = extractedValues.First(value => value.Category == "Surname");
            Assert.AreEqual("John", givenName.Value);
            Assert.AreEqual("Cane", surName.Value);
        }

        /// <summary>
        /// Test business card recognition with storage.
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiBcrParseStorageTest()
        {
            var fileName = $"{Guid.NewGuid().ToString()}.png";
            // 1) Upload business card image to storage
            using (var stream = File.OpenRead(BcrAiTestFilePath))
            {
                await emailApi.UploadFileAsync(new UploadFileRequest($"{folder}/{fileName}", stream,
                    StorageName));
            }

            var outFolder = Guid.NewGuid().ToString();
            var outFolderPath = $"{folder}/{outFolder}";
            await emailApi.CreateFolderAsync(new CreateFolderRequest(outFolderPath, StorageName));
            // 2) Call business card recognition action
            var result = await emailApi.AiBcrParseStorageAsync(new AiBcrParseStorageRequest(
                new AiBcrParseStorageRq(null,
                    new List<AiBcrImageStorageFile>
                    {
                        new AiBcrImageStorageFile(true,
                            new StorageFileLocation(StorageName, folder, fileName))
                    },
                    new StorageFolderLocation(StorageName, outFolderPath))));
            //Check that only one file produced
            Assert.True(result.Value.Count == 1);
            // 3) Get file name from recognition result
            var contactFile = result.Value.First();

            // 4) Download VCard file, produced by recognition method, check it contains text "Thomas"
            using (var contactFileStream = await emailApi.DownloadFileAsync(new DownloadFileRequest(
                $"{contactFile.FolderPath}/{contactFile.FileName}", contactFile.Storage)))
            using (var memoryStream = new MemoryStream())
            {
                contactFileStream.CopyTo(memoryStream);
                var contactFileContent = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.True(contactFileContent.Contains("Thomas"));
            }

            // 5) Get VCard object properties list, check that there are 3 properties or more
            var contactProperties = await emailApi.GetContactPropertiesAsync(
                new GetContactPropertiesRequest(
                    "vcard", contactFile.FileName, contactFile.FolderPath, contactFile.Storage));
            Assert.GreaterOrEqual(contactProperties.InternalProperties.Count, 3);
        }

        /// <summary>
        ///     Test business card recognition without storage.
        ///     Send image as Base64 string and get VCard properties without producing any files in storage.
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiBcrParseTest()
        {
            var result = await emailApi.AiBcrParseAsync(new AiBcrParseRequest(new AiBcrBase64Rq(
                null,
                new List<AiBcrBase64Image>
                    {new AiBcrBase64Image(true, FileToBase64(BcrAiTestFilePath))})));
            Assert.AreEqual(1, result.Value.Count);
            Assert.True(result.Value
                .First()
                .InternalProperties
                .Where(property => property.Type == nameof(PrimitiveObject))
                .Select(property => (PrimitiveObject) property)
                .Any(property => property.Value?.Contains("Thomas") ?? false));
        }

        [Test]
        [Pipeline]
        public async Task CreateCalendarEmailTest()
        {
            var calendar = new CalendarDto
            {
                Attendees = new List<MailAddress>
                {
                    new MailAddress("Attendee Name", "attendee@am.ru", "Accepted")
                },
                Description = "Some description",
                Summary = "Some summary",
                Organizer = new MailAddress("Organizer Name", "cloud.em@yandex.ru", null),
                StartDate = DateTime.UtcNow.AddDays(1).AddHours(12),
                EndDate = DateTime.UtcNow.AddDays(1).AddHours(13),
                Location = "Some location"
            };
            var folderLocation = new StorageFolderLocation(StorageName, folder);
            var calendarFile = $"{Guid.NewGuid()}.ics";
            await emailApi.SaveCalendarModelAsync(
                new SaveCalendarModelRequest(calendarFile, new StorageModelRqOfCalendarDto(
                    calendar, folderLocation)));

            var exists = await IsFileExist(calendarFile);
            Assert.True(exists);

            var alternate = await emailApi.ConvertCalendarModelToAlternateAsync(
                new ConvertCalendarModelToAlternateRequest(
                    new CalendarDtoAlternateRq(calendar, "Create", null)));
            var email = new EmailDto
            {
                AlternateViews = new List<AlternateView> {alternate},
                From = new MailAddress("From address", "cloud.em@yandex.ru", "Accepted"),
                To = new List<MailAddress>
                    {new MailAddress("To address", "cloud.em@yandex.ru", null)},
                Subject = "Some subject",
                Body = "Some body"
            };
            var emailFile = $"{Guid.NewGuid().ToString()}.eml";
            await emailApi.SaveEmailModelAsync(
                new SaveEmailModelRequest("Eml", emailFile,
                    new StorageModelRqOfEmailDto(email,
                        folderLocation)));
            var emlFile = await emailApi.DownloadFileAsync(
                new DownloadFileRequest($"{folder}/{emailFile}", StorageName));
            emlFile.Seek(0, SeekOrigin.Begin);
            var fileReader = new StreamReader(emlFile);
            var emlFileContent = await fileReader.ReadToEndAsync();
            Assert.That(emlFileContent.Contains("cloud.em@yandex.ru"));
        }

        [Test]
        [Pipeline]
        public async Task ContactModelTest()
        {
            var contact = new ContactDto
            {
                Gender = "Male",
                Surname = "Thomas",
                GivenName = "Alex",
                EmailAddresses = new List<EmailAddress>
                {
                    new EmailAddress
                    {
                        Category = new EnumWithCustomOfEmailAddressCategory("Work", null),
                        Address = "alex.thomas@work.com",
                        Preferred = true,
                        DisplayName = "Alex Thomas"
                    }
                },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber
                    {
                        Category = new EnumWithCustomOfPhoneNumberCategory("Work", null),
                        Number = "+49211424721",
                        Preferred = true
                    }
                }
            };

            var contactFile = $"{Guid.NewGuid().ToString()}.vcf";
            await emailApi.SaveContactModelAsync(
                new SaveContactModelRequest(
                    "VCard", contactFile,
                    new StorageModelRqOfContactDto(contact,
                        new StorageFolderLocation(StorageName, folder))));
            var exists = await IsFileExist(contactFile);
            Assert.True(exists);
        }

        [Test]
        [Pipeline]
        public async Task AiBcrParseModelTest()
        {
            var result = await emailApi.AiBcrParseModelAsync(
                new AiBcrParseModelRequest(
                    new AiBcrBase64Rq(
                        null,
                        new List<AiBcrBase64Image>
                        {
                            new AiBcrBase64Image(true, FileToBase64(BcrAiTestFilePath))
                        })));
            Assert.AreEqual("Alex Thomas", result.Value.First().DisplayName);
        }

        private static string FileToBase64(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(bytes);
        }

        private async Task<bool> IsFileExist(string fileName, string folderPath = null)
        {
            var path = $"{folderPath ?? folder}/{fileName}";
            var request = new ObjectExistsRequest(path, StorageName);
            var result = await emailApi.ObjectExistsAsync(request);
            return result.IsFolder != true && result.Exists == true;
        }

        private async Task<string> CreateCalendar(DateTime? startDate = null)
        {
            var fileName = $"{Guid.NewGuid().ToString()}.ics";
            startDate = startDate ?? DateTime.UtcNow.Date.AddDays(1).AddHours(12);
            var endDate = startDate.Value.AddHours(1);
            var request = new CreateCalendarRequest(fileName,
                new HierarchicalObjectRequest(
                    new HierarchicalObject("CALENDAR", null,
                        new List<BaseObject>
                        {
                            new PrimitiveObject("LOCATION", null, "location"),
                            new PrimitiveObject("STARTDATE", null, startDate.Value.ToString("u")),
                            new PrimitiveObject("ENDDATE", null, endDate.ToString("u")),
                            new HierarchicalObject("ORGANIZER", null,
                                new List<BaseObject>
                                {
                                    new PrimitiveObject("ADDRESS", null, "organizer@am.ru"),
                                    new PrimitiveObject("DISPLAYNAME", null, "Piu Man")
                                }),
                            new HierarchicalObject("ATTENDEES", null,
                                new List<BaseObject>
                                {
                                    new IndexedHierarchicalObject("ATTENDEE", null, 0,
                                        new List<BaseObject>
                                        {
                                            new PrimitiveObject("ADDRESS", null, "attendee@am.ru"),
                                            new PrimitiveObject("DISPLAYNAME", null,
                                                "Attendee Name")
                                        })
                                })
                        }), new StorageFolderLocation(StorageName, folder)));
            await emailApi.CreateCalendarAsync(request);
            return fileName;
        }
    }
}