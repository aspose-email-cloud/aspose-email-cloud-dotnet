# Aspose.Email.Cloud.Sdk.ClientAccountApi

        <a name="Get"></a>
# Get

```csharp
EmailClientAccount Get(ClientAccountGetRequest request)
```

Get email client account from storage.             

### Return type

[**EmailClientAccount**](EmailClientAccount.md)

### request Parameter
```csharp
new ClientAccountGetRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage. | 
 **folder** | **string**| Folder on storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

```csharp
async Task<EmailClientAccount> GetAsync(ClientAccountGetRequest request)
```

Get email client account from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailClientAccount**](EmailClientAccount.md)>

### request Parameter
```csharp
new ClientAccountGetRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage. | 
 **folder** | **string**| Folder on storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="GetMulti"></a>
# GetMulti

```csharp
EmailClientMultiAccount GetMulti(ClientAccountGetMultiRequest request)
```

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

### Return type

[**EmailClientMultiAccount**](EmailClientMultiAccount.md)

### request Parameter
```csharp
new ClientAccountGetMultiRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMultiAsync"></a>
# GetMultiAsync

```csharp
async Task<EmailClientMultiAccount> GetMultiAsync(ClientAccountGetMultiRequest request)
```

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailClientMultiAccount**](EmailClientMultiAccount.md)>

### request Parameter
```csharp
new ClientAccountGetMultiRequest(
    fileName,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="Save"></a>
# Save

```csharp
void Save(ClientAccountSaveRequest request)
```

Create/update email client account file (*.account) with credentials             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientAccountSaveRequest](ClientAccountSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

```csharp
async Task SaveAsync(ClientAccountSaveRequest request)
```

Create/update email client account file (*.account) with credentials             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientAccountSaveRequest](ClientAccountSaveRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        <a name="SaveMulti"></a>
# SaveMulti

```csharp
void SaveMulti(ClientAccountSaveMultiRequest request)
```

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientAccountSaveMultiRequest](ClientAccountSaveMultiRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveMultiAsync"></a>
# SaveMultiAsync

```csharp
async Task SaveMultiAsync(ClientAccountSaveMultiRequest request)
```

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientAccountSaveMultiRequest](ClientAccountSaveMultiRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
