# ClientMessageSetIsReadRequest
Email client mark message is read/unread request.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsRead** | **bool?** | Message is read flag.              | 

## Parent class

See: [ClientMessageBaseRequest](ClientMessageBaseRequest.md)

## Example
```csharp
var clientMessageSetIsReadRequest = new ClientMessageSetIsReadRequest
{
    IsRead = true,
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

