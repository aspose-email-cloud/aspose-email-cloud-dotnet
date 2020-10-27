
# ClientThreadGetMessagesRequest

Request model for ClientThreadApi.GetMessages

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**threadId** |**string**|Thread identifier |
**account** |**string**|Email account |
**folder** |**string**|Specifies account folder to get thread from              |[optional] 
**storage** |**string**|Storage name where account file located |[optional] 
**accountStorageFolder** |**string**|Folder in storage where account file located |[optional] 

## Example
```csharp
var request = new ClientThreadGetMessagesRequest
{ 
    ThreadId = "5",
    Account = "email.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
