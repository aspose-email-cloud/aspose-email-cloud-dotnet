
# DeleteFolderRequest

Request model for FolderApi.DeleteFolder

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**path** |**string**|Folder path e.g. '/folder' |
**storageName** |**string**|Storage name |[optional] 
**recursive** |**bool?**|Enable to delete folders, subfolders and files |[optional] [default to false]

## Example
```csharp
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
