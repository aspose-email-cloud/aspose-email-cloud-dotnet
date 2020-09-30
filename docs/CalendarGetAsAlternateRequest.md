
# CalendarGetAsAlternateRequest

Request model for CalendarApi.GetAsAlternate

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**fileName** |**string**|iCalendar file name in storage |
**calendarAction** |**string**|iCalendar method type Enum, available values: Create, Update, Cancel |
**sequenceId** |**string**|The sequence id |[optional] 
**folder** |**string**|Path to folder in storage |[optional] 
**storage** |**string**|Storage name |[optional] 

## Example
```csharp
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
