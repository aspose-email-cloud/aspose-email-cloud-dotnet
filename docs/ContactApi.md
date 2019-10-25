# Aspose.Email.Cloud.Sdk.ContactApi

<a name="addcontactattachment"></a>
# **AddContactAttachment**

```csharp
void AddContactAttachment(AddContactAttachmentRequest request)
```

Add attachment to contact document

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddContactAttachmentRequest(
    format,
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcontact"></a>
# **CreateContact**

```csharp
void CreateContact(CreateContactRequest request)
```

Create contact document

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateContactRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create contact request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecontactproperty"></a>
# **DeleteContactProperty**

```csharp
void DeleteContactProperty(DeleteContactPropertyRequest request)
```

Delete property from indexed property list

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteContactPropertyRequest(
    format,
    name,
    memberName,
    index,
    folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **memberName** | **string**| Indexed property name | 
 **index** | **int?**| Property index | 
 **folder** | [**StorageFolder**](StorageFolder.md)| Calendar document location in storage information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactattachment"></a>
# **GetContactAttachment**

```csharp
System.IO.Stream GetContactAttachment(GetContactAttachmentRequest request)
```

Get attachment file by name

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetContactAttachmentRequest(
    format,
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactlist"></a>
# **GetContactList**

```csharp
ListResponseOfHierarchicalObjectResponse GetContactList(GetContactListRequest request)
```

Get contact list from storage folder

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetContactListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactproperties"></a>
# **GetContactProperties**

```csharp
HierarchicalObject GetContactProperties(GetContactPropertiesRequest request)
```

Get contact document properties

### Return type

[**HierarchicalObject**](HierarchicalObject.md)

### Request Parameters
```csharp
new GetContactPropertiesRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecontactproperties"></a>
# **UpdateContactProperties**

```csharp
void UpdateContactProperties(UpdateContactPropertiesRequest request)
```

Update contact document properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateContactPropertiesRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

