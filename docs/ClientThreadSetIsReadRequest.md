# ClientThreadSetIsReadRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsRead** | **bool?** | Message is read flag.              | 
**Folder** | **string** | Folder on email server, where thread is stored.              | [optional] 

## Parent class

See: [ClientThreadBaseRequest](ClientThreadBaseRequest.md)

## Example
```csharp
var clientThreadSetIsReadRequest = new ClientThreadSetIsReadRequest
{
    IsRead = true,
    Folder = "INBOX",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

