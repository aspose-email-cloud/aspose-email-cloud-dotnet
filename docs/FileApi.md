# Aspose.Email.Cloud.Sdk.FileApi

<a name="CopyFile"></a>
# CopyFile

Copy file

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CopyFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage",
};

// Call method:
Api.CloudStorage.File.CopyFile(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CopyFileAsync"></a>
# CopyFileAsync

Copy file

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CopyFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage",
};

// Call method:
await Api.CloudStorage.File.CopyFileAsync(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DeleteFile"></a>
# DeleteFile

Delete file

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage",
};

// Call method:
Api.CloudStorage.File.DeleteFile(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteFileAsync"></a>
# DeleteFileAsync

Delete file

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage",
};

// Call method:
await Api.CloudStorage.File.DeleteFileAsync(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DownloadFile"></a>
# DownloadFile

Download file

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage",
};

// Call method:
var result = Api.CloudStorage.File.DownloadFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DownloadFileAsync"></a>
# DownloadFileAsync

Download file

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage",
};

// Call method:
var result = await Api.CloudStorage.File.DownloadFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="MoveFile"></a>
# MoveFile

Move file

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage",
};

// Call method:
Api.CloudStorage.File.MoveFile(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveFileAsync"></a>
# MoveFileAsync

Move file

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage",
};

// Call method:
await Api.CloudStorage.File.MoveFileAsync(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="UploadFile"></a>
# UploadFile

Upload file

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};

// Call method:
var result = Api.CloudStorage.File.UploadFile(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="UploadFileAsync"></a>
# UploadFileAsync

Upload file

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};

// Call method:
var result = await Api.CloudStorage.File.UploadFileAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
