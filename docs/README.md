## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EmailApi* | [**AddCalendarAttachment**](EmailApi.md#addcalendarattachment) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file
*EmailApi* | [**AddCalendarAttachmentAsync**](EmailApi.md#addcalendarattachmentasync) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file. Not available on .NETFramework v2.0
*EmailApi* | [**AddContactAttachment**](EmailApi.md#addcontactattachment) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document
*EmailApi* | [**AddContactAttachmentAsync**](EmailApi.md#addcontactattachmentasync) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document. Not available on .NETFramework v2.0
*EmailApi* | [**AddEmailAttachment**](EmailApi.md#addemailattachment) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document
*EmailApi* | [**AddEmailAttachmentAsync**](EmailApi.md#addemailattachmentasync) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document. Not available on .NETFramework v2.0
*EmailApi* | [**AddMapiAttachment**](EmailApi.md#addmapiattachment) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document
*EmailApi* | [**AddMapiAttachmentAsync**](EmailApi.md#addmapiattachmentasync) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document. Not available on .NETFramework v2.0
*EmailApi* | [**AppendEmailMessage**](EmailApi.md#appendemailmessage) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account
*EmailApi* | [**AppendEmailMessageAsync**](EmailApi.md#appendemailmessageasync) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account. Not available on .NETFramework v2.0
*EmailApi* | [**AppendMimeMessage**](EmailApi.md#appendmimemessage) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account
*EmailApi* | [**AppendMimeMessageAsync**](EmailApi.md#appendmimemessageasync) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account. Not available on .NETFramework v2.0
*EmailApi* | [**CopyFile**](EmailApi.md#copyfile) | **PUT** /email/storage/file/copy/{srcPath} | Copy file
*EmailApi* | [**CopyFileAsync**](EmailApi.md#copyfileasync) | **PUT** /email/storage/file/copy/{srcPath} | Copy file. Not available on .NETFramework v2.0
*EmailApi* | [**CopyFolder**](EmailApi.md#copyfolder) | **PUT** /email/storage/folder/copy/{srcPath} | Copy folder
*EmailApi* | [**CopyFolderAsync**](EmailApi.md#copyfolderasync) | **PUT** /email/storage/folder/copy/{srcPath} | Copy folder. Not available on .NETFramework v2.0
*EmailApi* | [**CreateCalendar**](EmailApi.md#createcalendar) | **PUT** /email/Calendar/{name} | Create calendar file
*EmailApi* | [**CreateCalendarAsync**](EmailApi.md#createcalendarasync) | **PUT** /email/Calendar/{name} | Create calendar file. Not available on .NETFramework v2.0
*EmailApi* | [**CreateContact**](EmailApi.md#createcontact) | **PUT** /email/Contact/{format}/{name} | Create contact document
*EmailApi* | [**CreateContactAsync**](EmailApi.md#createcontactasync) | **PUT** /email/Contact/{format}/{name} | Create contact document. Not available on .NETFramework v2.0
*EmailApi* | [**CreateEmail**](EmailApi.md#createemail) | **PUT** /email/{fileName} | Create an email document
*EmailApi* | [**CreateEmailAsync**](EmailApi.md#createemailasync) | **PUT** /email/{fileName} | Create an email document. Not available on .NETFramework v2.0
*EmailApi* | [**CreateEmailFolder**](EmailApi.md#createemailfolder) | **PUT** /email/client/CreateFolder | Create new folder in email account
*EmailApi* | [**CreateEmailFolderAsync**](EmailApi.md#createemailfolderasync) | **PUT** /email/client/CreateFolder | Create new folder in email account. Not available on .NETFramework v2.0
*EmailApi* | [**CreateFolder**](EmailApi.md#createfolder) | **PUT** /email/storage/folder/{path} | Create the folder
*EmailApi* | [**CreateFolderAsync**](EmailApi.md#createfolderasync) | **PUT** /email/storage/folder/{path} | Create the folder. Not available on .NETFramework v2.0
*EmailApi* | [**CreateMapi**](EmailApi.md#createmapi) | **PUT** /email/Mapi/{name} | Create new document
*EmailApi* | [**CreateMapiAsync**](EmailApi.md#createmapiasync) | **PUT** /email/Mapi/{name} | Create new document. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteCalendarProperty**](EmailApi.md#deletecalendarproperty) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}
*EmailApi* | [**DeleteCalendarPropertyAsync**](EmailApi.md#deletecalendarpropertyasync) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteContactProperty**](EmailApi.md#deletecontactproperty) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list
*EmailApi* | [**DeleteContactPropertyAsync**](EmailApi.md#deletecontactpropertyasync) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteEmailFolder**](EmailApi.md#deleteemailfolder) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account
*EmailApi* | [**DeleteEmailFolderAsync**](EmailApi.md#deleteemailfolderasync) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteEmailMessage**](EmailApi.md#deleteemailmessage) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id
*EmailApi* | [**DeleteEmailMessageAsync**](EmailApi.md#deleteemailmessageasync) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteFile**](EmailApi.md#deletefile) | **DELETE** /email/storage/file/{path} | Delete file
*EmailApi* | [**DeleteFileAsync**](EmailApi.md#deletefileasync) | **DELETE** /email/storage/file/{path} | Delete file. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteFolder**](EmailApi.md#deletefolder) | **DELETE** /email/storage/folder/{path} | Delete folder
*EmailApi* | [**DeleteFolderAsync**](EmailApi.md#deletefolderasync) | **DELETE** /email/storage/folder/{path} | Delete folder. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteMapiAttachment**](EmailApi.md#deletemapiattachment) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document
*EmailApi* | [**DeleteMapiAttachmentAsync**](EmailApi.md#deletemapiattachmentasync) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document. Not available on .NETFramework v2.0
*EmailApi* | [**DeleteMapiProperties**](EmailApi.md#deletemapiproperties) | **DELETE** /email/Mapi/{name}/properties | Delete document properties
*EmailApi* | [**DeleteMapiPropertiesAsync**](EmailApi.md#deletemapipropertiesasync) | **DELETE** /email/Mapi/{name}/properties | Delete document properties. Not available on .NETFramework v2.0
*EmailApi* | [**DownloadFile**](EmailApi.md#downloadfile) | **GET** /email/storage/file/{path} | Download file
*EmailApi* | [**DownloadFileAsync**](EmailApi.md#downloadfileasync) | **GET** /email/storage/file/{path} | Download file. Not available on .NETFramework v2.0
*EmailApi* | [**FetchEmailMessage**](EmailApi.md#fetchemailmessage) | **GET** /email/client/Fetch | Fetch message mime from email account
*EmailApi* | [**FetchEmailMessageAsync**](EmailApi.md#fetchemailmessageasync) | **GET** /email/client/Fetch | Fetch message mime from email account. Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendar**](EmailApi.md#getcalendar) | **GET** /email/Calendar/{name}/properties | Get calendar file properties
*EmailApi* | [**GetCalendarAsync**](EmailApi.md#getcalendarasync) | **GET** /email/Calendar/{name}/properties | Get calendar file properties. Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarAttachment**](EmailApi.md#getcalendarattachment) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name
*EmailApi* | [**GetCalendarAttachmentAsync**](EmailApi.md#getcalendarattachmentasync) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name. Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarList**](EmailApi.md#getcalendarlist) | **GET** /email/Calendar | Get iCalendar files list in folder on storage
*EmailApi* | [**GetCalendarListAsync**](EmailApi.md#getcalendarlistasync) | **GET** /email/Calendar | Get iCalendar files list in folder on storage. Not available on .NETFramework v2.0
*EmailApi* | [**GetContactAttachment**](EmailApi.md#getcontactattachment) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name
*EmailApi* | [**GetContactAttachmentAsync**](EmailApi.md#getcontactattachmentasync) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name. Not available on .NETFramework v2.0
*EmailApi* | [**GetContactList**](EmailApi.md#getcontactlist) | **GET** /email/Contact/{format} | Get contact list from storage folder
*EmailApi* | [**GetContactListAsync**](EmailApi.md#getcontactlistasync) | **GET** /email/Contact/{format} | Get contact list from storage folder. Not available on .NETFramework v2.0
*EmailApi* | [**GetContactProperties**](EmailApi.md#getcontactproperties) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties
*EmailApi* | [**GetContactPropertiesAsync**](EmailApi.md#getcontactpropertiesasync) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties. Not available on .NETFramework v2.0
*EmailApi* | [**GetDiscUsage**](EmailApi.md#getdiscusage) | **GET** /email/storage/disc | Get disc usage
*EmailApi* | [**GetDiscUsageAsync**](EmailApi.md#getdiscusageasync) | **GET** /email/storage/disc | Get disc usage. Not available on .NETFramework v2.0
*EmailApi* | [**GetEmail**](EmailApi.md#getemail) | **GET** /email/{fileName} | Get email document
*EmailApi* | [**GetEmailAsync**](EmailApi.md#getemailasync) | **GET** /email/{fileName} | Get email document. Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailAttachment**](EmailApi.md#getemailattachment) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name
*EmailApi* | [**GetEmailAttachmentAsync**](EmailApi.md#getemailattachmentasync) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name. Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailProperty**](EmailApi.md#getemailproperty) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name
*EmailApi* | [**GetEmailPropertyAsync**](EmailApi.md#getemailpropertyasync) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name. Not available on .NETFramework v2.0
*EmailApi* | [**GetFileVersions**](EmailApi.md#getfileversions) | **GET** /email/storage/version/{path} | Get file versions
*EmailApi* | [**GetFileVersionsAsync**](EmailApi.md#getfileversionsasync) | **GET** /email/storage/version/{path} | Get file versions. Not available on .NETFramework v2.0
*EmailApi* | [**GetFilesList**](EmailApi.md#getfileslist) | **GET** /email/storage/folder/{path} | Get all files and folders within a folder
*EmailApi* | [**GetFilesListAsync**](EmailApi.md#getfileslistasync) | **GET** /email/storage/folder/{path} | Get all files and folders within a folder. Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiAttachment**](EmailApi.md#getmapiattachment) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream
*EmailApi* | [**GetMapiAttachmentAsync**](EmailApi.md#getmapiattachmentasync) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream. Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiAttachments**](EmailApi.md#getmapiattachments) | **GET** /email/Mapi/{name}/attachments | Get document attachment list
*EmailApi* | [**GetMapiAttachmentsAsync**](EmailApi.md#getmapiattachmentsasync) | **GET** /email/Mapi/{name}/attachments | Get document attachment list. Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiList**](EmailApi.md#getmapilist) | **GET** /email/Mapi | Get document list from storage folder
*EmailApi* | [**GetMapiListAsync**](EmailApi.md#getmapilistasync) | **GET** /email/Mapi | Get document list from storage folder. Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiProperties**](EmailApi.md#getmapiproperties) | **GET** /email/Mapi/{name}/properties | Get document properties
*EmailApi* | [**GetMapiPropertiesAsync**](EmailApi.md#getmapipropertiesasync) | **GET** /email/Mapi/{name}/properties | Get document properties. Not available on .NETFramework v2.0
*EmailApi* | [**ListEmailFolders**](EmailApi.md#listemailfolders) | **GET** /email/client/ListFolders | Get folders list in email account
*EmailApi* | [**ListEmailFoldersAsync**](EmailApi.md#listemailfoldersasync) | **GET** /email/client/ListFolders | Get folders list in email account. Not available on .NETFramework v2.0
*EmailApi* | [**ListEmailMessages**](EmailApi.md#listemailmessages) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query
*EmailApi* | [**ListEmailMessagesAsync**](EmailApi.md#listemailmessagesasync) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query. Not available on .NETFramework v2.0
*EmailApi* | [**MoveFile**](EmailApi.md#movefile) | **PUT** /email/storage/file/move/{srcPath} | Move file
*EmailApi* | [**MoveFileAsync**](EmailApi.md#movefileasync) | **PUT** /email/storage/file/move/{srcPath} | Move file. Not available on .NETFramework v2.0
*EmailApi* | [**MoveFolder**](EmailApi.md#movefolder) | **PUT** /email/storage/folder/move/{srcPath} | Move folder
*EmailApi* | [**MoveFolderAsync**](EmailApi.md#movefolderasync) | **PUT** /email/storage/folder/move/{srcPath} | Move folder. Not available on .NETFramework v2.0
*EmailApi* | [**ObjectExists**](EmailApi.md#objectexists) | **GET** /email/storage/exist/{path} | Check if file or folder exists
*EmailApi* | [**ObjectExistsAsync**](EmailApi.md#objectexistsasync) | **GET** /email/storage/exist/{path} | Check if file or folder exists. Not available on .NETFramework v2.0
*EmailApi* | [**SaveMailAccount**](EmailApi.md#savemailaccount) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication
*EmailApi* | [**SaveMailAccountAsync**](EmailApi.md#savemailaccountasync) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication. Not available on .NETFramework v2.0
*EmailApi* | [**SaveMailOAuthAccount**](EmailApi.md#savemailoauthaccount) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth
*EmailApi* | [**SaveMailOAuthAccountAsync**](EmailApi.md#savemailoauthaccountasync) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth. Not available on .NETFramework v2.0
*EmailApi* | [**SendEmail**](EmailApi.md#sendemail) | **POST** /email/client/Send | Send an email from *.eml file located on storage
*EmailApi* | [**SendEmailAsync**](EmailApi.md#sendemailasync) | **POST** /email/client/Send | Send an email from *.eml file located on storage. Not available on .NETFramework v2.0
*EmailApi* | [**SendEmailMime**](EmailApi.md#sendemailmime) | **POST** /email/client/SendMime | Send an email specified by MIME in request
*EmailApi* | [**SendEmailMimeAsync**](EmailApi.md#sendemailmimeasync) | **POST** /email/client/SendMime | Send an email specified by MIME in request. Not available on .NETFramework v2.0
*EmailApi* | [**SetEmailProperty**](EmailApi.md#setemailproperty) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value
*EmailApi* | [**SetEmailPropertyAsync**](EmailApi.md#setemailpropertyasync) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value. Not available on .NETFramework v2.0
*EmailApi* | [**SetEmailReadFlag**](EmailApi.md#setemailreadflag) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag
*EmailApi* | [**SetEmailReadFlagAsync**](EmailApi.md#setemailreadflagasync) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag. Not available on .NETFramework v2.0
*EmailApi* | [**StorageExists**](EmailApi.md#storageexists) | **GET** /email/storage/{storageName}/exist | Check if storage exists
*EmailApi* | [**StorageExistsAsync**](EmailApi.md#storageexistsasync) | **GET** /email/storage/{storageName}/exist | Check if storage exists. Not available on .NETFramework v2.0
*EmailApi* | [**UpdateCalendarProperties**](EmailApi.md#updatecalendarproperties) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties
*EmailApi* | [**UpdateCalendarPropertiesAsync**](EmailApi.md#updatecalendarpropertiesasync) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties. Not available on .NETFramework v2.0
*EmailApi* | [**UpdateContactProperties**](EmailApi.md#updatecontactproperties) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties
*EmailApi* | [**UpdateContactPropertiesAsync**](EmailApi.md#updatecontactpropertiesasync) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties. Not available on .NETFramework v2.0
*EmailApi* | [**UpdateMapiProperties**](EmailApi.md#updatemapiproperties) | **PUT** /email/Mapi/{name}/properties | Update document properties
*EmailApi* | [**UpdateMapiPropertiesAsync**](EmailApi.md#updatemapipropertiesasync) | **PUT** /email/Mapi/{name}/properties | Update document properties. Not available on .NETFramework v2.0
*EmailApi* | [**UploadFile**](EmailApi.md#uploadfile) | **PUT** /email/storage/file/{path} | Upload file
*EmailApi* | [**UploadFileAsync**](EmailApi.md#uploadfileasync) | **PUT** /email/storage/file/{path} | Upload file. Not available on .NETFramework v2.0


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

