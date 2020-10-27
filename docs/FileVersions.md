# FileVersions
File versions FileVersion.

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**List&lt;FileVersion&gt;**](FileVersion.md) | File versions FileVersion. | [optional] 


## Example
```csharp
var fileVersions = new FileVersions
{
    Value = new List<FileVersion>
    {
        new FileVersion
        {
            VersionId = "d5afd857-8797-4ca0-b806-a03fdfc3831f",
            IsLatest = true,
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 4096,
            Path = "/storage/path/to"
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

