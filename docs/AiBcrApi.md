# Aspose.Email.Cloud.Sdk.AiBcrApi

<a name="aibcrparse"></a>
# **AiBcrParse**

```csharp
ListResponseOfContactDto AiBcrParse(AiBcrParseRequest request)
```

Parse images to vCard document models             

### Return type

[**ListResponseOfContactDto**](ListResponseOfContactDto.md)

### Request Parameters
```csharp
new AiBcrParseRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparse"></a>
# **AiBcrParseAsync**

```csharp
async Task<ListResponseOfContactDto> AiBcrParseAsync(AiBcrParseRequest request)
```

Parse images to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfContactDto**](ListResponseOfContactDto.md)>

### Request Parameters
```csharp
new AiBcrParseRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsestorage"></a>
# **AiBcrParseStorage**

```csharp
ListResponseOfStorageFileLocation AiBcrParseStorage(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

### Return type

[**ListResponseOfStorageFileLocation**](ListResponseOfStorageFileLocation.md)

### Request Parameters
```csharp
new AiBcrParseStorageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrParseStorageRq**](AiBcrParseStorageRq.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsestorage"></a>
# **AiBcrParseStorageAsync**

```csharp
async Task<ListResponseOfStorageFileLocation> AiBcrParseStorageAsync(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfStorageFileLocation**](ListResponseOfStorageFileLocation.md)>

### Request Parameters
```csharp
new AiBcrParseStorageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrParseStorageRq**](AiBcrParseStorageRq.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

