
# EmailGetRequest

Request model for EmailApi.Get

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**format** |**string**|Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**fileName** |**string**|Email document file name. |
**folder** |**string**|Path to folder in storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 

## Example
```csharp
var request = new EmailGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
