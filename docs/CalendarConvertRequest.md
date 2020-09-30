
# CalendarConvertRequest

Request model for CalendarApi.Convert

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**format** |**string**|File format. Enum, available values: Ics, Msg |
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
