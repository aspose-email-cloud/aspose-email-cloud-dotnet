
# ClientMessageFetchRequest

Request model for ClientMessageApi.Fetch

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**messageId** |**string**|Message identifier |
**account** |**string**|Email account |
**folder** |**string**|Account folder to fetch from (should be specified for some protocols such as IMAP)              |[optional] 
**storage** |**string**|Storage name where account file located. |[optional] 
**accountStorageFolder** |**string**|Folder in storage where account file located. |[optional] 
**type** |**string**|MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 |[optional] [default to 0]
**format** |**string**|Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |[optional] [default to 0]

## Example
```csharp
var request = new ClientMessageFetchRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
