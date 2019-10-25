## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EmailApi* | [**AddCalendarAttachment**](EmailApi.md#addcalendarattachment) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file
*EmailApi* | [**AddContactAttachment**](EmailApi.md#addcontactattachment) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document
*EmailApi* | [**AddEmailAttachment**](EmailApi.md#addemailattachment) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document
*EmailApi* | [**AddMapiAttachment**](EmailApi.md#addmapiattachment) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document
*EmailApi* | [**AppendEmailMessage**](EmailApi.md#appendemailmessage) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account
*EmailApi* | [**AppendMimeMessage**](EmailApi.md#appendmimemessage) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account
*EmailApi* | [**CopyFile**](EmailApi.md#copyfile) | **PUT** /email/storage/file/copy/{srcPath} | Copy file
*EmailApi* | [**CopyFolder**](EmailApi.md#copyfolder) | **PUT** /email/storage/folder/copy/{srcPath} | Copy folder
*EmailApi* | [**CreateCalendar**](EmailApi.md#createcalendar) | **PUT** /email/Calendar/{name} | Create calendar file
*EmailApi* | [**CreateContact**](EmailApi.md#createcontact) | **PUT** /email/Contact/{format}/{name} | Create contact document
*EmailApi* | [**CreateEmail**](EmailApi.md#createemail) | **PUT** /email/{fileName} | Create an email document
*EmailApi* | [**CreateEmailFolder**](EmailApi.md#createemailfolder) | **PUT** /email/client/CreateFolder | Create new folder in email account
*EmailApi* | [**CreateFolder**](EmailApi.md#createfolder) | **PUT** /email/storage/folder/{path} | Create the folder
*EmailApi* | [**CreateMapi**](EmailApi.md#createmapi) | **PUT** /email/Mapi/{name} | Create new document
*EmailApi* | [**DeleteCalendarProperty**](EmailApi.md#deletecalendarproperty) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}
*EmailApi* | [**DeleteContactProperty**](EmailApi.md#deletecontactproperty) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list
*EmailApi* | [**DeleteEmailFolder**](EmailApi.md#deleteemailfolder) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account
*EmailApi* | [**DeleteEmailMessage**](EmailApi.md#deleteemailmessage) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id
*EmailApi* | [**DeleteFile**](EmailApi.md#deletefile) | **DELETE** /email/storage/file/{path} | Delete file
*EmailApi* | [**DeleteFolder**](EmailApi.md#deletefolder) | **DELETE** /email/storage/folder/{path} | Delete folder
*EmailApi* | [**DeleteMapiAttachment**](EmailApi.md#deletemapiattachment) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document
*EmailApi* | [**DeleteMapiProperties**](EmailApi.md#deletemapiproperties) | **DELETE** /email/Mapi/{name}/properties | Delete document properties
*EmailApi* | [**DownloadFile**](EmailApi.md#downloadfile) | **GET** /email/storage/file/{path} | Download file
*EmailApi* | [**FetchEmailMessage**](EmailApi.md#fetchemailmessage) | **GET** /email/client/Fetch | Fetch message mime from email account
*EmailApi* | [**GetCalendar**](EmailApi.md#getcalendar) | **GET** /email/Calendar/{name}/properties | Get calendar file properties
*EmailApi* | [**GetCalendarAttachment**](EmailApi.md#getcalendarattachment) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name
*EmailApi* | [**GetCalendarList**](EmailApi.md#getcalendarlist) | **GET** /email/Calendar | Get iCalendar files list in folder on storage
*EmailApi* | [**GetContactAttachment**](EmailApi.md#getcontactattachment) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name
*EmailApi* | [**GetContactList**](EmailApi.md#getcontactlist) | **GET** /email/Contact/{format} | Get contact list from storage folder
*EmailApi* | [**GetContactProperties**](EmailApi.md#getcontactproperties) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties
*EmailApi* | [**GetDiscUsage**](EmailApi.md#getdiscusage) | **GET** /email/storage/disc | Get disc usage
*EmailApi* | [**GetEmail**](EmailApi.md#getemail) | **GET** /email/{fileName} | Get email document
*EmailApi* | [**GetEmailAttachment**](EmailApi.md#getemailattachment) | **GET** /email/{fileName}/attachments | Get email attachment by name
*EmailApi* | [**GetEmailProperty**](EmailApi.md#getemailproperty) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name
*EmailApi* | [**GetFileVersions**](EmailApi.md#getfileversions) | **GET** /email/storage/version/{path} | Get file versions
*EmailApi* | [**GetFilesList**](EmailApi.md#getfileslist) | **GET** /email/storage/folder/{path} | Get all files and folders within a folder
*EmailApi* | [**GetMapiAttachment**](EmailApi.md#getmapiattachment) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream
*EmailApi* | [**GetMapiAttachments**](EmailApi.md#getmapiattachments) | **GET** /email/Mapi/{name}/attachments | Get document attachment list
*EmailApi* | [**GetMapiList**](EmailApi.md#getmapilist) | **GET** /email/Mapi | Get document list from storage folder
*EmailApi* | [**GetMapiProperties**](EmailApi.md#getmapiproperties) | **GET** /email/Mapi/{name}/properties | Get document properties
*EmailApi* | [**ListEmailFolders**](EmailApi.md#listemailfolders) | **GET** /email/client/ListFolders | Get folders list in email account
*EmailApi* | [**ListEmailMessages**](EmailApi.md#listemailmessages) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query
*EmailApi* | [**MoveFile**](EmailApi.md#movefile) | **PUT** /email/storage/file/move/{srcPath} | Move file
*EmailApi* | [**MoveFolder**](EmailApi.md#movefolder) | **PUT** /email/storage/folder/move/{srcPath} | Move folder
*EmailApi* | [**ObjectExists**](EmailApi.md#objectexists) | **GET** /email/storage/exist/{path} | Check if file or folder exists
*EmailApi* | [**SaveMailAccount**](EmailApi.md#savemailaccount) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication
*EmailApi* | [**SaveMailOAuthAccount**](EmailApi.md#savemailoauthaccount) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth
*EmailApi* | [**SendEmail**](EmailApi.md#sendemail) | **POST** /email/client/Send | Send an email from *.eml file located on storage
*EmailApi* | [**SendEmailMime**](EmailApi.md#sendemailmime) | **POST** /email/client/SendMime | Send an email specified by MIME in request
*EmailApi* | [**SetEmailProperty**](EmailApi.md#setemailproperty) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value
*EmailApi* | [**SetEmailReadFlag**](EmailApi.md#setemailreadflag) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag
*EmailApi* | [**StorageExists**](EmailApi.md#storageexists) | **GET** /email/storage/{storageName}/exist | Check if storage exists
*EmailApi* | [**UpdateCalendarProperties**](EmailApi.md#updatecalendarproperties) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties
*EmailApi* | [**UpdateContactProperties**](EmailApi.md#updatecontactproperties) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties
*EmailApi* | [**UpdateMapiProperties**](EmailApi.md#updatemapiproperties) | **PUT** /email/Mapi/{name}/properties | Update document properties
*EmailApi* | [**UploadFile**](EmailApi.md#uploadfile) | **PUT** /email/storage/file/{path} | Upload file


## Documentation for Models

 - [Model.AccountBaseRequest](AccountBaseRequest.md)
 - [Model.AddAttachmentRequest](AddAttachmentRequest.md)
 - [Model.AsposeResponse](AsposeResponse.md)
 - [Model.BaseObject](BaseObject.md)
 - [Model.ContactFormat](ContactFormat.md)
 - [Model.CreateEmailRequest](CreateEmailRequest.md)
 - [Model.DiscUsage](DiscUsage.md)
 - [Model.EmailAccountRequest](EmailAccountRequest.md)
 - [Model.EmailDocument](EmailDocument.md)
 - [Model.EmailProperties](EmailProperties.md)
 - [Model.EmailProperty](EmailProperty.md)
 - [Model.Error](Error.md)
 - [Model.ErrorDetails](ErrorDetails.md)
 - [Model.FileVersions](FileVersions.md)
 - [Model.FilesList](FilesList.md)
 - [Model.FilesUploadResult](FilesUploadResult.md)
 - [Model.HierarchicalObjectRequest](HierarchicalObjectRequest.md)
 - [Model.HierarchicalObjectResponse](HierarchicalObjectResponse.md)
 - [Model.Link](Link.md)
 - [Model.ListResponseOfHierarchicalObjectResponse](ListResponseOfHierarchicalObjectResponse.md)
 - [Model.ListResponseOfString](ListResponseOfString.md)
 - [Model.MailServerFolder](MailServerFolder.md)
 - [Model.ObjectExist](ObjectExist.md)
 - [Model.SetEmailPropertyRequest](SetEmailPropertyRequest.md)
 - [Model.StorageExist](StorageExist.md)
 - [Model.StorageFile2](StorageFile2.md)
 - [Model.StorageFolder](StorageFolder.md)
 - [Model.AppendEmailAccountBaseRequest](AppendEmailAccountBaseRequest.md)
 - [Model.CreateFolderBaseRequest](CreateFolderBaseRequest.md)
 - [Model.DeleteFolderBaseRequest](DeleteFolderBaseRequest.md)
 - [Model.DeleteMessageBaseRequest](DeleteMessageBaseRequest.md)
 - [Model.EmailDocumentResponse](EmailDocumentResponse.md)
 - [Model.EmailPropertyResponse](EmailPropertyResponse.md)
 - [Model.FaultResponse](FaultResponse.md)
 - [Model.FileVersion](FileVersion.md)
 - [Model.HierarchicalObject](HierarchicalObject.md)
 - [Model.IndexedHierarchicalObject](IndexedHierarchicalObject.md)
 - [Model.IndexedPrimitiveObject](IndexedPrimitiveObject.md)
 - [Model.ListFoldersResponse](ListFoldersResponse.md)
 - [Model.ListMessagesResponse](ListMessagesResponse.md)
 - [Model.MimeResponse](MimeResponse.md)
 - [Model.PrimitiveObject](PrimitiveObject.md)
 - [Model.SaveEmailAccountRequest](SaveEmailAccountRequest.md)
 - [Model.SaveOAuthEmailAccountRequest](SaveOAuthEmailAccountRequest.md)
 - [Model.SendEmailBaseRequest](SendEmailBaseRequest.md)
 - [Model.SendEmailMimeBaseRequest](SendEmailMimeBaseRequest.md)
 - [Model.SetMessageReadFlagAccountBaseRequest](SetMessageReadFlagAccountBaseRequest.md)
 - [Model.StorageFile](StorageFile.md)
 - [Model.ValueResponse](ValueResponse.md)
 - [Model.AppendEmailBaseRequest](AppendEmailBaseRequest.md)
 - [Model.AppendEmailMimeBaseRequest](AppendEmailMimeBaseRequest.md)

