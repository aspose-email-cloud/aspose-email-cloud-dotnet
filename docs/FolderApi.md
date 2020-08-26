# Aspose.Email.Cloud.Sdk.FolderApi

        <a name="CopyFolder"></a>
# CopyFolder

```csharp
void CopyFolder(CopyFolderRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new CopyFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CopyFolderAsync"></a>
# CopyFolderAsync

```csharp
async Task CopyFolderAsync(CopyFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new CopyFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="CreateFolder"></a>
# CreateFolder

```csharp
void CreateFolder(CreateFolderRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateFolderAsync"></a>
# CreateFolderAsync

```csharp
async Task CreateFolderAsync(CreateFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="DeleteFolder"></a>
# DeleteFolder

```csharp
void DeleteFolder(DeleteFolderRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new DeleteFolderRequest(
    path,
    storageName=storageName,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **recursive** | **bool?**|  | [optional] [default to false]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteFolderAsync"></a>
# DeleteFolderAsync

```csharp
async Task DeleteFolderAsync(DeleteFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new DeleteFolderRequest(
    path,
    storageName=storageName,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **recursive** | **bool?**|  | [optional] [default to false]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetFilesList"></a>
# GetFilesList

```csharp
FilesList GetFilesList(GetFilesListRequest request)
```



### Return type

[**FilesList**](FilesList.md)

### request Parameter
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetFilesListAsync"></a>
# GetFilesListAsync

```csharp
async Task<FilesList> GetFilesListAsync(GetFilesListRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FilesList**](FilesList.md)>

### request Parameter
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="MoveFolder"></a>
# MoveFolder

```csharp
void MoveFolder(MoveFolderRequest request)
```



### Return type

void (empty response body)

### request Parameter
```csharp
new MoveFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveFolderAsync"></a>
# MoveFolderAsync

```csharp
async Task MoveFolderAsync(MoveFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new MoveFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
