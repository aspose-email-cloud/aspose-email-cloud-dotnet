# Aspose.Email.Cloud.Sdk.ClientThreadApi

<a name="Delete"></a>
## Delete

Delete thread by id. All messages from thread will also be deleted.             

Returns: Returns 200 if delete is successful.

Method call example:
```csharp
Api.Client.Thread.Delete(request);
```

### request Parameter

Delete email thread request.

See parameter model documentation at [ClientThreadDeleteRequest](ClientThreadDeleteRequest.md)

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

*Returns:* Returns 200 if delete is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
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
Api.Client.Thread.Delete(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
## DeleteAsync

Delete thread by id. All messages from thread will also be deleted.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if delete is successful.

Method call example:
```csharp
await Api.Client.Thread.DeleteAsync(request);
```

### request Parameter

Delete email thread request.

See parameter model documentation at [ClientThreadDeleteRequest](ClientThreadDeleteRequest.md)

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

*Returns:* Returns 200 if delete is successful.

*Return type:* Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
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
await Api.Client.Thread.DeleteAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

Returns: List of threads

Method call example:
```csharp
var result = Api.Client.Thread.GetList(request);
```

### request Parameter

GetList method request.

See parameter model documentation at [ClientThreadGetListRequest](ClientThreadGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
};
```

</details>

### Result

*Returns:* List of threads

*Return type:* [**EmailThreadList**](EmailThreadList.md)

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
// Prepare parameters:
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
};

// Call method:
var result = Api.Client.Thread.GetList(request);

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

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: List of threads

Method call example:
```csharp
var result = await Api.Client.Thread.GetListAsync(request);
```

### request Parameter

GetListAsync method request.

See parameter model documentation at [ClientThreadGetListRequest](ClientThreadGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
};
```

</details>

### Result

*Returns:* List of threads

*Return type:* [**EmailThreadList**](EmailThreadList.md)

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
// Prepare parameters:
var request = new ClientThreadGetListRequest
{ 
    Folder = "INBOX/SubFolder",
    Account = "email.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
};

// Call method:
var result = await Api.Client.Thread.GetListAsync(request);

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
<a name="GetMessages"></a>
## GetMessages

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Returns: Requested thread with fully fetched messages

Method call example:
```csharp
var result = Api.Client.Thread.GetMessages(request);
```

### request Parameter

GetMessages method request.

See parameter model documentation at [ClientThreadGetMessagesRequest](ClientThreadGetMessagesRequest.md)

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

*Returns:* Requested thread with fully fetched messages

*Return type:* [**EmailList**](EmailList.md)

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
var result = Api.Client.Thread.GetMessages(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMessagesAsync"></a>
## GetMessagesAsync

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Requested thread with fully fetched messages

Method call example:
```csharp
var result = await Api.Client.Thread.GetMessagesAsync(request);
```

### request Parameter

GetMessagesAsync method request.

See parameter model documentation at [ClientThreadGetMessagesRequest](ClientThreadGetMessagesRequest.md)

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

*Returns:* Requested thread with fully fetched messages

*Return type:* [**EmailList**](EmailList.md)

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
var result = await Api.Client.Thread.GetMessagesAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Move"></a>
## Move

Move thread to another folder.             

Returns: Returns 200 if move is successful.

Method call example:
```csharp
Api.Client.Thread.Move(request);
```

### request Parameter

Move thread request.

See parameter model documentation at [ClientThreadMoveRequest](ClientThreadMoveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
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

*Returns:* Returns 200 if move is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Thread.Move(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveAsync"></a>
## MoveAsync

Move thread to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if move is successful.

Method call example:
```csharp
await Api.Client.Thread.MoveAsync(request);
```

### request Parameter

Move thread request.

See parameter model documentation at [ClientThreadMoveRequest](ClientThreadMoveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
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

*Returns:* Returns 200 if move is successful.

*Return type:* Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientThreadMoveRequest
{
    DestinationFolder = "INBOX/SubFolder",
    ThreadId = "5",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Thread.MoveAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SetIsRead"></a>
## SetIsRead

Mark all messages in thread as read or unread.             

Returns: Returns 200 if flag set is successful.

Method call example:
```csharp
Api.Client.Thread.SetIsRead(request);
```

### request Parameter

Email account specifier and IsRead flag.

See parameter model documentation at [ClientThreadSetIsReadRequest](ClientThreadSetIsReadRequest.md)

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

*Returns:* Returns 200 if flag set is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
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
Api.Client.Thread.SetIsRead(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
## SetIsReadAsync

Mark all messages in thread as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if flag set is successful.

Method call example:
```csharp
await Api.Client.Thread.SetIsReadAsync(request);
```

### request Parameter

Email account specifier and IsRead flag.

See parameter model documentation at [ClientThreadSetIsReadRequest](ClientThreadSetIsReadRequest.md)

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

*Returns:* Returns 200 if flag set is successful.

*Return type:* Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
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
await Api.Client.Thread.SetIsReadAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
