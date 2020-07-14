# Aspose.Email.Cloud.Sdk.FolderApi

<a name="copyfolder"></a>
# **CopyFolder**

```csharp
void CopyFolder(CopyFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfolder"></a>
# **CopyFolderAsync**

```csharp
async Task CopyFolderAsync(CopyFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createfolder"></a>
# **CreateFolder**

```csharp
void CreateFolder(CreateFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createfolder"></a>
# **CreateFolderAsync**

```csharp
async Task CreateFolderAsync(CreateFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefolder"></a>
# **DeleteFolder**

```csharp
void DeleteFolder(DeleteFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefolder"></a>
# **DeleteFolderAsync**

```csharp
async Task DeleteFolderAsync(DeleteFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileslist"></a>
# **GetFilesList**

```csharp
FilesList GetFilesList(GetFilesListRequest request)
```



### Return type

[**FilesList**](FilesList.md)

### Request Parameters
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileslist"></a>
# **GetFilesListAsync**

```csharp
async Task<FilesList> GetFilesListAsync(GetFilesListRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FilesList**](FilesList.md)>

### Request Parameters
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefolder"></a>
# **MoveFolder**

```csharp
void MoveFolder(MoveFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefolder"></a>
# **MoveFolderAsync**

```csharp
async Task MoveFolderAsync(MoveFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

