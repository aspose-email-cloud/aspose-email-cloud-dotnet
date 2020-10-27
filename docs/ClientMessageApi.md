# ClientMessageApi (EmailCloud.Client.Message)

Email client message operations.

<a name="Append"></a>
## Append

**Description**: Add email message to specified folder in email account.             


**Returns:** Message id.

**Method call example:**
```csharp
var result = api.Client.Message.Append(request);
```

### Parameter: *request*

**Description:** Append email request.

**See also** parameter model documentation at [**ClientMessageAppendRequest**](ClientMessageAppendRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** Message id.

**Return type:** [**ValueTOfString**](ValueTOfString.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = api.Client.Message.Append(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AppendAsync"></a>
## AppendAsync

**Description:** Add email message to specified folder in email account.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Message id.

**Method call example:**
```csharp
var result = await api.Client.Message.AppendAsync(request);
```

### Parameter: *request*

**Description:** Append email request.

**See also** parameter model documentation at [**ClientMessageAppendRequest**](ClientMessageAppendRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** Message id.

**Return type:** Task<[**ValueTOfString**](ValueTOfString.md)>

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = await api.Client.Message.AppendAsync(request);

//Result example:
result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AppendFile"></a>
## AppendFile
**Descrption:** Add email message from file to specified folder in email account.             


**Returns:** Message id.

**Method call example:**
```csharp
var result = api.Client.Message.AppendFile(request);
```

### Parameter: *request*

**Description:** AppendFile method request.

**See also** parameter model documentation at [**ClientMessageAppendFileRequest**](ClientMessageAppendFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX"
};
```

</details>

### Result

**Description:** Message id.

**Return type:** [**ValueTOfString**](ValueTOfString.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX"
};

// Call method:
var result = api.Client.Message.AppendFile(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AppendFileAsync"></a>
## AppendFileAsync

**Description:** Add email message from file to specified folder in email account.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Message id.

**Method call example:**
```csharp
var result = await api.Client.Message.AppendFileAsync(request);
```

### Parameter: *request*

**Description:** AppendFileAsync method request.

**See also** parameter model documentation at [**ClientMessageAppendFileRequest**](ClientMessageAppendFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX"
};
```

</details>

### Result

**Returns:** Message id.

**Return type:** [**ValueTOfString**](ValueTOfString.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageAppendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml",
    Folder = "INBOX"
};

// Call method:
var result = await api.Client.Message.AppendFileAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Delete"></a>
## Delete

**Description**: Delete message.             


**Method call example:**
```csharp
api.Client.Message.Delete(request);
```

### Parameter: *request*

**Description:** Delete message request.

**See also** parameter model documentation at [**ClientMessageDeleteRequest**](ClientMessageDeleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Message.Delete(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
## DeleteAsync

**Description:** Delete message.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Message.DeleteAsync(request);
```

### Parameter: *request*

**Description:** Delete message request.

**See also** parameter model documentation at [**ClientMessageDeleteRequest**](ClientMessageDeleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Message.DeleteAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Fetch"></a>
## Fetch
**Descrption:** Fetch message from email account             


**Returns:** MailMessageBase object that represents fetched message in requested format.

**Method call example:**
```csharp
var result = api.Client.Message.Fetch(request);
```

### Parameter: *request*

**Description:** Fetch method request.

**See also** parameter model documentation at [**ClientMessageFetchRequest**](ClientMessageFetchRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageFetchRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};
```

</details>

### Result

**Description:** MailMessageBase object that represents fetched message in requested format.

**Return type:** [**MailMessageBase**](MailMessageBase.md)

<details>
    <summary>Result example</summary>

```csharp
result = new MailMessageBase
{
    
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageFetchRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = api.Client.Message.Fetch(request);

// Result example:
result = new MailMessageBase
{
    
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FetchAsync"></a>
## FetchAsync

**Description:** Fetch message from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** MailMessageBase object that represents fetched message in requested format.

**Method call example:**
```csharp
var result = await api.Client.Message.FetchAsync(request);
```

### Parameter: *request*

**Description:** FetchAsync method request.

**See also** parameter model documentation at [**ClientMessageFetchRequest**](ClientMessageFetchRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageFetchRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};
```

</details>

### Result

**Returns:** MailMessageBase object that represents fetched message in requested format.

**Return type:** [**MailMessageBase**](MailMessageBase.md)

<details>
    <summary>Result example</summary>

```csharp
result = new MailMessageBase
{
    
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageFetchRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = await api.Client.Message.FetchAsync(request);

result = new MailMessageBase
{
    
};

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FetchFile"></a>
## FetchFile
**Descrption:** Fetch message as file from email account             


**Returns:** Email message file in requested format.

**Method call example:**
```csharp
var result = api.Client.Message.FetchFile(request);
```

### Parameter: *request*

**Description:** FetchFile method request.

**See also** parameter model documentation at [**ClientMessageFetchFileRequest**](ClientMessageFetchFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};
```

</details>

### Result

**Description:** Email message file in requested format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};

// Call method:
var result = api.Client.Message.FetchFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FetchFileAsync"></a>
## FetchFileAsync

**Description:** Fetch message as file from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Email message file in requested format.

**Method call example:**
```csharp
var result = await api.Client.Message.FetchFileAsync(request);
```

### Parameter: *request*

**Description:** FetchFileAsync method request.

**See also** parameter model documentation at [**ClientMessageFetchFileRequest**](ClientMessageFetchFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};
```

</details>

### Result

**Returns:** Email message file in requested format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageFetchFileRequest
{ 
    MessageId = "<put your message identifier here>",
    Account = "email.multi.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};

// Call method:
var result = await api.Client.Message.FetchFileAsync(request);

using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="List"></a>
## List
**Descrption:** Get messages from folder, filtered by query             

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

**Returns:** List of MailMessageBase objects that represent fetched message in requested format.

**Method call example:**
```csharp
var result = api.Client.Message.List(request);
```

### Parameter: *request*

**Description:** List method request.

**See also** parameter model documentation at [**ClientMessageListRequest**](ClientMessageListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "('From' Contains '.com')",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};
```

</details>

### Result

**Description:** List of MailMessageBase objects that represent fetched message in requested format.

**Return type:** [**MailMessageBaseList**](MailMessageBaseList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "('From' Contains '.com')",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = api.Client.Message.List(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ListAsync"></a>
## ListAsync

**Description:** Get messages from folder, filtered by query             

Performs operation asynchronously. Not available on .NETFramework v2.0

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

**Returns:** List of MailMessageBase objects that represent fetched message in requested format.

**Method call example:**
```csharp
var result = await api.Client.Message.ListAsync(request);
```

### Parameter: *request*

**Description:** ListAsync method request.

**See also** parameter model documentation at [**ClientMessageListRequest**](ClientMessageListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "('From' Contains '.com')",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};
```

</details>

### Result

**Returns:** List of MailMessageBase objects that represent fetched message in requested format.

**Return type:** [**MailMessageBaseList**](MailMessageBaseList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ClientMessageListRequest
{ 
    Folder = "INBOX",
    Account = "email.multi.account",
    QueryString = "('From' Contains '.com')",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Recursive = true,
    Type = "Dto",
    Format = "Eml"
};

// Call method:
var result = await api.Client.Message.ListAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Move"></a>
## Move

**Description**: Move message to another folder.             


**Method call example:**
```csharp
api.Client.Message.Move(request);
```

### Parameter: *request*

**Description:** Move message request.

**See also** parameter model documentation at [**ClientMessageMoveRequest**](ClientMessageMoveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Message.Move(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveAsync"></a>
## MoveAsync

**Description:** Move message to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Message.MoveAsync(request);
```

### Parameter: *request*

**Description:** Move message request.

**See also** parameter model documentation at [**ClientMessageMoveRequest**](ClientMessageMoveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Message.MoveAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Send"></a>
## Send

**Description**: Send an email specified by model in request.             


**Method call example:**
```csharp
api.Client.Message.Send(request);
```

### Parameter: *request*

**Description:** Send email request.

**See also** parameter model documentation at [**ClientMessageSendRequest**](ClientMessageSendRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Message.Send(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SendAsync"></a>
## SendAsync

**Description:** Send an email specified by model in request.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Message.SendAsync(request);
```

### Parameter: *request*

**Description:** Send email request.

**See also** parameter model documentation at [**ClientMessageSendRequest**](ClientMessageSendRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Message.SendAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SendFile"></a>
## SendFile
**Descrption:** Send an email file.             


**Method call example:**
```csharp
api.Client.Message.SendFile(request);
```

### Parameter: *request*

**Description:** SendFile method request.

**See also** parameter model documentation at [**ClientMessageSendFileRequest**](ClientMessageSendFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageSendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};
```

</details>

### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Message.SendFile(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SendFileAsync"></a>
## SendFileAsync

**Description:** Send an email file.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Message.SendFileAsync(request);
```

### Parameter: *request*

**Description:** SendFileAsync method request.

**See also** parameter model documentation at [**ClientMessageSendFileRequest**](ClientMessageSendFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientMessageSendFileRequest
{ 
    Account = "email.multi.account",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml")),
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    Format = "Eml"
};
```

</details>

### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Message.SendFileAsync(request);


```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SetIsRead"></a>
## SetIsRead

**Description**: Mark message as read or unread.             


**Method call example:**
```csharp
api.Client.Message.SetIsRead(request);
```

### Parameter: *request*

**Description:** Delete message request.

**See also** parameter model documentation at [**ClientMessageSetIsReadRequest**](ClientMessageSetIsReadRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Message.SetIsRead(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
## SetIsReadAsync

**Description:** Mark message as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Message.SetIsReadAsync(request);
```

### Parameter: *request*

**Description:** Delete message request.

**See also** parameter model documentation at [**ClientMessageSetIsReadRequest**](ClientMessageSetIsReadRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Message.SetIsReadAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
