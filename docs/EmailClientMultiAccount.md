# EmailClientMultiAccount
Email client virtual account, which contains several accounts             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReceiveAccounts** | [**List&lt;EmailClientAccount&gt;**](EmailClientAccount.md) | Email client receive accounts              | 
**SendAccount** | [**EmailClientAccount**](EmailClientAccount.md) | Email client send account              | [optional] 


## Example
```csharp
var emailClientMultiAccount = new EmailClientMultiAccount
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

[[Back to Model list]](Models.md) [[Back to README]](README.md)

