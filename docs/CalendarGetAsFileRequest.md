
# CalendarGetAsFileRequest

Request model for CalendarApi.GetAsFile

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**fileName** |**string**|Calendar document file name. |
**format** |**string**|File format. Enum, available values: Ics, Msg |
**storage** |**string**|Storage name. |[optional] 
**folder** |**string**|Path to folder in storage. |[optional] 

## Example
```csharp
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
