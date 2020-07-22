# Aspose.Email.Cloud.Sdk.MapiContactApi

        ﻿<a name="AsContactDto"></a>
# AsContactDto

```csharp
ContactDto AsContactDto(MapiContactDto mapiContactDto)
```

Converts MAPI contact model to ContactDto model.             

### Return type

[**ContactDto**](ContactDto.md)

### mapiContactDto Parameter

See parameter model documentation at [MapiContactDto](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsContactDtoAsync"></a>
# AsContactDtoAsync

```csharp
async Task<ContactDto> AsContactDtoAsync(MapiContactDto mapiContactDto)
```

Converts MAPI contact model to ContactDto model.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### mapiContactDto Parameter

See parameter model documentation at [MapiContactDto](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="AsFile"></a>
# AsFile

```csharp
Stream AsFile(MapiContactAsFileRequest request)
```

Converts MAPI contact model to specified format and returns as file.             

### Return type

**Stream**

### request Parameter

See parameter model documentation at [MapiContactAsFileRequest](MapiContactAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

```csharp
async Task<Stream> AsFileAsync(MapiContactAsFileRequest request)
```

Converts MAPI contact model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter

See parameter model documentation at [MapiContactAsFileRequest](MapiContactAsFileRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="FromFile"></a>
# FromFile

```csharp
MapiContactDto FromFile(MapiContactFromFileRequest request)
```

Converts contact file to a MAPI model representation.             

### Return type

[**MapiContactDto**](MapiContactDto.md)

### request Parameter
```csharp
new MapiContactFromFileRequest(
    fileFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

```csharp
async Task<MapiContactDto> FromFileAsync(MapiContactFromFileRequest request)
```

Converts contact file to a MAPI model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

### request Parameter
```csharp
new MapiContactFromFileRequest(
    fileFormat,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Get"></a>
# Get

```csharp
MapiContactDto Get(MapiContactGetRequest request)
```

Get MAPI contact document.             

### Return type

[**MapiContactDto**](MapiContactDto.md)

### request Parameter
```csharp
new MapiContactGetRequest(
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<MapiContactDto> GetAsync(MapiContactGetRequest request)
```

Get MAPI contact document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

### request Parameter
```csharp
new MapiContactGetRequest(
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Save"></a>
# Save

```csharp
void Save(MapiContactSaveRequest request)
```

Save MAPI Contact to storage.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [MapiContactSaveRequest](MapiContactSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(MapiContactSaveRequest request)
```

Save MAPI Contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [MapiContactSaveRequest](MapiContactSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
