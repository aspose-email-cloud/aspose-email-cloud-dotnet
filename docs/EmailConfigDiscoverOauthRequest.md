# EmailConfigDiscoverOauthRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | OAuth client id.              | 
**ClientSecret** | **string** | OAuth client secret.              | 
**RefreshToken** | **string** | OAuth refresh token.              | 
**RequestUrl** | **string** | The url to obtain access token. If not specified, will be discovered from email configuration.              | [optional] 

## Parent class

See: [DiscoverEmailConfigRequest](DiscoverEmailConfigRequest.md)

## Example
```csharp
var emailConfigDiscoverOauthRequest = new EmailConfigDiscoverOauthRequest
{
    ClientId = "ClientId",
    ClientSecret = "ClientSecret",
    RefreshToken = "RefreshToken",
    Address = "example@aspose.com",
    FastProcessing = true
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

