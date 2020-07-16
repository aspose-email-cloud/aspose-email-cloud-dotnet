# Aspose.Email.Cloud.Sdk.ClientAccountApi

<a name="clientaccountget"></a>
# **ClientAccountGet**

```csharp
EmailClientAccount ClientAccountGet(ClientAccountGetRequest request)
```

Get email client account from storage.             

### Return type

[**EmailClientAccount**](EmailClientAccount.md)

### Request Parameters
```csharp
new ClientAccountGetRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage. | 
 **folder** | **string**| Folder on storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountget"></a>
# **ClientAccountGetAsync**

```csharp
async Task<EmailClientAccount> ClientAccountGetAsync(ClientAccountGetRequest request)
```

Get email client account from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailClientAccount**](EmailClientAccount.md)>

### Request Parameters
```csharp
new ClientAccountGetRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage. | 
 **folder** | **string**| Folder on storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountgetmulti"></a>
# **ClientAccountGetMulti**

```csharp
EmailClientMultiAccount ClientAccountGetMulti(ClientAccountGetMultiRequest request)
```

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

### Return type

[**EmailClientMultiAccount**](EmailClientMultiAccount.md)

### Request Parameters
```csharp
new ClientAccountGetMultiRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountgetmulti"></a>
# **ClientAccountGetMultiAsync**

```csharp
async Task<EmailClientMultiAccount> ClientAccountGetMultiAsync(ClientAccountGetMultiRequest request)
```

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailClientMultiAccount**](EmailClientMultiAccount.md)>

### Request Parameters
```csharp
new ClientAccountGetMultiRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountsave"></a>
# **ClientAccountSave**

```csharp
void ClientAccountSave(ClientAccountSaveRequest request)
```

Create/update email client account file (*.account) with credentials             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientAccountSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailClientAccountSaveRequest**](EmailClientAccountSaveRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountsave"></a>
# **ClientAccountSaveAsync**

```csharp
async Task ClientAccountSaveAsync(ClientAccountSaveRequest request)
```

Create/update email client account file (*.account) with credentials             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientAccountSaveRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailClientAccountSaveRequest**](EmailClientAccountSaveRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountsavemulti"></a>
# **ClientAccountSaveMulti**

```csharp
void ClientAccountSaveMulti(ClientAccountSaveMultiRequest request)
```

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

### Return type

void (empty response body)

### Request Parameters
```csharp
new ClientAccountSaveMultiRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailClientMultiAccountSaveRequest**](EmailClientMultiAccountSaveRequest.md)| Email accounts information. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="clientaccountsavemulti"></a>
# **ClientAccountSaveMultiAsync**

```csharp
async Task ClientAccountSaveMultiAsync(ClientAccountSaveMultiRequest request)
```

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new ClientAccountSaveMultiRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**EmailClientMultiAccountSaveRequest**](EmailClientMultiAccountSaveRequest.md)| Email accounts information. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

