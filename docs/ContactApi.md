# Aspose.Email.Cloud.Sdk.ContactApi

<a name="contactasfile"></a>
# **ContactAsFile**

```csharp
Stream ContactAsFile(ContactAsFileRequest request)
```

Converts contact model to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ContactAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ContactAsFileRequest**](ContactAsFileRequest.md)| Contact model and format to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactasfile"></a>
# **ContactAsFileAsync**

```csharp
async Task<Stream> ContactAsFileAsync(ContactAsFileRequest request)
```

Converts contact model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ContactAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ContactAsFileRequest**](ContactAsFileRequest.md)| Contact model and format to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactasmapi"></a>
# **ContactAsMapi**

```csharp
MapiContactDto ContactAsMapi(ContactAsMapiRequest request)
```

Converts ContactDto to MapiContactDto.             

### Return type

[**MapiContactDto**](MapiContactDto.md)

### Request Parameters
```csharp
new ContactAsMapiRequest(
    contactDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactDto** | [**ContactDto**](ContactDto.md)| Contact model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactasmapi"></a>
# **ContactAsMapiAsync**

```csharp
async Task<MapiContactDto> ContactAsMapiAsync(ContactAsMapiRequest request)
```

Converts ContactDto to MapiContactDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

### Request Parameters
```csharp
new ContactAsMapiRequest(
    contactDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactDto** | [**ContactDto**](ContactDto.md)| Contact model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactconvert"></a>
# **ContactConvert**

```csharp
Stream ContactConvert(ContactConvertRequest request)
```

Converts contact document to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ContactConvertRequest(
    toFormat,
    fromFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toFormat** | **string**| File format to convert to Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactconvert"></a>
# **ContactConvertAsync**

```csharp
async Task<Stream> ContactConvertAsync(ContactConvertRequest request)
```

Converts contact document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ContactConvertRequest(
    toFormat,
    fromFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toFormat** | **string**| File format to convert to Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactfromfile"></a>
# **ContactFromFile**

```csharp
ContactDto ContactFromFile(ContactFromFileRequest request)
```

Converts contact document to a model representation             

### Return type

[**ContactDto**](ContactDto.md)

### Request Parameters
```csharp
new ContactFromFileRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactfromfile"></a>
# **ContactFromFileAsync**

```csharp
async Task<ContactDto> ContactFromFileAsync(ContactFromFileRequest request)
```

Converts contact document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### Request Parameters
```csharp
new ContactFromFileRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactget"></a>
# **ContactGet**

```csharp
ContactDto ContactGet(ContactGetRequest request)
```

Get contact document from storage.             

### Return type

[**ContactDto**](ContactDto.md)

### Request Parameters
```csharp
new ContactGetRequest(
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

<a name="contactget"></a>
# **ContactGetAsync**

```csharp
async Task<ContactDto> ContactGetAsync(ContactGetRequest request)
```

Get contact document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### Request Parameters
```csharp
new ContactGetRequest(
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

<a name="contactgetasfile"></a>
# **ContactGetAsFile**

```csharp
Stream ContactGetAsFile(ContactGetAsFileRequest request)
```

Converts contact document from storage to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ContactGetAsFileRequest(
    fileName,
    toFormat,
    fromFormat,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **toFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactgetasfile"></a>
# **ContactGetAsFileAsync**

```csharp
async Task<Stream> ContactGetAsFileAsync(ContactGetAsFileRequest request)
```

Converts contact document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ContactGetAsFileRequest(
    fileName,
    toFormat,
    fromFormat,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **toFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactgetlist"></a>
# **ContactGetList**

```csharp
ContactStorageList ContactGetList(ContactGetListRequest request)
```

Get contact list from storage folder.             

### Return type

[**ContactStorageList**](ContactStorageList.md)

### Request Parameters
```csharp
new ContactGetListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactgetlist"></a>
# **ContactGetListAsync**

```csharp
async Task<ContactStorageList> ContactGetListAsync(ContactGetListRequest request)
```

Get contact list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactStorageList**](ContactStorageList.md)>

### Request Parameters
```csharp
new ContactGetListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactsave"></a>
# **ContactSave**

```csharp
void ContactSave(ContactSaveRequest request)
```

Save contact to storage.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ContactSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ContactSaveRequest**](ContactSaveRequest.md)| Create/Update contact request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="contactsave"></a>
# **ContactSaveAsync**

```csharp
async Task ContactSaveAsync(ContactSaveRequest request)
```

Save contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ContactSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ContactSaveRequest**](ContactSaveRequest.md)| Create/Update contact request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

