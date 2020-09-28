# MapiCalendarAsFileRequest
Convert MapiCalendar to file request.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | Calendar file format Enum, available values: Ics, Msg | 
**Value** | [**MapiCalendarDto**](MapiCalendarDto.md) | MAPI calendar model.              | 


## Example
```csharp
var mapiCalendarAsFileRequest = new MapiCalendarAsFileRequest
{
    Format = "Msg",
    Value = new MapiCalendarDto
    {
        Attendees = new MapiCalendarAttendeesDto
        {
            AppointmentRecipients = new List<MapiRecipientDto>
            {
                new MapiRecipientDto
                {
                    EmailAddress = "organizer@aspose.com",
                    AddressType = "SMTP",
                    DisplayName = "Organizer Name",
                    RecipientType = "MapiTo"
                },
                new MapiRecipientDto
                {
                    EmailAddress = "attendee@aspose.com",
                    AddressType = "SMTP",
                    DisplayName = "Attendee Name",
                    RecipientType = "MapiTo"
                }
            }
        },
        BusyStatus = "Tentative",
        ClientIntent = new List<MapiCalendarClientIntent>
        {
            "Manager"
        },
        EndDate = DateTime.Today,
        Location = "Some location",
        Recurrence = new MapiCalendarEventRecurrenceDto
        {
            RecurrencePattern = new MapiCalendarDailyRecurrencePatternDto
            {
                Frequency = "Daily",
                OccurrenceCount = 10,
                WeekStartDay = "Monday"
            }
        },
        StartDate = DateTime.Today,
        Organizer = new MapiElectronicAddressDto
        {
            EmailAddress = "organizer@aspose.com"
        },
        Body = "Some description",
        Subject = "Some summary"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

