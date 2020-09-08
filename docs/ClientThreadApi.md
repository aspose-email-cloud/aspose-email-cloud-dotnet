# Aspose.Email.Cloud.Sdk.ClientThreadApi

        <a name="Delete"></a>
# Delete

```csharp
void Delete(ClientThreadDeleteRequest request)
```

Delete thread by id. All messages from thread will also be deleted.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientThreadDeleteRequest](ClientThreadDeleteRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
# DeleteAsync

```csharp
async Task DeleteAsync(ClientThreadDeleteRequest request)
```

Delete thread by id. All messages from thread will also be deleted.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientThreadDeleteRequest](ClientThreadDeleteRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetList"></a>
# GetList

```csharp
EmailThreadList GetList(ClientThreadGetListRequest request)
```

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

### Return type

[**EmailThreadList**](EmailThreadList.md)

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

```csharp
async Task<EmailThreadList> GetListAsync(ClientThreadGetListRequest request)
```

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailThreadList**](EmailThreadList.md)>

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetMessages"></a>
# GetMessages

```csharp
EmailList GetMessages(ClientThreadGetMessagesRequest request)
```

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

### Return type

[**EmailList**](EmailList.md)

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMessagesAsync"></a>
# GetMessagesAsync

```csharp
async Task<EmailList> GetMessagesAsync(ClientThreadGetMessagesRequest request)
```

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailList**](EmailList.md)>

### request Parameter
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Move"></a>
# Move

```csharp
void Move(ClientThreadMoveRequest request)
```

Move thread to another folder.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientThreadMoveRequest](ClientThreadMoveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveAsync"></a>
# MoveAsync

```csharp
async Task MoveAsync(ClientThreadMoveRequest request)
```

Move thread to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientThreadMoveRequest](ClientThreadMoveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="SetIsRead"></a>
# SetIsRead

```csharp
void SetIsRead(ClientThreadSetIsReadRequest request)
```

Mark all messages in thread as read or unread.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientThreadSetIsReadRequest](ClientThreadSetIsReadRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
# SetIsReadAsync

```csharp
async Task SetIsReadAsync(ClientThreadSetIsReadRequest request)
```

Mark all messages in thread as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientThreadSetIsReadRequest](ClientThreadSetIsReadRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
