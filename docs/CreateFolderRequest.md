
# CreateFolderRequest

Request model for FolderApi.CreateFolder

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**path** |**string**|Folder path to create e.g. 'folder_1/folder_2/' |
**storageName** |**string**|Storage name |[optional] 

## Example
```csharp
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
