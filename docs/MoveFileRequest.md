
# MoveFileRequest

Request model for FileApi.MoveFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
**destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
**srcStorageName** | **string**| Source storage name | [optional] 
**destStorageName** | **string**| Destination storage name | [optional] 
**versionId** | **string**| File version ID to move | [optional] 

## Example
```csharp
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage",
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
