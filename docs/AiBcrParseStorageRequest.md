# AiBcrParseStorageRequest
Parse business card images from Storage request             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutFolder** | [**StorageFolderLocation**](StorageFolderLocation.md) | Parse output folder location on storage              | 
**Images** | [**List&lt;AiBcrImageStorageFile&gt;**](AiBcrImageStorageFile.md) | Images to parse.              | 
**Options** | [**AiBcrOptions**](AiBcrOptions.md) | Recognition options.              | [optional] 


## Example
```csharp
var aiBcrParseStorageRequest = new AiBcrParseStorageRequest
{
    OutFolder = new StorageFolderLocation
    {
        Storage = "First Storage",
        FolderPath = "VCard/files/produced/by/parser/will/be/placed/here"
    },
    Images = new List<AiBcrImageStorageFile>
    {
        new AiBcrImageStorageFile
        {
            File = new StorageFileLocation
            {
                FileName = "VCardScanImage.jpg",
                Storage = "First Storage",
                FolderPath = "image/location/on/storage"
            },
            IsSingle = true
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

