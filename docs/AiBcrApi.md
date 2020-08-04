# Aspose.Email.Cloud.Sdk.AiBcrApi

        <a name="Parse"></a>
# Parse

```csharp
ContactList Parse(AiBcrParseRequest request)
```

Parse images to vCard document models             

### Return type

[**ContactList**](ContactList.md)

### request Parameter
```csharp
new AiBcrParseRequest(
    file,
    countries=countries,
    languages=languages,
    isSingle=isSingle)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to parse | 
 **countries** | **string**| Comma-separated codes of countries. | [optional] 
 **languages** | **string**| Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.              | [optional] 
 **isSingle** | **bool?**| Determines that image contains single VCard or more. | [optional] [default to true]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
# ParseAsync

```csharp
async Task<ContactList> ParseAsync(AiBcrParseRequest request)
```

Parse images to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactList**](ContactList.md)>

### request Parameter
```csharp
new AiBcrParseRequest(
    file,
    countries=countries,
    languages=languages,
    isSingle=isSingle)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to parse | 
 **countries** | **string**| Comma-separated codes of countries. | [optional] 
 **languages** | **string**| Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.              | [optional] 
 **isSingle** | **bool?**| Determines that image contains single VCard or more. | [optional] [default to true]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="ParseStorage"></a>
# ParseStorage

```csharp
StorageFileLocationList ParseStorage(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

### Return type

[**StorageFileLocationList**](StorageFileLocationList.md)

### request Parameter

See parameter model documentation at [AiBcrParseStorageRequest](AiBcrParseStorageRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseStorageAsync"></a>
# ParseStorageAsync

```csharp
async Task<StorageFileLocationList> ParseStorageAsync(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**StorageFileLocationList**](StorageFileLocationList.md)>

### request Parameter

See parameter model documentation at [AiBcrParseStorageRequest](AiBcrParseStorageRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
