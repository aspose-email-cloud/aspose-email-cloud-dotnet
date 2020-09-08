# Aspose.Email.Cloud.Sdk.ClientFolderApi

        <a name="Create"></a>
# Create

```csharp
void Create(ClientFolderCreateRequest request)
```

Create new folder in email account             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientFolderCreateRequest](ClientFolderCreateRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateAsync"></a>
# CreateAsync

```csharp
async Task CreateAsync(ClientFolderCreateRequest request)
```

Create new folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientFolderCreateRequest](ClientFolderCreateRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Delete"></a>
# Delete

```csharp
void Delete(ClientFolderDeleteRequest request)
```

Delete a folder in email account             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientFolderDeleteRequest](ClientFolderDeleteRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
# DeleteAsync

```csharp
async Task DeleteAsync(ClientFolderDeleteRequest request)
```

Delete a folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientFolderDeleteRequest](ClientFolderDeleteRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetList"></a>
# GetList

```csharp
MailServerFolderList GetList(ClientFolderGetListRequest request)
```

Get folders list in email account             

### Return type

[**MailServerFolderList**](MailServerFolderList.md)

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

```csharp
async Task<MailServerFolderList> GetListAsync(ClientFolderGetListRequest request)
```

Get folders list in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MailServerFolderList**](MailServerFolderList.md)>

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
