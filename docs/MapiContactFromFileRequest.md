
# MapiContactFromFileRequest

Request model for MapiContactApi.FromFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**format** |**string**|File format Enum, available values: VCard, WebDav, Msg |
**file** |**System.IO.Stream**|File to convert |

## Example
```csharp
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
