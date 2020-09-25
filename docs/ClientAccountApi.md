# Aspose.Email.Cloud.Sdk.ClientAccountApi

<a name="Get"></a>
# Get

Get email client account from storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Client.Account.Get(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage. | 
 **folder** | **string**| Folder on storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**EmailClientAccount**](EmailClientAccount.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

Get email client account from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientAccountGetRequest
{ 
    FileName = "email.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Client.Account.GetAsync(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage. | 
 **folder** | **string**| Folder on storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**EmailClientAccount**](EmailClientAccount.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetMulti"></a>
# GetMulti

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientAccountGetMultiRequest
{ 
    FileName = "email.multi.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Client.Account.GetMulti(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

### Return type

[**EmailClientMultiAccount**](EmailClientMultiAccount.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMultiAsync"></a>
# GetMultiAsync

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientAccountGetMultiRequest
{ 
    FileName = "email.multi.account",
    Folder = "email/account/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Client.Account.GetMultiAsync(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

### Return type

[**EmailClientMultiAccount**](EmailClientMultiAccount.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
# Save

Create/update email client account file (*.account) with credentials             

<details>
    <summary>Method call example:</summary>

```csharp
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
Api.Client.Account.Save(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientAccountSaveRequest](ClientAccountSaveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

Create/update email client account file (*.account) with credentials             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
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
await Api.Client.Account.SaveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientAccountSaveRequest](ClientAccountSaveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SaveMulti"></a>
# SaveMulti

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

<details>
    <summary>Method call example:</summary>

```csharp
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
Api.Client.Account.SaveMulti(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientAccountSaveMultiRequest](ClientAccountSaveMultiRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveMultiAsync"></a>
# SaveMultiAsync

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
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
await Api.Client.Account.SaveMultiAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientAccountSaveMultiRequest](ClientAccountSaveMultiRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
