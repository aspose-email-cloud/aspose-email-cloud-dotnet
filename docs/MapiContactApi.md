# Aspose.Email.Cloud.Sdk.MapiContactApi

<a name="AsContactDto"></a>
# AsContactDto

Converts MAPI contact model to ContactDto model.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var mapiContactDto = new MapiContactDto
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

// Call method:
var result = Api.Mapi.Contact.AsContactDto(mapiContactDto);

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

### mapiContactDto Parameter
See parameter model documentation at [MapiContactDto](MapiContactDto.md)


### Return type

[**ContactDto**](ContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsContactDtoAsync"></a>
# AsContactDtoAsync

Converts MAPI contact model to ContactDto model.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var mapiContactDto = new MapiContactDto
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

// Call method:
var result = await Api.Mapi.Contact.AsContactDtoAsync(mapiContactDto);

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

### mapiContactDto Parameter
See parameter model documentation at [MapiContactDto](MapiContactDto.md)


### Return type

Task<[**ContactDto**](ContactDto.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsFile"></a>
# AsFile

Converts MAPI contact model to specified format and returns as file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactAsFileRequest
{
    Format = "Msg",
    Value = new MapiContactDto
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
    }
};

// Call method:
var result = Api.Mapi.Contact.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [MapiContactAsFileRequest](MapiContactAsFileRequest.md)


### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

Converts MAPI contact model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactAsFileRequest
{
    Format = "Msg",
    Value = new MapiContactDto
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
    }
};

// Call method:
var result = await Api.Mapi.Contact.AsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [MapiContactAsFileRequest](MapiContactAsFileRequest.md)


### Return type

**Task<Stream>**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
# FromFile

Converts contact file to a MAPI model representation.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = Api.Mapi.Contact.FromFile(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**MapiContactDto**](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

Converts contact file to a MAPI model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = await Api.Mapi.Contact.FromFileAsync(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**MapiContactDto**](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
# Get

Get MAPI contact document.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Mapi.Contact.Get(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **fileName** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**MapiContactDto**](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

Get MAPI contact document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Mapi.Contact.GetAsync(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **fileName** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**MapiContactDto**](MapiContactDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
# Save

Save MAPI Contact to storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "contact.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiContactDto
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
    }
};

// Call method:
Api.Mapi.Contact.Save(request);

```

</details>

### request Parameter
See parameter model documentation at [MapiContactSaveRequest](MapiContactSaveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

Save MAPI Contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiContactSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "contact.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiContactDto
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
    }
};

// Call method:
await Api.Mapi.Contact.SaveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [MapiContactSaveRequest](MapiContactSaveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
