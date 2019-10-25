# Aspose.Email.Cloud.Sdk.EmailClientApi

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

