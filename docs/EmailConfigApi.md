# Aspose.Email.Cloud.Sdk.EmailConfigApi

        ﻿<a name="Discover"></a>
# Discover

```csharp
EmailAccountConfigList Discover(EmailConfigDiscoverRequest request)
```

Discover email accounts by email address. Does not validate discovered accounts.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### request Parameter
```csharp
new EmailConfigDiscoverRequest(
    address,
    fastProcessing=fastProcessing)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address. | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              | [optional] [default to false]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverAsync"></a>
# DiscoverAsync

```csharp
async Task<EmailAccountConfigList> DiscoverAsync(EmailConfigDiscoverRequest request)
```

Discover email accounts by email address. Does not validate discovered accounts.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### request Parameter
```csharp
new EmailConfigDiscoverRequest(
    address,
    fastProcessing=fastProcessing)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address. | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              | [optional] [default to false]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="DiscoverOauth"></a>
# DiscoverOauth

```csharp
EmailAccountConfigList DiscoverOauth(DiscoverEmailConfigOauth request)
```

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### request Parameter

See parameter model documentation at [DiscoverEmailConfigOauth](DiscoverEmailConfigOauth.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverOauthAsync"></a>
# DiscoverOauthAsync

```csharp
async Task<EmailAccountConfigList> DiscoverOauthAsync(DiscoverEmailConfigOauth request)
```

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### request Parameter

See parameter model documentation at [DiscoverEmailConfigOauth](DiscoverEmailConfigOauth.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="DiscoverPassword"></a>
# DiscoverPassword

```csharp
EmailAccountConfigList DiscoverPassword(DiscoverEmailConfigPassword request)
```

Discover email accounts by email address. Validates discovered accounts using login and password.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### request Parameter

See parameter model documentation at [DiscoverEmailConfigPassword](DiscoverEmailConfigPassword.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverPasswordAsync"></a>
# DiscoverPasswordAsync

```csharp
async Task<EmailAccountConfigList> DiscoverPasswordAsync(DiscoverEmailConfigPassword request)
```

Discover email accounts by email address. Validates discovered accounts using login and password.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### request Parameter

See parameter model documentation at [DiscoverEmailConfigPassword](DiscoverEmailConfigPassword.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
