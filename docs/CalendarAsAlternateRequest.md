# CalendarAsAlternateRequest
Convert iCalendar to AlternateView request             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**CalendarDto**](CalendarDto.md) | iCalendar document model              | 
**Action** | **string** | iCalendar actions. Enum, available values: Create, Update, Cancel | 
**SequenceId** | **string** | iCalendar sequence id              | [optional] 


## Example
```csharp
var calendarAsAlternateRequest = new CalendarAsAlternateRequest
{
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
    },
    SequenceId = "cf4ffb6c-895d-4e58-bdb4-0a3918e96a43"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

