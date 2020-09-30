
# ClientMessageSendFileRequest

Request model for ClientMessageApi.SendFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**account** |**string**|Email account |
**file** |**System.IO.Stream**|File to send |
**storage** |**string**|Storage name where account file located. |[optional] 
**accountStorageFolder** |**string**|Folder in storage where account file located. |[optional] 
**format** |**string**|Email file format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |[optional] [default to 0]

## Example
```csharp
var request = new ClientMessageSendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
