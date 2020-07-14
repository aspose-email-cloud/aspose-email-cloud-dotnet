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
    public class MapiCalendarTests : TestFixtureBase
    {
        private static MapiCalendarDto MapiCalendar => new MapiCalendarDto
        {
            BusyStatus = "Tentative", EndDate = DateTime.Today.AddDays(1),
            Location = "Some location", StartDate = DateTime.Today, Body = "Some description",
            BodyType = "PlainText", Subject = "Some summary",
            Attendees = new MapiCalendarAttendeesDto
            {
                AppointmentRecipients = new List<MapiRecipientDto>
                {
                    new MapiRecipientDto
                    {
                        AddressType = "SMTP", DisplayName = "Organizer Name",
                        EmailAddress = "organizer@aspose.com", RecipientType = "MapiTo"
                    },
                    new MapiRecipientDto
                    {
                        AddressType = "SMTP", DisplayName = "Attendee Name",
                        EmailAddress = "attendee@aspose.com", RecipientType = "MapiTo"
                    }
                }
            },
            ClientIntent = new List<string> {"Manager"},
            Recurrence = new MapiCalendarEventRecurrenceDto
            {
                RecurrencePattern = new MapiCalendarDailyRecurrencePatternDto
                    {OccurrenceCount = 10, WeekStartDay = "Monday"}
            },
            Organizer = new MapiElectronicAddressDto {EmailAddress = "organizer@aspose.com"},
        };

        // [Test]
        // public async Task ModelToCalendarDtoTest()
        // {
        //     var calendarDto =
        //         await Api.ConvertMapiCalendarModelToCalendarModelAsync(
        //             new ConvertMapiCalendarModelToCalendarModelRequest(
        //                 MapiCalendar));
        //     Assert.AreEqual(MapiCalendar.Subject, calendarDto.Summary);
        //     Assert.AreEqual(MapiCalendar.Location, calendarDto.Location);
        // }
        //
        // [Test]
        // public async Task ModelToFileTest()
        // {
        //     var icsStream = await Api.ConvertMapiCalendarModelToFileAsync(
        //         new ConvertMapiCalendarModelToFileRequest(
        //             "Ics", MapiCalendar));
        //     using (var memoryStream = new MemoryStream())
        //     {
        //         await icsStream.CopyToAsync(memoryStream);
        //         var icsString = Encoding.UTF8.GetString(memoryStream.ToArray());
        //         Assert.IsTrue(icsString.Contains(MapiCalendar.Location));
        //     }
        //
        //     icsStream.Seek(0, SeekOrigin.Begin);
        //     var mapiCalendarConverted = await Api.GetCalendarFileAsMapiModelAsync(
        //         new GetCalendarFileAsMapiModelRequest(icsStream));
        //     Assert.AreEqual(MapiCalendar.Location, mapiCalendarConverted.Location);
        // }
        //
        // [Test]
        // public async Task StorageTest()
        // {
        //     var fileName = $"{Guid.NewGuid()}.msg";
        //     await Api.SaveMapiCalendarModelAsync(
        //         new SaveMapiCalendarModelRequest(
        //             fileName, "Msg", new StorageModelRqOfMapiCalendarDto(
        //                 MapiCalendar, new StorageFolderLocation(StorageName, Folder))));
        //     var mapiCalendarFromStorage = await Api.GetMapiCalendarModelAsync(
        //         new GetMapiCalendarModelRequest(
        //             fileName, Folder, StorageName));
        //     Assert.AreEqual(MapiCalendar.Location, mapiCalendarFromStorage.Location);
        // }
    }
}