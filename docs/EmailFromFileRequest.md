
# EmailFromFileRequest

Request model for EmailApi.FromFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**format** |**string**| Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new EmailFromFileRequest
{ 
    Format = "Eml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
