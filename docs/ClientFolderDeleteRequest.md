# ClientFolderDeleteRequest
Email client delete folder request.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | **string** | Path to folder to delete.              | 

## Parent class

See: [ClientAccountBaseRequest](ClientAccountBaseRequest.md)

## Example
```csharp
var clientFolderDeleteRequest = new ClientFolderDeleteRequest
{
    Folder = "INBOX/SubFolder/FolderToDelete",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

