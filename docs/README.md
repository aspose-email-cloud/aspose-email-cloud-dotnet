## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CalendarApi* | [**AddCalendarAttachment**](CalendarApi.md#addcalendarattachment) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file
*CalendarApi* | [**CreateCalendar**](CalendarApi.md#createcalendar) | **PUT** /email/Calendar/{name} | Create calendar file
*CalendarApi* | [**DeleteCalendarProperty**](CalendarApi.md#deletecalendarproperty) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}
*CalendarApi* | [**GetCalendar**](CalendarApi.md#getcalendar) | **GET** /email/Calendar/{name}/properties | Get calendar file properties
*CalendarApi* | [**GetCalendarAttachment**](CalendarApi.md#getcalendarattachment) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name
*CalendarApi* | [**GetCalendarList**](CalendarApi.md#getcalendarlist) | **GET** /email/Calendar | Get iCalendar files list in folder on storage
*CalendarApi* | [**UpdateCalendarProperties**](CalendarApi.md#updatecalendarproperties) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties
*ContactApi* | [**AddContactAttachment**](ContactApi.md#addcontactattachment) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document
*ContactApi* | [**CreateContact**](ContactApi.md#createcontact) | **PUT** /email/Contact/{format}/{name} | Create contact document
*ContactApi* | [**DeleteContactProperty**](ContactApi.md#deletecontactproperty) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list
*ContactApi* | [**GetContactAttachment**](ContactApi.md#getcontactattachment) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name
*ContactApi* | [**GetContactList**](ContactApi.md#getcontactlist) | **GET** /email/Contact/{format} | Get contact list from storage folder
*ContactApi* | [**GetContactProperties**](ContactApi.md#getcontactproperties) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties
*ContactApi* | [**UpdateContactProperties**](ContactApi.md#updatecontactproperties) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties
*EmailApi* | [**AddEmailAttachment**](EmailApi.md#addemailattachment) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document
*EmailApi* | [**CreateEmail**](EmailApi.md#createemail) | **PUT** /email/{fileName} | Create an email document
*EmailApi* | [**GetEmail**](EmailApi.md#getemail) | **GET** /email/{fileName} | Get email document
*EmailApi* | [**GetEmailAttachment**](EmailApi.md#getemailattachment) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name
*EmailApi* | [**GetEmailProperty**](EmailApi.md#getemailproperty) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name
*EmailApi* | [**SetEmailProperty**](EmailApi.md#setemailproperty) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value
*EmailClientApi* | [**AppendEmailMessage**](EmailClientApi.md#appendemailmessage) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account
*EmailClientApi* | [**AppendMimeMessage**](EmailClientApi.md#appendmimemessage) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account
*EmailClientApi* | [**CreateEmailFolder**](EmailClientApi.md#createemailfolder) | **PUT** /email/client/CreateFolder | Create new folder in email account
*EmailClientApi* | [**DeleteEmailFolder**](EmailClientApi.md#deleteemailfolder) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account
*EmailClientApi* | [**DeleteEmailMessage**](EmailClientApi.md#deleteemailmessage) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id
*EmailClientApi* | [**FetchEmailMessage**](EmailClientApi.md#fetchemailmessage) | **GET** /email/client/Fetch | Fetch message mime from email account
*EmailClientApi* | [**ListEmailFolders**](EmailClientApi.md#listemailfolders) | **GET** /email/client/ListFolders | Get folders list in email account
*EmailClientApi* | [**ListEmailMessages**](EmailClientApi.md#listemailmessages) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query
*EmailClientApi* | [**SaveMailAccount**](EmailClientApi.md#savemailaccount) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication
*EmailClientApi* | [**SaveMailOAuthAccount**](EmailClientApi.md#savemailoauthaccount) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth
*EmailClientApi* | [**SendEmail**](EmailClientApi.md#sendemail) | **POST** /email/client/Send | Send an email from *.eml file located on storage
*EmailClientApi* | [**SendEmailMime**](EmailClientApi.md#sendemailmime) | **POST** /email/client/SendMime | Send an email specified by MIME in request
*EmailClientApi* | [**SetEmailReadFlag**](EmailClientApi.md#setemailreadflag) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag
*FileApi* | [**CopyFile**](FileApi.md#copyfile) | **PUT** /email/storage/file/copy/{srcPath} | Copy file
*FileApi* | [**DeleteFile**](FileApi.md#deletefile) | **DELETE** /email/storage/file/{path} | Delete file
*FileApi* | [**DownloadFile**](FileApi.md#downloadfile) | **GET** /email/storage/file/{path} | Download file
*FileApi* | [**MoveFile**](FileApi.md#movefile) | **PUT** /email/storage/file/move/{srcPath} | Move file
*FileApi* | [**UploadFile**](FileApi.md#uploadfile) | **PUT** /email/storage/file/{path} | Upload file
*FolderApi* | [**CopyFolder**](FolderApi.md#copyfolder) | **PUT** /email/storage/folder/copy/{srcPath} | Copy folder
*FolderApi* | [**CreateFolder**](FolderApi.md#createfolder) | **PUT** /email/storage/folder/{path} | Create the folder
*FolderApi* | [**DeleteFolder**](FolderApi.md#deletefolder) | **DELETE** /email/storage/folder/{path} | Delete folder
*FolderApi* | [**GetFilesList**](FolderApi.md#getfileslist) | **GET** /email/storage/folder/{path} | Get all files and folders within a folder
*FolderApi* | [**MoveFolder**](FolderApi.md#movefolder) | **PUT** /email/storage/folder/move/{srcPath} | Move folder
*MapiApi* | [**AddMapiAttachment**](MapiApi.md#addmapiattachment) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document
*MapiApi* | [**CreateMapi**](MapiApi.md#createmapi) | **PUT** /email/Mapi/{name} | Create new document
*MapiApi* | [**DeleteMapiAttachment**](MapiApi.md#deletemapiattachment) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document
*MapiApi* | [**DeleteMapiProperties**](MapiApi.md#deletemapiproperties) | **DELETE** /email/Mapi/{name}/properties | Delete document properties
*MapiApi* | [**GetMapiAttachment**](MapiApi.md#getmapiattachment) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream
*MapiApi* | [**GetMapiAttachments**](MapiApi.md#getmapiattachments) | **GET** /email/Mapi/{name}/attachments | Get document attachment list
*MapiApi* | [**GetMapiList**](MapiApi.md#getmapilist) | **GET** /email/Mapi | Get document list from storage folder
*MapiApi* | [**GetMapiProperties**](MapiApi.md#getmapiproperties) | **GET** /email/Mapi/{name}/properties | Get document properties
*MapiApi* | [**UpdateMapiProperties**](MapiApi.md#updatemapiproperties) | **PUT** /email/Mapi/{name}/properties | Update document properties
*StorageApi* | [**GetDiscUsage**](StorageApi.md#getdiscusage) | **GET** /email/storage/disc | Get disc usage
*StorageApi* | [**GetFileVersions**](StorageApi.md#getfileversions) | **GET** /email/storage/version/{path} | Get file versions
*StorageApi* | [**ObjectExists**](StorageApi.md#objectexists) | **GET** /email/storage/exist/{path} | Check if file or folder exists
*StorageApi* | [**StorageExists**](StorageApi.md#storageexists) | **GET** /email/storage/{storageName}/exist | Check if storage exists


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

