
# EmailGetAsFileRequest

Request model for EmailApi.GetAsFile

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**fileName** |**string**|Email document file name |
**format** |**string**|File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**storage** |**string**|Storage name |[optional] 
**folder** |**string**|Path to folder in storage |[optional] 

## Example
```csharp
var request = new EmailGetAsFileRequest
{ 
    FileName = "email.eml",
    Format = "Mhtml",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
