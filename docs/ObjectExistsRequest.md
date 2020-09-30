
# ObjectExistsRequest

Request model for StorageApi.ObjectExists

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**path** |**string**|File or folder path e.g. '/file.ext' or '/folder' |
**storageName** |**string**|Storage name |[optional] 
**versionId** |**string**|File version ID |[optional] 

## Example
```csharp
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
