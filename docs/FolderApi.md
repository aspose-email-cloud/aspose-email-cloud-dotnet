# Aspose.Email.Cloud.Sdk.FolderApi

<a name="CopyFolder"></a>
## CopyFolder

Copy folder

Returns: Returns 200 if the copy is successful.

Method call example:
```csharp
Api.CloudStorage.Folder.CopyFolder(request);
```

### request Parameter

CopyFolder method request.

See parameter model documentation at [CopyFolderRequest](CopyFolderRequest.md)

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

*Returns:* Returns 200 if the copy is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
Api.CloudStorage.Folder.CopyFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CopyFolderAsync"></a>
## CopyFolderAsync

Copy folder

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if the copy is successful.

Method call example:
```csharp
await Api.CloudStorage.Folder.CopyFolderAsync(request);
```

### request Parameter

CopyFolderAsync method request.

See parameter model documentation at [CopyFolderRequest](CopyFolderRequest.md)

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

*Returns:* Returns 200 if the copy is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CopyFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
await Api.CloudStorage.Folder.CopyFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="CreateFolder"></a>
## CreateFolder

Create the folder

Returns: Returns 200 if the create is successful.

Method call example:
```csharp
Api.CloudStorage.Folder.CreateFolder(request);
```

### request Parameter

CreateFolder method request.

See parameter model documentation at [CreateFolderRequest](CreateFolderRequest.md)

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

*Returns:* Returns 200 if the create is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
};

// Call method:
Api.CloudStorage.Folder.CreateFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CreateFolderAsync"></a>
## CreateFolderAsync

Create the folder

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if the create is successful.

Method call example:
```csharp
await Api.CloudStorage.Folder.CreateFolderAsync(request);
```

### request Parameter

CreateFolderAsync method request.

See parameter model documentation at [CreateFolderRequest](CreateFolderRequest.md)

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

*Returns:* Returns 200 if the create is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CreateFolderRequest
{ 
    Path = "/storage/path/to/new/folder",
    StorageName = "First Storage"
};

// Call method:
await Api.CloudStorage.Folder.CreateFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DeleteFolder"></a>
## DeleteFolder

Delete folder

Returns: Returns 200 if the delete is successful.

Method call example:
```csharp
Api.CloudStorage.Folder.DeleteFolder(request);
```

### request Parameter

DeleteFolder method request.

See parameter model documentation at [DeleteFolderRequest](DeleteFolderRequest.md)

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

*Returns:* Returns 200 if the delete is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
};

// Call method:
Api.CloudStorage.Folder.DeleteFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteFolderAsync"></a>
## DeleteFolderAsync

Delete folder

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if the delete is successful.

Method call example:
```csharp
await Api.CloudStorage.Folder.DeleteFolderAsync(request);
```

### request Parameter

DeleteFolderAsync method request.

See parameter model documentation at [DeleteFolderRequest](DeleteFolderRequest.md)

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

*Returns:* Returns 200 if the delete is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DeleteFolderRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage",
    Recursive = true
};

// Call method:
await Api.CloudStorage.Folder.DeleteFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetFilesList"></a>
## GetFilesList

Get all files and folders within a folder

Returns: Returns all files and folders contained by the folder.

Method call example:
```csharp
var result = Api.CloudStorage.Folder.GetFilesList(request);
```

### request Parameter

GetFilesList method request.

See parameter model documentation at [GetFilesListRequest](GetFilesListRequest.md)

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

*Returns:* Returns all files and folders contained by the folder.

*Return type:* [**FilesList**](FilesList.md)

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
// Prepare parameters:
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};

// Call method:
var result = Api.CloudStorage.Folder.GetFilesList(request);

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

Get all files and folders within a folder

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns all files and folders contained by the folder.

Method call example:
```csharp
var result = await Api.CloudStorage.Folder.GetFilesListAsync(request);
```

### request Parameter

GetFilesListAsync method request.

See parameter model documentation at [GetFilesListRequest](GetFilesListRequest.md)

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

*Returns:* Returns all files and folders contained by the folder.

*Return type:* [**FilesList**](FilesList.md)

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
// Prepare parameters:
var request = new GetFilesListRequest
{ 
    Path = "/storage/path/to/folder",
    StorageName = "First Storage"
};

// Call method:
var result = await Api.CloudStorage.Folder.GetFilesListAsync(request);

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

Move folder

Returns: Returns 200 if the move is successful.

Method call example:
```csharp
Api.CloudStorage.Folder.MoveFolder(request);
```

### request Parameter

MoveFolder method request.

See parameter model documentation at [MoveFolderRequest](MoveFolderRequest.md)

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

*Returns:* Returns 200 if the move is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
Api.CloudStorage.Folder.MoveFolder(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveFolderAsync"></a>
## MoveFolderAsync

Move folder

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if the move is successful.

Method call example:
```csharp
await Api.CloudStorage.Folder.MoveFolderAsync(request);
```

### request Parameter

MoveFolderAsync method request.

See parameter model documentation at [MoveFolderRequest](MoveFolderRequest.md)

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

*Returns:* Returns 200 if the move is successful.

*Return type:* void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MoveFolderRequest
{ 
    SrcPath = "/storage/path/to/source/folder",
    DestPath = "/storage/path/to/destination/folder",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
await Api.CloudStorage.Folder.MoveFolderAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
