
# CalendarFromFileRequest

Request model for CalendarApi.FromFile

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
