# FolderApi (EmailCloud.CloudStorage.Folder)

Folder operations controller

<a name="CopyFolder"></a>
## CopyFolder
**Descrption:** Copy folder


**Method call example:**
```csharp
api.CloudStorage.Folder.CopyFolder(request);
```

### Parameter: *request*

**Description:** CopyFolder method request.

**See also** parameter model documentation at [**CopyFolderRequest**](CopyFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
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
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
api.CloudStorage.Folder.CopyFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CopyFolderAsync"></a>
## CopyFolderAsync

**Description:** Copy folder

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.Folder.CopyFolderAsync(request);
```

### Parameter: *request*

**Description:** CopyFolderAsync method request.

**See also** parameter model documentation at [**CopyFolderRequest**](CopyFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
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
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
await api.CloudStorage.Folder.CopyFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="CreateFolder"></a>
## CreateFolder
**Descrption:** Create the folder


**Method call example:**
```csharp
api.CloudStorage.Folder.CreateFolder(request);
```

### Parameter: *request*

**Description:** CreateFolder method request.

**See also** parameter model documentation at [**CreateFolderRequest**](CreateFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
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
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
};

// Call method:
api.CloudStorage.Folder.CreateFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateFolderAsync"></a>
## CreateFolderAsync

**Description:** Create the folder

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.Folder.CreateFolderAsync(request);
```

### Parameter: *request*

**Description:** CreateFolderAsync method request.

**See also** parameter model documentation at [**CreateFolderRequest**](CreateFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
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
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
};

// Call method:
await api.CloudStorage.Folder.CreateFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DeleteFolder"></a>
## DeleteFolder
**Descrption:** Delete folder


**Method call example:**
```csharp
api.CloudStorage.Folder.DeleteFolder(request);
```

### Parameter: *request*

**Description:** DeleteFolder method request.

**See also** parameter model documentation at [**DeleteFolderRequest**](DeleteFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
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
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
};

// Call method:
api.CloudStorage.Folder.DeleteFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteFolderAsync"></a>
## DeleteFolderAsync

**Description:** Delete folder

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.Folder.DeleteFolderAsync(request);
```

### Parameter: *request*

**Description:** DeleteFolderAsync method request.

**See also** parameter model documentation at [**DeleteFolderRequest**](DeleteFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
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
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
};

// Call method:
await api.CloudStorage.Folder.DeleteFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetFilesList"></a>
## GetFilesList
**Descrption:** Get all files and folders within a folder


**Returns:** Returns all files and folders contained by the folder.

**Method call example:**
```csharp
var result = api.CloudStorage.Folder.GetFilesList(request);
```

### Parameter: *request*

**Description:** GetFilesList method request.

**See also** parameter model documentation at [**GetFilesListRequest**](GetFilesListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};
```

</details>

### Result

**Description:** Returns all files and folders contained by the folder.

**Return type:** [**FilesList**](FilesList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new FilesList
{
    Value = new List<StorageFile>
    {
        new StorageFile
        {
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 1024,
            Path = "/path/to/file/on/storage"
        }
    }
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};

// Call method:
var result = api.CloudStorage.Folder.GetFilesList(request);

// Result example:
result = new FilesList
{
    Value = new List<StorageFile>
    {
        new StorageFile
        {
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 1024,
            Path = "/path/to/file/on/storage"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetFilesListAsync"></a>
## GetFilesListAsync

**Description:** Get all files and folders within a folder

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Returns all files and folders contained by the folder.

**Method call example:**
```csharp
var result = await api.CloudStorage.Folder.GetFilesListAsync(request);
```

### Parameter: *request*

**Description:** GetFilesListAsync method request.

**See also** parameter model documentation at [**GetFilesListRequest**](GetFilesListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};
```

</details>

### Result

**Returns:** Returns all files and folders contained by the folder.

**Return type:** [**FilesList**](FilesList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new FilesList
{
    Value = new List<StorageFile>
    {
        new StorageFile
        {
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 1024,
            Path = "/path/to/file/on/storage"
        }
    }
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};

// Call method:
var result = await api.CloudStorage.Folder.GetFilesListAsync(request);

// Result example:
result = new FilesList
{
    Value = new List<StorageFile>
    {
        new StorageFile
        {
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 1024,
            Path = "/path/to/file/on/storage"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="MoveFolder"></a>
## MoveFolder
**Descrption:** Move folder


**Method call example:**
```csharp
api.CloudStorage.Folder.MoveFolder(request);
```

### Parameter: *request*

**Description:** MoveFolder method request.

**See also** parameter model documentation at [**MoveFolderRequest**](MoveFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
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
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
api.CloudStorage.Folder.MoveFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveFolderAsync"></a>
## MoveFolderAsync

**Description:** Move folder

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.Folder.MoveFolderAsync(request);
```

### Parameter: *request*

**Description:** MoveFolderAsync method request.

**See also** parameter model documentation at [**MoveFolderRequest**](MoveFolderRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
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
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
await api.CloudStorage.Folder.MoveFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
