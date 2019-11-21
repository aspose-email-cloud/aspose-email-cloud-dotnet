# Aspose.Email.Cloud.Sdk.MapiApi

<a name="addmapiattachment"></a>
# **AddMapiAttachment**

```csharp
void AddMapiAttachment(AddMapiAttachmentRequest request)
```

Add attachment to document

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddMapiAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addmapiattachment"></a>
# **AddMapiAttachmentAsync**

```csharp
async Task AddMapiAttachmentAsync(AddMapiAttachmentRequest request)
```

Add attachment to document

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new AddMapiAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createmapi"></a>
# **CreateMapi**

```csharp
void CreateMapi(CreateMapiRequest request)
```

Create new document

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateMapiRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create document request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createmapi"></a>
# **CreateMapiAsync**

```csharp
async Task CreateMapiAsync(CreateMapiRequest request)
```

Create new document

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateMapiRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create document request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiattachment"></a>
# **DeleteMapiAttachment**

```csharp
void DeleteMapiAttachment(DeleteMapiAttachmentRequest request)
```

Remove attachment from document

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteMapiAttachmentRequest(
    name,
    attachment,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **storage** | [**StorageFolderLocation**](StorageFolderLocation.md)| Document file storage location info | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiattachment"></a>
# **DeleteMapiAttachmentAsync**

```csharp
async Task DeleteMapiAttachmentAsync(DeleteMapiAttachmentRequest request)
```

Remove attachment from document

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteMapiAttachmentRequest(
    name,
    attachment,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **storage** | [**StorageFolderLocation**](StorageFolderLocation.md)| Document file storage location info | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiproperties"></a>
# **DeleteMapiProperties**

```csharp
void DeleteMapiProperties(DeleteMapiPropertiesRequest request)
```

Delete document properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be deleted | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiproperties"></a>
# **DeleteMapiPropertiesAsync**

```csharp
async Task DeleteMapiPropertiesAsync(DeleteMapiPropertiesRequest request)
```

Delete document properties

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be deleted | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachment"></a>
# **GetMapiAttachment**

```csharp
System.IO.Stream GetMapiAttachment(GetMapiAttachmentRequest request)
```

Get document attachment as file stream

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetMapiAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachment"></a>
# **GetMapiAttachmentAsync**

```csharp
async Task<System.IO.Stream> GetMapiAttachmentAsync(GetMapiAttachmentRequest request)
```

Get document attachment as file stream

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<System.IO.Stream>**

### Request Parameters
```csharp
new GetMapiAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachments"></a>
# **GetMapiAttachments**

```csharp
ListResponseOfString GetMapiAttachments(GetMapiAttachmentsRequest request)
```

Get document attachment list

### Return type

[**ListResponseOfString**](ListResponseOfString.md)

### Request Parameters
```csharp
new GetMapiAttachmentsRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachments"></a>
# **GetMapiAttachmentsAsync**

```csharp
async Task<ListResponseOfString> GetMapiAttachmentsAsync(GetMapiAttachmentsRequest request)
```

Get document attachment list

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfString**](ListResponseOfString.md)>

### Request Parameters
```csharp
new GetMapiAttachmentsRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapilist"></a>
# **GetMapiList**

```csharp
ListResponseOfHierarchicalObjectResponse GetMapiList(GetMapiListRequest request)
```

Get document list from storage folder

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetMapiListRequest(
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapilist"></a>
# **GetMapiListAsync**

```csharp
async Task<ListResponseOfHierarchicalObjectResponse> GetMapiListAsync(GetMapiListRequest request)
```

Get document list from storage folder

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetMapiListRequest(
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiproperties"></a>
# **GetMapiProperties**

```csharp
HierarchicalObjectResponse GetMapiProperties(GetMapiPropertiesRequest request)
```

Get document properties

### Return type

[**HierarchicalObjectResponse**](HierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetMapiPropertiesRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiproperties"></a>
# **GetMapiPropertiesAsync**

```csharp
async Task<HierarchicalObjectResponse> GetMapiPropertiesAsync(GetMapiPropertiesRequest request)
```

Get document properties

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**HierarchicalObjectResponse**](HierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetMapiPropertiesRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatemapiproperties"></a>
# **UpdateMapiProperties**

```csharp
void UpdateMapiProperties(UpdateMapiPropertiesRequest request)
```

Update document properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatemapiproperties"></a>
# **UpdateMapiPropertiesAsync**

```csharp
async Task UpdateMapiPropertiesAsync(UpdateMapiPropertiesRequest request)
```

Update document properties

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new UpdateMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

