using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
using Aspose.Email.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Tests
{
    [Pipeline]
    public class CalendarTests : TestFixtureBase
    {
        private const string Location = "Some location";

        private static CalendarDto Calendar => new CalendarDto
        {
            Location = Location,
            Description = "Some description",
            Summary = "Some summary",
            StartDate = DateTime.UtcNow.AddDays(1).AddHours(12),
            EndDate = DateTime.UtcNow.AddDays(1).AddHours(13),
            Attendees = new List<MailAddress>
            {
                new MailAddress("Attendee Name", "attendee@am.ru", "Accepted", null)
            },
            Organizer = new MailAddress("Organizer Name", "cloud.em@yandex.ru", null, null),
            Recurrence = new DailyRecurrencePatternDto
            {
                Occurs = 10,
                WeekStart = "Monday"
            }
        };

        /// <summary>
        /// Synchronous API call test
        /// </summary>
        [Test]
        public async Task SyncTest()
        {
            var calendarFile = await CreateCalendar();
            // ReSharper disable once MethodHasAsyncOverload
            var calendar =
                Api.Calendar.Get(new CalendarGetRequest
                {
                    FileName = calendarFile,
                    Folder = Folder,
                    Storage = StorageName
                });
            Assert.AreEqual(Location, calendar.Location);
        }


        /// <summary>
        /// System.IO.Stream support test
        /// </summary>
        [Test]
        public async Task StreamTest()
        {
            var calendarFile = await CreateCalendar();
            var newFileName = $"{Guid.NewGuid().ToString()}.ics";
            var newPath = $"{Folder}/{newFileName}";
            using (var stream = await Api.CloudStorage.File.DownloadFileAsync(
                new DownloadFileRequest
                {
                    Path = $"{Folder}/{calendarFile}",
                    StorageName = StorageName
                }))
            {
                var uploadRequest = new UploadFileRequest
                {
                    Path = newPath,
                    File = stream,
                    StorageName = StorageName
                };
                await Api.CloudStorage.File.UploadFileAsync(uploadRequest);
            }

            var newFileExist = await Api.CloudStorage.Storage.ObjectExistsAsync(
                new ObjectExistsRequest
                {
                    Path = newPath,
                    StorageName = StorageName
                });
            Assert.IsTrue(newFileExist.Exists);
            Assert.IsFalse(newFileExist.IsFolder);
        }


        [Test]
        public async Task CreateCalendarEmailTest()
        {
            var calendarFile = $"{Guid.NewGuid()}.ics";
            await Api.Calendar.SaveAsync(new CalendarSaveRequest(
                new StorageFileLocation(StorageName, Folder, calendarFile), Calendar, "Ics"));

            var exists = await IsFileExist(calendarFile);
            Assert.True(exists);

            var alternate =
                await Api.Calendar.AsAlternateAsync(
                    new CalendarAsAlternateRequest(Calendar, "Create", null));
            var email = new EmailDto
            {
                AlternateViews = new List<AlternateView>
                {
                    alternate
                },
                From = new MailAddress("From address", "cloud.em@yandex.ru", "Accepted", null),
                To = new List<MailAddress>
                {
                    new MailAddress("To address", "cloud.em@yandex.ru", null, null)
                },
                Subject = "Some subject",
                Body = "Some body"
            };
            var emailFile = $"{Guid.NewGuid().ToString()}.eml";
            await Api.Email.SaveAsync(new EmailSaveRequest(
                new StorageFileLocation(StorageName, Folder, emailFile), email, "Eml"));
            var emlFile = await Api.CloudStorage.File.DownloadFileAsync(
                new DownloadFileRequest($"{Folder}/{emailFile}", StorageName));
            emlFile.Seek(0, SeekOrigin.Begin);
            var fileReader = new StreamReader(emlFile);
            var emlFileContent = await fileReader.ReadToEndAsync();
            Assert.That(emlFileContent.Contains("cloud.em@yandex.ru"));
        }

        [Test]
        public async Task ConvertCalendarTest()
        {
            //Create DTO with specified location:
            //We can convert this DTO to a MAPI or ICS file stream:
            var mapiStream = await Api.Calendar.AsFileAsync(
                new CalendarAsFileRequest("Msg", Calendar));
            /*
            //mapiStream can be saved as a calendar.msg file:
            using (var file = File.OpenWrite("calendar.msg"))
            {
                await mapiStream.CopyToAsync(file);
            }
            mapiStream.Seek(0, SeekOrigin.Begin);
            */

            //Let's convert this stream to an ICS file:
            var icsStream =
                await Api.Calendar.ConvertAsync(new CalendarConvertRequest("Ics", mapiStream));
            /*
            //icsStream can be saved as a calendar.ics file:
            using (var file = File.OpenWrite("calendar.ics"))
            {
                await icsStream.CopyToAsync(file);
            }
            icsStream.Seek(0, SeekOrigin.Begin);
            */

            //ICS is a text format. We can convert the stream to a string and check that it
            //contains specified location as a substring:
            using (var memoryStream = new MemoryStream())
            {
                await icsStream.CopyToAsync(memoryStream);
                var icsString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(icsString.Contains(Location));
            }

            icsStream.Seek(0, SeekOrigin.Begin);
            //We can also convert a file stream back to a CalendarDto
            var dto = await Api.Calendar.FromFileAsync(new CalendarFromFileRequest(icsStream));
            Assert.AreEqual(Location, dto.Location);
        }

        [Test]
        public async Task ConvertModelToMapiModelTest()
        {
            var mapiCalendar = await Api.Calendar.AsMapiAsync(Calendar);
            Assert.AreEqual(Calendar.Location, mapiCalendar.Location);
            Assert.AreEqual(nameof(MapiCalendarDailyRecurrencePatternDto),
                mapiCalendar.Recurrence.RecurrencePattern.Discriminator);
        }

        private async Task<string> CreateCalendar(DateTime? startDate = null)
        {
            var fileName = $"{Guid.NewGuid().ToString()}.ics";
            var calendar = Calendar;
            calendar.StartDate = startDate ?? DateTime.UtcNow.Date.AddDays(1).AddHours(12);
            calendar.EndDate = calendar.StartDate?.AddHours(1);

            await Api.Calendar.SaveAsync(new CalendarSaveRequest(
                new StorageFileLocation(StorageName, Folder, fileName), calendar, "Ics"));
            return fileName;
        }
    }
}
