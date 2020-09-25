# Aspose.Email.Cloud.Sdk.ClientFolderApi

<a name="Create"></a>
# Create

Create new folder in email account             

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

### request Parameter
See parameter model documentation at [ClientFolderCreateRequest](ClientFolderCreateRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateAsync"></a>
# CreateAsync

Create new folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [ClientFolderCreateRequest](ClientFolderCreateRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Delete"></a>
# Delete

Delete a folder in email account             

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

### request Parameter
See parameter model documentation at [ClientFolderDeleteRequest](ClientFolderDeleteRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteAsync"></a>
# DeleteAsync

Delete a folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [ClientFolderDeleteRequest](ClientFolderDeleteRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
# GetList

Get folders list in email account             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

### Return type

[**MailServerFolderList**](MailServerFolderList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

Get folders list in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| Email account | 
 **storage** | **string**| Storage name where account file located | [optional] 
 **accountStorageFolder** | **string**| Folder in storage where account file located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

### Return type

[**MailServerFolderList**](MailServerFolderList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
