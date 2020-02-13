# Model.EmailAccountRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Email account host              | 
**Port** | **int?** | Email account port              | 
**Login** | **string** | Email account login              | 
**SecurityOptions** | **string** | Security mode for a mail client Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto | 
**ProtocolType** | **string** | Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav | 
**Description** | **string** | Email account description              | [optional] 
**StorageFile** | [**StorageFileLocation**](StorageFileLocation.md) | A storage file location info to store email account              | 



[[Back to Model list]](README.md#documentation-for-models) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to README]](README.md)


