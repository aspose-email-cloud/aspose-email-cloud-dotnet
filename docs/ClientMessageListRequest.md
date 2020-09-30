
# ClientMessageListRequest

Request model for ClientMessageApi.List

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**folder** |**string**|A folder in email account |
**account** |**string**|Email account |
**queryString** |**string**|A MailQuery search string |[optional] 
**storage** |**string**|Storage name where account file located |[optional] 
**accountStorageFolder** |**string**|Folder in storage where account file located |[optional] 
**recursive** |**bool?**|Specifies that should message be searched in subfolders recursively |[optional] [default to false]
**type** |**string**|MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 |[optional] [default to 0]
**format** |**string**|Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |[optional] [default to 0]

## Example
```csharp
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "('From' Contains '.com')",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
