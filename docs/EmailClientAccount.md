# Model.EmailClientAccount
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Mail server host name or IP address              | 
**Port** | **int?** | Mail server port              | 
**SecurityOptions** | **string** | Email account security mode Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto | 
**ProtocolType** | **string** | Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav | 
**Credentials** | [**EmailClientAccountCredentials**](EmailClientAccountCredentials.md) | Email client account credentials              | 
**CacheFile** | [**StorageFileLocation**](StorageFileLocation.md) | File with messages cache. Used to provide extra functions, which are not supported by account              | [optional] 



[[Back to Model list]](Models.doc) [[Back to README]](README.md)


