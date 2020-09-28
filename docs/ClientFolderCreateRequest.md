# ClientFolderCreateRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentFolder** | **string** | Path to parent folder.              | [optional] 
**FolderName** | **string** | Folder name.              | 

## Parent class

See: [ClientAccountBaseRequest](ClientAccountBaseRequest.md)

## Example
```csharp
var clientFolderCreateRequest = new ClientFolderCreateRequest
{
    ParentFolder = "INBOX/SubFolder/ParentFolder",
    FolderName = "NewFolder",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

