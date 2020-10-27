# Aspose.Email.Cloud.Sdk.CalendarApi

        <a name="AsAlternate"></a>
# AsAlternate

```csharp
AlternateView AsAlternate(CalendarAsAlternateRequest request)
```

Convert iCalendar to AlternateView             

### Return type

[**AlternateView**](AlternateView.md)

### request Parameter

See parameter model documentation at [CalendarAsAlternateRequest](CalendarAsAlternateRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsAlternateAsync"></a>
# AsAlternateAsync

```csharp
async Task<AlternateView> AsAlternateAsync(CalendarAsAlternateRequest request)
```

Convert iCalendar to AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AlternateView**](AlternateView.md)>

### request Parameter

See parameter model documentation at [CalendarAsAlternateRequest](CalendarAsAlternateRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="AsFile"></a>
# AsFile

```csharp
Stream AsFile(CalendarAsFileRequest request)
```

Converts calendar model to specified format and returns as file.             

### Return type

**Stream**

### request Parameter

See parameter model documentation at [CalendarAsFileRequest](CalendarAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

```csharp
async Task<Stream> AsFileAsync(CalendarAsFileRequest request)
```

Converts calendar model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter

See parameter model documentation at [CalendarAsFileRequest](CalendarAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="AsMapi"></a>
# AsMapi

```csharp
MapiCalendarDto AsMapi(CalendarDto calendarDto)
```

Converts CalendarDto to MapiCalendarDto.             

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

### calendarDto Parameter

See parameter model documentation at [CalendarDto](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
# AsMapiAsync

```csharp
async Task<MapiCalendarDto> AsMapiAsync(CalendarDto calendarDto)
```

Converts CalendarDto to MapiCalendarDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

### calendarDto Parameter

See parameter model documentation at [CalendarDto](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Convert"></a>
# Convert

```csharp
Stream Convert(CalendarConvertRequest request)
```

Converts calendar document to specified format and returns as file.             

### Return type

**Stream**

### request Parameter
```csharp
new CalendarConvertRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
# ConvertAsync

```csharp
async Task<Stream> ConvertAsync(CalendarConvertRequest request)
```

Converts calendar document to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
```csharp
new CalendarConvertRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="FromFile"></a>
# FromFile

```csharp
CalendarDto FromFile(CalendarFromFileRequest request)
```

Converts calendar document to a model representation.             

### Return type

[**CalendarDto**](CalendarDto.md)

### request Parameter
```csharp
new CalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

```csharp
async Task<CalendarDto> FromFileAsync(CalendarFromFileRequest request)
```

Converts calendar document to a model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### request Parameter
```csharp
new CalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Get"></a>
# Get

```csharp
CalendarDto Get(CalendarGetRequest request)
```

Get calendar file from storage.             

### Return type

[**CalendarDto**](CalendarDto.md)

### request Parameter
```csharp
new CalendarGetRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<CalendarDto> GetAsync(CalendarGetRequest request)
```

Get calendar file from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### request Parameter
```csharp
new CalendarGetRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetAsAlternate"></a>
# GetAsAlternate

```csharp
AlternateView GetAsAlternate(CalendarGetAsAlternateRequest request)
```

Get iCalendar from storage as AlternateView             

### Return type

[**AlternateView**](AlternateView.md)

### request Parameter
```csharp
new CalendarGetAsAlternateRequest(
    fileName,
    calendarAction,
    sequenceId=sequenceId,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsAlternateAsync"></a>
# GetAsAlternateAsync

```csharp
async Task<AlternateView> GetAsAlternateAsync(CalendarGetAsAlternateRequest request)
```

Get iCalendar from storage as AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AlternateView**](AlternateView.md)>

### request Parameter
```csharp
new CalendarGetAsAlternateRequest(
    fileName,
    calendarAction,
    sequenceId=sequenceId,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetAsFile"></a>
# GetAsFile

```csharp
Stream GetAsFile(CalendarGetAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file.             

### Return type

**Stream**

### request Parameter
```csharp
new CalendarGetAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name. | 
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **storage** | **string**| Storage name. | [optional] 
 **folder** | **string**| Path to folder in storage. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
# GetAsFileAsync

```csharp
async Task<Stream> GetAsFileAsync(CalendarGetAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
```csharp
new CalendarGetAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name. | 
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **storage** | **string**| Storage name. | [optional] 
 **folder** | **string**| Path to folder in storage. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetList"></a>
# GetList

```csharp
CalendarStorageList GetList(CalendarGetListRequest request)
```

Get iCalendar list from storage folder.             

### Return type

[**CalendarStorageList**](CalendarStorageList.md)

### request Parameter
```csharp
new CalendarGetListRequest(
    folder,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage. | 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

```csharp
async Task<CalendarStorageList> GetListAsync(CalendarGetListRequest request)
```

Get iCalendar list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarStorageList**](CalendarStorageList.md)>

### request Parameter
```csharp
new CalendarGetListRequest(
    folder,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage. | 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Save"></a>
# Save

```csharp
void Save(CalendarSaveRequest request)
```

Save iCalendar             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [CalendarSaveRequest](CalendarSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(CalendarSaveRequest request)
```

Save iCalendar             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [CalendarSaveRequest](CalendarSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
