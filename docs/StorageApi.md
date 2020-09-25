# Aspose.Email.Cloud.Sdk.StorageApi

<a name="GetDiscUsage"></a>
# GetDiscUsage

Get disc usage

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new GetDiscUsageRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = Api.CloudStorage.Storage.GetDiscUsage(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetDiscUsageAsync"></a>
# GetDiscUsageAsync

Get disc usage

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new GetDiscUsageRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = await Api.CloudStorage.Storage.GetDiscUsageAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetFileVersions"></a>
# GetFileVersions

Get file versions

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
var result = Api.CloudStorage.Storage.GetFileVersions(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetFileVersionsAsync"></a>
# GetFileVersionsAsync

Get file versions

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
var result = await Api.CloudStorage.Storage.GetFileVersionsAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ObjectExists"></a>
# ObjectExists

Check if file or folder exists

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage",
};

// Call method:
var result = Api.CloudStorage.Storage.ObjectExists(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ObjectExistsAsync"></a>
# ObjectExistsAsync

Check if file or folder exists

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage",
};

// Call method:
var result = await Api.CloudStorage.Storage.ObjectExistsAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Exists"></a>
# Exists

Check if storage exists

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new StorageExistsRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = Api.CloudStorage.Storage.Exists(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExistsAsync"></a>
# ExistsAsync

Check if storage exists

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new StorageExistsRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = await Api.CloudStorage.Storage.ExistsAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
