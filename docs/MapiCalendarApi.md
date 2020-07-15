# Aspose.Email.Cloud.Sdk.MapiCalendarApi

<a name="mapicalendarascalendardto"></a>
# **MapiCalendarAsCalendarDto**

```csharp
CalendarDto MapiCalendarAsCalendarDto(MapiCalendarAsCalendarDtoRequest request)
```

Converts MAPI calendar model to CalendarDto model             

### Return type

[**CalendarDto**](CalendarDto.md)

### Request Parameters
```csharp
new MapiCalendarAsCalendarDtoRequest(
    mapiCalendarDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapiCalendarDto** | [**MapiCalendarDto**](MapiCalendarDto.md)| MAPI calendar model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarascalendardto"></a>
# **MapiCalendarAsCalendarDtoAsync**

```csharp
async Task<CalendarDto> MapiCalendarAsCalendarDtoAsync(MapiCalendarAsCalendarDtoRequest request)
```

Converts MAPI calendar model to CalendarDto model             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### Request Parameters
```csharp
new MapiCalendarAsCalendarDtoRequest(
    mapiCalendarDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapiCalendarDto** | [**MapiCalendarDto**](MapiCalendarDto.md)| MAPI calendar model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarasfile"></a>
# **MapiCalendarAsFile**

```csharp
Stream MapiCalendarAsFile(MapiCalendarAsFileRequest request)
```

Converts MAPI calendar model to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new MapiCalendarAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiCalendarAsFileRequest**](MapiCalendarAsFileRequest.md)| MAPI calendar model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarasfile"></a>
# **MapiCalendarAsFileAsync**

```csharp
async Task<Stream> MapiCalendarAsFileAsync(MapiCalendarAsFileRequest request)
```

Converts MAPI calendar model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new MapiCalendarAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiCalendarAsFileRequest**](MapiCalendarAsFileRequest.md)| MAPI calendar model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarfromfile"></a>
# **MapiCalendarFromFile**

```csharp
MapiCalendarDto MapiCalendarFromFile(MapiCalendarFromFileRequest request)
```

Converts calendar file to a MAPI model representation             

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

### Request Parameters
```csharp
new MapiCalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarfromfile"></a>
# **MapiCalendarFromFileAsync**

```csharp
async Task<MapiCalendarDto> MapiCalendarFromFileAsync(MapiCalendarFromFileRequest request)
```

Converts calendar file to a MAPI model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

### Request Parameters
```csharp
new MapiCalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarget"></a>
# **MapiCalendarGet**

```csharp
MapiCalendarDto MapiCalendarGet(MapiCalendarGetRequest request)
```

Get MAPI calendar document.             

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

### Request Parameters
```csharp
new MapiCalendarGetRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarget"></a>
# **MapiCalendarGetAsync**

```csharp
async Task<MapiCalendarDto> MapiCalendarGetAsync(MapiCalendarGetRequest request)
```

Get MAPI calendar document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

### Request Parameters
```csharp
new MapiCalendarGetRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarsave"></a>
# **MapiCalendarSave**

```csharp
void MapiCalendarSave(MapiCalendarSaveRequest request)
```

Save MAPI Calendar to storage.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new MapiCalendarSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiCalendarSaveRequest**](MapiCalendarSaveRequest.md)| Calendar create/update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="mapicalendarsave"></a>
# **MapiCalendarSaveAsync**

```csharp
async Task MapiCalendarSaveAsync(MapiCalendarSaveRequest request)
```

Save MAPI Calendar to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MapiCalendarSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MapiCalendarSaveRequest**](MapiCalendarSaveRequest.md)| Calendar create/update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

