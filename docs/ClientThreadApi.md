# Aspose.Email.Cloud.Sdk.ClientThreadApi

<a name="Delete"></a>
# Delete

Delete thread by id. All messages from thread will also be deleted.             

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

### request Parameter
See parameter model documentation at [ClientThreadDeleteRequest](ClientThreadDeleteRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
# DeleteAsync

Delete thread by id. All messages from thread will also be deleted.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [ClientThreadDeleteRequest](ClientThreadDeleteRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
# GetList

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account.              | 
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **updateFolderCache** | **bool?**| This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              | [optional] [default to true]
 **messagesCacheLimit** | **int?**| Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              | [optional] [default to 200]

### Return type

[**EmailThreadList**](EmailThreadList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

Get message threads from folder. All messages are partly fetched (without email body and some other fields).             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account.              | 
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **updateFolderCache** | **bool?**| This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              | [optional] [default to true]
 **messagesCacheLimit** | **int?**| Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              | [optional] [default to 200]

### Return type

[**EmailThreadList**](EmailThreadList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetMessages"></a>
# GetMessages

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Specifies account folder to get thread from              | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 

### Return type

[**EmailList**](EmailList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetMessagesAsync"></a>
# GetMessagesAsync

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **account** | **string**| Email account | 
 **folder** | **string**| Specifies account folder to get thread from              | [optional] 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 

### Return type

[**EmailList**](EmailList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Move"></a>
# Move

Move thread to another folder.             

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

### request Parameter
See parameter model documentation at [ClientThreadMoveRequest](ClientThreadMoveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveAsync"></a>
# MoveAsync

Move thread to another folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [ClientThreadMoveRequest](ClientThreadMoveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="SetIsRead"></a>
# SetIsRead

Mark all messages in thread as read or unread.             

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

### request Parameter
See parameter model documentation at [ClientThreadSetIsReadRequest](ClientThreadSetIsReadRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SetIsReadAsync"></a>
# SetIsReadAsync

Mark all messages in thread as read or unread.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [ClientThreadSetIsReadRequest](ClientThreadSetIsReadRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
