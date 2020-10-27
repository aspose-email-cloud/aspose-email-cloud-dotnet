
# EmailConvertRequest

Request model for EmailApi.Convert

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**fromFormat** |**string**|File format to convert to Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**toFormat** |**string**|File format to convert from Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new EmailConvertRequest
{ 
    FromFormat = "Msg",
    ToFormat = "Mhtml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
