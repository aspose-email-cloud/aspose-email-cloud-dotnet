using System;
using System.Collections.Generic;
using System.Linq;
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
                ApiBaseUrl = configurationHelper.GetValue("apiBaseUrl", "https://api-qa.aspose.cloud"),
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
        public async Task HierarchicalTest()
        {
            var calendarFile = await CreateCalendar();
            var request = new GetCalendarRequest(calendarFile, folder, StorageName);
            var calendar = await emailApi.GetCalendarAsync(request);
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
        public async Task StreamTest()
        {
            var calendarFile = await CreateCalendar();
            var newFileName = $"{Guid.NewGuid().ToString()}.ics";
            var newPath = $"{folder}/{newFileName}";
            var request = new DownloadFileRequest($"{folder}/{calendarFile}", StorageName);
            using (var stream = await emailApi.DownloadFileAsync(request))
            {
                var uploadRequest = new UploadFileRequest(newPath, stream, StorageName);
                await emailApi.UploadFileAsync(uploadRequest);
            }

            var existRequest = new ObjectExistsRequest(newPath, StorageName);
            var newFileExist = await emailApi.ObjectExistsAsync(existRequest);
            Assert.IsTrue(newFileExist.Exists);
            Assert.IsFalse(newFileExist.IsFolder);
        }

        /// <summary>
        /// Contact format specified as Enum, but SDK represents it as a string.
        /// Test checks that value parsing works properly
        /// </summary>
        [Test]
        public async Task ContactFormatTest()
        {
            foreach (var format in new[] {"vcard", "msg"})
            {
                var extension = format == "vcard" ? ".vcf" : ".msg";
                var request = new CreateContactRequest
                {
                    format = format,
                    name = $"{Guid.NewGuid().ToString()}{extension}",
                    request = new HierarchicalObjectRequest
                    {
                        StorageFolder = new StorageFolderLocation {Storage = StorageName, FolderPath = folder},
                        HierarchicalObject = new HierarchicalObject
                            {Name = "CONTACT", InternalProperties = new List<BaseObject>()}
                    }
                };
                await emailApi.CreateContactAsync(request);
                var contactExist = await IsFileExist(request.name);
                Assert.IsTrue(contactExist);
            }
        }

        /// <summary>
        /// Test DateTime serialization and deserialization.
        /// Checks that SDK and Backend do not change DateTime during processing.
        /// In most cases developer should carefully serialize and deserialize DateTime
        /// </summary>
        [Test]
        public async Task DateTimeTest()
        {
            var startDate = DateTime.UtcNow.Date.AddDays(1).AddHours(12);
            var calendarFile = await CreateCalendar(startDate);
            var request = new GetCalendarRequest(calendarFile, folder, StorageName);
            var calendar = await emailApi.GetCalendarAsync(request);
            var startDateProperty = calendar.InternalProperties
                .First(property => property.Name == "STARTDATE");
            var factStartDate = DateTime
                .Parse(((PrimitiveObject) startDateProperty).Value)
                .ToUniversalTime();
            Assert.AreEqual(startDate, factStartDate);
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
            var request = new CreateCalendarRequest
            {
                name = fileName,
                request = new HierarchicalObjectRequest
                {
                    HierarchicalObject = new HierarchicalObject
                    {
                        Name = "CALENDAR", InternalProperties = new List<BaseObject>
                        {
                            new PrimitiveObject {Name = "LOCATION", Value = "location"},
                            new PrimitiveObject {Name = "STARTDATE", Value = startDate.Value.ToString("u")},
                            new PrimitiveObject {Name = "ENDDATE", Value = endDate.ToString("u")},
                            new HierarchicalObject
                            {
                                Name = "ORGANIZER", InternalProperties = new List<BaseObject>
                                {
                                    new PrimitiveObject {Name = "ADDRESS", Value = "organizer@am.ru"},
                                    new PrimitiveObject {Name = "DISPLAYNAME", Value = "Piu Man"}
                                }
                            },
                            new HierarchicalObject
                            {
                                Name = "ATTENDEES", InternalProperties = new List<BaseObject>
                                {
                                    new IndexedHierarchicalObject
                                    {
                                        Index = 0, Name = "ATTENDEE", InternalProperties = new List<BaseObject>
                                        {
                                            new PrimitiveObject {Name = "ADDRESS", Value = "attendee@am.ru"},
                                            new PrimitiveObject {Name = "DISPLAYNAME", Value = "Attendee Name"}
                                        }
                                    }
                                }
                            }
                        }
                    },
                    StorageFolder = new StorageFolderLocation
                    {
                        Storage = "First Storage",
                        FolderPath = folder
                    }
                }
            };
            await emailApi.CreateCalendarAsync(request);
            return fileName;
        }
    }
}