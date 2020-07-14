# Aspose.Email.Cloud.Sdk.EmailApi

<a name="emailasfile"></a>
# **EmailAsFile**

```csharp
Stream EmailAsFile(EmailAsFileRequest request)
```

Converts Email model to specified format and returns as file.             

### Return type

**Stream**

### Request Parameters
```csharp
new EmailAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailAsFileRequest**](EmailAsFileRequest.md)| Email model and format to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailasfile"></a>
# **EmailAsFileAsync**

```csharp
async Task<Stream> EmailAsFileAsync(EmailAsFileRequest request)
```

Converts Email model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new EmailAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailAsFileRequest**](EmailAsFileRequest.md)| Email model and format to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailasmapi"></a>
# **EmailAsMapi**

```csharp
MapiMessageDto EmailAsMapi(EmailAsMapiRequest request)
```

Converts EmailDto to MapiMessageDto.             

### Return type

[**MapiMessageDto**](MapiMessageDto.md)

### Request Parameters
```csharp
new EmailAsMapiRequest(
    emailDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailDto** | [**EmailDto**](EmailDto.md)| Email model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailasmapi"></a>
# **EmailAsMapiAsync**

```csharp
async Task<MapiMessageDto> EmailAsMapiAsync(EmailAsMapiRequest request)
```

Converts EmailDto to MapiMessageDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

### Request Parameters
```csharp
new EmailAsMapiRequest(
    emailDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailDto** | [**EmailDto**](EmailDto.md)| Email model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconvert"></a>
# **EmailConvert**

```csharp
Stream EmailConvert(EmailConvertRequest request)
```

Converts email document to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new EmailConvertRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconvert"></a>
# **EmailConvertAsync**

```csharp
async Task<Stream> EmailConvertAsync(EmailConvertRequest request)
```

Converts email document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new EmailConvertRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailfromfile"></a>
# **EmailFromFile**

```csharp
EmailDto EmailFromFile(EmailFromFileRequest request)
```

Converts email document to a model representation             

### Return type

[**EmailDto**](EmailDto.md)

### Request Parameters
```csharp
new EmailFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailfromfile"></a>
# **EmailFromFileAsync**

```csharp
async Task<EmailDto> EmailFromFileAsync(EmailFromFileRequest request)
```

Converts email document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### Request Parameters
```csharp
new EmailFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailget"></a>
# **EmailGet**

```csharp
EmailDto EmailGet(EmailGetRequest request)
```

Get email document from storage.             

### Return type

[**EmailDto**](EmailDto.md)

### Request Parameters
```csharp
new EmailGetRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **name** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailget"></a>
# **EmailGetAsync**

```csharp
async Task<EmailDto> EmailGetAsync(EmailGetRequest request)
```

Get email document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### Request Parameters
```csharp
new EmailGetRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **name** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailgetasfile"></a>
# **EmailGetAsFile**

```csharp
Stream EmailGetAsFile(EmailGetAsFileRequest request)
```

Converts email document from storage to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new EmailGetAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name | 
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailgetasfile"></a>
# **EmailGetAsFileAsync**

```csharp
async Task<Stream> EmailGetAsFileAsync(EmailGetAsFileRequest request)
```

Converts email document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new EmailGetAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name | 
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailgetlist"></a>
# **EmailGetList**

```csharp
EmailStorageList EmailGetList(EmailGetListRequest request)
```

Get email list from storage folder.             

### Return type

[**EmailStorageList**](EmailStorageList.md)

### Request Parameters
```csharp
new EmailGetListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailgetlist"></a>
# **EmailGetListAsync**

```csharp
async Task<EmailStorageList> EmailGetListAsync(EmailGetListRequest request)
```

Get email list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailStorageList**](EmailStorageList.md)>

### Request Parameters
```csharp
new EmailGetListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailsave"></a>
# **EmailSave**

```csharp
void EmailSave(EmailSaveRequest request)
```

Save email document to storage.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new EmailSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailSaveRequest**](EmailSaveRequest.md)| Email document create/update request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailsave"></a>
# **EmailSaveAsync**

```csharp
async Task EmailSaveAsync(EmailSaveRequest request)
```

Save email document to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new EmailSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailSaveRequest**](EmailSaveRequest.md)| Email document create/update request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

