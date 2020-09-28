
# ClientFolderGetListRequest

Request model for ClientFolderApi.GetList

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**account** | **string**| Email account | 
**storage** | **string**| Storage name where account file located | [optional] 
**accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
**parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

## Example
```csharp
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
