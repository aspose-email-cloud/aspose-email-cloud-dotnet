# Aspose.Email.Cloud.Sdk.AiBcrApi

<a name="Parse"></a>
# Parse

Parse images to vCard document models             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};

// Call method:
var result = Api.Ai.Bcr.Parse(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to parse | 
 **countries** | **string**| Comma-separated codes of countries. | [optional] 
 **languages** | **string**| Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.              | [optional] 
 **isSingle** | **bool?**| Determines that image contains single VCard or more. | [optional] [default to true]

### Return type

[**ContactList**](ContactList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
# ParseAsync

Parse images to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};

// Call method:
var result = await Api.Ai.Bcr.ParseAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to parse | 
 **countries** | **string**| Comma-separated codes of countries. | [optional] 
 **languages** | **string**| Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.              | [optional] 
 **isSingle** | **bool?**| Determines that image contains single VCard or more. | [optional] [default to true]

### Return type

[**ContactList**](ContactList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ParseStorage"></a>
# ParseStorage

Parse images from storage to vCard files             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiBcrParseStorageRequest
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

// Call method:
var result = Api.Ai.Bcr.ParseStorage(request);

// Result example:
result = ;
```

</details>

### request Parameter
See parameter model documentation at [AiBcrParseStorageRequest](AiBcrParseStorageRequest.md)


### Return type

[**StorageFileLocationList**](StorageFileLocationList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseStorageAsync"></a>
# ParseStorageAsync

Parse images from storage to vCard files             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiBcrParseStorageRequest
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

// Call method:
var result = await Api.Ai.Bcr.ParseStorageAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter
See parameter model documentation at [AiBcrParseStorageRequest](AiBcrParseStorageRequest.md)


### Return type

Task<[**StorageFileLocationList**](StorageFileLocationList.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
