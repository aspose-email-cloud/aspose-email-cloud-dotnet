
# GetFilesListRequest

Request model for FolderApi.GetFilesList

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**path** |**string**|Folder path e.g. '/folder' |
**storageName** |**string**|Storage name |[optional] 

## Example
```csharp
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
