# StorageApi (EmailCloud.CloudStorage.Storage)

Storage operations controller

<a name="GetDiscUsage"></a>
## GetDiscUsage

Get disc usage

Returns: Disc usage.

Method call example:
```csharp
var result = api.CloudStorage.Storage.GetDiscUsage(request);
```

### request Parameter

GetDiscUsage method request.

See parameter model documentation at [GetDiscUsageRequest](GetDiscUsageRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new GetDiscUsageRequest
{ 
    StorageName = "First Storage"
};
```

</details>

### Result

*Returns:* Disc usage.

*Return type:* [**DiscUsage**](DiscUsage.md)

<details>
    <summary>Result example</summary>

```csharp
result = new DiscUsage
{
    UsedSize = 1048576,
    TotalSize = 3145728
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new GetDiscUsageRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = api.CloudStorage.Storage.GetDiscUsage(request);

// Result example:
result = new DiscUsage
{
    UsedSize = 1048576,
    TotalSize = 3145728
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetDiscUsageAsync"></a>
## GetDiscUsageAsync

Get disc usage

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Disc usage.

Method call example:
```csharp
var result = await api.CloudStorage.Storage.GetDiscUsageAsync(request);
```

### request Parameter

GetDiscUsageAsync method request.

See parameter model documentation at [GetDiscUsageRequest](GetDiscUsageRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new GetDiscUsageRequest
{ 
    StorageName = "First Storage"
};
```

</details>

### Result

*Returns:* Disc usage.

*Return type:* [**DiscUsage**](DiscUsage.md)

<details>
    <summary>Result example</summary>

```csharp
result = new DiscUsage
{
    UsedSize = 1048576,
    TotalSize = 3145728
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new GetDiscUsageRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = await api.CloudStorage.Storage.GetDiscUsageAsync(request);

// Result example:
result = new DiscUsage
{
    UsedSize = 1048576,
    TotalSize = 3145728
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetFileVersions"></a>
## GetFileVersions

Get file versions

Returns: File versions.

Method call example:
```csharp
var result = api.CloudStorage.Storage.GetFileVersions(request);
```

### request Parameter

GetFileVersions method request.

See parameter model documentation at [GetFileVersionsRequest](GetFileVersionsRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};
```

</details>

### Result

*Returns:* File versions.

*Return type:* [**FileVersions**](FileVersions.md)

<details>
    <summary>Result example</summary>

```csharp
result = new FileVersions
{
    Value = new List<FileVersion>
    {
        new FileVersion
        {
            VersionId = "d5afd857-8797-4ca0-b806-a03fdfc3831f",
            IsLatest = true,
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 4096,
            Path = "/storage/path/to"
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
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
var result = api.CloudStorage.Storage.GetFileVersions(request);

// Result example:
result = new FileVersions
{
    Value = new List<FileVersion>
    {
        new FileVersion
        {
            VersionId = "d5afd857-8797-4ca0-b806-a03fdfc3831f",
            IsLatest = true,
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 4096,
            Path = "/storage/path/to"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetFileVersionsAsync"></a>
## GetFileVersionsAsync

Get file versions

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File versions.

Method call example:
```csharp
var result = await api.CloudStorage.Storage.GetFileVersionsAsync(request);
```

### request Parameter

GetFileVersionsAsync method request.

See parameter model documentation at [GetFileVersionsRequest](GetFileVersionsRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};
```

</details>

### Result

*Returns:* File versions.

*Return type:* [**FileVersions**](FileVersions.md)

<details>
    <summary>Result example</summary>

```csharp
result = new FileVersions
{
    Value = new List<FileVersion>
    {
        new FileVersion
        {
            VersionId = "d5afd857-8797-4ca0-b806-a03fdfc3831f",
            IsLatest = true,
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 4096,
            Path = "/storage/path/to"
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
var request = new GetFileVersionsRequest
{ 
    Path = "/storage/path/to/file.ext",
    StorageName = "First Storage"
};

// Call method:
var result = await api.CloudStorage.Storage.GetFileVersionsAsync(request);

// Result example:
result = new FileVersions
{
    Value = new List<FileVersion>
    {
        new FileVersion
        {
            VersionId = "d5afd857-8797-4ca0-b806-a03fdfc3831f",
            IsLatest = true,
            Name = "file.ext",
            ModifiedDate = DateTime.Today,
            Size = 4096,
            Path = "/storage/path/to"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ObjectExists"></a>
## ObjectExists

Check if file or folder exists

Returns: Object exist result.

Method call example:
```csharp
var result = api.CloudStorage.Storage.ObjectExists(request);
```

### request Parameter

ObjectExists method request.

See parameter model documentation at [ObjectExistsRequest](ObjectExistsRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage",
};
```

</details>

### Result

*Returns:* Object exist result.

*Return type:* [**ObjectExist**](ObjectExist.md)

<details>
    <summary>Result example</summary>

```csharp
result = new ObjectExist
{
    Exists = true
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage",
};

// Call method:
var result = api.CloudStorage.Storage.ObjectExists(request);

// Result example:
result = new ObjectExist
{
    Exists = true
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ObjectExistsAsync"></a>
## ObjectExistsAsync

Check if file or folder exists

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Object exist result.

Method call example:
```csharp
var result = await api.CloudStorage.Storage.ObjectExistsAsync(request);
```

### request Parameter

ObjectExistsAsync method request.

See parameter model documentation at [ObjectExistsRequest](ObjectExistsRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage",
};
```

</details>

### Result

*Returns:* Object exist result.

*Return type:* [**ObjectExist**](ObjectExist.md)

<details>
    <summary>Result example</summary>

```csharp
result = new ObjectExist
{
    Exists = true
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new ObjectExistsRequest
{ 
    Path = "/storage/path/to/folder/or/file.ext",
    StorageName = "First Storage",
};

// Call method:
var result = await api.CloudStorage.Storage.ObjectExistsAsync(request);

// Result example:
result = new ObjectExist
{
    Exists = true
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Exists"></a>
## Exists

Check if storage exists

Returns: Storage exist result.

Method call example:
```csharp
var result = api.CloudStorage.Storage.Exists(request);
```

### request Parameter

Exists method request.

See parameter model documentation at [StorageExistsRequest](StorageExistsRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new StorageExistsRequest
{ 
    StorageName = "First Storage"
};
```

</details>

### Result

*Returns:* Storage exist result.

*Return type:* [**StorageExist**](StorageExist.md)

<details>
    <summary>Result example</summary>

```csharp
result = new StorageExist
{
    Exists = true
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new StorageExistsRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = api.CloudStorage.Storage.Exists(request);

// Result example:
result = new StorageExist
{
    Exists = true
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExistsAsync"></a>
## ExistsAsync

Check if storage exists

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Storage exist result.

Method call example:
```csharp
var result = await api.CloudStorage.Storage.ExistsAsync(request);
```

### request Parameter

ExistsAsync method request.

See parameter model documentation at [StorageExistsRequest](StorageExistsRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new StorageExistsRequest
{ 
    StorageName = "First Storage"
};
```

</details>

### Result

*Returns:* Storage exist result.

*Return type:* [**StorageExist**](StorageExist.md)

<details>
    <summary>Result example</summary>

```csharp
result = new StorageExist
{
    Exists = true
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new StorageExistsRequest
{ 
    StorageName = "First Storage"
};

// Call method:
var result = await api.CloudStorage.Storage.ExistsAsync(request);

// Result example:
result = new StorageExist
{
    Exists = true
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
