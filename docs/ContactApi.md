# Aspose.Email.Cloud.Sdk.ContactApi

<a name="AsFile"></a>
# AsFile

Converts contact model to specified format and returns as file             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactAsFileRequest
{
    Value = new ContactDto
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
};

// Call method:
var result = Api.Contact.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [ContactAsFileRequest](ContactAsFileRequest.md)


### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

Converts contact model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactAsFileRequest
{
    Value = new ContactDto
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
};

// Call method:
var result = await Api.Contact.AsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [ContactAsFileRequest](ContactAsFileRequest.md)


### Return type

**Task<Stream>**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsMapi"></a>
# AsMapi

Converts ContactDto to MapiContactDto.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var contactDto = new ContactDto
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
};

// Call method:
var result = Api.Contact.AsMapi(contactDto);

// Result example:
result = new MapiContactDto
{
    ElectronicAddresses = new MapiContactElectronicAddressPropertySetDto
    {
        DefaultEmailAddress = new MapiContactElectronicAddressDto
        {
            EmailAddress = "email@aspose.com"
        }
    },
    NameInfo = new MapiContactNamePropertySetDto
    {
        GivenName = "Alex",
        Surname = "Thomas"
    },
    PersonalInfo = new MapiContactPersonalInfoPropertySetDto
    {
        BusinessHomePage = "www.aspose.com"
    },
    ProfessionalInfo = new MapiContactProfessionalPropertySetDto
    {
        Profession = "GENERAL DIRECTOR"
    },
    Telephones = new MapiContactTelephonePropertySetDto
    {
        PrimaryTelephoneNumber = "+49 211 4247 21"
    }
};
```

</details>

### contactDto Parameter
See parameter model documentation at [ContactDto](ContactDto.md)


### Return type

[**MapiContactDto**](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
# AsMapiAsync

Converts ContactDto to MapiContactDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var contactDto = new ContactDto
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
};

// Call method:
var result = await Api.Contact.AsMapiAsync(contactDto);

// Result example:
result = new MapiContactDto
{
    ElectronicAddresses = new MapiContactElectronicAddressPropertySetDto
    {
        DefaultEmailAddress = new MapiContactElectronicAddressDto
        {
            EmailAddress = "email@aspose.com"
        }
    },
    NameInfo = new MapiContactNamePropertySetDto
    {
        GivenName = "Alex",
        Surname = "Thomas"
    },
    PersonalInfo = new MapiContactPersonalInfoPropertySetDto
    {
        BusinessHomePage = "www.aspose.com"
    },
    ProfessionalInfo = new MapiContactProfessionalPropertySetDto
    {
        Profession = "GENERAL DIRECTOR"
    },
    Telephones = new MapiContactTelephonePropertySetDto
    {
        PrimaryTelephoneNumber = "+49 211 4247 21"
    }
};
```

</details>

### contactDto Parameter
See parameter model documentation at [ContactDto](ContactDto.md)


### Return type

Task<[**MapiContactDto**](MapiContactDto.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Convert"></a>
# Convert

Converts contact document to specified format and returns as file             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactConvertRequest
{ 
    ToFormat = "VCard",
    FromFormat = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = Api.Contact.Convert(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toFormat** | **string**| File format to convert to Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
# ConvertAsync

Converts contact document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactConvertRequest
{ 
    ToFormat = "VCard",
    FromFormat = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = await Api.Contact.ConvertAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toFormat** | **string**| File format to convert to Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
# FromFile

Converts contact document to a model representation             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = Api.Contact.FromFile(request);

// Result example:
result = new ContactDto
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
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**ContactDto**](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

Converts contact document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = await Api.Contact.FromFileAsync(request);

// Result example:
result = new ContactDto
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
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**ContactDto**](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
# Get

Get contact document from storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Contact.Get(request);

// Result example:
result = new ContactDto
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
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **fileName** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**ContactDto**](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

Get contact document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Contact.GetAsync(request);

// Result example:
result = new ContactDto
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
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **fileName** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**ContactDto**](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsFile"></a>
# GetAsFile

Converts contact document from storage to specified format and returns as file             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactGetAsFileRequest
{ 
    FileName = "contact.msg",
    ToFormat = "VCard",
    FromFormat = "Msg",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};

// Call method:
var result = Api.Contact.GetAsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **toFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
# GetAsFileAsync

Converts contact document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactGetAsFileRequest
{ 
    FileName = "contact.msg",
    ToFormat = "VCard",
    FromFormat = "Msg",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};

// Call method:
var result = await Api.Contact.GetAsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **toFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
# GetList

Get contact list from storage folder.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactGetListRequest
{ 
    Format = "VCard",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};

// Call method:
var result = Api.Contact.GetList(request);

// Result example:
result = new ContactStorageList
{
    Value = new List<StorageModel<ContactDto>>
    {
        new StorageModel<ContactDto>
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "contact.vcf",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new ContactDto
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
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

### Return type

[**ContactStorageList**](ContactStorageList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

Get contact list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactGetListRequest
{ 
    Format = "VCard",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};

// Call method:
var result = await Api.Contact.GetListAsync(request);

// Result example:
result = new ContactStorageList
{
    Value = new List<StorageModel<ContactDto>>
    {
        new StorageModel<ContactDto>
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "contact.vcf",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new ContactDto
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
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

### Return type

[**ContactStorageList**](ContactStorageList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
# Save

Save contact to storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "contact.vcf",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new ContactDto
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
};

// Call method:
Api.Contact.Save(request);

```

</details>

### request Parameter
See parameter model documentation at [ContactSaveRequest](ContactSaveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

Save contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new ContactSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "contact.vcf",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new ContactDto
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
};

// Call method:
await Api.Contact.SaveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [ContactSaveRequest](ContactSaveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
