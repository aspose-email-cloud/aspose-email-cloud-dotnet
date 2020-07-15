# Aspose.Email.Cloud.Sdk.MapiMessageApi

<a name="mapimessageasemaildto"></a>
# **MapiMessageAsEmailDto**

```csharp
EmailDto MapiMessageAsEmailDto(MapiMessageAsEmailDtoRequest request)
```

Converts MAPI message model to EmailDto model             

### Return type

[**EmailDto**](EmailDto.md)

### Request Parameters
```csharp
new MapiMessageAsEmailDtoRequest(
    mapiMessage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapiMessage** | [**MapiMessageDto**](MapiMessageDto.md)| MAPI message model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessageasemaildto"></a>
# **MapiMessageAsEmailDtoAsync**

```csharp
async Task<EmailDto> MapiMessageAsEmailDtoAsync(MapiMessageAsEmailDtoRequest request)
```

Converts MAPI message model to EmailDto model             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### Request Parameters
```csharp
new MapiMessageAsEmailDtoRequest(
    mapiMessage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapiMessage** | [**MapiMessageDto**](MapiMessageDto.md)| MAPI message model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessageasfile"></a>
# **MapiMessageAsFile**

```csharp
Stream MapiMessageAsFile(MapiMessageAsFileRequest request)
```

Converts MAPI message model to specified format and returns as file.             

### Return type

**Stream**

### Request Parameters
```csharp
new MapiMessageAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiMessageAsFileRequest**](MapiMessageAsFileRequest.md)| MAPI message model to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessageasfile"></a>
# **MapiMessageAsFileAsync**

```csharp
async Task<Stream> MapiMessageAsFileAsync(MapiMessageAsFileRequest request)
```

Converts MAPI message model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new MapiMessageAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiMessageAsFileRequest**](MapiMessageAsFileRequest.md)| MAPI message model to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessagefromfile"></a>
# **MapiMessageFromFile**

```csharp
MapiMessageDto MapiMessageFromFile(MapiMessageFromFileRequest request)
```

Converts email file to a MAPI model representation             

### Return type

[**MapiMessageDto**](MapiMessageDto.md)

### Request Parameters
```csharp
new MapiMessageFromFileRequest(
    fileFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileFormat** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessagefromfile"></a>
# **MapiMessageFromFileAsync**

```csharp
async Task<MapiMessageDto> MapiMessageFromFileAsync(MapiMessageFromFileRequest request)
```

Converts email file to a MAPI model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

### Request Parameters
```csharp
new MapiMessageFromFileRequest(
    fileFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileFormat** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessageget"></a>
# **MapiMessageGet**

```csharp
MapiMessageDto MapiMessageGet(MapiMessageGetRequest request)
```

Get MAPI message document.             

### Return type

[**MapiMessageDto**](MapiMessageDto.md)

### Request Parameters
```csharp
new MapiMessageGetRequest(
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

<a name="mapimessageget"></a>
# **MapiMessageGetAsync**

```csharp
async Task<MapiMessageDto> MapiMessageGetAsync(MapiMessageGetRequest request)
```

Get MAPI message document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

### Request Parameters
```csharp
new MapiMessageGetRequest(
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

<a name="mapimessagesave"></a>
# **MapiMessageSave**

```csharp
void MapiMessageSave(MapiMessageSaveRequest request)
```

Save MAPI message to storage.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new MapiMessageSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiMessageSaveRequest**](MapiMessageSaveRequest.md)| Message create/update request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapimessagesave"></a>
# **MapiMessageSaveAsync**

```csharp
async Task MapiMessageSaveAsync(MapiMessageSaveRequest request)
```

Save MAPI message to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MapiMessageSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiMessageSaveRequest**](MapiMessageSaveRequest.md)| Message create/update request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

