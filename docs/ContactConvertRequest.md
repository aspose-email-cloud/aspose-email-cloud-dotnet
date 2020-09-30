
# ContactConvertRequest

Request model for ContactApi.Convert

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**toFormat** |**string**|File format to convert to Enum, available values: VCard, WebDav, Msg |
**fromFormat** |**string**|File format to convert from Enum, available values: VCard, WebDav, Msg |
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new ContactConvertRequest
{ 
    ToFormat = "VCard",
    FromFormat = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
