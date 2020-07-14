# Aspose.Email.Cloud.Sdk.CalendarApi

<a name="calendarasalternate"></a>
# **CalendarAsAlternate**

```csharp
AlternateView CalendarAsAlternate(CalendarAsAlternateRequest request)
```

Convert iCalendar to AlternateView             

### Return type

[**AlternateView**](AlternateView.md)

### Request Parameters
```csharp
new CalendarAsAlternateRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CalendarAsAlternateRequest**](CalendarAsAlternateRequest.md)| iCalendar to AlternateView request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarasalternate"></a>
# **CalendarAsAlternateAsync**

```csharp
async Task<AlternateView> CalendarAsAlternateAsync(CalendarAsAlternateRequest request)
```

Convert iCalendar to AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AlternateView**](AlternateView.md)>

### Request Parameters
```csharp
new CalendarAsAlternateRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CalendarAsAlternateRequest**](CalendarAsAlternateRequest.md)| iCalendar to AlternateView request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarasfile"></a>
# **CalendarAsFile**

```csharp
Stream CalendarAsFile(CalendarAsFileRequest request)
```

Converts calendar model to specified format and returns as file.             

### Return type

**Stream**

### Request Parameters
```csharp
new CalendarAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CalendarAsFileRequest**](CalendarAsFileRequest.md)| Calendar model and format to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarasfile"></a>
# **CalendarAsFileAsync**

```csharp
async Task<Stream> CalendarAsFileAsync(CalendarAsFileRequest request)
```

Converts calendar model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new CalendarAsFileRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CalendarAsFileRequest**](CalendarAsFileRequest.md)| Calendar model and format to convert. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarasmapi"></a>
# **CalendarAsMapi**

```csharp
MapiCalendarDto CalendarAsMapi(CalendarAsMapiRequest request)
```

Converts CalendarDto to MapiCalendarDto.             

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

### Request Parameters
```csharp
new CalendarAsMapiRequest(
    calendarDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calendarDto** | [**CalendarDto**](CalendarDto.md)| iCalendar model calendar representation. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarasmapi"></a>
# **CalendarAsMapiAsync**

```csharp
async Task<MapiCalendarDto> CalendarAsMapiAsync(CalendarAsMapiRequest request)
```

Converts CalendarDto to MapiCalendarDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

### Request Parameters
```csharp
new CalendarAsMapiRequest(
    calendarDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calendarDto** | [**CalendarDto**](CalendarDto.md)| iCalendar model calendar representation. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarconvert"></a>
# **CalendarConvert**

```csharp
Stream CalendarConvert(CalendarConvertRequest request)
```

Converts calendar document to specified format and returns as file.             

### Return type

**Stream**

### Request Parameters
```csharp
new CalendarConvertRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarconvert"></a>
# **CalendarConvertAsync**

```csharp
async Task<Stream> CalendarConvertAsync(CalendarConvertRequest request)
```

Converts calendar document to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new CalendarConvertRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarfromfile"></a>
# **CalendarFromFile**

```csharp
CalendarDto CalendarFromFile(CalendarFromFileRequest request)
```

Converts calendar document to a model representation.             

### Return type

[**CalendarDto**](CalendarDto.md)

### Request Parameters
```csharp
new CalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarfromfile"></a>
# **CalendarFromFileAsync**

```csharp
async Task<CalendarDto> CalendarFromFileAsync(CalendarFromFileRequest request)
```

Converts calendar document to a model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### Request Parameters
```csharp
new CalendarFromFileRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarget"></a>
# **CalendarGet**

```csharp
CalendarDto CalendarGet(CalendarGetRequest request)
```

Get calendar file from storage.             

### Return type

[**CalendarDto**](CalendarDto.md)

### Request Parameters
```csharp
new CalendarGetRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarget"></a>
# **CalendarGetAsync**

```csharp
async Task<CalendarDto> CalendarGetAsync(CalendarGetRequest request)
```

Get calendar file from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### Request Parameters
```csharp
new CalendarGetRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendargetasalternate"></a>
# **CalendarGetAsAlternate**

```csharp
AlternateView CalendarGetAsAlternate(CalendarGetAsAlternateRequest request)
```

Get iCalendar from storage as AlternateView             

### Return type

[**AlternateView**](AlternateView.md)

### Request Parameters
```csharp
new CalendarGetAsAlternateRequest(
    name,
    calendarAction,
    sequenceId=sequenceId,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendargetasalternate"></a>
# **CalendarGetAsAlternateAsync**

```csharp
async Task<AlternateView> CalendarGetAsAlternateAsync(CalendarGetAsAlternateRequest request)
```

Get iCalendar from storage as AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AlternateView**](AlternateView.md)>

### Request Parameters
```csharp
new CalendarGetAsAlternateRequest(
    name,
    calendarAction,
    sequenceId=sequenceId,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendargetasfile"></a>
# **CalendarGetAsFile**

```csharp
Stream CalendarGetAsFile(CalendarGetAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file.             

### Return type

**Stream**

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendargetasfile"></a>
# **CalendarGetAsFileAsync**

```csharp
async Task<Stream> CalendarGetAsFileAsync(CalendarGetAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendargetlist"></a>
# **CalendarGetList**

```csharp
CalendarStorageList CalendarGetList(CalendarGetListRequest request)
```

Get iCalendar list from storage folder.             

### Return type

[**CalendarStorageList**](CalendarStorageList.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendargetlist"></a>
# **CalendarGetListAsync**

```csharp
async Task<CalendarStorageList> CalendarGetListAsync(CalendarGetListRequest request)
```

Get iCalendar list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarStorageList**](CalendarStorageList.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarsave"></a>
# **CalendarSave**

```csharp
void CalendarSave(CalendarSaveRequest request)
```

Save iCalendar             

### Return type

void (empty response body)

### Request Parameters
```csharp
new CalendarSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CalendarSaveRequest**](CalendarSaveRequest.md)| iCalendar create/update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="calendarsave"></a>
# **CalendarSaveAsync**

```csharp
async Task CalendarSaveAsync(CalendarSaveRequest request)
```

Save iCalendar             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CalendarSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CalendarSaveRequest**](CalendarSaveRequest.md)| iCalendar create/update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

