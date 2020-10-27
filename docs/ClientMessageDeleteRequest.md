# ClientMessageDeleteRequest
Email client delete message request.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | **string** | Folder to delete message from.              | [optional] 

## Parent class

See: [ClientMessageBaseRequest](ClientMessageBaseRequest.md)

## Example
```csharp
var clientMessageDeleteRequest = new ClientMessageDeleteRequest
{
    Folder = "INBOX",
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

