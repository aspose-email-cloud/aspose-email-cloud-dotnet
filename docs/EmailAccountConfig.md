# Model.EmailAccountConfig
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Email account display name              | [optional] 
**ProtocolType** | **string** | Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav | 
**Host** | **string** | Email account host.              | [optional] 
**Port** | **int?** | Port.              | [optional] 
**SocketType** | **string** | Email account security mode Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto | 
**AuthenticationTypes** | **List&lt;string&gt;** | Supported authentication types.              Items: Email account authentication types. Enum, available values: NoAuth, OAuth2, PasswordCleartext, PasswordEncrypted, SmtpAfterPop, ClientIpAddress | [optional] 
**ExtraInfo** | [**List&lt;NameValuePair&gt;**](NameValuePair.md) | Extra account information.              | [optional] 
**IsValidated** | **bool?** | Determines that configuration validated. Set to false if validation skipped.              | 



[[Back to Model list]](Models.doc) [[Back to README]](README.md)


