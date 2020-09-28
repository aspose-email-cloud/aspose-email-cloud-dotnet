# StorageFile
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | File or folder name. | [optional] 
**IsFolder** | **bool?** | True if it is a folder. | 
**ModifiedDate** | **DateTime?** | File or folder last modified DateTime. | [optional] 
**Size** | **long?** | File or folder size. | 
**Path** | **string** | File or folder path. | [optional] 


## Example
```csharp
var storageFile = new StorageFile
{
    Name = "file.ext",
    ModifiedDate = DateTime.Today,
    Size = 4096,
    Path = "/storage/path/to"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

