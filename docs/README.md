## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CalendarApi* | [**AddCalendarAttachment**](CalendarApi.md#addcalendarattachment) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file
*CalendarApi* | [**AddCalendarAttachmentAsync**](CalendarApi.md#addcalendarattachmentasync) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file. Not available on .NETFramework v2.0
*CalendarApi* | [**CreateCalendar**](CalendarApi.md#createcalendar) | **PUT** /email/Calendar/{name} | Create calendar file
*CalendarApi* | [**CreateCalendarAsync**](CalendarApi.md#createcalendarasync) | **PUT** /email/Calendar/{name} | Create calendar file. Not available on .NETFramework v2.0
*CalendarApi* | [**DeleteCalendarProperty**](CalendarApi.md#deletecalendarproperty) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}
*CalendarApi* | [**DeleteCalendarPropertyAsync**](CalendarApi.md#deletecalendarpropertyasync) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}. Not available on .NETFramework v2.0
*CalendarApi* | [**GetCalendar**](CalendarApi.md#getcalendar) | **GET** /email/Calendar/{name}/properties | Get calendar file properties
*CalendarApi* | [**GetCalendarAsync**](CalendarApi.md#getcalendarasync) | **GET** /email/Calendar/{name}/properties | Get calendar file properties. Not available on .NETFramework v2.0
*CalendarApi* | [**GetCalendarAttachment**](CalendarApi.md#getcalendarattachment) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name
*CalendarApi* | [**GetCalendarAttachmentAsync**](CalendarApi.md#getcalendarattachmentasync) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name. Not available on .NETFramework v2.0
*CalendarApi* | [**GetCalendarList**](CalendarApi.md#getcalendarlist) | **GET** /email/Calendar | Get iCalendar files list in folder on storage
*CalendarApi* | [**GetCalendarListAsync**](CalendarApi.md#getcalendarlistasync) | **GET** /email/Calendar | Get iCalendar files list in folder on storage. Not available on .NETFramework v2.0
*CalendarApi* | [**UpdateCalendarProperties**](CalendarApi.md#updatecalendarproperties) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties
*CalendarApi* | [**UpdateCalendarPropertiesAsync**](CalendarApi.md#updatecalendarpropertiesasync) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties. Not available on .NETFramework v2.0
*ContactApi* | [**AddContactAttachment**](ContactApi.md#addcontactattachment) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document
*ContactApi* | [**AddContactAttachmentAsync**](ContactApi.md#addcontactattachmentasync) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document. Not available on .NETFramework v2.0
*ContactApi* | [**CreateContact**](ContactApi.md#createcontact) | **PUT** /email/Contact/{format}/{name} | Create contact document
*ContactApi* | [**CreateContactAsync**](ContactApi.md#createcontactasync) | **PUT** /email/Contact/{format}/{name} | Create contact document. Not available on .NETFramework v2.0
*ContactApi* | [**DeleteContactProperty**](ContactApi.md#deletecontactproperty) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list
*ContactApi* | [**DeleteContactPropertyAsync**](ContactApi.md#deletecontactpropertyasync) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list. Not available on .NETFramework v2.0
*ContactApi* | [**GetContactAttachment**](ContactApi.md#getcontactattachment) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name
*ContactApi* | [**GetContactAttachmentAsync**](ContactApi.md#getcontactattachmentasync) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name. Not available on .NETFramework v2.0
*ContactApi* | [**GetContactList**](ContactApi.md#getcontactlist) | **GET** /email/Contact/{format} | Get contact list from storage folder
*ContactApi* | [**GetContactListAsync**](ContactApi.md#getcontactlistasync) | **GET** /email/Contact/{format} | Get contact list from storage folder. Not available on .NETFramework v2.0
*ContactApi* | [**GetContactProperties**](ContactApi.md#getcontactproperties) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties
*ContactApi* | [**GetContactPropertiesAsync**](ContactApi.md#getcontactpropertiesasync) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties. Not available on .NETFramework v2.0
*ContactApi* | [**UpdateContactProperties**](ContactApi.md#updatecontactproperties) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties
*ContactApi* | [**UpdateContactPropertiesAsync**](ContactApi.md#updatecontactpropertiesasync) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties. Not available on .NETFramework v2.0
*EmailApi* | [**AddEmailAttachment**](EmailApi.md#addemailattachment) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document
*EmailApi* | [**AddEmailAttachmentAsync**](EmailApi.md#addemailattachmentasync) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document. Not available on .NETFramework v2.0
*EmailApi* | [**CreateEmail**](EmailApi.md#createemail) | **PUT** /email/{fileName} | Create an email document
*EmailApi* | [**CreateEmailAsync**](EmailApi.md#createemailasync) | **PUT** /email/{fileName} | Create an email document. Not available on .NETFramework v2.0
*EmailApi* | [**GetEmail**](EmailApi.md#getemail) | **GET** /email/{fileName} | Get email document
*EmailApi* | [**GetEmailAsync**](EmailApi.md#getemailasync) | **GET** /email/{fileName} | Get email document. Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailAttachment**](EmailApi.md#getemailattachment) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name
*EmailApi* | [**GetEmailAttachmentAsync**](EmailApi.md#getemailattachmentasync) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name. Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailProperty**](EmailApi.md#getemailproperty) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name
*EmailApi* | [**GetEmailPropertyAsync**](EmailApi.md#getemailpropertyasync) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name. Not available on .NETFramework v2.0
*EmailApi* | [**SetEmailProperty**](EmailApi.md#setemailproperty) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value
*EmailApi* | [**SetEmailPropertyAsync**](EmailApi.md#setemailpropertyasync) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value. Not available on .NETFramework v2.0
*EmailClientApi* | [**AppendEmailMessage**](EmailClientApi.md#appendemailmessage) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account
*EmailClientApi* | [**AppendEmailMessageAsync**](EmailClientApi.md#appendemailmessageasync) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account. Not available on .NETFramework v2.0
*EmailClientApi* | [**AppendMimeMessage**](EmailClientApi.md#appendmimemessage) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account
*EmailClientApi* | [**AppendMimeMessageAsync**](EmailClientApi.md#appendmimemessageasync) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account. Not available on .NETFramework v2.0
*EmailClientApi* | [**CreateEmailFolder**](EmailClientApi.md#createemailfolder) | **PUT** /email/client/CreateFolder | Create new folder in email account
*EmailClientApi* | [**CreateEmailFolderAsync**](EmailClientApi.md#createemailfolderasync) | **PUT** /email/client/CreateFolder | Create new folder in email account. Not available on .NETFramework v2.0
*EmailClientApi* | [**DeleteEmailFolder**](EmailClientApi.md#deleteemailfolder) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account
*EmailClientApi* | [**DeleteEmailFolderAsync**](EmailClientApi.md#deleteemailfolderasync) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account. Not available on .NETFramework v2.0
*EmailClientApi* | [**DeleteEmailMessage**](EmailClientApi.md#deleteemailmessage) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id
*EmailClientApi* | [**DeleteEmailMessageAsync**](EmailClientApi.md#deleteemailmessageasync) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id. Not available on .NETFramework v2.0
*EmailClientApi* | [**FetchEmailMessage**](EmailClientApi.md#fetchemailmessage) | **GET** /email/client/Fetch | Fetch message mime from email account
*EmailClientApi* | [**FetchEmailMessageAsync**](EmailClientApi.md#fetchemailmessageasync) | **GET** /email/client/Fetch | Fetch message mime from email account. Not available on .NETFramework v2.0
*EmailClientApi* | [**ListEmailFolders**](EmailClientApi.md#listemailfolders) | **GET** /email/client/ListFolders | Get folders list in email account
*EmailClientApi* | [**ListEmailFoldersAsync**](EmailClientApi.md#listemailfoldersasync) | **GET** /email/client/ListFolders | Get folders list in email account. Not available on .NETFramework v2.0
*EmailClientApi* | [**ListEmailMessages**](EmailClientApi.md#listemailmessages) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query
*EmailClientApi* | [**ListEmailMessagesAsync**](EmailClientApi.md#listemailmessagesasync) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query. Not available on .NETFramework v2.0
*EmailClientApi* | [**SaveMailAccount**](EmailClientApi.md#savemailaccount) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication
*EmailClientApi* | [**SaveMailAccountAsync**](EmailClientApi.md#savemailaccountasync) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication. Not available on .NETFramework v2.0
*EmailClientApi* | [**SaveMailOAuthAccount**](EmailClientApi.md#savemailoauthaccount) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth
*EmailClientApi* | [**SaveMailOAuthAccountAsync**](EmailClientApi.md#savemailoauthaccountasync) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth. Not available on .NETFramework v2.0
*EmailClientApi* | [**SendEmail**](EmailClientApi.md#sendemail) | **POST** /email/client/Send | Send an email from *.eml file located on storage
*EmailClientApi* | [**SendEmailAsync**](EmailClientApi.md#sendemailasync) | **POST** /email/client/Send | Send an email from *.eml file located on storage. Not available on .NETFramework v2.0
*EmailClientApi* | [**SendEmailMime**](EmailClientApi.md#sendemailmime) | **POST** /email/client/SendMime | Send an email specified by MIME in request
*EmailClientApi* | [**SendEmailMimeAsync**](EmailClientApi.md#sendemailmimeasync) | **POST** /email/client/SendMime | Send an email specified by MIME in request. Not available on .NETFramework v2.0
*EmailClientApi* | [**SetEmailReadFlag**](EmailClientApi.md#setemailreadflag) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag
*EmailClientApi* | [**SetEmailReadFlagAsync**](EmailClientApi.md#setemailreadflagasync) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag. Not available on .NETFramework v2.0
*FileApi* | [**CopyFile**](FileApi.md#copyfile) | **PUT** /email/storage/file/copy/{srcPath} | Copy file
*FileApi* | [**CopyFileAsync**](FileApi.md#copyfileasync) | **PUT** /email/storage/file/copy/{srcPath} | Copy file. Not available on .NETFramework v2.0
*FileApi* | [**DeleteFile**](FileApi.md#deletefile) | **DELETE** /email/storage/file/{path} | Delete file
*FileApi* | [**DeleteFileAsync**](FileApi.md#deletefileasync) | **DELETE** /email/storage/file/{path} | Delete file. Not available on .NETFramework v2.0
*FileApi* | [**DownloadFile**](FileApi.md#downloadfile) | **GET** /email/storage/file/{path} | Download file
*FileApi* | [**DownloadFileAsync**](FileApi.md#downloadfileasync) | **GET** /email/storage/file/{path} | Download file. Not available on .NETFramework v2.0
*FileApi* | [**MoveFile**](FileApi.md#movefile) | **PUT** /email/storage/file/move/{srcPath} | Move file
*FileApi* | [**MoveFileAsync**](FileApi.md#movefileasync) | **PUT** /email/storage/file/move/{srcPath} | Move file. Not available on .NETFramework v2.0
*FileApi* | [**UploadFile**](FileApi.md#uploadfile) | **PUT** /email/storage/file/{path} | Upload file
*FileApi* | [**UploadFileAsync**](FileApi.md#uploadfileasync) | **PUT** /email/storage/file/{path} | Upload file. Not available on .NETFramework v2.0
*FolderApi* | [**CopyFolder**](FolderApi.md#copyfolder) | **PUT** /email/storage/folder/copy/{srcPath} | Copy folder
*FolderApi* | [**CopyFolderAsync**](FolderApi.md#copyfolderasync) | **PUT** /email/storage/folder/copy/{srcPath} | Copy folder. Not available on .NETFramework v2.0
*FolderApi* | [**CreateFolder**](FolderApi.md#createfolder) | **PUT** /email/storage/folder/{path} | Create the folder
*FolderApi* | [**CreateFolderAsync**](FolderApi.md#createfolderasync) | **PUT** /email/storage/folder/{path} | Create the folder. Not available on .NETFramework v2.0
*FolderApi* | [**DeleteFolder**](FolderApi.md#deletefolder) | **DELETE** /email/storage/folder/{path} | Delete folder
*FolderApi* | [**DeleteFolderAsync**](FolderApi.md#deletefolderasync) | **DELETE** /email/storage/folder/{path} | Delete folder. Not available on .NETFramework v2.0
*FolderApi* | [**GetFilesList**](FolderApi.md#getfileslist) | **GET** /email/storage/folder/{path} | Get all files and folders within a folder
*FolderApi* | [**GetFilesListAsync**](FolderApi.md#getfileslistasync) | **GET** /email/storage/folder/{path} | Get all files and folders within a folder. Not available on .NETFramework v2.0
*FolderApi* | [**MoveFolder**](FolderApi.md#movefolder) | **PUT** /email/storage/folder/move/{srcPath} | Move folder
*FolderApi* | [**MoveFolderAsync**](FolderApi.md#movefolderasync) | **PUT** /email/storage/folder/move/{srcPath} | Move folder. Not available on .NETFramework v2.0
*MapiApi* | [**AddMapiAttachment**](MapiApi.md#addmapiattachment) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document
*MapiApi* | [**AddMapiAttachmentAsync**](MapiApi.md#addmapiattachmentasync) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document. Not available on .NETFramework v2.0
*MapiApi* | [**CreateMapi**](MapiApi.md#createmapi) | **PUT** /email/Mapi/{name} | Create new document
*MapiApi* | [**CreateMapiAsync**](MapiApi.md#createmapiasync) | **PUT** /email/Mapi/{name} | Create new document. Not available on .NETFramework v2.0
*MapiApi* | [**DeleteMapiAttachment**](MapiApi.md#deletemapiattachment) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document
*MapiApi* | [**DeleteMapiAttachmentAsync**](MapiApi.md#deletemapiattachmentasync) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document. Not available on .NETFramework v2.0
*MapiApi* | [**DeleteMapiProperties**](MapiApi.md#deletemapiproperties) | **DELETE** /email/Mapi/{name}/properties | Delete document properties
*MapiApi* | [**DeleteMapiPropertiesAsync**](MapiApi.md#deletemapipropertiesasync) | **DELETE** /email/Mapi/{name}/properties | Delete document properties. Not available on .NETFramework v2.0
*MapiApi* | [**GetMapiAttachment**](MapiApi.md#getmapiattachment) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream
*MapiApi* | [**GetMapiAttachmentAsync**](MapiApi.md#getmapiattachmentasync) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream. Not available on .NETFramework v2.0
*MapiApi* | [**GetMapiAttachments**](MapiApi.md#getmapiattachments) | **GET** /email/Mapi/{name}/attachments | Get document attachment list
*MapiApi* | [**GetMapiAttachmentsAsync**](MapiApi.md#getmapiattachmentsasync) | **GET** /email/Mapi/{name}/attachments | Get document attachment list. Not available on .NETFramework v2.0
*MapiApi* | [**GetMapiList**](MapiApi.md#getmapilist) | **GET** /email/Mapi | Get document list from storage folder
*MapiApi* | [**GetMapiListAsync**](MapiApi.md#getmapilistasync) | **GET** /email/Mapi | Get document list from storage folder. Not available on .NETFramework v2.0
*MapiApi* | [**GetMapiProperties**](MapiApi.md#getmapiproperties) | **GET** /email/Mapi/{name}/properties | Get document properties
*MapiApi* | [**GetMapiPropertiesAsync**](MapiApi.md#getmapipropertiesasync) | **GET** /email/Mapi/{name}/properties | Get document properties. Not available on .NETFramework v2.0
*MapiApi* | [**UpdateMapiProperties**](MapiApi.md#updatemapiproperties) | **PUT** /email/Mapi/{name}/properties | Update document properties
*MapiApi* | [**UpdateMapiPropertiesAsync**](MapiApi.md#updatemapipropertiesasync) | **PUT** /email/Mapi/{name}/properties | Update document properties. Not available on .NETFramework v2.0
*StorageApi* | [**GetDiscUsage**](StorageApi.md#getdiscusage) | **GET** /email/storage/disc | Get disc usage
*StorageApi* | [**GetDiscUsageAsync**](StorageApi.md#getdiscusageasync) | **GET** /email/storage/disc | Get disc usage. Not available on .NETFramework v2.0
*StorageApi* | [**GetFileVersions**](StorageApi.md#getfileversions) | **GET** /email/storage/version/{path} | Get file versions
*StorageApi* | [**GetFileVersionsAsync**](StorageApi.md#getfileversionsasync) | **GET** /email/storage/version/{path} | Get file versions. Not available on .NETFramework v2.0
*StorageApi* | [**ObjectExists**](StorageApi.md#objectexists) | **GET** /email/storage/exist/{path} | Check if file or folder exists
*StorageApi* | [**ObjectExistsAsync**](StorageApi.md#objectexistsasync) | **GET** /email/storage/exist/{path} | Check if file or folder exists. Not available on .NETFramework v2.0
*StorageApi* | [**StorageExists**](StorageApi.md#storageexists) | **GET** /email/storage/{storageName}/exist | Check if storage exists
*StorageApi* | [**StorageExistsAsync**](StorageApi.md#storageexistsasync) | **GET** /email/storage/{storageName}/exist | Check if storage exists. Not available on .NETFramework v2.0


## Documentation for Models

 - [Model.AccountBaseRequest](AccountBaseRequest.md)
 - [Model.AddAttachmentRequest](AddAttachmentRequest.md)
 - [Model.BaseObject](BaseObject.md)
 - [Model.ContactFormat](ContactFormat.md)
 - [Model.CreateEmailRequest](CreateEmailRequest.md)
 - [Model.DiscUsage](DiscUsage.md)
 - [Model.EmailAccountRequest](EmailAccountRequest.md)
 - [Model.EmailDocument](EmailDocument.md)
 - [Model.EmailDocumentResponse](EmailDocumentResponse.md)
 - [Model.EmailProperties](EmailProperties.md)
 - [Model.EmailProperty](EmailProperty.md)
 - [Model.EmailPropertyResponse](EmailPropertyResponse.md)
 - [Model.Error](Error.md)
 - [Model.ErrorDetails](ErrorDetails.md)
 - [Model.FileVersions](FileVersions.md)
 - [Model.FilesList](FilesList.md)
 - [Model.FilesUploadResult](FilesUploadResult.md)
 - [Model.HierarchicalObjectRequest](HierarchicalObjectRequest.md)
 - [Model.HierarchicalObjectResponse](HierarchicalObjectResponse.md)
 - [Model.Link](Link.md)
 - [Model.ListResponseOfHierarchicalObjectResponse](ListResponseOfHierarchicalObjectResponse.md)
 - [Model.ListResponseOfMailServerFolder](ListResponseOfMailServerFolder.md)
 - [Model.ListResponseOfString](ListResponseOfString.md)
 - [Model.MailServerFolder](MailServerFolder.md)
 - [Model.MimeResponse](MimeResponse.md)
 - [Model.ObjectExist](ObjectExist.md)
 - [Model.SetEmailPropertyRequest](SetEmailPropertyRequest.md)
 - [Model.StorageExist](StorageExist.md)
 - [Model.StorageFile](StorageFile.md)
 - [Model.StorageFolderLocation](StorageFolderLocation.md)
 - [Model.ValueResponse](ValueResponse.md)
 - [Model.AppendEmailAccountBaseRequest](AppendEmailAccountBaseRequest.md)
 - [Model.CreateFolderBaseRequest](CreateFolderBaseRequest.md)
 - [Model.DeleteFolderBaseRequest](DeleteFolderBaseRequest.md)
 - [Model.DeleteMessageBaseRequest](DeleteMessageBaseRequest.md)
 - [Model.FileVersion](FileVersion.md)
 - [Model.HierarchicalObject](HierarchicalObject.md)
 - [Model.IndexedHierarchicalObject](IndexedHierarchicalObject.md)
 - [Model.IndexedPrimitiveObject](IndexedPrimitiveObject.md)
 - [Model.PrimitiveObject](PrimitiveObject.md)
 - [Model.SaveEmailAccountRequest](SaveEmailAccountRequest.md)
 - [Model.SaveOAuthEmailAccountRequest](SaveOAuthEmailAccountRequest.md)
 - [Model.SendEmailBaseRequest](SendEmailBaseRequest.md)
 - [Model.SendEmailMimeBaseRequest](SendEmailMimeBaseRequest.md)
 - [Model.SetMessageReadFlagAccountBaseRequest](SetMessageReadFlagAccountBaseRequest.md)
 - [Model.StorageFileLocation](StorageFileLocation.md)
 - [Model.AppendEmailBaseRequest](AppendEmailBaseRequest.md)
 - [Model.AppendEmailMimeBaseRequest](AppendEmailMimeBaseRequest.md)

