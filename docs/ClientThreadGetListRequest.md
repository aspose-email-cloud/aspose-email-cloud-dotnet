
# ClientThreadGetListRequest

Request model for ClientThreadApi.GetList

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**folder** |**string**|A folder in email account.              |
**account** |**string**|Email account |
**storage** |**string**|Storage name where account file located |[optional] 
**accountStorageFolder** |**string**|Folder in storage where account file located |[optional] 
**updateFolderCache** |**bool?**|This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              |[optional] [default to true]
**messagesCacheLimit** |**int?**|Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              |[optional] [default to 200]

## Example
```csharp
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
