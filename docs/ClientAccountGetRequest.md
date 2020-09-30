
# ClientAccountGetRequest

Request model for ClientAccountApi.Get

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**fileName** |**string**|File name on storage. |
**folder** |**string**|Folder on storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 

## Example
```csharp
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
