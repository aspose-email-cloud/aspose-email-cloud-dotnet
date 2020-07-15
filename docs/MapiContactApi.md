# Aspose.Email.Cloud.Sdk.MapiContactApi

<a name="mapicontactascontactdto"></a>
# **MapiContactAsContactDto**

```csharp
ContactDto MapiContactAsContactDto(MapiContactAsContactDtoRequest request)
```

Converts MAPI contact model to ContactDto model.             

### Return type

[**ContactDto**](ContactDto.md)

### Request Parameters
```csharp
new MapiContactAsContactDtoRequest(
    mapiContactDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapiContactDto** | [**MapiContactDto**](MapiContactDto.md)| MAPI contact model to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactascontactdto"></a>
# **MapiContactAsContactDtoAsync**

```csharp
async Task<ContactDto> MapiContactAsContactDtoAsync(MapiContactAsContactDtoRequest request)
```

Converts MAPI contact model to ContactDto model.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### Request Parameters
```csharp
new MapiContactAsContactDtoRequest(
    mapiContactDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapiContactDto** | [**MapiContactDto**](MapiContactDto.md)| MAPI contact model to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactasfile"></a>
# **MapiContactAsFile**

```csharp
Stream MapiContactAsFile(MapiContactAsFileRequest request)
```

Converts MAPI contact model to specified format and returns as file.             

### Return type

**Stream**

### Request Parameters
```csharp
new MapiContactAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiContactAsFileRequest**](MapiContactAsFileRequest.md)| MAPI contact model to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactasfile"></a>
# **MapiContactAsFileAsync**

```csharp
async Task<Stream> MapiContactAsFileAsync(MapiContactAsFileRequest request)
```

Converts MAPI contact model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new MapiContactAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiContactAsFileRequest**](MapiContactAsFileRequest.md)| MAPI contact model to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactfromfile"></a>
# **MapiContactFromFile**

```csharp
MapiContactDto MapiContactFromFile(MapiContactFromFileRequest request)
```

Converts contact file to a MAPI model representation.             

### Return type

[**MapiContactDto**](MapiContactDto.md)

### Request Parameters
```csharp
new MapiContactFromFileRequest(
    fileFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactfromfile"></a>
# **MapiContactFromFileAsync**

```csharp
async Task<MapiContactDto> MapiContactFromFileAsync(MapiContactFromFileRequest request)
```

Converts contact file to a MAPI model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

### Request Parameters
```csharp
new MapiContactFromFileRequest(
    fileFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactget"></a>
# **MapiContactGet**

```csharp
MapiContactDto MapiContactGet(MapiContactGetRequest request)
```

Get MAPI contact document.             

### Return type

[**MapiContactDto**](MapiContactDto.md)

### Request Parameters
```csharp
new MapiContactGetRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactget"></a>
# **MapiContactGetAsync**

```csharp
async Task<MapiContactDto> MapiContactGetAsync(MapiContactGetRequest request)
```

Get MAPI contact document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

### Request Parameters
```csharp
new MapiContactGetRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactsave"></a>
# **MapiContactSave**

```csharp
void MapiContactSave(MapiContactSaveRequest request)
```

Save MAPI Contact to storage.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new MapiContactSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiContactSaveRequest**](MapiContactSaveRequest.md)| Create/Update contact request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicontactsave"></a>
# **MapiContactSaveAsync**

```csharp
async Task MapiContactSaveAsync(MapiContactSaveRequest request)
```

Save MAPI Contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MapiContactSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiContactSaveRequest**](MapiContactSaveRequest.md)| Create/Update contact request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

