# AiBcrImageStorageFile
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**File** | [**StorageFileLocation**](StorageFileLocation.md) | Image location              | 

## Parent class

See: [AiBcrImage](AiBcrImage.md)

## Example
```csharp
var aiBcrImageStorageFile = new AiBcrImageStorageFile
{
    File = new StorageFileLocation
    {
        FileName = "VCardScanImage.jpg",
        Storage = "First Storage",
        FolderPath = "image/location/on/storage"
    },
    IsSingle = true
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

