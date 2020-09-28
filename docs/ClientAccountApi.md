# ClientAccountApi (EmailCloud.Client.Account)

Email server account for built-in client operations.

<a name="Get"></a>
## Get

Get email client account from storage.             

Returns: Email client account from storage.

Method call example:
```csharp
var result = api.Client.Account.Get(request);
```

### request Parameter

Get method request.

See parameter model documentation at [ClientAccountGetRequest](ClientAccountGetRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Email client account from storage.

*Return type:* [**EmailClientAccount**](EmailClientAccount.md)

<details>
    <summary>Result example</summary>

```csharp
result = new EmailClientAccount
{
    Host = "smtp.example.com",
    Port = 465,
    SecurityOptions = "SSLAuto",
    ProtocolType = "SMTP",
    Credentials = new EmailClientAccountOauthCredentials
    {
        ClientId = "clientId",
        ClientSecret = "clientSecret",
        RefreshToken = "refreshToken",
        Login = "example@example.com"
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
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = api.Client.Account.Get(request);

// Result example:
result = new EmailClientAccount
{
    Host = "smtp.example.com",
    Port = 465,
    SecurityOptions = "SSLAuto",
    ProtocolType = "SMTP",
    Credentials = new EmailClientAccountOauthCredentials
    {
        ClientId = "clientId",
        ClientSecret = "clientSecret",
        RefreshToken = "refreshToken",
        Login = "example@example.com"
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
## GetAsync

Get email client account from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Email client account from storage.

Method call example:
```csharp
var result = await api.Client.Account.GetAsync(request);
```

### request Parameter

GetAsync method request.

See parameter model documentation at [ClientAccountGetRequest](ClientAccountGetRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Email client account from storage.

*Return type:* [**EmailClientAccount**](EmailClientAccount.md)

<details>
    <summary>Result example</summary>

```csharp
result = new EmailClientAccount
{
    Host = "smtp.example.com",
    Port = 465,
    SecurityOptions = "SSLAuto",
    ProtocolType = "SMTP",
    Credentials = new EmailClientAccountOauthCredentials
    {
        ClientId = "clientId",
        ClientSecret = "clientSecret",
        RefreshToken = "refreshToken",
        Login = "example@example.com"
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
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await api.Client.Account.GetAsync(request);

// Result example:
result = new EmailClientAccount
{
    Host = "smtp.example.com",
    Port = 465,
    SecurityOptions = "SSLAuto",
    ProtocolType = "SMTP",
    Credentials = new EmailClientAccountOauthCredentials
    {
        ClientId = "clientId",
        ClientSecret = "clientSecret",
        RefreshToken = "refreshToken",
        Login = "example@example.com"
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetMulti"></a>
## GetMulti

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Returns: Email client multi account from storage

Method call example:
```csharp
var result = api.Client.Account.GetMulti(request);
```

### request Parameter

GetMulti method request.

See parameter model documentation at [ClientAccountGetMultiRequest](ClientAccountGetMultiRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountGetMultiRequest
{ 
    FileName = "email.multi.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Email client multi account from storage

*Return type:* [**EmailClientMultiAccount**](EmailClientMultiAccount.md)

<details>
    <summary>Result example</summary>

```csharp
result = new EmailClientMultiAccount
{
    ReceiveAccounts = new List<EmailClientAccount>
    {
        new EmailClientAccount
        {
            Host = "imap.gmail.com",
            Port = 993,
            SecurityOptions = "SSLAuto",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        },
        new EmailClientAccount
        {
            Host = "exchange@outlook.com",
            Port = 443,
            ProtocolType = "EWS",
            Credentials = new EmailClientAccountOauthCredentials
            {
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                RefreshToken = "refreshToken",
                Login = "example@outlook.com"
            }
        }
    },
    SendAccount = new EmailClientAccount
    {
        Host = "smtp.gmail.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountPasswordCredentials
        {
            Password = "password",
            Login = "example@gmail.com"
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
var request = new ClientAccountGetMultiRequest
{ 
    FileName = "email.multi.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = api.Client.Account.GetMulti(request);

// Result example:
result = new EmailClientMultiAccount
{
    ReceiveAccounts = new List<EmailClientAccount>
    {
        new EmailClientAccount
        {
            Host = "imap.gmail.com",
            Port = 993,
            SecurityOptions = "SSLAuto",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        },
        new EmailClientAccount
        {
            Host = "exchange@outlook.com",
            Port = 443,
            ProtocolType = "EWS",
            Credentials = new EmailClientAccountOauthCredentials
            {
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                RefreshToken = "refreshToken",
                Login = "example@outlook.com"
            }
        }
    },
    SendAccount = new EmailClientAccount
    {
        Host = "smtp.gmail.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountPasswordCredentials
        {
            Password = "password",
            Login = "example@gmail.com"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMultiAsync"></a>
## GetMultiAsync

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Email client multi account from storage

Method call example:
```csharp
var result = await api.Client.Account.GetMultiAsync(request);
```

### request Parameter

GetMultiAsync method request.

See parameter model documentation at [ClientAccountGetMultiRequest](ClientAccountGetMultiRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountGetMultiRequest
{ 
    FileName = "email.multi.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Email client multi account from storage

*Return type:* [**EmailClientMultiAccount**](EmailClientMultiAccount.md)

<details>
    <summary>Result example</summary>

```csharp
result = new EmailClientMultiAccount
{
    ReceiveAccounts = new List<EmailClientAccount>
    {
        new EmailClientAccount
        {
            Host = "imap.gmail.com",
            Port = 993,
            SecurityOptions = "SSLAuto",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        },
        new EmailClientAccount
        {
            Host = "exchange@outlook.com",
            Port = 443,
            ProtocolType = "EWS",
            Credentials = new EmailClientAccountOauthCredentials
            {
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                RefreshToken = "refreshToken",
                Login = "example@outlook.com"
            }
        }
    },
    SendAccount = new EmailClientAccount
    {
        Host = "smtp.gmail.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountPasswordCredentials
        {
            Password = "password",
            Login = "example@gmail.com"
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
var request = new ClientAccountGetMultiRequest
{ 
    FileName = "email.multi.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await api.Client.Account.GetMultiAsync(request);

// Result example:
result = new EmailClientMultiAccount
{
    ReceiveAccounts = new List<EmailClientAccount>
    {
        new EmailClientAccount
        {
            Host = "imap.gmail.com",
            Port = 993,
            SecurityOptions = "SSLAuto",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        },
        new EmailClientAccount
        {
            Host = "exchange@outlook.com",
            Port = 443,
            ProtocolType = "EWS",
            Credentials = new EmailClientAccountOauthCredentials
            {
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                RefreshToken = "refreshToken",
                Login = "example@outlook.com"
            }
        }
    },
    SendAccount = new EmailClientAccount
    {
        Host = "smtp.gmail.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountPasswordCredentials
        {
            Password = "password",
            Login = "example@gmail.com"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
## Save

Create/update email client account file (*.account) with credentials             

Returns: Returns 200 if save is successful.

Method call example:
```csharp
api.Client.Account.Save(request);
```

### request Parameter

Email account information

See parameter model documentation at [ClientAccountSaveRequest](ClientAccountSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientAccount
    {
        Host = "smtp.example.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountOauthCredentials
        {
            ClientId = "clientId",
            ClientSecret = "clientSecret",
            RefreshToken = "refreshToken",
            Login = "example@example.com"
        }
    }
};
```

</details>


### Result

*Returns:* Returns 200 if save is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientAccountSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientAccount
    {
        Host = "smtp.example.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountOauthCredentials
        {
            ClientId = "clientId",
            ClientSecret = "clientSecret",
            RefreshToken = "refreshToken",
            Login = "example@example.com"
        }
    }
};

// Call method:
api.Client.Account.Save(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
## SaveAsync

Create/update email client account file (*.account) with credentials             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if save is successful.

Method call example:
```csharp
await api.Client.Account.SaveAsync(request);
```

### request Parameter

Email account information

See parameter model documentation at [ClientAccountSaveRequest](ClientAccountSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientAccount
    {
        Host = "smtp.example.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountOauthCredentials
        {
            ClientId = "clientId",
            ClientSecret = "clientSecret",
            RefreshToken = "refreshToken",
            Login = "example@example.com"
        }
    }
};
```

</details>


### Result

*Returns:* Returns 200 if save is successful.

*Return type:* Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientAccountSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientAccount
    {
        Host = "smtp.example.com",
        Port = 465,
        SecurityOptions = "SSLAuto",
        ProtocolType = "SMTP",
        Credentials = new EmailClientAccountOauthCredentials
        {
            ClientId = "clientId",
            ClientSecret = "clientSecret",
            RefreshToken = "refreshToken",
            Login = "example@example.com"
        }
    }
};

// Call method:
await api.Client.Account.SaveAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SaveMulti"></a>
## SaveMulti

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Returns: Returns 200 if save is successful.

Method call example:
```csharp
api.Client.Account.SaveMulti(request);
```

### request Parameter

Email accounts information.

See parameter model documentation at [ClientAccountSaveMultiRequest](ClientAccountSaveMultiRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountSaveMultiRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.multi.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientMultiAccount
    {
        ReceiveAccounts = new List<EmailClientAccount>
        {
            new EmailClientAccount
            {
                Host = "imap.gmail.com",
                Port = 993,
                SecurityOptions = "SSLAuto",
                Credentials = new EmailClientAccountPasswordCredentials
                {
                    Password = "password",
                    Login = "example@gmail.com"
                }
            },
            new EmailClientAccount
            {
                Host = "exchange@outlook.com",
                Port = 443,
                ProtocolType = "EWS",
                Credentials = new EmailClientAccountOauthCredentials
                {
                    ClientId = "clientId",
                    ClientSecret = "clientSecret",
                    RefreshToken = "refreshToken",
                    Login = "example@outlook.com"
                }
            }
        },
        SendAccount = new EmailClientAccount
        {
            Host = "smtp.gmail.com",
            Port = 465,
            SecurityOptions = "SSLAuto",
            ProtocolType = "SMTP",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        }
    }
};
```

</details>


### Result

*Returns:* Returns 200 if save is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientAccountSaveMultiRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.multi.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientMultiAccount
    {
        ReceiveAccounts = new List<EmailClientAccount>
        {
            new EmailClientAccount
            {
                Host = "imap.gmail.com",
                Port = 993,
                SecurityOptions = "SSLAuto",
                Credentials = new EmailClientAccountPasswordCredentials
                {
                    Password = "password",
                    Login = "example@gmail.com"
                }
            },
            new EmailClientAccount
            {
                Host = "exchange@outlook.com",
                Port = 443,
                ProtocolType = "EWS",
                Credentials = new EmailClientAccountOauthCredentials
                {
                    ClientId = "clientId",
                    ClientSecret = "clientSecret",
                    RefreshToken = "refreshToken",
                    Login = "example@outlook.com"
                }
            }
        },
        SendAccount = new EmailClientAccount
        {
            Host = "smtp.gmail.com",
            Port = 465,
            SecurityOptions = "SSLAuto",
            ProtocolType = "SMTP",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        }
    }
};

// Call method:
api.Client.Account.SaveMulti(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveMultiAsync"></a>
## SaveMultiAsync

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if save is successful.

Method call example:
```csharp
await api.Client.Account.SaveMultiAsync(request);
```

### request Parameter

Email accounts information.

See parameter model documentation at [ClientAccountSaveMultiRequest](ClientAccountSaveMultiRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientAccountSaveMultiRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.multi.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientMultiAccount
    {
        ReceiveAccounts = new List<EmailClientAccount>
        {
            new EmailClientAccount
            {
                Host = "imap.gmail.com",
                Port = 993,
                SecurityOptions = "SSLAuto",
                Credentials = new EmailClientAccountPasswordCredentials
                {
                    Password = "password",
                    Login = "example@gmail.com"
                }
            },
            new EmailClientAccount
            {
                Host = "exchange@outlook.com",
                Port = 443,
                ProtocolType = "EWS",
                Credentials = new EmailClientAccountOauthCredentials
                {
                    ClientId = "clientId",
                    ClientSecret = "clientSecret",
                    RefreshToken = "refreshToken",
                    Login = "example@outlook.com"
                }
            }
        },
        SendAccount = new EmailClientAccount
        {
            Host = "smtp.gmail.com",
            Port = 465,
            SecurityOptions = "SSLAuto",
            ProtocolType = "SMTP",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        }
    }
};
```

</details>


### Result

*Returns:* Returns 200 if save is successful.

*Return type:* Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientAccountSaveMultiRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "email.multi.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailClientMultiAccount
    {
        ReceiveAccounts = new List<EmailClientAccount>
        {
            new EmailClientAccount
            {
                Host = "imap.gmail.com",
                Port = 993,
                SecurityOptions = "SSLAuto",
                Credentials = new EmailClientAccountPasswordCredentials
                {
                    Password = "password",
                    Login = "example@gmail.com"
                }
            },
            new EmailClientAccount
            {
                Host = "exchange@outlook.com",
                Port = 443,
                ProtocolType = "EWS",
                Credentials = new EmailClientAccountOauthCredentials
                {
                    ClientId = "clientId",
                    ClientSecret = "clientSecret",
                    RefreshToken = "refreshToken",
                    Login = "example@outlook.com"
                }
            }
        },
        SendAccount = new EmailClientAccount
        {
            Host = "smtp.gmail.com",
            Port = 465,
            SecurityOptions = "SSLAuto",
            ProtocolType = "SMTP",
            Credentials = new EmailClientAccountPasswordCredentials
            {
                Password = "password",
                Login = "example@gmail.com"
            }
        }
    }
};

// Call method:
await api.Client.Account.SaveMultiAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
