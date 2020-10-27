
# CalendarGetRequest

Request model for CalendarApi.Get

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**fileName** |**string**|iCalendar file name in storage. |
**folder** |**string**|Path to folder in storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 

## Example
```csharp
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
