# Aspose.Email.Cloud.Sdk.CalendarApi

<a name="addcalendarattachment"></a>
# **AddCalendarAttachment**

```csharp
void AddCalendarAttachment(AddCalendarAttachmentRequest request)
```

Adds an attachment to iCalendar file

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddCalendarAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **attachment** | **string**| Attachment file name in storage | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage name and folder path for calendar and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addcalendarattachment"></a>
# **AddCalendarAttachmentAsync**

```csharp
async Task AddCalendarAttachmentAsync(AddCalendarAttachmentRequest request)
```

Adds an attachment to iCalendar file

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new AddCalendarAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **attachment** | **string**| Attachment file name in storage | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage name and folder path for calendar and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcalendar"></a>
# **CreateCalendar**

```csharp
void CreateCalendar(CreateCalendarRequest request)
```

Create calendar file

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateCalendarRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcalendar"></a>
# **CreateCalendarAsync**

```csharp
async Task CreateCalendarAsync(CreateCalendarRequest request)
```

Create calendar file

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateCalendarRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecalendarproperty"></a>
# **DeleteCalendarProperty**

```csharp
void DeleteCalendarProperty(DeleteCalendarPropertyRequest request)
```

Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteCalendarPropertyRequest(
    name,
    memberName,
    index,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **memberName** | **string**| Indexed property name | 
 **index** | **string**| Property index path | 
 **request** | [**StorageFolderLocation**](StorageFolderLocation.md)| Storage detail to specify iCalendar file location | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecalendarproperty"></a>
# **DeleteCalendarPropertyAsync**

```csharp
async Task DeleteCalendarPropertyAsync(DeleteCalendarPropertyRequest request)
```

Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteCalendarPropertyRequest(
    name,
    memberName,
    index,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **memberName** | **string**| Indexed property name | 
 **index** | **string**| Property index path | 
 **request** | [**StorageFolderLocation**](StorageFolderLocation.md)| Storage detail to specify iCalendar file location | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendar"></a>
# **GetCalendar**

```csharp
HierarchicalObject GetCalendar(GetCalendarRequest request)
```

Get calendar file properties

### Return type

[**HierarchicalObject**](HierarchicalObject.md)

### Request Parameters
```csharp
new GetCalendarRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendar"></a>
# **GetCalendarAsync**

```csharp
async Task<HierarchicalObject> GetCalendarAsync(GetCalendarRequest request)
```

Get calendar file properties

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**HierarchicalObject**](HierarchicalObject.md)>

### Request Parameters
```csharp
new GetCalendarRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarattachment"></a>
# **GetCalendarAttachment**

```csharp
System.IO.Stream GetCalendarAttachment(GetCalendarAttachmentRequest request)
```

Get iCalendar document attachment by name

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetCalendarAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarattachment"></a>
# **GetCalendarAttachmentAsync**

```csharp
async Task<System.IO.Stream> GetCalendarAttachmentAsync(GetCalendarAttachmentRequest request)
```

Get iCalendar document attachment by name

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<System.IO.Stream>**

### Request Parameters
```csharp
new GetCalendarAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarlist"></a>
# **GetCalendarList**

```csharp
ListResponseOfHierarchicalObjectResponse GetCalendarList(GetCalendarListRequest request)
```

Get iCalendar files list in folder on storage

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetCalendarListRequest(
    folder,
    itemsPerPage,
    pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | 
 **pageNumber** | **int?**| Page number | 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarlist"></a>
# **GetCalendarListAsync**

```csharp
async Task<ListResponseOfHierarchicalObjectResponse> GetCalendarListAsync(GetCalendarListRequest request)
```

Get iCalendar files list in folder on storage

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetCalendarListRequest(
    folder,
    itemsPerPage,
    pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | 
 **pageNumber** | **int?**| Page number | 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecalendarproperties"></a>
# **UpdateCalendarProperties**

```csharp
void UpdateCalendarProperties(UpdateCalendarPropertiesRequest request)
```

Update calendar file properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateCalendarPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecalendarproperties"></a>
# **UpdateCalendarPropertiesAsync**

```csharp
async Task UpdateCalendarPropertiesAsync(UpdateCalendarPropertiesRequest request)
```

Update calendar file properties

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new UpdateCalendarPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

