
# CopyFolderRequest

Request model for FolderApi.CopyFolder

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**srcPath** |**string**|Source folder path e.g. '/src' |
**destPath** |**string**|Destination folder path e.g. '/dst' |
**srcStorageName** |**string**|Source storage name |[optional] 
**destStorageName** |**string**|Destination storage name |[optional] 

## Example
```csharp
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
