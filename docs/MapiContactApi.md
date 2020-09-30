# MapiContactApi (EmailCloud.Mapi.Contact)

MAPI contact operations

<a name="AsContactDto"></a>
## AsContactDto

**Description**: Converts MAPI contact model to ContactDto model.             


**Returns:** Contact model.

**Method call example:**
```csharp
var result = api.Mapi.Contact.AsContactDto(mapiContactDto);
```

### Parameter: *mapiContactDto*

**Description:** MAPI contact model to convert.

**See also** parameter model documentation at [**MapiContactDto**](MapiContactDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** Contact model.

**Return type:** [**ContactDto**](ContactDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = api.Mapi.Contact.AsContactDto(mapiContactDto);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsContactDtoAsync"></a>
## AsContactDtoAsync

**Description:** Converts MAPI contact model to ContactDto model.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Contact model.

**Method call example:**
```csharp
var result = await api.Mapi.Contact.AsContactDtoAsync(mapiContactDto);
```

### Parameter: *mapiContactDto*

**Description:** MAPI contact model to convert.

**See also** parameter model documentation at [**MapiContactDto**](MapiContactDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** Contact model.

**Return type:** Task<[**ContactDto**](ContactDto.md)>

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = await api.Mapi.Contact.AsContactDtoAsync(mapiContactDto);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsFile"></a>
## AsFile

**Description**: Converts MAPI contact model to specified format and returns as file.             


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = api.Mapi.Contact.AsFile(request);
```

### Parameter: *request*

**Description:** MAPI contact model to convert.

**See also** parameter model documentation at [**MapiContactAsFileRequest**](MapiContactAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** File stream in specified format.

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
var api = new EmailCloud(appKey, appSid);

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
var result = api.Mapi.Contact.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
## AsFileAsync

**Description:** Converts MAPI contact model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = await api.Mapi.Contact.AsFileAsync(request);
```

### Parameter: *request*

**Description:** MAPI contact model to convert.

**See also** parameter model documentation at [**MapiContactAsFileRequest**](MapiContactAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** File stream in specified format.

**Return type:** **Task<Stream>**

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
var api = new EmailCloud(appKey, appSid);

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
var result = await api.Mapi.Contact.AsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
## FromFile
**Descrption:** Converts contact file to a MAPI model representation.             


**Returns:** MAPI model

**Method call example:**
```csharp
var result = api.Mapi.Contact.FromFile(request);
```

### Parameter: *request*

**Description:** FromFile method request.

**See also** parameter model documentation at [**MapiContactFromFileRequest**](MapiContactFromFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

</details>

### Result

**Description:** MAPI model

**Return type:** [**MapiContactDto**](MapiContactDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = api.Mapi.Contact.FromFile(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
## FromFileAsync

**Description:** Converts contact file to a MAPI model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** MAPI model

**Method call example:**
```csharp
var result = await api.Mapi.Contact.FromFileAsync(request);
```

### Parameter: *request*

**Description:** FromFileAsync method request.

**See also** parameter model documentation at [**MapiContactFromFileRequest**](MapiContactFromFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

</details>

### Result

**Returns:** MAPI model

**Return type:** [**MapiContactDto**](MapiContactDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new MapiContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};

// Call method:
var result = await api.Mapi.Contact.FromFileAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
## Get
**Descrption:** Get MAPI contact document.             


**Returns:** Contact model.

**Method call example:**
```csharp
var result = api.Mapi.Contact.Get(request);
```

### Parameter: *request*

**Description:** Get method request.

**See also** parameter model documentation at [**MapiContactGetRequest**](MapiContactGetRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Description:** Contact model.

**Return type:** [**MapiContactDto**](MapiContactDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = api.Mapi.Contact.Get(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
## GetAsync

**Description:** Get MAPI contact document.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Contact model.

**Method call example:**
```csharp
var result = await api.Mapi.Contact.GetAsync(request);
```

### Parameter: *request*

**Description:** GetAsync method request.

**See also** parameter model documentation at [**MapiContactGetRequest**](MapiContactGetRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Returns:** Contact model.

**Return type:** [**MapiContactDto**](MapiContactDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await api.Mapi.Contact.GetAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
## Save

**Description**: Save MAPI Contact to storage.             


**Method call example:**
```csharp
api.Mapi.Contact.Save(request);
```

### Parameter: *request*

**Description:** Create/Update contact request.

**See also** parameter model documentation at [**MapiContactSaveRequest**](MapiContactSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
api.Mapi.Contact.Save(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
## SaveAsync

**Description:** Save MAPI Contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Mapi.Contact.SaveAsync(request);
```

### Parameter: *request*

**Description:** Create/Update contact request.

**See also** parameter model documentation at [**MapiContactSaveRequest**](MapiContactSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Mapi.Contact.SaveAsync(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
