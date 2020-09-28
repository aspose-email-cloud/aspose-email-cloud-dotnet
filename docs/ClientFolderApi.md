# Aspose.Email.Cloud.Sdk.ClientFolderApi

<a name="Create"></a>
## Create

Create new folder in email account             

Returns: Returns 200 if create is successful.

Method call example:
```csharp
Api.Client.Folder.Create(request);
```

### request Parameter

Create folder request

See parameter model documentation at [ClientFolderCreateRequest](ClientFolderCreateRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientFolderCreateRequest
{
    ParentFolder = "INBOX/SubFolder/ParentFolder",
    FolderName = "NewFolder",
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

*Returns:* Returns 200 if create is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientFolderCreateRequest
{
    ParentFolder = "INBOX/SubFolder/ParentFolder",
    FolderName = "NewFolder",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Folder.Create(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateAsync"></a>
## CreateAsync

Create new folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if create is successful.

Method call example:
```csharp
await Api.Client.Folder.CreateAsync(request);
```

### request Parameter

Create folder request

See parameter model documentation at [ClientFolderCreateRequest](ClientFolderCreateRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientFolderCreateRequest
{
    ParentFolder = "INBOX/SubFolder/ParentFolder",
    FolderName = "NewFolder",
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

*Returns:* Returns 200 if create is successful.

*Return type:* Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ClientFolderCreateRequest
{
    ParentFolder = "INBOX/SubFolder/ParentFolder",
    FolderName = "NewFolder",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Folder.CreateAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Delete"></a>
## Delete

Delete a folder in email account             

Returns: Returns 200 if delete is successful.

Method call example:
```csharp
Api.Client.Folder.Delete(request);
```

### request Parameter

Delete folder request

See parameter model documentation at [ClientFolderDeleteRequest](ClientFolderDeleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientFolderDeleteRequest
{
    Folder = "INBOX/SubFolder/FolderToDelete",
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
var request = new ClientFolderDeleteRequest
{
    Folder = "INBOX/SubFolder/FolderToDelete",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
Api.Client.Folder.Delete(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
## DeleteAsync

Delete a folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if delete is successful.

Method call example:
```csharp
await Api.Client.Folder.DeleteAsync(request);
```

### request Parameter

Delete folder request

See parameter model documentation at [ClientFolderDeleteRequest](ClientFolderDeleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientFolderDeleteRequest
{
    Folder = "INBOX/SubFolder/FolderToDelete",
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
var request = new ClientFolderDeleteRequest
{
    Folder = "INBOX/SubFolder/FolderToDelete",
    AccountLocation = new StorageFileLocation
    {
        FileName = "email.account",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    }
};

// Call method:
await Api.Client.Folder.DeleteAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList

Get folders list in email account             

Returns: Folders list

Method call example:
```csharp
var result = Api.Client.Folder.GetList(request);
```

### request Parameter

GetList method request.

See parameter model documentation at [ClientFolderGetListRequest](ClientFolderGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};
```

</details>

### Result

*Returns:* Folders list

*Return type:* [**MailServerFolderList**](MailServerFolderList.md)

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
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};

// Call method:
var result = Api.Client.Folder.GetList(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
## GetListAsync

Get folders list in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Folders list

Method call example:
```csharp
var result = await Api.Client.Folder.GetListAsync(request);
```

### request Parameter

GetListAsync method request.

See parameter model documentation at [ClientFolderGetListRequest](ClientFolderGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};
```

</details>

### Result

*Returns:* Folders list

*Return type:* [**MailServerFolderList**](MailServerFolderList.md)

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
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};

// Call method:
var result = await Api.Client.Folder.GetListAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
