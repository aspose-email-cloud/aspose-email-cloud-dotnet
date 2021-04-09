# ClientThreadApi (EmailCloud.Client.Thread)

Email client thread operations.

<a name="Delete"></a>
## Delete

**Description**: Delete thread by id. All messages from thread will also be deleted.             


**Method call example:**
```csharp
api.Client.Thread.Delete(request);
```

### Parameter: *request*

**Description:** Delete email thread request.

**See also** parameter model documentation at [**ClientThreadDeleteRequest**](ClientThreadDeleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadDeleteRequest
{
    Folder = "INBOX/SubFolder",
    ThreadId = "5",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadDeleteRequest
{
    Folder = "INBOX/SubFolder",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
api.Client.Thread.Delete(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
## DeleteAsync

**Description:** Delete thread by id. All messages from thread will also be deleted.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Thread.DeleteAsync(request);
```

### Parameter: *request*

**Description:** Delete email thread request.

**See also** parameter model documentation at [**ClientThreadDeleteRequest**](ClientThreadDeleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadDeleteRequest
{
    Folder = "INBOX/SubFolder",
    ThreadId = "5",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadDeleteRequest
{
    Folder = "INBOX/SubFolder",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await api.Client.Thread.DeleteAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList
**Descrption:** Get message threads from folder. All messages are partly fetched (without email body and some other fields).             


**Returns:** List of threads

**Method call example:**
```csharp
var result = api.Client.Thread.GetList(request);
```

### Parameter: *request*

**Description:** GetList method request.

**See also** parameter model documentation at [**ClientThreadGetListRequest**](ClientThreadGetListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};
```

</details>

### Result

**Description:** List of threads

**Return type:** [**EmailThreadList**](EmailThreadList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new EmailThreadList
{
    Value = new List<EmailThread>
    {
        new EmailThread
        {
            Id = "123",
            Subject = "Some email subject",
            Messages = new List<EmailDto>
            {
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "1",
                    Subject = "Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                },
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "3",
                    Subject = "Re: Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                }
            }
        }
    }
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};

// Call method:
var result = api.Client.Thread.GetList(request);

// Result example:
result = new EmailThreadList
{
    Value = new List<EmailThread>
    {
        new EmailThread
        {
            Id = "123",
            Subject = "Some email subject",
            Messages = new List<EmailDto>
            {
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "1",
                    Subject = "Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                },
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "3",
                    Subject = "Re: Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                }
            }
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
## GetListAsync

**Description:** Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of threads

**Method call example:**
```csharp
var result = await api.Client.Thread.GetListAsync(request);
```

### Parameter: *request*

**Description:** GetListAsync method request.

**See also** parameter model documentation at [**ClientThreadGetListRequest**](ClientThreadGetListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};
```

</details>

### Result

**Returns:** List of threads

**Return type:** [**EmailThreadList**](EmailThreadList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new EmailThreadList
{
    Value = new List<EmailThread>
    {
        new EmailThread
        {
            Id = "123",
            Subject = "Some email subject",
            Messages = new List<EmailDto>
            {
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "1",
                    Subject = "Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                },
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "3",
                    Subject = "Re: Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                }
            }
        }
    }
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};

// Call method:
var result = await api.Client.Thread.GetListAsync(request);

result = new EmailThreadList
{
    Value = new List<EmailThread>
    {
        new EmailThread
        {
            Id = "123",
            Subject = "Some email subject",
            Messages = new List<EmailDto>
            {
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "1",
                    Subject = "Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                },
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "3",
                    Subject = "Re: Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                }
            }
        }
    }
};

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetMessages"></a>
## GetMessages
**Descrption:** Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             


**Returns:** Requested thread with fully fetched messages

**Method call example:**
```csharp
var result = api.Client.Thread.GetMessages(request);
```

### Parameter: *request*

**Description:** GetMessages method request.

**See also** parameter model documentation at [**ClientThreadGetMessagesRequest**](ClientThreadGetMessagesRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadGetMessagesRequest
{ 
    ThreadId = "5",
    Account = "email.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};
```

</details>

### Result

**Description:** Requested thread with fully fetched messages

**Return type:** [**EmailList**](EmailList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadGetMessagesRequest
{ 
    ThreadId = "5",
    Account = "email.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};

// Call method:
var result = api.Client.Thread.GetMessages(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMessagesAsync"></a>
## GetMessagesAsync

**Description:** Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Requested thread with fully fetched messages

**Method call example:**
```csharp
var result = await api.Client.Thread.GetMessagesAsync(request);
```

### Parameter: *request*

**Description:** GetMessagesAsync method request.

**See also** parameter model documentation at [**ClientThreadGetMessagesRequest**](ClientThreadGetMessagesRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadGetMessagesRequest
{ 
    ThreadId = "5",
    Account = "email.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};
```

</details>

### Result

**Returns:** Requested thread with fully fetched messages

**Return type:** [**EmailList**](EmailList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadGetMessagesRequest
{ 
    ThreadId = "5",
    Account = "email.account",
    Folder = "INBOX",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage"
};

// Call method:
var result = await api.Client.Thread.GetMessagesAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Move"></a>
## Move

**Description**: Move thread to another folder.             


**Method call example:**
```csharp
api.Client.Thread.Move(request);
```

### Parameter: *request*

**Description:** Move thread request.

**See also** parameter model documentation at [**ClientThreadMoveRequest**](ClientThreadMoveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    SourceFolder = "INBOX",
    ThreadId = "5",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    SourceFolder = "INBOX",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
api.Client.Thread.Move(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveAsync"></a>
## MoveAsync

**Description:** Move thread to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Thread.MoveAsync(request);
```

### Parameter: *request*

**Description:** Move thread request.

**See also** parameter model documentation at [**ClientThreadMoveRequest**](ClientThreadMoveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    SourceFolder = "INBOX",
    ThreadId = "5",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    SourceFolder = "INBOX",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await api.Client.Thread.MoveAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SetIsRead"></a>
## SetIsRead

**Description**: Mark all messages in thread as read or unread.             


**Method call example:**
```csharp
api.Client.Thread.SetIsRead(request);
```

### Parameter: *request*

**Description:** Email account specifier and IsRead flag.

**See also** parameter model documentation at [**ClientThreadSetIsReadRequest**](ClientThreadSetIsReadRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadSetIsReadRequest
{
    IsRead = true,
    Folder = "INBOX",
    ThreadId = "5",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadSetIsReadRequest
{
    IsRead = true,
    Folder = "INBOX",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
api.Client.Thread.SetIsRead(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
## SetIsReadAsync

**Description:** Mark all messages in thread as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Client.Thread.SetIsReadAsync(request);
```

### Parameter: *request*

**Description:** Email account specifier and IsRead flag.

**See also** parameter model documentation at [**ClientThreadSetIsReadRequest**](ClientThreadSetIsReadRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadSetIsReadRequest
{
    IsRead = true,
    Folder = "INBOX",
    ThreadId = "5",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new ClientThreadSetIsReadRequest
{
    IsRead = true,
    Folder = "INBOX",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await api.Client.Thread.SetIsReadAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
