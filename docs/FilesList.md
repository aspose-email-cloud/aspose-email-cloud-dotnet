# FilesList
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**List&lt;StorageFile&gt;**](StorageFile.md) | Files and folders contained by folder StorageFile. | [optional] 


## Example
```csharp
var filesList = new FilesList
{
    Value = new List<StorageFile>
    {
        new StorageFile
        {
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 1024,
            Path = "/path/to/file/on/storage"
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

