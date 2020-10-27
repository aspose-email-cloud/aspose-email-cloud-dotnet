# Aspose.Email.Cloud.Sdk.ContactApi

        <a name="AsFile"></a>
# AsFile

```csharp
Stream AsFile(ContactAsFileRequest request)
```

Converts contact model to specified format and returns as file             

### Return type

**Stream**

### request Parameter

See parameter model documentation at [ContactAsFileRequest](ContactAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

```csharp
async Task<Stream> AsFileAsync(ContactAsFileRequest request)
```

Converts contact model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter

See parameter model documentation at [ContactAsFileRequest](ContactAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="AsMapi"></a>
# AsMapi

```csharp
MapiContactDto AsMapi(ContactDto contactDto)
```

Converts ContactDto to MapiContactDto.             

### Return type

[**MapiContactDto**](MapiContactDto.md)

### contactDto Parameter

See parameter model documentation at [ContactDto](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
# AsMapiAsync

```csharp
async Task<MapiContactDto> AsMapiAsync(ContactDto contactDto)
```

Converts ContactDto to MapiContactDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

### contactDto Parameter

See parameter model documentation at [ContactDto](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Convert"></a>
# Convert

```csharp
Stream Convert(ContactConvertRequest request)
```

Converts contact document to specified format and returns as file             

### Return type

**Stream**

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
# ConvertAsync

```csharp
async Task<Stream> ConvertAsync(ContactConvertRequest request)
```

Converts contact document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="FromFile"></a>
# FromFile

```csharp
ContactDto FromFile(ContactFromFileRequest request)
```

Converts contact document to a model representation             

### Return type

[**ContactDto**](ContactDto.md)

### request Parameter
```csharp
new ContactFromFileRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

```csharp
async Task<ContactDto> FromFileAsync(ContactFromFileRequest request)
```

Converts contact document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### request Parameter
```csharp
new ContactFromFileRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Get"></a>
# Get

```csharp
ContactDto Get(ContactGetRequest request)
```

Get contact document from storage.             

### Return type

[**ContactDto**](ContactDto.md)

### request Parameter
```csharp
new ContactGetRequest(
    format,
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **fileName** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<ContactDto> GetAsync(ContactGetRequest request)
```

Get contact document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### request Parameter
```csharp
new ContactGetRequest(
    format,
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **fileName** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetAsFile"></a>
# GetAsFile

```csharp
Stream GetAsFile(ContactGetAsFileRequest request)
```

Converts contact document from storage to specified format and returns as file             

### Return type

**Stream**

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
# GetAsFileAsync

```csharp
async Task<Stream> GetAsFileAsync(ContactGetAsFileRequest request)
```

Converts contact document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetList"></a>
# GetList

```csharp
ContactStorageList GetList(ContactGetListRequest request)
```

Get contact list from storage folder.             

### Return type

[**ContactStorageList**](ContactStorageList.md)

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

```csharp
async Task<ContactStorageList> GetListAsync(ContactGetListRequest request)
```

Get contact list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactStorageList**](ContactStorageList.md)>

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Save"></a>
# Save

```csharp
void Save(ContactSaveRequest request)
```

Save contact to storage.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ContactSaveRequest](ContactSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(ContactSaveRequest request)
```

Save contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ContactSaveRequest](ContactSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
