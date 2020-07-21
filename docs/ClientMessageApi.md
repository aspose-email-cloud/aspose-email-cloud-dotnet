# Aspose.Email.Cloud.Sdk.ClientMessageApi

        ﻿<a name="Append"></a>
# Append

```csharp
ValueTOfString Append(ClientMessageAppendRequest request)
```

Add email message to specified folder in email account.             

### Return type

[**ValueTOfString**](ValueTOfString.md)

### request Parameter

See parameter model documentation at [ClientMessageAppendRequest](ClientMessageAppendRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="AppendAsync"></a>
# AppendAsync

```csharp
async Task<ValueTOfString> AppendAsync(ClientMessageAppendRequest request)
```

Add email message to specified folder in email account.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ValueTOfString**](ValueTOfString.md)>

### request Parameter

See parameter model documentation at [ClientMessageAppendRequest](ClientMessageAppendRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="AppendFile"></a>
# AppendFile

```csharp
ValueTOfString AppendFile(ClientMessageAppendFileRequest request)
```

Add email message from file to specified folder in email account.             

### Return type

[**ValueTOfString**](ValueTOfString.md)

### request Parameter
```csharp
new ClientMessageAppendFileRequest(
    account,
    file,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    format=format,
    folder=folder,
    markAsSent=markAsSent)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account. | 
 **file** | **System.IO.Stream**| Message file to append. | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]
 **folder** | **string**| Path to folder on email server to append message to. | [optional] 
 **markAsSent** | **bool?**| Determines that appended message should be market as sent or not. | [optional] [default to true]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="AppendFileAsync"></a>
# AppendFileAsync

```csharp
async Task<ValueTOfString> AppendFileAsync(ClientMessageAppendFileRequest request)
```

Add email message from file to specified folder in email account.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ValueTOfString**](ValueTOfString.md)>

### request Parameter
```csharp
new ClientMessageAppendFileRequest(
    account,
    file,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    format=format,
    folder=folder,
    markAsSent=markAsSent)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account. | 
 **file** | **System.IO.Stream**| Message file to append. | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]
 **folder** | **string**| Path to folder on email server to append message to. | [optional] 
 **markAsSent** | **bool?**| Determines that appended message should be market as sent or not. | [optional] [default to true]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="Delete"></a>
# Delete

```csharp
void Delete(ClientMessageDeleteRequest request)
```

Delete message.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageDeleteRequest](ClientMessageDeleteRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
# DeleteAsync

```csharp
async Task DeleteAsync(ClientMessageDeleteRequest request)
```

Delete message.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageDeleteRequest](ClientMessageDeleteRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="Fetch"></a>
# Fetch

```csharp
MailMessageBase Fetch(ClientMessageFetchRequest request)
```

Fetch message from email account             

### Return type

[**MailMessageBase**](MailMessageBase.md)

### request Parameter
```csharp
new ClientMessageFetchRequest(
    messageId,
    account,
    folder=folder,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    type=type,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **type** | **string**| MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="FetchAsync"></a>
# FetchAsync

```csharp
async Task<MailMessageBase> FetchAsync(ClientMessageFetchRequest request)
```

Fetch message from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MailMessageBase**](MailMessageBase.md)>

### request Parameter
```csharp
new ClientMessageFetchRequest(
    messageId,
    account,
    folder=folder,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    type=type,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **type** | **string**| MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="FetchFile"></a>
# FetchFile

```csharp
Stream FetchFile(ClientMessageFetchFileRequest request)
```

Fetch message as file from email account             

### Return type

**Stream**

### request Parameter
```csharp
new ClientMessageFetchFileRequest(
    messageId,
    account,
    folder=folder,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Fetched message file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="FetchFileAsync"></a>
# FetchFileAsync

```csharp
async Task<Stream> FetchFileAsync(ClientMessageFetchFileRequest request)
```

Fetch message as file from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### request Parameter
```csharp
new ClientMessageFetchFileRequest(
    messageId,
    account,
    folder=folder,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Fetched message file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="List"></a>
# List

```csharp
MailMessageBaseList List(ClientMessageListRequest request)
```

Get messages from folder, filtered by query             

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

### Return type

[**MailMessageBaseList**](MailMessageBaseList.md)

### request Parameter
```csharp
new ClientMessageListRequest(
    folder,
    account,
    queryString=queryString,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    recursive=recursive,
    type=type,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **account** | **string**| Email account | 
 **queryString** | **string**| A MailQuery search string | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]
 **type** | **string**| MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ListAsync"></a>
# ListAsync

```csharp
async Task<MailMessageBaseList> ListAsync(ClientMessageListRequest request)
```

Get messages from folder, filtered by query             

Performs operation asynchronously. Not available on .NETFramework v2.0

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

### Return type

Task<[**MailMessageBaseList**](MailMessageBaseList.md)>

### request Parameter
```csharp
new ClientMessageListRequest(
    folder,
    account,
    queryString=queryString,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    recursive=recursive,
    type=type,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **account** | **string**| Email account | 
 **queryString** | **string**| A MailQuery search string | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]
 **type** | **string**| MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="Move"></a>
# Move

```csharp
void Move(ClientMessageMoveRequest request)
```

Move message to another folder.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageMoveRequest](ClientMessageMoveRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="MoveAsync"></a>
# MoveAsync

```csharp
async Task MoveAsync(ClientMessageMoveRequest request)
```

Move message to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageMoveRequest](ClientMessageMoveRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="Send"></a>
# Send

```csharp
void Send(ClientMessageSendRequest request)
```

Send an email specified by model in request.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageSendRequest](ClientMessageSendRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="SendAsync"></a>
# SendAsync

```csharp
async Task SendAsync(ClientMessageSendRequest request)
```

Send an email specified by model in request.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageSendRequest](ClientMessageSendRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="SendFile"></a>
# SendFile

```csharp
void SendFile(ClientMessageSendFileRequest request)
```

Send an email file.             

### Return type

void (empty response body)

### request Parameter
```csharp
new ClientMessageSendFileRequest(
    account,
    file,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **file** | **System.IO.Stream**| File to send | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="SendFileAsync"></a>
# SendFileAsync

```csharp
async Task SendFileAsync(ClientMessageSendFileRequest request)
```

Send an email file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter
```csharp
new ClientMessageSendFileRequest(
    account,
    file,
    storage=storage,
    accountStorageFolder=accountStorageFolder,
    format=format)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **file** | **System.IO.Stream**| File to send | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
        ﻿<a name="SetIsRead"></a>
# SetIsRead

```csharp
void SetIsRead(ClientMessageSetIsReadRequest request)
```

Mark message as read or unread.             

### Return type

void (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageSetIsReadRequest](ClientMessageSetIsReadRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
# SetIsReadAsync

```csharp
async Task SetIsReadAsync(ClientMessageSetIsReadRequest request)
```

Mark message as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### request Parameter

See parameter model documentation at [ClientMessageSetIsReadRequest](ClientMessageSetIsReadRequest.md)

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)
