# Aspose.Email.Cloud.Sdk.FolderApi

<a name="copyfolder"></a>
# **CopyFolder**

```csharp
void CopyFolder(CopyFolderRequest request)
```

Copy folder

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
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createfolder"></a>
# **CreateFolder**

```csharp
void CreateFolder(CreateFolderRequest request)
```

Create the folder

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
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefolder"></a>
# **DeleteFolder**

```csharp
void DeleteFolder(DeleteFolderRequest request)
```

Delete folder

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
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileslist"></a>
# **GetFilesList**

```csharp
FilesList GetFilesList(GetFilesListRequest request)
```

Get all files and folders within a folder

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
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefolder"></a>
# **MoveFolder**

```csharp
void MoveFolder(MoveFolderRequest request)
```

Move folder

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
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

