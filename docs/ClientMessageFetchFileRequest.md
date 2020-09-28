
# ClientMessageFetchFileRequest

Request model for ClientMessageApi.FetchFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**messageId** | **string**| Message identifier | 
**account** | **string**| Email account | 
**folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
**storage** | **string**| Storage name where account file located. | [optional] 
**accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
**format** | **string**| Fetched message file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

## Example
```csharp
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "&lt;put your message identifier here&gt;",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
