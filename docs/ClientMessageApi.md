# Aspose.Email.Cloud.Sdk.ClientMessageApi

<a name="Append"></a>
# Append

Add email message to specified folder in email account.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageAppendRequest
{
    Folder = "INBOX/SubFolder",
    Message = new MailMessageDto
    {
        Value = new EmailDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "some-file.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            Body = "Some body",
            BodyType = "Html",
            DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
            {
                "OnSuccess",
                "Delay"
            },
            From = new MailAddress
            {
                DisplayName = "From Address",
                Address = "from@aspose.com"
            },
            HtmlBody = "<b>Some body</b>",
            IsBodyHtml = true,
            IsDraft = true,
            Subject = "Re: Some subject",
            To = new List<MailAddress>
            {
                new MailAddress
                {
                    DisplayName = "To Address",
                    Address = "to@aspose.com"
                }
            }
        }
    },
    MarkAsSent = true,
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
var result = Api.Client.Message.Append(request);

// Result example:
result = ;
```

</details>

### request Parameter
See parameter model documentation at [ClientMessageAppendRequest](ClientMessageAppendRequest.md)


### Return type

[**ValueTOfString**](ValueTOfString.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AppendAsync"></a>
# AppendAsync

Add email message to specified folder in email account.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageAppendRequest
{
    Folder = "INBOX/SubFolder",
    Message = new MailMessageDto
    {
        Value = new EmailDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "some-file.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            Body = "Some body",
            BodyType = "Html",
            DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
            {
                "OnSuccess",
                "Delay"
            },
            From = new MailAddress
            {
                DisplayName = "From Address",
                Address = "from@aspose.com"
            },
            HtmlBody = "<b>Some body</b>",
            IsBodyHtml = true,
            IsDraft = true,
            Subject = "Re: Some subject",
            To = new List<MailAddress>
            {
                new MailAddress
                {
                    DisplayName = "To Address",
                    Address = "to@aspose.com"
                }
            }
        }
    },
    MarkAsSent = true,
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
var result = await Api.Client.Message.AppendAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter
See parameter model documentation at [ClientMessageAppendRequest](ClientMessageAppendRequest.md)


### Return type

Task<[**ValueTOfString**](ValueTOfString.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AppendFile"></a>
# AppendFile

Add email message from file to specified folder in email account.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX",
};

// Call method:
var result = Api.Client.Message.AppendFile(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account. | 
 **file** | **System.IO.Stream**| Message file to append. | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]
 **folder** | **string**| Path to folder on email server to append message to. | [optional] 
 **markAsSent** | **bool?**| Determines that appended message should be market as sent or not. | [optional] [default to true]

### Return type

[**ValueTOfString**](ValueTOfString.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AppendFileAsync"></a>
# AppendFileAsync

Add email message from file to specified folder in email account.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX",
};

// Call method:
var result = await Api.Client.Message.AppendFileAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account. | 
 **file** | **System.IO.Stream**| Message file to append. | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]
 **folder** | **string**| Path to folder on email server to append message to. | [optional] 
 **markAsSent** | **bool?**| Determines that appended message should be market as sent or not. | [optional] [default to true]

### Return type

[**ValueTOfString**](ValueTOfString.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Delete"></a>
# Delete

Delete message.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageDeleteRequest
{
    Folder = "INBOX",
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Message.Delete(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageDeleteRequest](ClientMessageDeleteRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
# DeleteAsync

Delete message.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageDeleteRequest
{
    Folder = "INBOX",
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Message.DeleteAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageDeleteRequest](ClientMessageDeleteRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Fetch"></a>
# Fetch

Fetch message from email account             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageFetchRequest
{ 
    MessageId = "&lt;put your message identifier here&gt;",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = Api.Client.Message.Fetch(request);

// Result example:
result = new MailMessageBase
{
    
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **type** | **string**| MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

[**MailMessageBase**](MailMessageBase.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FetchAsync"></a>
# FetchAsync

Fetch message from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageFetchRequest
{ 
    MessageId = "&lt;put your message identifier here&gt;",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = await Api.Client.Message.FetchAsync(request);

// Result example:
result = new MailMessageBase
{
    
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **type** | **string**| MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

[**MailMessageBase**](MailMessageBase.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FetchFile"></a>
# FetchFile

Fetch message as file from email account             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "&lt;put your message identifier here&gt;",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};

// Call method:
var result = Api.Client.Message.FetchFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Fetched message file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FetchFileAsync"></a>
# FetchFileAsync

Fetch message as file from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "&lt;put your message identifier here&gt;",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};

// Call method:
var result = await Api.Client.Message.FetchFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Fetched message file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="List"></a>
# List

Get messages from folder, filtered by query             

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "(&#39;From&#39; Contains &#39;.com&#39;)",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = Api.Client.Message.List(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **account** | **string**| Email account | 
 **queryString** | **string**| A MailQuery search string | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]
 **type** | **string**| MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

[**MailMessageBaseList**](MailMessageBaseList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ListAsync"></a>
# ListAsync

Get messages from folder, filtered by query             

Performs operation asynchronously. Not available on .NETFramework v2.0

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "(&#39;From&#39; Contains &#39;.com&#39;)",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = await Api.Client.Message.ListAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **account** | **string**| Email account | 
 **queryString** | **string**| A MailQuery search string | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]
 **type** | **string**| MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64 | [optional] [default to 0]
 **format** | **string**| Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

[**MailMessageBaseList**](MailMessageBaseList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Move"></a>
# Move

Move message to another folder.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageMoveRequest
{
    SourceFolder = "INBOX",
    DestinationFolder = "INBOX/SubFolder",
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Message.Move(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageMoveRequest](ClientMessageMoveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveAsync"></a>
# MoveAsync

Move message to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageMoveRequest
{
    SourceFolder = "INBOX",
    DestinationFolder = "INBOX/SubFolder",
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Message.MoveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageMoveRequest](ClientMessageMoveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Send"></a>
# Send

Send an email specified by model in request.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageSendRequest
{
    Message = new MailMessageDto
    {
        Value = new EmailDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "some-file.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            Body = "Some body",
            BodyType = "Html",
            DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
            {
                "OnSuccess",
                "Delay"
            },
            From = new MailAddress
            {
                DisplayName = "From Address",
                Address = "from@aspose.com"
            },
            HtmlBody = "<b>Some body</b>",
            IsBodyHtml = true,
            IsDraft = true,
            Subject = "Re: Some subject",
            To = new List<MailAddress>
            {
                new MailAddress
                {
                    DisplayName = "To Address",
                    Address = "to@aspose.com"
                }
            }
        }
    },
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Message.Send(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageSendRequest](ClientMessageSendRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SendAsync"></a>
# SendAsync

Send an email specified by model in request.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageSendRequest
{
    Message = new MailMessageDto
    {
        Value = new EmailDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "some-file.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            Body = "Some body",
            BodyType = "Html",
            DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
            {
                "OnSuccess",
                "Delay"
            },
            From = new MailAddress
            {
                DisplayName = "From Address",
                Address = "from@aspose.com"
            },
            HtmlBody = "<b>Some body</b>",
            IsBodyHtml = true,
            IsDraft = true,
            Subject = "Re: Some subject",
            To = new List<MailAddress>
            {
                new MailAddress
                {
                    DisplayName = "To Address",
                    Address = "to@aspose.com"
                }
            }
        }
    },
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Message.SendAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageSendRequest](ClientMessageSendRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SendFile"></a>
# SendFile

Send an email file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageSendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};

// Call method:
Api.Client.Message.SendFile(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **file** | **System.IO.Stream**| File to send | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SendFileAsync"></a>
# SendFileAsync

Send an email file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageSendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};

// Call method:
await Api.Client.Message.SendFileAsync(request);

```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **file** | **System.IO.Stream**| File to send | 
 **storage** | **string**| Storage name where account file located. | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located. | [optional] 
 **format** | **string**| Email file format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | [optional] [default to 0]

### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SetIsRead"></a>
# SetIsRead

Mark message as read or unread.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageSetIsReadRequest
{
    IsRead = true,
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Message.SetIsRead(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageSetIsReadRequest](ClientMessageSetIsReadRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
# SetIsReadAsync

Mark message as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientMessageSetIsReadRequest
{
    IsRead = true,
    MessageId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Message.SetIsReadAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ClientMessageSetIsReadRequest](ClientMessageSetIsReadRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
