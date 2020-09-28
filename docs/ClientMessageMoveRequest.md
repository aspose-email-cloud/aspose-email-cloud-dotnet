# ClientMessageMoveRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceFolder** | **string** | Folder to move message from.              | [optional] 
**DestinationFolder** | **string** | Folder to move message to.              | 

## Parent class

See: [ClientMessageBaseRequest](ClientMessageBaseRequest.md)

## Example
```csharp
var clientMessageMoveRequest = new ClientMessageMoveRequest
{
    SourceFolder = "INBOX",
    DestinationFolder = "INBOX/SubFolder",
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

