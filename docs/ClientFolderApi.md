# ClientFolderApi (EmailCloud.Client.Folder)

Email client folder operations.

<a name="Create"></a>
## Create

**Description**: Create new folder in email account             


**Returns:** Returns 200 if create is successful.

**Method call example:**
```csharp
api.Client.Folder.Create(request);
```

### Parameter: *request*

**Description:** Create folder request

**See also** parameter model documentation at [**ClientFolderCreateRequest**](ClientFolderCreateRequest.md)

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

**Description:** Returns 200 if create is successful.

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Folder.Create(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateAsync"></a>
## CreateAsync

**Description:** Create new folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Returns 200 if create is successful.

**Method call example:**
```csharp
await api.Client.Folder.CreateAsync(request);
```

### Parameter: *request*

**Description:** Create folder request

**See also** parameter model documentation at [**ClientFolderCreateRequest**](ClientFolderCreateRequest.md)

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

**Description:** Returns 200 if create is successful.

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Folder.CreateAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Delete"></a>
## Delete

**Description**: Delete a folder in email account             


**Returns:** Returns 200 if delete is successful.

**Method call example:**
```csharp
api.Client.Folder.Delete(request);
```

### Parameter: *request*

**Description:** Delete folder request

**See also** parameter model documentation at [**ClientFolderDeleteRequest**](ClientFolderDeleteRequest.md)

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

**Description:** Returns 200 if delete is successful.

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Client.Folder.Delete(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
## DeleteAsync

**Description:** Delete a folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Returns 200 if delete is successful.

**Method call example:**
```csharp
await api.Client.Folder.DeleteAsync(request);
```

### Parameter: *request*

**Description:** Delete folder request

**See also** parameter model documentation at [**ClientFolderDeleteRequest**](ClientFolderDeleteRequest.md)

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

**Description:** Returns 200 if delete is successful.

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Client.Folder.DeleteAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList
**Descrption:** Get folders list in email account             


**Returns:** Folders list

**Method call example:**
```csharp
var result = api.Client.Folder.GetList(request);
```

### Parameter: *request*

**Description:** GetList method request.

**See also** parameter model documentation at [**ClientFolderGetListRequest**](ClientFolderGetListRequest.md)

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

**Description:** Folders list

**Return type:** [**MailServerFolderList**](MailServerFolderList.md)

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
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};

// Call method:
var result = api.Client.Folder.GetList(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
## GetListAsync

**Description:** Get folders list in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Folders list

**Method call example:**
```csharp
var result = await api.Client.Folder.GetListAsync(request);
```

### Parameter: *request*

**Description:** GetListAsync method request.

**See also** parameter model documentation at [**ClientFolderGetListRequest**](ClientFolderGetListRequest.md)

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

**Returns:** Folders list

**Return type:** [**MailServerFolderList**](MailServerFolderList.md)

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
var request = new ClientFolderGetListRequest
{ 
    Account = "email.multi.account",
    Storage = "First Storage",
    AccountStorageFolder = "email/account/location/on/storage",
    ParentFolder = "INBOX"
};

// Call method:
var result = await api.Client.Folder.GetListAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
