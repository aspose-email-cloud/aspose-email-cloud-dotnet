# AiBcrApi (EmailCloud.Ai.Bcr)

AI Business card recognition operations.

<a name="Parse"></a>
## Parse
**Descrption:** Parse images to vCard document models             


**Returns:** List of vCards

**Method call example:**
```csharp
var result = api.Ai.Bcr.Parse(request);
```

### Parameter: *request*

**Description:** Parse method request.

**See also** parameter model documentation at [**AiBcrParseRequest**](AiBcrParseRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};
```

</details>

### Result

**Description:** List of vCards

**Return type:** [**ContactList**](ContactList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new ContactList
{
    Value = new List<ContactDto>
    {
        new ContactDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "attachment.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            DisplayName = "Alex Thomas",
            EmailAddresses = new List<EmailAddress>
            {
                new EmailAddress
                {
                    Category = new EnumWithCustom<EmailAddressCategory>
                    {
                        Value = "Custom",
                        Description = "Partners"
                    },
                    DisplayName = "Alex Thomas Partners",
                    Preferred = true,
                    Address = "email@aspose.com"
                }
            },
            Gender = "Male",
            GivenName = "Alex",
            PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber
                {
                    Category = new EnumWithCustom<PhoneNumberCategory>
                    {
                        Value = "Office"
                    },
                    Number = "+49 211 4247 21",
                    Preferred = true
                }
            },
            Profession = "GENERAL DIRECTOR",
            Surname = "Thomas",
            Urls = new List<Url>
            {
                new Url
                {
                    Category = new EnumWithCustom<UrlCategory>
                    {
                        Value = "Work"
                    },
                    Preferred = true,
                    Href = "www.aspose.com"
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
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};

// Call method:
var result = api.Ai.Bcr.Parse(request);

// Result example:
result = new ContactList
{
    Value = new List<ContactDto>
    {
        new ContactDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "attachment.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            DisplayName = "Alex Thomas",
            EmailAddresses = new List<EmailAddress>
            {
                new EmailAddress
                {
                    Category = new EnumWithCustom<EmailAddressCategory>
                    {
                        Value = "Custom",
                        Description = "Partners"
                    },
                    DisplayName = "Alex Thomas Partners",
                    Preferred = true,
                    Address = "email@aspose.com"
                }
            },
            Gender = "Male",
            GivenName = "Alex",
            PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber
                {
                    Category = new EnumWithCustom<PhoneNumberCategory>
                    {
                        Value = "Office"
                    },
                    Number = "+49 211 4247 21",
                    Preferred = true
                }
            },
            Profession = "GENERAL DIRECTOR",
            Surname = "Thomas",
            Urls = new List<Url>
            {
                new Url
                {
                    Category = new EnumWithCustom<UrlCategory>
                    {
                        Value = "Work"
                    },
                    Preferred = true,
                    Href = "www.aspose.com"
                }
            }
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
## ParseAsync

**Description:** Parse images to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of vCards

**Method call example:**
```csharp
var result = await api.Ai.Bcr.ParseAsync(request);
```

### Parameter: *request*

**Description:** ParseAsync method request.

**See also** parameter model documentation at [**AiBcrParseRequest**](AiBcrParseRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};
```

</details>

### Result

**Returns:** List of vCards

