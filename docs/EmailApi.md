# Aspose.Email.Cloud.Sdk.EmailApi

<a name="addcalendarattachment"></a>
# **AddCalendarAttachment**

```csharp
void AddCalendarAttachment(AddCalendarAttachmentRequest request)
```

Adds an attachment to iCalendar file

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddCalendarAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **attachment** | **string**| Attachment file name in storage | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage name and folder path for calendar and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addcontactattachment"></a>
# **AddContactAttachment**

```csharp
void AddContactAttachment(AddContactAttachmentRequest request)
```

Add attachment to contact document

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddContactAttachmentRequest(
    format,
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addemailattachment"></a>
# **AddEmailAttachment**

```csharp
EmailDocumentResponse AddEmailAttachment(AddEmailAttachmentRequest request)
```

Adds an attachment to Email document

### Return type

[**EmailDocumentResponse**](EmailDocumentResponse.md)

### Request Parameters
```csharp
new AddEmailAttachmentRequest(
    attachmentName,
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentName** | **string**| Attachment file name | 
 **fileName** | **string**| Email document file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage info to specify location of email document and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addmapiattachment"></a>
# **AddMapiAttachment**

```csharp
void AddMapiAttachment(AddMapiAttachmentRequest request)
```

Add attachment to document

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddMapiAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendemailmessage"></a>
# **AppendEmailMessage**

```csharp
EmailPropertyResponse AppendEmailMessage(AppendEmailMessageRequest request)
```

Adds an email from *.eml file to specified folder in email account

### Return type

[**EmailPropertyResponse**](EmailPropertyResponse.md)

### Request Parameters
```csharp
new AppendEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AppendEmailBaseRequest**](AppendEmailBaseRequest.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendmimemessage"></a>
# **AppendMimeMessage**

```csharp
ValueResponse AppendMimeMessage(AppendMimeMessageRequest request)
```

Adds an email from MIME to specified folder in email account

### Return type

[**ValueResponse**](ValueResponse.md)

### Request Parameters
```csharp
new AppendMimeMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AppendEmailMimeBaseRequest**](AppendEmailMimeBaseRequest.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfile"></a>
# **CopyFile**

```csharp
void CopyFile(CopyFileRequest request)
```

Copy file

### Return type

void (empty response body)

### Request Parameters
```csharp
new CopyFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfolder"></a>
# **CopyFolder**

```csharp
void CopyFolder(CopyFolderRequest request)
```

Copy folder

### Return type

void (empty response body)

### Request Parameters
```csharp
new CopyFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcalendar"></a>
# **CreateCalendar**

```csharp
void CreateCalendar(CreateCalendarRequest request)
```

Create calendar file

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateCalendarRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcontact"></a>
# **CreateContact**

```csharp
void CreateContact(CreateContactRequest request)
```

Create contact document

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateContactRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create contact request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createemail"></a>
# **CreateEmail**

```csharp
EmailDocumentResponse CreateEmail(CreateEmailRequest request)
```

Create an email document

### Return type

[**EmailDocumentResponse**](EmailDocumentResponse.md)

### Request Parameters
```csharp
new CreateEmailRequest(
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name in storage | 
 **request** | [**CreateEmailRequest**](CreateEmailRequest.md)| An email document and optional Storage info to specify where the file should be located | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createemailfolder"></a>
# **CreateEmailFolder**

```csharp
void CreateEmailFolder(CreateEmailFolderRequest request)
```

Create new folder in email account

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateEmailFolderRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateFolderBaseRequest**](CreateFolderBaseRequest.md)| Create folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createfolder"></a>
# **CreateFolder**

```csharp
void CreateFolder(CreateFolderRequest request)
```

Create the folder

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createmapi"></a>
# **CreateMapi**

```csharp
void CreateMapi(CreateMapiRequest request)
```

Create new document

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateMapiRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create document request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecalendarproperty"></a>
# **DeleteCalendarProperty**

```csharp
void DeleteCalendarProperty(DeleteCalendarPropertyRequest request)
```

Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteCalendarPropertyRequest(
    name,
    memberName,
    index,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **memberName** | **string**| Indexed property name | 
 **index** | **string**| Property index path | 
 **request** | [**StorageFolder**](StorageFolder.md)| Storage detail to specify iCalendar file location | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecontactproperty"></a>
# **DeleteContactProperty**

```csharp
void DeleteContactProperty(DeleteContactPropertyRequest request)
```

Delete property from indexed property list

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteContactPropertyRequest(
    format,
    name,
    memberName,
    index,
    folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **memberName** | **string**| Indexed property name | 
 **index** | **int?**| Property index | 
 **folder** | [**StorageFolder**](StorageFolder.md)| Calendar document location in storage information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailfolder"></a>
# **DeleteEmailFolder**

```csharp
void DeleteEmailFolder(DeleteEmailFolderRequest request)
```

Delete a folder in email account

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteEmailFolderRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DeleteFolderBaseRequest**](DeleteFolderBaseRequest.md)| Delete folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailmessage"></a>
# **DeleteEmailMessage**

```csharp
void DeleteEmailMessage(DeleteEmailMessageRequest request)
```

Delete message from email account by id

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DeleteMessageBaseRequest**](DeleteMessageBaseRequest.md)| Delete message request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefile"></a>
# **DeleteFile**

```csharp
void DeleteFile(DeleteFileRequest request)
```

Delete file

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefolder"></a>
# **DeleteFolder**

```csharp
void DeleteFolder(DeleteFolderRequest request)
```

Delete folder

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteFolderRequest(
    path,
    storageName=storageName,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiattachment"></a>
# **DeleteMapiAttachment**

```csharp
void DeleteMapiAttachment(DeleteMapiAttachmentRequest request)
```

Remove attachment from document

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteMapiAttachmentRequest(
    name,
    attachment,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **storage** | [**StorageFolder**](StorageFolder.md)| Document file storage location info | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiproperties"></a>
# **DeleteMapiProperties**

```csharp
void DeleteMapiProperties(DeleteMapiPropertiesRequest request)
```

Delete document properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be deleted | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="downloadfile"></a>
# **DownloadFile**

```csharp
Stream DownloadFile(DownloadFileRequest request)
```

Download file

### Return type

**file**

### Request Parameters
```csharp
new DownloadFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailmessage"></a>
# **FetchEmailMessage**

```csharp
MimeResponse FetchEmailMessage(FetchEmailMessageRequest request)
```

Fetch message mime from email account

### Return type

[**MimeResponse**](MimeResponse.md)

### Request Parameters
```csharp
new FetchEmailMessageRequest(
    messageId,
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (should be specified for POP/IMAP accounts and should be SMTP account) | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendar"></a>
# **GetCalendar**

```csharp
HierarchicalObject GetCalendar(GetCalendarRequest request)
```

Get calendar file properties

### Return type

[**HierarchicalObject**](HierarchicalObject.md)

### Request Parameters
```csharp
new GetCalendarRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarattachment"></a>
# **GetCalendarAttachment**

```csharp
System.IO.Stream GetCalendarAttachment(GetCalendarAttachmentRequest request)
```

Get iCalendar document attachment by name

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetCalendarAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarlist"></a>
# **GetCalendarList**

```csharp
ListResponseOfHierarchicalObjectResponse GetCalendarList(GetCalendarListRequest request)
```

Get iCalendar files list in folder on storage

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetCalendarListRequest(
    folder,
    itemsPerPage,
    pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | 
 **pageNumber** | **int?**| Page number | 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactattachment"></a>
# **GetContactAttachment**

```csharp
System.IO.Stream GetContactAttachment(GetContactAttachmentRequest request)
```

Get attachment file by name

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetContactAttachmentRequest(
    format,
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactlist"></a>
# **GetContactList**

```csharp
ListResponseOfHierarchicalObjectResponse GetContactList(GetContactListRequest request)
```

Get contact list from storage folder

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetContactListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactproperties"></a>
# **GetContactProperties**

```csharp
HierarchicalObject GetContactProperties(GetContactPropertiesRequest request)
```

Get contact document properties

### Return type

[**HierarchicalObject**](HierarchicalObject.md)

### Request Parameters
```csharp
new GetContactPropertiesRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getdiscusage"></a>
# **GetDiscUsage**

```csharp
DiscUsage GetDiscUsage(GetDiscUsageRequest request)
```

Get disc usage

### Return type

[**DiscUsage**](DiscUsage.md)

### Request Parameters
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemail"></a>
# **GetEmail**

```csharp
EmailDocument GetEmail(GetEmailRequest request)
```

Get email document

### Return type

[**EmailDocument**](EmailDocument.md)

### Request Parameters
```csharp
new GetEmailRequest(
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name in storage | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailattachment"></a>
# **GetEmailAttachment**

```csharp
System.IO.Stream GetEmailAttachment(GetEmailAttachmentRequest request)
```

Get email attachment by name

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetEmailAttachmentRequest(
    attachment,
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachment** | **string**| Attachment name | 
 **fileName** | **string**| Email document file name | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailproperty"></a>
# **GetEmailProperty**

```csharp
EmailPropertyResponse GetEmailProperty(GetEmailPropertyRequest request)
```

Get an email document property by its name

### Return type

[**EmailPropertyResponse**](EmailPropertyResponse.md)

### Request Parameters
```csharp
new GetEmailPropertyRequest(
    propertyName,
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| A property name | 
 **fileName** | **string**| Email document file name | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileversions"></a>
# **GetFileVersions**

```csharp
FileVersions GetFileVersions(GetFileVersionsRequest request)
```

Get file versions

### Return type

[**FileVersions**](FileVersions.md)

### Request Parameters
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileslist"></a>
# **GetFilesList**

```csharp
FilesList GetFilesList(GetFilesListRequest request)
```

Get all files and folders within a folder

### Return type

[**FilesList**](FilesList.md)

### Request Parameters
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachment"></a>
# **GetMapiAttachment**

```csharp
System.IO.Stream GetMapiAttachment(GetMapiAttachmentRequest request)
```

Get document attachment as file stream

### Return type

**System.IO.Stream**

### Request Parameters
```csharp
new GetMapiAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachments"></a>
# **GetMapiAttachments**

```csharp
ListResponseOfString GetMapiAttachments(GetMapiAttachmentsRequest request)
```

Get document attachment list

### Return type

[**ListResponseOfString**](ListResponseOfString.md)

### Request Parameters
```csharp
new GetMapiAttachmentsRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapilist"></a>
# **GetMapiList**

```csharp
ListResponseOfHierarchicalObjectResponse GetMapiList(GetMapiListRequest request)
```

Get document list from storage folder

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetMapiListRequest(
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiproperties"></a>
# **GetMapiProperties**

```csharp
HierarchicalObjectResponse GetMapiProperties(GetMapiPropertiesRequest request)
```

Get document properties

### Return type

[**HierarchicalObjectResponse**](HierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetMapiPropertiesRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailfolders"></a>
# **ListEmailFolders**

```csharp
ListFoldersResponse ListEmailFolders(ListEmailFoldersRequest request)
```

Get folders list in email account

### Return type

[**ListFoldersResponse**](ListFoldersResponse.md)

### Request Parameters
```csharp
new ListEmailFoldersRequest(
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    parentFolder=parentFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (should be specified for POP/IMAP accounts and should be SMTP account) | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailmessages"></a>
# **ListEmailMessages**

```csharp
ListMessagesResponse ListEmailMessages(ListEmailMessagesRequest request)
```

Get messages from folder, filtered by query

The query string should have the following view.  The example of a simple expression:   '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.  The number of simple expressions can make a compound one, ex.: (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3>,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator  At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message  Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message  Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item  Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once  The field value (<Field value>) can take the following values: For text fields - any string, For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\", For flags (fields of boolean type) - either \"True\", or \"False\"

### Return type

[**ListMessagesResponse**](ListMessagesResponse.md)

### Request Parameters
```csharp
new ListEmailMessagesRequest(
    folder,
    queryString,
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **queryString** | **string**| A MailQuery search string | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (should be specified for POP/IMAP accounts and should be SMTP account) | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefile"></a>
# **MoveFile**

```csharp
void MoveFile(MoveFileRequest request)
```

Move file

### Return type

void (empty response body)

### Request Parameters
```csharp
new MoveFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefolder"></a>
# **MoveFolder**

```csharp
void MoveFolder(MoveFolderRequest request)
```

Move folder

### Return type

void (empty response body)

### Request Parameters
```csharp
new MoveFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="objectexists"></a>
# **ObjectExists**

```csharp
ObjectExist ObjectExists(ObjectExistsRequest request)
```

Check if file or folder exists

### Return type

[**ObjectExist**](ObjectExist.md)

### Request Parameters
```csharp
new ObjectExistsRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savemailaccount"></a>
# **SaveMailAccount**

```csharp
void SaveMailAccount(SaveMailAccountRequest request)
```

Create email account file (*.account) with login/password authentication

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveMailAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveEmailAccountRequest**](SaveEmailAccountRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savemailoauthaccount"></a>
# **SaveMailOAuthAccount**

```csharp
void SaveMailOAuthAccount(SaveMailOAuthAccountRequest request)
```

Create email account file (*.account) with OAuth

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveMailOAuthAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveOAuthEmailAccountRequest**](SaveOAuthEmailAccountRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemail"></a>
# **SendEmail**

```csharp
void SendEmail(SendEmailRequest request)
```

Send an email from *.eml file located on storage

### Return type

void (empty response body)

### Request Parameters
```csharp
new SendEmailRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendEmailBaseRequest**](SendEmailBaseRequest.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemailmime"></a>
# **SendEmailMime**

```csharp
void SendEmailMime(SendEmailMimeRequest request)
```

Send an email specified by MIME in request

### Return type

void (empty response body)

### Request Parameters
```csharp
new SendEmailMimeRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendEmailMimeBaseRequest**](SendEmailMimeBaseRequest.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailproperty"></a>
# **SetEmailProperty**

```csharp
EmailPropertyResponse SetEmailProperty(SetEmailPropertyRequest request)
```

Set email document property value

### Return type

[**EmailPropertyResponse**](EmailPropertyResponse.md)

### Request Parameters
```csharp
new SetEmailPropertyRequest(
    propertyName,
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| A property name that should be changed | 
 **fileName** | **string**| Email document file name | 
 **request** | [**SetEmailPropertyRequest**](SetEmailPropertyRequest.md)| A property that should be changed and optional Storage info to specify             where the file located | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailreadflag"></a>
# **SetEmailReadFlag**

```csharp
void SetEmailReadFlag(SetEmailReadFlagRequest request)
```

Sets \"Message is read\" flag

### Return type

void (empty response body)

### Request Parameters
```csharp
new SetEmailReadFlagRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetMessageReadFlagAccountBaseRequest**](SetMessageReadFlagAccountBaseRequest.md)| Message is read request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="storageexists"></a>
# **StorageExists**

```csharp
StorageExist StorageExists(StorageExistsRequest request)
```

Check if storage exists

### Return type

[**StorageExist**](StorageExist.md)

### Request Parameters
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecalendarproperties"></a>
# **UpdateCalendarProperties**

```csharp
void UpdateCalendarProperties(UpdateCalendarPropertiesRequest request)
```

Update calendar file properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateCalendarPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecontactproperties"></a>
# **UpdateContactProperties**

```csharp
void UpdateContactProperties(UpdateContactPropertiesRequest request)
```

Update contact document properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateContactPropertiesRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **int?**| Contact document format | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatemapiproperties"></a>
# **UpdateMapiProperties**

```csharp
void UpdateMapiProperties(UpdateMapiPropertiesRequest request)
```

Update document properties

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="uploadfile"></a>
# **UploadFile**

```csharp
FilesUploadResult UploadFile(UploadFileRequest request)
```

Upload file

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### Request Parameters
```csharp
new UploadFileRequest(
    path,
    file,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

