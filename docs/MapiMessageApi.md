# Aspose.Email.Cloud.Sdk.MapiMessageApi

        <a name="AsEmailDto"></a>
# AsEmailDto

```csharp
EmailDto AsEmailDto(MapiMessageDto mapiMessage)
```

Converts MAPI message model to EmailDto model             

### Return type

[**EmailDto**](EmailDto.md)

### mapiMessage Parameter

See parameter model documentation at [MapiMessageDto](MapiMessageDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsEmailDtoAsync"></a>
# AsEmailDtoAsync

```csharp
async Task<EmailDto> AsEmailDtoAsync(MapiMessageDto mapiMessage)
```

Converts MAPI message model to EmailDto model             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### mapiMessage Parameter

See parameter model documentation at [MapiMessageDto](MapiMessageDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="AsFile"></a>
# AsFile

```csharp
Stream AsFile(MapiMessageAsFileRequest request)
```

Converts MAPI message model to specified format and returns as file.             

### Return type

**Stream**

### request Parameter

See parameter model documentation at [MapiMessageAsFileRequest](MapiMessageAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

```csharp
async Task<Stream> AsFileAsync(MapiMessageAsFileRequest request)
```

Converts MAPI message model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter

See parameter model documentation at [MapiMessageAsFileRequest](MapiMessageAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="FromFile"></a>
# FromFile

```csharp
MapiMessageDto FromFile(MapiMessageFromFileRequest request)
```

Converts email file to a MAPI model representation             

### Return type

[**MapiMessageDto**](MapiMessageDto.md)

### request Parameter
```csharp
new MapiMessageFromFileRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

```csharp
async Task<MapiMessageDto> FromFileAsync(MapiMessageFromFileRequest request)
```

Converts email file to a MAPI model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

### request Parameter
```csharp
new MapiMessageFromFileRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Get"></a>
# Get

```csharp
MapiMessageDto Get(MapiMessageGetRequest request)
```

Get MAPI message document.             

### Return type

[**MapiMessageDto**](MapiMessageDto.md)

### request Parameter
```csharp
new MapiMessageGetRequest(
    format,
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **fileName** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<MapiMessageDto> GetAsync(MapiMessageGetRequest request)
```

Get MAPI message document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

### request Parameter
```csharp
new MapiMessageGetRequest(
    format,
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | 
 **fileName** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Save"></a>
# Save

```csharp
void Save(MapiMessageSaveRequest request)
```

Save MAPI message to storage.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [MapiMessageSaveRequest](MapiMessageSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(MapiMessageSaveRequest request)
```

Save MAPI message to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [MapiMessageSaveRequest](MapiMessageSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
