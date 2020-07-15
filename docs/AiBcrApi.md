# Aspose.Email.Cloud.Sdk.AiBcrApi

<a name="aibcrparse"></a>
# **AiBcrParse**

```csharp
ContactList AiBcrParse(AiBcrParseRequest request)
```

Parse images to vCard document models             

### Return type

[**ContactList**](ContactList.md)

### Request Parameters
```csharp
new AiBcrParseRequest(
    file,
    countries=countries,
    languages=languages,
    isSingle=isSingle)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 
 **countries** | **string**| Comma-separated codes of countries. | [optional] 
 **languages** | **string**| Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.              | [optional] 
 **isSingle** | **bool?**| Determines that image contains single VCard or more. | [optional] [default to true]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparse"></a>
# **AiBcrParseAsync**

```csharp
async Task<ContactList> AiBcrParseAsync(AiBcrParseRequest request)
```

Parse images to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactList**](ContactList.md)>

### Request Parameters
```csharp
new AiBcrParseRequest(
    file,
    countries=countries,
    languages=languages,
    isSingle=isSingle)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 
 **countries** | **string**| Comma-separated codes of countries. | [optional] 
 **languages** | **string**| Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.              | [optional] 
 **isSingle** | **bool?**| Determines that image contains single VCard or more. | [optional] [default to true]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsestorage"></a>
# **AiBcrParseStorage**

```csharp
StorageFileLocationList AiBcrParseStorage(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

### Return type

[**StorageFileLocationList**](StorageFileLocationList.md)

### Request Parameters
```csharp
new AiBcrParseStorageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiBcrParseStorageRequest**](AiBcrParseStorageRequest.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsestorage"></a>
# **AiBcrParseStorageAsync**

```csharp
async Task<StorageFileLocationList> AiBcrParseStorageAsync(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**StorageFileLocationList**](StorageFileLocationList.md)>

### Request Parameters
```csharp
new AiBcrParseStorageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiBcrParseStorageRequest**](AiBcrParseStorageRequest.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

