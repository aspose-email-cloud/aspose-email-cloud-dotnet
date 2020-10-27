# EmailClientAccount
A universal email client account             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Mail server host name or IP address              | 
**Port** | **int?** | Mail server port              | 
**SecurityOptions** | **string** | Email account security mode Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto | 
**ProtocolType** | **string** | Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav | 
**Credentials** | [**EmailClientAccountCredentials**](EmailClientAccountCredentials.md) | Email client account credentials              | 
**CacheFile** | [**StorageFileLocation**](StorageFileLocation.md) | File with messages cache. Used to provide extra functions, which are not supported by account              | [optional] 


## Example
```csharp
var emailClientAccount = new EmailClientAccount
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

[[Back to Model list]](Models.md) [[Back to README]](README.md)

