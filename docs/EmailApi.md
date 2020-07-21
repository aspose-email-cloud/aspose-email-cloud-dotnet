# Aspose.Email.Cloud.Sdk.EmailApi

        ﻿<a name="AsFile"></a>
# AsFile

```csharp
Stream AsFile(EmailAsFileRequest request)
```

Converts Email model to specified format and returns as file.             

### Return type

**Stream**

### request Parameter

See parameter model documentation at [EmailAsFileRequest](EmailAsFileRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

```csharp
async Task<Stream> AsFileAsync(EmailAsFileRequest request)
```

Converts Email model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter

See parameter model documentation at [EmailAsFileRequest](EmailAsFileRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="AsMapi"></a>
# AsMapi

```csharp
MapiMessageDto AsMapi(EmailDto emailDto)
```

Converts EmailDto to MapiMessageDto.             

### Return type

[**MapiMessageDto**](MapiMessageDto.md)

### emailDto Parameter

See parameter model documentation at [EmailDto](EmailDto.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
# AsMapiAsync

```csharp
async Task<MapiMessageDto> AsMapiAsync(EmailDto emailDto)
```

Converts EmailDto to MapiMessageDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

### emailDto Parameter

See parameter model documentation at [EmailDto](EmailDto.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="Convert"></a>
# Convert

```csharp
Stream Convert(EmailConvertRequest request)
```

Converts email document to specified format and returns as file             

### Return type

**Stream**

### request Parameter
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

<a name="ConvertAsync"></a>
# ConvertAsync

```csharp
async Task<Stream> ConvertAsync(EmailConvertRequest request)
```

Converts email document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
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
        ﻿<a name="FromFile"></a>
# FromFile

```csharp
EmailDto FromFile(EmailFromFileRequest request)
```

Converts email document to a model representation             

### Return type

[**EmailDto**](EmailDto.md)

### request Parameter
```csharp
new EmailFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

```csharp
async Task<EmailDto> FromFileAsync(EmailFromFileRequest request)
```

Converts email document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### request Parameter
```csharp
new EmailFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="Get"></a>
# Get

```csharp
EmailDto Get(EmailGetRequest request)
```

Get email document from storage.             

### Return type

[**EmailDto**](EmailDto.md)

### request Parameter
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

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<EmailDto> GetAsync(EmailGetRequest request)
```

Get email document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### request Parameter
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
        ﻿<a name="GetAsFile"></a>
# GetAsFile

```csharp
Stream GetAsFile(EmailGetAsFileRequest request)
```

Converts email document from storage to specified format and returns as file             

### Return type

**Stream**

### request Parameter
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

<a name="GetAsFileAsync"></a>
# GetAsFileAsync

```csharp
async Task<Stream> GetAsFileAsync(EmailGetAsFileRequest request)
```

Converts email document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
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
        ﻿<a name="GetList"></a>
# GetList

```csharp
EmailStorageList GetList(EmailGetListRequest request)
```

Get email list from storage folder.             

### Return type

[**EmailStorageList**](EmailStorageList.md)

### request Parameter
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

<a name="GetListAsync"></a>
# GetListAsync

```csharp
async Task<EmailStorageList> GetListAsync(EmailGetListRequest request)
```

Get email list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailStorageList**](EmailStorageList.md)>

### request Parameter
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
        ﻿<a name="Save"></a>
# Save

```csharp
void Save(EmailSaveRequest request)
```

Save email document to storage.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [EmailSaveRequest](EmailSaveRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(EmailSaveRequest request)
```

Save email document to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [EmailSaveRequest](EmailSaveRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
