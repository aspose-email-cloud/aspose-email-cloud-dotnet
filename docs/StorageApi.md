# Aspose.Email.Cloud.Sdk.StorageApi

<a name="getdiscusage"></a>
# **GetDiscUsage**

```csharp
DiscUsage GetDiscUsage(GetDiscUsageRequest request)
```

Get disc usage

### Return type

[**DiscUsage**](DiscUsage.md)

### Request Parameters
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getdiscusage"></a>
# **GetDiscUsageAsync**

```csharp
async Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request)
```

Get disc usage

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**DiscUsage**](DiscUsage.md)>

### Request Parameters
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileversions"></a>
# **GetFileVersions**

```csharp
FileVersions GetFileVersions(GetFileVersionsRequest request)
```

Get file versions

### Return type

[**FileVersions**](FileVersions.md)

### Request Parameters
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileversions"></a>
# **GetFileVersionsAsync**

```csharp
async Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request)
```

Get file versions

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FileVersions**](FileVersions.md)>

### Request Parameters
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="objectexists"></a>
# **ObjectExists**

```csharp
ObjectExist ObjectExists(ObjectExistsRequest request)
```

Check if file or folder exists

### Return type

[**ObjectExist**](ObjectExist.md)

### Request Parameters
```csharp
new ObjectExistsRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="objectexists"></a>
# **ObjectExistsAsync**

```csharp
async Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request)
```

Check if file or folder exists

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ObjectExist**](ObjectExist.md)>

### Request Parameters
```csharp
new ObjectExistsRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="storageexists"></a>
# **StorageExists**

```csharp
StorageExist StorageExists(StorageExistsRequest request)
```

Check if storage exists

### Return type

[**StorageExist**](StorageExist.md)

### Request Parameters
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="storageexists"></a>
# **StorageExistsAsync**

```csharp
async Task<StorageExist> StorageExistsAsync(StorageExistsRequest request)
```

Check if storage exists

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**StorageExist**](StorageExist.md)>

### Request Parameters
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

