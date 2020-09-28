# Aspose.Email.Cloud.Sdk.ContactApi

<a name="AsFile"></a>
## AsFile

Converts contact model to specified format and returns as file             

Returns: File stream in specified format

Method call example:
```csharp
var result = Api.Contact.AsFile(request);
```

### request Parameter

Contact model and format to convert

See parameter model documentation at [ContactAsFileRequest](ContactAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* File stream in specified format

*Return type:* **Stream**

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
## AsFileAsync

Converts contact model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File stream in specified format

Method call example:
```csharp
var result = await Api.Contact.AsFileAsync(request);
```

### request Parameter

Contact model and format to convert

See parameter model documentation at [ContactAsFileRequest](ContactAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* File stream in specified format

*Return type:* **Task<Stream>**

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsMapi"></a>
## AsMapi

Converts ContactDto to MapiContactDto.             

Returns: MAPI model contact representation

Method call example:
```csharp
var result = Api.Contact.AsMapi(contactDto);
```

### contactDto Parameter

Contact model to convert

See parameter model documentation at [ContactDto](ContactDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* MAPI model contact representation

*Return type:* [**MapiContactDto**](MapiContactDto.md)

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
## AsMapiAsync

Converts ContactDto to MapiContactDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: MAPI model contact representation

Method call example:
```csharp
var result = await Api.Contact.AsMapiAsync(contactDto);
```

### contactDto Parameter

Contact model to convert

See parameter model documentation at [ContactDto](ContactDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* MAPI model contact representation

*Return type:* Task<[**MapiContactDto**](MapiContactDto.md)>

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Convert"></a>
## Convert

Converts contact document to specified format and returns as file             

Returns: File stream in specified destination format

Method call example:
```csharp
var result = Api.Contact.Convert(request);
```

### request Parameter

Convert method request.

See parameter model documentation at [ContactConvertRequest](ContactConvertRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactConvertRequest
{ 
    ToFormat = "VCard",
    FromFormat = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

</details>

### Result

*Returns:* File stream in specified destination format

*Return type:* **Stream**

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
## ConvertAsync

Converts contact document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File stream in specified destination format

Method call example:
```csharp
var result = await Api.Contact.ConvertAsync(request);
```

### request Parameter

ConvertAsync method request.

See parameter model documentation at [ContactConvertRequest](ContactConvertRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactConvertRequest
{ 
    ToFormat = "VCard",
    FromFormat = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

</details>

### Result

*Returns:* File stream in specified destination format

*Return type:* **Stream**

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
## FromFile

Converts contact document to a model representation             

Returns: Contact model

Method call example:
```csharp
var result = Api.Contact.FromFile(request);
```

### request Parameter

FromFile method request.

See parameter model documentation at [ContactFromFileRequest](ContactFromFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

</details>

### Result

*Returns:* Contact model

*Return type:* [**ContactDto**](ContactDto.md)

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
## FromFileAsync

Converts contact document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Contact model

Method call example:
```csharp
var result = await Api.Contact.FromFileAsync(request);
```

### request Parameter

FromFileAsync method request.

See parameter model documentation at [ContactFromFileRequest](ContactFromFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/contact.msg"))
};
```

</details>

### Result

*Returns:* Contact model

*Return type:* [**ContactDto**](ContactDto.md)

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
## Get

Get contact document from storage.             

Returns: Contact document.

Method call example:
```csharp
var result = Api.Contact.Get(request);
```

### request Parameter

Get method request.

See parameter model documentation at [ContactGetRequest](ContactGetRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Contact document.

*Return type:* [**ContactDto**](ContactDto.md)

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
## GetAsync

Get contact document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Contact document.

Method call example:
```csharp
var result = await Api.Contact.GetAsync(request);
```

### request Parameter

GetAsync method request.

See parameter model documentation at [ContactGetRequest](ContactGetRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Contact document.

*Return type:* [**ContactDto**](ContactDto.md)

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsFile"></a>
## GetAsFile

Converts contact document from storage to specified format and returns as file             

Returns: File stream in specified format

Method call example:
```csharp
var result = Api.Contact.GetAsFile(request);
```

### request Parameter

GetAsFile method request.

See parameter model documentation at [ContactGetAsFileRequest](ContactGetAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactGetAsFileRequest
{ 
    FileName = "contact.msg",
    ToFormat = "VCard",
    FromFormat = "Msg",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};
```

</details>

### Result

*Returns:* File stream in specified format

*Return type:* **Stream**

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
## GetAsFileAsync

Converts contact document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File stream in specified format

Method call example:
```csharp
var result = await Api.Contact.GetAsFileAsync(request);
```

### request Parameter

GetAsFileAsync method request.

See parameter model documentation at [ContactGetAsFileRequest](ContactGetAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactGetAsFileRequest
{ 
    FileName = "contact.msg",
    ToFormat = "VCard",
    FromFormat = "Msg",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};
```

</details>

### Result

*Returns:* File stream in specified format

*Return type:* **Stream**

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList

Get contact list from storage folder.             

Returns: Contact list.

Method call example:
```csharp
var result = Api.Contact.GetList(request);
```

### request Parameter

GetList method request.

See parameter model documentation at [ContactGetListRequest](ContactGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactGetListRequest
{ 
    Format = "VCard",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};
```

</details>

### Result

*Returns:* Contact list.

*Return type:* [**ContactStorageList**](ContactStorageList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
## GetListAsync

Get contact list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Contact list.

Method call example:
```csharp
var result = await Api.Contact.GetListAsync(request);
```

### request Parameter

GetListAsync method request.

See parameter model documentation at [ContactGetListRequest](ContactGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new ContactGetListRequest
{ 
    Format = "VCard",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};
```

</details>

### Result

*Returns:* Contact list.

*Return type:* [**ContactStorageList**](ContactStorageList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
## Save

Save contact to storage.             

Returns: Returns 200 if create is successful.

Method call example:
```csharp
Api.Contact.Save(request);
```

### request Parameter

Create/Update contact request.

See parameter model documentation at [ContactSaveRequest](ContactSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* Returns 200 if create is successful.

*Return type:* void (empty response body)


### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
## SaveAsync

Save contact to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if create is successful.

Method call example:
```csharp
await Api.Contact.SaveAsync(request);
```

### request Parameter

Create/Update contact request.

See parameter model documentation at [ContactSaveRequest](ContactSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* Returns 200 if create is successful.

*Return type:* Task (empty response body)


### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
