# EmailConfigApi (EmailCloud.EmailConfig)

Email server configuration discovery.

<a name="Discover"></a>
## Discover
**Descrption:** Discover email accounts by email address. Does not validate discovered accounts.             


**Returns:** Discovered account configurations.

**Method call example:**
```csharp
var result = api.EmailConfig.Discover(request);
```

### Parameter: *request*

**Description:** Discover method request.

**See also** parameter model documentation at [**EmailConfigDiscoverRequest**](EmailConfigDiscoverRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConfigDiscoverRequest
{ 
};
```

</details>

### Result

**Description:** Discovered account configurations.

**Return type:** [**EmailAccountConfigList**](EmailAccountConfigList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new EmailConfigDiscoverRequest
{ 
};

// Call method:
var result = api.EmailConfig.Discover(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverAsync"></a>
## DiscoverAsync

**Description:** Discover email accounts by email address. Does not validate discovered accounts.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Discovered account configurations.

**Method call example:**
```csharp
var result = await api.EmailConfig.DiscoverAsync(request);
```

### Parameter: *request*

**Description:** DiscoverAsync method request.

**See also** parameter model documentation at [**EmailConfigDiscoverRequest**](EmailConfigDiscoverRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConfigDiscoverRequest
{ 
};
```

</details>

### Result

**Returns:** Discovered account configurations.

**Return type:** [**EmailAccountConfigList**](EmailAccountConfigList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new EmailConfigDiscoverRequest
{ 
};

// Call method:
var result = await api.EmailConfig.DiscoverAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DiscoverOauth"></a>
## DiscoverOauth

**Description**: Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             


**Returns:** Discovered account configurations.

**Method call example:**
```csharp
var result = api.EmailConfig.DiscoverOauth(request);
```

### Parameter: *request*

**Description:** Discover email configuration request.

**See also** parameter model documentation at [**EmailConfigDiscoverOauthRequest**](EmailConfigDiscoverOauthRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConfigDiscoverOauthRequest
{
    ClientId = "ClientId",
    ClientSecret = "ClientSecret",
    RefreshToken = "RefreshToken",
    Address = "example@aspose.com",
    FastProcessing = true
};
```

</details>


### Result

**Description:** Discovered account configurations.

**Return type:** [**EmailAccountConfigList**](EmailAccountConfigList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = api.EmailConfig.DiscoverOauth(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverOauthAsync"></a>
## DiscoverOauthAsync

**Description:** Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Discovered account configurations.

**Method call example:**
```csharp
var result = await api.EmailConfig.DiscoverOauthAsync(request);
```

### Parameter: *request*

**Description:** Discover email configuration request.

**See also** parameter model documentation at [**EmailConfigDiscoverOauthRequest**](EmailConfigDiscoverOauthRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConfigDiscoverOauthRequest
{
    ClientId = "ClientId",
    ClientSecret = "ClientSecret",
    RefreshToken = "RefreshToken",
    Address = "example@aspose.com",
    FastProcessing = true
};
```

</details>


### Result

**Description:** Discovered account configurations.

**Return type:** Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = await api.EmailConfig.DiscoverOauthAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DiscoverPassword"></a>
## DiscoverPassword

**Description**: Discover email accounts by email address. Validates discovered accounts using login and password.             


**Returns:** Discovered account configurations.

**Method call example:**
```csharp
var result = api.EmailConfig.DiscoverPassword(request);
```

### Parameter: *request*

**Description:** Discover email configuration request.

**See also** parameter model documentation at [**EmailConfigDiscoverPasswordRequest**](EmailConfigDiscoverPasswordRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConfigDiscoverPasswordRequest
{
    Password = "password",
    Address = "example@aspose.com",
    FastProcessing = true
};
```

</details>


### Result

**Description:** Discovered account configurations.

**Return type:** [**EmailAccountConfigList**](EmailAccountConfigList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new EmailConfigDiscoverPasswordRequest
{
    Password = "password",
    Address = "example@aspose.com",
    FastProcessing = true
};

// Call method:
var result = api.EmailConfig.DiscoverPassword(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DiscoverPasswordAsync"></a>
## DiscoverPasswordAsync

**Description:** Discover email accounts by email address. Validates discovered accounts using login and password.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Discovered account configurations.

**Method call example:**
```csharp
var result = await api.EmailConfig.DiscoverPasswordAsync(request);
```

### Parameter: *request*

**Description:** Discover email configuration request.

**See also** parameter model documentation at [**EmailConfigDiscoverPasswordRequest**](EmailConfigDiscoverPasswordRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConfigDiscoverPasswordRequest
{
    Password = "password",
    Address = "example@aspose.com",
    FastProcessing = true
};
```

</details>


### Result

**Description:** Discovered account configurations.

**Return type:** Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new EmailConfigDiscoverPasswordRequest
{
    Password = "password",
    Address = "example@aspose.com",
    FastProcessing = true
};

// Call method:
var result = await api.EmailConfig.DiscoverPasswordAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
