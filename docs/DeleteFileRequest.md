
# DeleteFileRequest

Request model for FileApi.DeleteFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
**storageName** | **string**| Storage name | [optional] 
**versionId** | **string**| File version ID to delete | [optional] 

## Example
```csharp
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage",
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
