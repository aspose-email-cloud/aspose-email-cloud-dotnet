
# MapiMessageFromFileRequest

Request model for MapiMessageApi.FromFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**format** |**string**|File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new MapiMessageFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
