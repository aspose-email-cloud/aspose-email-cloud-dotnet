# Aspose.Email.Cloud.Sdk.StorageApi

        <a name="GetDiscUsage"></a>
# GetDiscUsage

```csharp
DiscUsage GetDiscUsage(GetDiscUsageRequest request)
```



### Return type

[**DiscUsage**](DiscUsage.md)

### request Parameter
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetDiscUsageAsync"></a>
# GetDiscUsageAsync

```csharp
async Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**DiscUsage**](DiscUsage.md)>

### request Parameter
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetFileVersions"></a>
# GetFileVersions

```csharp
FileVersions GetFileVersions(GetFileVersionsRequest request)
```



### Return type

[**FileVersions**](FileVersions.md)

### request Parameter
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetFileVersionsAsync"></a>
# GetFileVersionsAsync

```csharp
async Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FileVersions**](FileVersions.md)>

### request Parameter
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="ObjectExists"></a>
# ObjectExists

```csharp
ObjectExist ObjectExists(ObjectExistsRequest request)
```



### Return type

[**ObjectExist**](ObjectExist.md)

### request Parameter
```csharp
new ObjectExistsRequest(
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

<a name="ObjectExistsAsync"></a>
# ObjectExistsAsync

```csharp
async Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ObjectExist**](ObjectExist.md)>

### request Parameter
```csharp
new ObjectExistsRequest(
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
        <a name="Exists"></a>
# Exists

```csharp
StorageExist Exists(StorageExistsRequest request)
```



### Return type

[**StorageExist**](StorageExist.md)

### request Parameter
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExistsAsync"></a>
# ExistsAsync

```csharp
async Task<StorageExist> ExistsAsync(StorageExistsRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**StorageExist**](StorageExist.md)>

### request Parameter
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
