# Aspose.Email.Cloud.Sdk.EmailConfigApi

<a name="emailconfigdiscover"></a>
# **EmailConfigDiscover**

```csharp
EmailAccountConfigList EmailConfigDiscover(EmailConfigDiscoverRequest request)
```

Discover email accounts by email address. Does not validate discovered accounts.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### Request Parameters
```csharp
new EmailConfigDiscoverRequest(
    address,
    fastProcessing=fastProcessing)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address. | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconfigdiscover"></a>
# **EmailConfigDiscoverAsync**

```csharp
async Task<EmailAccountConfigList> EmailConfigDiscoverAsync(EmailConfigDiscoverRequest request)
```

Discover email accounts by email address. Does not validate discovered accounts.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### Request Parameters
```csharp
new EmailConfigDiscoverRequest(
    address,
    fastProcessing=fastProcessing)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address. | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconfigdiscoveroauth"></a>
# **EmailConfigDiscoverOauth**

```csharp
EmailAccountConfigList EmailConfigDiscoverOauth(EmailConfigDiscoverOauthRequest request)
```

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### Request Parameters
```csharp
new EmailConfigDiscoverOauthRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DiscoverEmailConfigOauth**](DiscoverEmailConfigOauth.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconfigdiscoveroauth"></a>
# **EmailConfigDiscoverOauthAsync**

```csharp
async Task<EmailAccountConfigList> EmailConfigDiscoverOauthAsync(EmailConfigDiscoverOauthRequest request)
```

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### Request Parameters
```csharp
new EmailConfigDiscoverOauthRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DiscoverEmailConfigOauth**](DiscoverEmailConfigOauth.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconfigdiscoverpassword"></a>
# **EmailConfigDiscoverPassword**

```csharp
EmailAccountConfigList EmailConfigDiscoverPassword(EmailConfigDiscoverPasswordRequest request)
```

Discover email accounts by email address. Validates discovered accounts using login and password.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### Request Parameters
```csharp
new EmailConfigDiscoverPasswordRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DiscoverEmailConfigPassword**](DiscoverEmailConfigPassword.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="emailconfigdiscoverpassword"></a>
# **EmailConfigDiscoverPasswordAsync**

```csharp
async Task<EmailAccountConfigList> EmailConfigDiscoverPasswordAsync(EmailConfigDiscoverPasswordRequest request)
```

Discover email accounts by email address. Validates discovered accounts using login and password.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### Request Parameters
```csharp
new EmailConfigDiscoverPasswordRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DiscoverEmailConfigPassword**](DiscoverEmailConfigPassword.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

