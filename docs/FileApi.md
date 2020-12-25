# FileApi (EmailCloud.CloudStorage.File)

File operations controller

<a name="CopyFile"></a>
## CopyFile
**Descrption:** Copy file


**Method call example:**
```csharp
api.CloudStorage.File.CopyFile(request);
```

### Parameter: *request*

**Description:** CopyFile method request.

**See also** parameter model documentation at [**CopyFileRequest**](CopyFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CopyFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new CopyFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
api.CloudStorage.File.CopyFile(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CopyFileAsync"></a>
## CopyFileAsync

**Description:** Copy file

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.File.CopyFileAsync(request);
```

### Parameter: *request*

**Description:** CopyFileAsync method request.

**See also** parameter model documentation at [**CopyFileRequest**](CopyFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CopyFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new CopyFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
await api.CloudStorage.File.CopyFileAsync(request);


```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DeleteFile"></a>
## DeleteFile
**Descrption:** Delete file


**Method call example:**
```csharp
api.CloudStorage.File.DeleteFile(request);
```

### Parameter: *request*

**Description:** DeleteFile method request.

**See also** parameter model documentation at [**DeleteFileRequest**](DeleteFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
api.CloudStorage.File.DeleteFile(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DeleteFileAsync"></a>
## DeleteFileAsync

**Description:** Delete file

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.File.DeleteFileAsync(request);
```

### Parameter: *request*

**Description:** DeleteFileAsync method request.

**See also** parameter model documentation at [**DeleteFileRequest**](DeleteFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new DeleteFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
await api.CloudStorage.File.DeleteFileAsync(request);


```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="DownloadFile"></a>
## DownloadFile
**Descrption:** Download file


**Returns:** The raw data of the file.

**Method call example:**
```csharp
var result = api.CloudStorage.File.DownloadFile(request);
```

### Parameter: *request*

**Description:** DownloadFile method request.

**See also** parameter model documentation at [**DownloadFileRequest**](DownloadFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};
```

</details>

### Result

**Description:** The raw data of the file.

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
var result = api.CloudStorage.File.DownloadFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="DownloadFileAsync"></a>
## DownloadFileAsync

**Description:** Download file

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** The raw data of the file.

**Method call example:**
```csharp
var result = await api.CloudStorage.File.DownloadFileAsync(request);
```

### Parameter: *request*

**Description:** DownloadFileAsync method request.

**See also** parameter model documentation at [**DownloadFileRequest**](DownloadFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};
```

</details>

### Result

**Returns:** The raw data of the file.

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new DownloadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
var result = await api.CloudStorage.File.DownloadFileAsync(request);

using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="MoveFile"></a>
## MoveFile
**Descrption:** Move file


**Method call example:**
```csharp
api.CloudStorage.File.MoveFile(request);
```

### Parameter: *request*

**Description:** MoveFile method request.

**See also** parameter model documentation at [**MoveFileRequest**](MoveFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
api.CloudStorage.File.MoveFile(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MoveFileAsync"></a>
## MoveFileAsync

**Description:** Move file

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.CloudStorage.File.MoveFileAsync(request);
```

### Parameter: *request*

**Description:** MoveFileAsync method request.

**See also** parameter model documentation at [**MoveFileRequest**](MoveFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MoveFileRequest
{ 
    SrcPath = "/storage/path/to/source/file.ext",
    DestPath = "/storage/path/to/destination/file.ext",
    SrcStorageName = "First Storage",
    DestStorageName = "Other Storage"
};

// Call method:
await api.CloudStorage.File.MoveFileAsync(request);


```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="UploadFile"></a>
## UploadFile
**Descrption:** Upload file


**Returns:** Empty error list if the upload is successful.

**Method call example:**
```csharp
var result = api.CloudStorage.File.UploadFile(request);
```

### Parameter: *request*

**Description:** UploadFile method request.

**See also** parameter model documentation at [**UploadFileRequest**](UploadFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};
```

</details>

### Result

**Description:** Empty error list if the upload is successful.

**Return type:** [**FilesUploadResult**](FilesUploadResult.md)

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
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};

// Call method:
var result = api.CloudStorage.File.UploadFile(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="UploadFileAsync"></a>
## UploadFileAsync

**Description:** Upload file

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Empty error list if the upload is successful.

**Method call example:**
```csharp
var result = await api.CloudStorage.File.UploadFileAsync(request);
```

### Parameter: *request*

**Description:** UploadFileAsync method request.

**See also** parameter model documentation at [**UploadFileRequest**](UploadFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};
```

</details>

### Result

**Returns:** Empty error list if the upload is successful.

**Return type:** [**FilesUploadResult**](FilesUploadResult.md)

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
var request = new UploadFileRequest
{ 
    Path = "/storage/path/to/file.ext",
    File = new MemoryStream(File.ReadAllBytes("/local/file/system/path/to/file.ext")),
    StorageName = "First Storage"
};

// Call method:
var result = await api.CloudStorage.File.UploadFileAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
