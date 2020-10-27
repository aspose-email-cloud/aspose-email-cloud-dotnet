# CalendarStorageList
iCalendar models list with corresponding storage locations.             

## Properties
Class has no properties

## Parent class

See: [ListResponseOfStorageModelOfCalendarDto](ListResponseOfStorageModelOfCalendarDto.md)

## Example
```csharp
var calendarStorageList = new CalendarStorageList
{
    Value = new List<StorageModelOfCalendarDto>
    {
        new StorageModelOfCalendarDto
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "calendar.ics",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new CalendarDto
            {
                Attendees = new List<MailAddress>
                {
                    new MailAddress
                    {
                        DisplayName = "Attendee Name",
                        Address = "attendee@aspose.com",
                        ParticipationStatus = "Accepted"
                    }
                },
                Description = "Some description",
                EndDate = DateTime.Today,
                Location = "Some location",
                Organizer = new MailAddress
                {
                    DisplayName = "Organizer Name",
                    Address = "organizer@aspose.com"
                },
                Recurrence = new DailyRecurrencePatternDto
                {
                    Interval = -1,
                    Occurs = 10,
                    WeekStart = "Monday"
                },
                StartDate = DateTime.Today,
                Summary = "Some summary"
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

