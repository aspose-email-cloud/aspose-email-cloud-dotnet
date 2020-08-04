# Aspose.Email.Cloud.Sdk.MapiCalendarApi

        <a name="AsCalendarDto"></a>
# AsCalendarDto

```csharp
CalendarDto AsCalendarDto(MapiCalendarDto mapiCalendarDto)
```

Converts MAPI calendar model to CalendarDto model.             

### Return type

[**CalendarDto**](CalendarDto.md)

### mapiCalendarDto Parameter

See parameter model documentation at [MapiCalendarDto](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsCalendarDtoAsync"></a>
# AsCalendarDtoAsync

```csharp
async Task<CalendarDto> AsCalendarDtoAsync(MapiCalendarDto mapiCalendarDto)
```

Converts MAPI calendar model to CalendarDto model.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### mapiCalendarDto Parameter

See parameter model documentation at [MapiCalendarDto](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="AsFile"></a>
# AsFile

```csharp
Stream AsFile(MapiCalendarAsFileRequest request)
```

Converts MAPI calendar model to specified format and returns as file.             

### Return type

**Stream**

### request Parameter

See parameter model documentation at [MapiCalendarAsFileRequest](MapiCalendarAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

```csharp
async Task<Stream> AsFileAsync(MapiCalendarAsFileRequest request)
```

Converts MAPI calendar model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter

See parameter model documentation at [MapiCalendarAsFileRequest](MapiCalendarAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="FromFile"></a>
# FromFile

```csharp
MapiCalendarDto FromFile(MapiCalendarFromFileRequest request)
```

Converts calendar file to a MAPI model representation.             

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

### request Parameter
```csharp
new MapiCalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

```csharp
async Task<MapiCalendarDto> FromFileAsync(MapiCalendarFromFileRequest request)
```

Converts calendar file to a MAPI model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

### request Parameter
```csharp
new MapiCalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Get"></a>
# Get

```csharp
MapiCalendarDto Get(MapiCalendarGetRequest request)
```

Get MAPI calendar document.             

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

### request Parameter
```csharp
new MapiCalendarGetRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<MapiCalendarDto> GetAsync(MapiCalendarGetRequest request)
```

Get MAPI calendar document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

### request Parameter
```csharp
new MapiCalendarGetRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Save"></a>
# Save

```csharp
void Save(MapiCalendarSaveRequest request)
```

Save MAPI Calendar to storage.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [MapiCalendarSaveRequest](MapiCalendarSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(MapiCalendarSaveRequest request)
```

Save MAPI Calendar to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [MapiCalendarSaveRequest](MapiCalendarSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
