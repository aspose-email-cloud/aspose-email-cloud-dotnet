# ClientAccountSaveRequest
Email client account save request             

## Properties
Class has no properties

## Parent class

See: [StorageModelOfEmailClientAccount](StorageModelOfEmailClientAccount.md)

## Example
```csharp
var clientAccountSaveRequest = new ClientAccountSaveRequest
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
        },
        CacheFile = new StorageFileLocation
        {
            FileName = "account.cache",
            Storage = "First Storage",
            FolderPath = "file/location/folder/on/storage"
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

