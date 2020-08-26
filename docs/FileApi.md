# Aspose.Email.Cloud.Sdk.FileApi

        <a name="CopyFile"></a>
# CopyFile

```csharp
void CopyFile(CopyFileRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new CopyFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CopyFileAsync"></a>
# CopyFileAsync

```csharp
async Task CopyFileAsync(CopyFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new CopyFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="DeleteFile"></a>
# DeleteFile

```csharp
void DeleteFile(DeleteFileRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new DeleteFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteFileAsync"></a>
# DeleteFileAsync

```csharp
async Task DeleteFileAsync(DeleteFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new DeleteFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="DownloadFile"></a>
# DownloadFile

```csharp
Stream DownloadFile(DownloadFileRequest request)
```



### Return type

**Stream**

### request Parameter
```csharp
new DownloadFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DownloadFileAsync"></a>
# DownloadFileAsync

```csharp
async Task<Stream> DownloadFileAsync(DownloadFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
```csharp
new DownloadFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="MoveFile"></a>
# MoveFile

```csharp
void MoveFile(MoveFileRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new MoveFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveFileAsync"></a>
# MoveFileAsync

```csharp
async Task MoveFileAsync(MoveFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new MoveFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="UploadFile"></a>
# UploadFile

```csharp
FilesUploadResult UploadFile(UploadFileRequest request)
```



### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### request Parameter
```csharp
new UploadFileRequest(
    path,
    file,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="UploadFileAsync"></a>
# UploadFileAsync

```csharp
async Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FilesUploadResult**](FilesUploadResult.md)>

### request Parameter
```csharp
new UploadFileRequest(
    path,
    file,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
