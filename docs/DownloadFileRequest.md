
# DownloadFileRequest

Request model for FileApi.DownloadFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**path** |**string**|File path e.g. '/folder/file.ext' |
**storageName** |**string**|Storage name |[optional] 
**versionId** |**string**|File version ID to download |[optional] 

## Example
```csharp
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
