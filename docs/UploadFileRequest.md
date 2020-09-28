
# UploadFileRequest

Request model for FileApi.UploadFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
**file** | **System.IO.Stream**| File to upload | 
**storageName** | **string**| Storage name | [optional] 

## Example
```csharp
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
