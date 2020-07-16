# Aspose.Email.Cloud.Sdk.ClientThreadApi

<a name="clientthreaddelete"></a>
# **ClientThreadDelete**

```csharp
void ClientThreadDelete(ClientThreadDeleteRequest request)
```

Delete thread by id. All messages from thread will also be deleted.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientThreadDeleteRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientThreadDeleteRequest**](ClientThreadDeleteRequest.md)| Delete email thread request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreaddelete"></a>
# **ClientThreadDeleteAsync**

```csharp
async Task ClientThreadDeleteAsync(ClientThreadDeleteRequest request)
```

Delete thread by id. All messages from thread will also be deleted.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientThreadDeleteRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientThreadDeleteRequest**](ClientThreadDeleteRequest.md)| Delete email thread request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadgetlist"></a>
# **ClientThreadGetList**

```csharp
EmailThreadList ClientThreadGetList(ClientThreadGetListRequest request)
```

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

### Return type

[**EmailThreadList**](EmailThreadList.md)

### Request Parameters
```csharp
new ClientThreadGetListRequest(
    folder,
    account,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    updateFolderCache=updateFolderCache,
    messagesCacheLimit=messagesCacheLimit)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account.              | 
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **updateFolderCache** | **bool?**| This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              | [optional] [default to true]
 **messagesCacheLimit** | **int?**| Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              | [optional] [default to 200]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadgetlist"></a>
# **ClientThreadGetListAsync**

```csharp
async Task<EmailThreadList> ClientThreadGetListAsync(ClientThreadGetListRequest request)
```

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailThreadList**](EmailThreadList.md)>

### Request Parameters
```csharp
new ClientThreadGetListRequest(
    folder,
    account,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    updateFolderCache=updateFolderCache,
    messagesCacheLimit=messagesCacheLimit)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account.              | 
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **updateFolderCache** | **bool?**| This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              | [optional] [default to true]
 **messagesCacheLimit** | **int?**| Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              | [optional] [default to 200]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadgetmessages"></a>
# **ClientThreadGetMessages**

```csharp
EmailList ClientThreadGetMessages(ClientThreadGetMessagesRequest request)
```

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

### Return type

[**EmailList**](EmailList.md)

### Request Parameters
```csharp
new ClientThreadGetMessagesRequest(
    threadId,
    account,
    folder=folder,
    storage=storage,
    accountStorageFolder=accountStorageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Specifies account folder to get thread from              | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadgetmessages"></a>
# **ClientThreadGetMessagesAsync**

```csharp
async Task<EmailList> ClientThreadGetMessagesAsync(ClientThreadGetMessagesRequest request)
```

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailList**](EmailList.md)>

### Request Parameters
```csharp
new ClientThreadGetMessagesRequest(
    threadId,
    account,
    folder=folder,
    storage=storage,
    accountStorageFolder=accountStorageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Specifies account folder to get thread from              | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadmove"></a>
# **ClientThreadMove**

```csharp
void ClientThreadMove(ClientThreadMoveRequest request)
```

Move thread to another folder.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientThreadMoveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientThreadMoveRequest**](ClientThreadMoveRequest.md)| Move thread request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadmove"></a>
# **ClientThreadMoveAsync**

```csharp
async Task ClientThreadMoveAsync(ClientThreadMoveRequest request)
```

Move thread to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientThreadMoveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientThreadMoveRequest**](ClientThreadMoveRequest.md)| Move thread request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadsetisread"></a>
# **ClientThreadSetIsRead**

```csharp
void ClientThreadSetIsRead(ClientThreadSetIsReadRequest request)
```

Mark all messages in thread as read or unread.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientThreadSetIsReadRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientThreadSetIsReadRequest**](ClientThreadSetIsReadRequest.md)| Email account specifier and IsRead flag. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientthreadsetisread"></a>
# **ClientThreadSetIsReadAsync**

```csharp
async Task ClientThreadSetIsReadAsync(ClientThreadSetIsReadRequest request)
```

Mark all messages in thread as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientThreadSetIsReadRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClientThreadSetIsReadRequest**](ClientThreadSetIsReadRequest.md)| Email account specifier and IsRead flag. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

