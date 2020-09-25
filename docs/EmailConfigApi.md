# Aspose.Email.Cloud.Sdk.EmailConfigApi

<a name="Discover"></a>
# Discover

Discover email accounts by email address. Does not validate discovered accounts.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConfigDiscoverRequest
{ 
};

// Call method:
var result = Api.EmailConfig.Discover(request);

// Result example:
result = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address. | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              | [optional] [default to false]

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverAsync"></a>
# DiscoverAsync

Discover email accounts by email address. Does not validate discovered accounts.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConfigDiscoverRequest
{ 
};

// Call method:
var result = await Api.EmailConfig.DiscoverAsync(request);

// Result example:
result = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address. | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              | [optional] [default to false]

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DiscoverOauth"></a>
# DiscoverOauth

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConfigDiscoverOauthRequest
{
    ClientId = "ClientId",
    ClientSecret = "ClientSecret",
    RefreshToken = "RefreshToken",
    Address = "example@aspose.com",
    FastProcessing = true
};

// Call method:
var result = Api.EmailConfig.DiscoverOauth(request);

// Result example:
result = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

</details>

### request Parameter
See parameter model documentation at [EmailConfigDiscoverOauthRequest](EmailConfigDiscoverOauthRequest.md)


### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverOauthAsync"></a>
# DiscoverOauthAsync

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConfigDiscoverOauthRequest
{
    ClientId = "ClientId",
    ClientSecret = "ClientSecret",
    RefreshToken = "RefreshToken",
    Address = "example@aspose.com",
    FastProcessing = true
};

// Call method:
var result = await Api.EmailConfig.DiscoverOauthAsync(request);

// Result example:
result = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

</details>

### request Parameter
See parameter model documentation at [EmailConfigDiscoverOauthRequest](EmailConfigDiscoverOauthRequest.md)


### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DiscoverPassword"></a>
# DiscoverPassword

Discover email accounts by email address. Validates discovered accounts using login and password.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConfigDiscoverPasswordRequest
{
    Password = "password",
    Address = "example@aspose.com",
    FastProcessing = true
};

// Call method:
var result = Api.EmailConfig.DiscoverPassword(request);

// Result example:
result = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

</details>

### request Parameter
See parameter model documentation at [EmailConfigDiscoverPasswordRequest](EmailConfigDiscoverPasswordRequest.md)


### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverPasswordAsync"></a>
# DiscoverPasswordAsync

Discover email accounts by email address. Validates discovered accounts using login and password.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConfigDiscoverPasswordRequest
{
    Password = "password",
    Address = "example@aspose.com",
    FastProcessing = true
};

// Call method:
var result = await Api.EmailConfig.DiscoverPasswordAsync(request);

// Result example:
result = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

</details>

### request Parameter
See parameter model documentation at [EmailConfigDiscoverPasswordRequest](EmailConfigDiscoverPasswordRequest.md)


### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
