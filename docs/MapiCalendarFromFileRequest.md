
# MapiCalendarFromFileRequest

Request model for MapiCalendarApi.FromFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new MapiCalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
