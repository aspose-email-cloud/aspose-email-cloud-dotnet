# ClientThreadMoveRequest
Email client move thread request.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationFolder** | **string** | Email account folder to move thread to.              | 
**SourceFolder** | **string** | Email account folder to move thread from.              | [optional] 

## Parent class

See: [ClientThreadBaseRequest](ClientThreadBaseRequest.md)

## Example
```csharp
var clientThreadMoveRequest = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    SourceFolder = "INBOX",
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

