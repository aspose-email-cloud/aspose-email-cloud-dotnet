
# GetFileVersionsRequest

Request model for StorageApi.GetFileVersions

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**path** | **string**| File path e.g. &#39;/file.ext&#39; | 
**storageName** | **string**| Storage name | [optional] 

## Example
```csharp
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