**Return type:** [**ContactList**](ContactList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new ContactList
{
    Value = new List<ContactDto>
    {
        new ContactDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "attachment.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            DisplayName = "Alex Thomas",
            EmailAddresses = new List<EmailAddress>
            {
                new EmailAddress
                {
                    Category = new EnumWithCustom<EmailAddressCategory>
                    {
                        Value = "Custom",
                        Description = "Partners"
                    },
                    DisplayName = "Alex Thomas Partners",
                    Preferred = true,
                    Address = "email@aspose.com"
                }
            },
            Gender = "Male",
            GivenName = "Alex",
            PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber
                {
                    Category = new EnumWithCustom<PhoneNumberCategory>
                    {
                        Value = "Office"
                    },
                    Number = "+49 211 4247 21",
                    Preferred = true
                }
            },
            Profession = "GENERAL DIRECTOR",
            Surname = "Thomas",
            Urls = new List<Url>
            {
                new Url
                {
                    Category = new EnumWithCustom<UrlCategory>
                    {
                        Value = "Work"
                    },
                    Preferred = true,
                    Href = "www.aspose.com"
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
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};

// Call method:
var result = await api.Ai.Bcr.ParseAsync(request);

// Result example:
result = new ContactList
{
    Value = new List<ContactDto>
    {
        new ContactDto
        {
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Name = "attachment.txt",
                    Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                }
            },
            DisplayName = "Alex Thomas",
            EmailAddresses = new List<EmailAddress>
            {
                new EmailAddress
                {
                    Category = new EnumWithCustom<EmailAddressCategory>
                    {
                        Value = "Custom",
                        Description = "Partners"
                    },
                    DisplayName = "Alex Thomas Partners",
                    Preferred = true,
                    Address = "email@aspose.com"
                }
            },
            Gender = "Male",
            GivenName = "Alex",
            PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber
                {
                    Category = new EnumWithCustom<PhoneNumberCategory>
                    {
                        Value = "Office"
                    },
                    Number = "+49 211 4247 21",
                    Preferred = true
                }
            },
            Profession = "GENERAL DIRECTOR",
            Surname = "Thomas",
            Urls = new List<Url>
            {
                new Url
                {
                    Category = new EnumWithCustom<UrlCategory>
                    {
                        Value = "Work"
                    },
                    Preferred = true,
                    Href = "www.aspose.com"
                }
            }
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ParseStorage"></a>
## ParseStorage

**Description**: Parse images from storage to vCard files             


**Returns:** List of vCard files located on storage

**Method call example:**
```csharp
var result = api.Ai.Bcr.ParseStorage(request);
```

### Parameter: *request*

**Description:** Request with images located on storage

**See also** parameter model documentation at [**AiBcrParseStorageRequest**](AiBcrParseStorageRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiBcrParseStorageRequest
{
    OutFolder = new StorageFolderLocation
    {
        Storage = "First Storage",
        FolderPath = "VCard/files/produced/by/parser/will/be/placed/here"
    },
    Images = new List<AiBcrImageStorageFile>
    {
        new AiBcrImageStorageFile
        {
            File = new StorageFileLocation
            {
                FileName = "VCardScanImage.jpg",
                Storage = "First Storage",
                FolderPath = "image/location/on/storage"
            },
            IsSingle = true
        }
    }
};
```

</details>


### Result

**Description:** List of vCard files located on storage

**Return type:** [**StorageFileLocationList**](StorageFileLocationList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new StorageFileLocationList
{
    Value = new List<StorageFileLocation>
    {
        new StorageFileLocation
        {
            FileName = "fileOnStorage.txt",
            Storage = "First Storage",
            FolderPath = "file/location/folder/on/storage"
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
var request = new AiBcrParseStorageRequest
{
    OutFolder = new StorageFolderLocation
    {
        Storage = "First Storage",
        FolderPath = "VCard/files/produced/by/parser/will/be/placed/here"
    },
    Images = new List<AiBcrImageStorageFile>
    {
        new AiBcrImageStorageFile
        {
            File = new StorageFileLocation
            {
                FileName = "VCardScanImage.jpg",
                Storage = "First Storage",
                FolderPath = "image/location/on/storage"
            },
            IsSingle = true
        }
    }
};

// Call method:
var result = api.Ai.Bcr.ParseStorage(request);

// Result example:
result = new StorageFileLocationList
{
    Value = new List<StorageFileLocation>
    {
        new StorageFileLocation
        {
            FileName = "fileOnStorage.txt",
            Storage = "First Storage",
            FolderPath = "file/location/folder/on/storage"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseStorageAsync"></a>
## ParseStorageAsync

**Description:** Parse images from storage to vCard files             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of vCard files located on storage

**Method call example:**
```csharp
var result = await api.Ai.Bcr.ParseStorageAsync(request);
```

### Parameter: *request*

**Description:** Request with images located on storage

**See also** parameter model documentation at [**AiBcrParseStorageRequest**](AiBcrParseStorageRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiBcrParseStorageRequest
{
    OutFolder = new StorageFolderLocation
    {
        Storage = "First Storage",
        FolderPath = "VCard/files/produced/by/parser/will/be/placed/here"
    },
    Images = new List<AiBcrImageStorageFile>
    {
        new AiBcrImageStorageFile
        {
            File = new StorageFileLocation
            {
                FileName = "VCardScanImage.jpg",
                Storage = "First Storage",
                FolderPath = "image/location/on/storage"
            },
            IsSingle = true
        }
    }
};
```

</details>


### Result

**Description:** List of vCard files located on storage

**Return type:** Task<[**StorageFileLocationList**](StorageFileLocationList.md)>

<details>
    <summary>Result example</summary>

```csharp
result = new StorageFileLocationList
{
    Value = new List<StorageFileLocation>
    {
        new StorageFileLocation
        {
            FileName = "fileOnStorage.txt",
            Storage = "First Storage",
            FolderPath = "file/location/folder/on/storage"
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
var request = new AiBcrParseStorageRequest
{
    OutFolder = new StorageFolderLocation
    {
        Storage = "First Storage",
        FolderPath = "VCard/files/produced/by/parser/will/be/placed/here"
    },
    Images = new List<AiBcrImageStorageFile>
    {
        new AiBcrImageStorageFile
        {
            File = new StorageFileLocation
            {
                FileName = "VCardScanImage.jpg",
                Storage = "First Storage",
                FolderPath = "image/location/on/storage"
            },
            IsSingle = true
        }
    }
};

// Call method:
var result = await api.Ai.Bcr.ParseStorageAsync(request);

// Result example:
result = new StorageFileLocationList
{
    Value = new List<StorageFileLocation>
    {
        new StorageFileLocation
        {
            FileName = "fileOnStorage.txt",
            Storage = "First Storage",
            FolderPath = "file/location/folder/on/storage"
        }
    }
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
