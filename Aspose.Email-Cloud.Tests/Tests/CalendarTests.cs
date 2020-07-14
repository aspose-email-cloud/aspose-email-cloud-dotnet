using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Location = Location, Description = "Some description", Summary = "Some summary",
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
                Api.Calendar.Get(new CalendarGetRequest(calendarFile, Folder, StorageName));
            Assert.AreEqual(Location, calendar.Location);
        }
        //
        // /// <summary>
        // /// HierarchicalObject serialization and deserialization test.
        // /// This test checks that BaseObject.Type field filled automatically by SDK
        // /// and properly used in serialization and deserialization
        // /// </summary>
        // [Test]
        // public async Task HierarchicalTest()
        // {
        //     var calendarFile = await CreateCalendar();
        //     var calendar = await Api.GetCalendarAsync(
        //         new GetCalendarRequest(calendarFile, Folder, StorageName));
        //     Assert.AreEqual("CALENDAR", calendar.Name);
        //     Assert.GreaterOrEqual(
        //         calendar.InternalProperties
        //             .Count(property => property.GetType() == typeof(PrimitiveObject)),
        //         1);
        //     Assert.GreaterOrEqual(
        //         calendar.InternalProperties
        //             .Count(property => property.GetType() == typeof(HierarchicalObject)),
        //         1);
        // }
        //
        // /// <summary>
        // /// System.IO.Stream support test
        // /// </summary>
        // [Test]
        // public async Task StreamTest()
        // {
        //     var calendarFile = await CreateCalendar();
        //     var newFileName = $"{Guid.NewGuid().ToString()}.ics";
        //     var newPath = $"{Folder}/{newFileName}";
        //     using (var stream = await Api.DownloadFileAsync(
        //         new DownloadFileRequest($"{Folder}/{calendarFile}", StorageName)))
        //     {
        //         var uploadRequest = new UploadFileRequest(newPath, stream, StorageName);
        //         await Api.UploadFileAsync(uploadRequest);
        //     }
        //
        //     var newFileExist = await Api.ObjectExistsAsync(
        //         new ObjectExistsRequest(newPath, StorageName));
        //     Assert.IsTrue(newFileExist.Exists);
        //     Assert.IsFalse(newFileExist.IsFolder);
        // }
        //
        // /// <summary>
        // /// Test DateTime serialization and deserialization.
        // /// Checks that SDK and Backend do not change DateTime during processing.
        // /// In most cases developer should carefully serialize and deserialize DateTime
        // /// </summary>
        // [Test]
        // public async Task DateTimeTest()
        // {
        //     var startDate = DateTime.UtcNow.Date.AddDays(1).AddHours(12);
        //     var calendarFile = await CreateCalendar(startDate);
        //     var calendar =
        //         await Api.GetCalendarAsync(new GetCalendarRequest(calendarFile, Folder,
        //             StorageName));
        //     var startDateProperty = calendar.InternalProperties
        //         .First(property => property.Name == "STARTDATE");
        //     var factStartDate = DateTime
        //         .Parse(((PrimitiveObject) startDateProperty).Value)
        //         .ToUniversalTime();
        //     Assert.AreEqual(startDate, factStartDate);
        // }
        //
        // [Test]
        // public async Task CreateCalendarEmailTest()
        // {
        //     var folderLocation = new StorageFolderLocation(StorageName, Folder);
        //     var calendarFile = $"{Guid.NewGuid()}.ics";
        //     await Api.SaveCalendarModelAsync(
        //         new SaveCalendarModelRequest(calendarFile, new StorageModelRqOfCalendarDto(
        //             Calendar, folderLocation)));
        //
        //     var exists = await IsFileExist(calendarFile);
        //     Assert.True(exists);
        //
        //     var alternate = await Api.ConvertCalendarModelToAlternateAsync(
        //         new ConvertCalendarModelToAlternateRequest(
        //             new CalendarDtoAlternateRq(Calendar, "Create", null)));
        //     var email = new EmailDto
        //     {
        //         AlternateViews = new List<AlternateView> {alternate},
        //         From = new MailAddress("From address", "cloud.em@yandex.ru", "Accepted", null),
        //         To = new List<MailAddress>
        //             {new MailAddress("To address", "cloud.em@yandex.ru", null, null)},
        //         Subject = "Some subject",
        //         Body = "Some body"
        //     };
        //     var emailFile = $"{Guid.NewGuid().ToString()}.eml";
        //     await Api.SaveEmailModelAsync(
        //         new SaveEmailModelRequest("Eml", emailFile,
        //             new StorageModelRqOfEmailDto(email,
        //                 folderLocation)));
        //     var emlFile = await Api.DownloadFileAsync(
        //         new DownloadFileRequest($"{Folder}/{emailFile}", StorageName));
        //     emlFile.Seek(0, SeekOrigin.Begin);
        //     var fileReader = new StreamReader(emlFile);
        //     var emlFileContent = await fileReader.ReadToEndAsync();
        //     Assert.That(emlFileContent.Contains("cloud.em@yandex.ru"));
        // }
        //
        // [Test]
        // public async Task ConvertCalendarTest()
        // {
        //     //Create DTO with specified location:
        //     //We can convert this DTO to a MAPI or ICS file stream:
        //     var mapiStream = await Api.ConvertCalendarModelToFileAsync(
        //         new ConvertCalendarModelToFileRequest(
        //             "Msg", Calendar));
        //     /*
        //     //mapiStream can be saved as a calendar.msg file:
        //     using (var file = File.OpenWrite("calendar.msg"))
        //     {
        //         await mapiStream.CopyToAsync(file);
        //     }
        //     mapiStream.Seek(0, SeekOrigin.Begin);
        //     */
        //
        //     //Let's convert this stream to an ICS file:
        //     var icsStream = await Api.ConvertCalendarAsync(new ConvertCalendarRequest(
        //         "Ics", mapiStream));
        //     /*
        //     //icsStream can be saved as a calendar.ics file:
        //     using (var file = File.OpenWrite("calendar.ics"))
        //     {
        //         await icsStream.CopyToAsync(file);
        //     }
        //     icsStream.Seek(0, SeekOrigin.Begin);
        //     */
        //
        //     //ICS is a text format. We can convert the stream to a string and check that it
        //     //contains specified location as a substring:
        //     using (var memoryStream = new MemoryStream())
        //     {
        //         await icsStream.CopyToAsync(memoryStream);
        //         var icsString = Encoding.UTF8.GetString(memoryStream.ToArray());
        //         Assert.IsTrue(icsString.Contains(Location));
        //     }
        //
        //     icsStream.Seek(0, SeekOrigin.Begin);
        //     //We can also convert a file stream back to a CalendarDto
        //     var dto = await Api.GetCalendarFileAsModelAsync(
        //         new GetCalendarFileAsModelRequest(icsStream));
        //     Assert.AreEqual(Location, dto.Location);
        // }
        //
        // [Test]
        // public async Task ConvertModelToMapiModelTest()
        // {
        //     var mapiCalendar = await Api.ConvertCalendarModelToMapiModelAsync(
        //         new ConvertCalendarModelToMapiModelRequest(Calendar));
        //     Assert.AreEqual(Calendar.Location, mapiCalendar.Location);
        //     Assert.AreEqual(nameof(MapiCalendarDailyRecurrencePatternDto),
        //         mapiCalendar.Recurrence.RecurrencePattern.Discriminator);
        // }
        //

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