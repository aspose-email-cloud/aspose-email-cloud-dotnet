
# MoveFolderRequest

Request model for FolderApi.MoveFolder

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**srcPath** |**string**|Folder path to move e.g. '/folder' |
**destPath** |**string**|Destination folder path to move to e.g '/dst' |
**srcStorageName** |**string**|Source storage name |[optional] 
**destStorageName** |**string**|Destination storage name |[optional] 

## Example
```csharp
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
