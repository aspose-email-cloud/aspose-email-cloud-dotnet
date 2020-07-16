# Aspose.Email.Cloud.Sdk.ClientFolderApi

<a name="clientfoldercreate"></a>
# **ClientFolderCreate**

```csharp
void ClientFolderCreate(ClientFolderCreateRequest request)
```

Create new folder in email account             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientFolderCreateRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientFolderCreateRequest**](ClientFolderCreateRequest.md)| Create folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientfoldercreate"></a>
# **ClientFolderCreateAsync**

```csharp
async Task ClientFolderCreateAsync(ClientFolderCreateRequest request)
```

Create new folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientFolderCreateRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientFolderCreateRequest**](ClientFolderCreateRequest.md)| Create folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientfolderdelete"></a>
# **ClientFolderDelete**

```csharp
void ClientFolderDelete(ClientFolderDeleteRequest request)
```

Delete a folder in email account             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientFolderDeleteRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientFolderDeleteRequest**](ClientFolderDeleteRequest.md)| Delete folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientfolderdelete"></a>
# **ClientFolderDeleteAsync**

```csharp
async Task ClientFolderDeleteAsync(ClientFolderDeleteRequest request)
```

Delete a folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientFolderDeleteRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientFolderDeleteRequest**](ClientFolderDeleteRequest.md)| Delete folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientfoldergetlist"></a>
# **ClientFolderGetList**

```csharp
MailServerFolderList ClientFolderGetList(ClientFolderGetListRequest request)
```

Get folders list in email account             

### Return type

[**MailServerFolderList**](MailServerFolderList.md)

### Request Parameters
```csharp
new ClientFolderGetListRequest(
    account,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    parentFolder=parentFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientfoldergetlist"></a>
# **ClientFolderGetListAsync**

```csharp
async Task<MailServerFolderList> ClientFolderGetListAsync(ClientFolderGetListRequest request)
```

Get folders list in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MailServerFolderList**](MailServerFolderList.md)>

### Request Parameters
```csharp
new ClientFolderGetListRequest(
    account,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    parentFolder=parentFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

