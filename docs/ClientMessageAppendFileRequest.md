
# ClientMessageAppendFileRequest

Request model for ClientMessageApi.AppendFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**account** |**string**|Email account. |
**file** |**System.IO.Stream**|Message file to append. |
**storage** |**string**|Storage name where account file located. |[optional] 
**accountStorageFolder** |**string**|Folder in storage where account file located. |[optional] 
**format** |**string**|Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |[optional] [default to 0]
**folder** |**string**|Path to folder on email server to append message to. |[optional] 
**markAsSent** |**bool?**|Determines that appended message should be market as sent or not. |[optional] [default to true]

## Example
```csharp
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
