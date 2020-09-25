# Aspose.Email.Cloud.Sdk.EmailApi

<a name="AsFile"></a>
# AsFile

Converts Email model to specified format and returns as file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailAsFileRequest
{
    Value = new EmailDto
    {
        Attachments = new List<Attachment>
        {
            new Attachment
            {
                Name = "some-file.txt",
                Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
            }
        },
        Body = "Some body",
        BodyType = "Html",
        DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
        {
            "OnSuccess",
            "Delay"
        },
        From = new MailAddress
        {
            DisplayName = "From Address",
            Address = "from@aspose.com"
        },
        HtmlBody = "<b>Some body</b>",
        IsBodyHtml = true,
        IsDraft = true,
        Subject = "Re: Some subject",
        To = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "To Address",
                Address = "to@aspose.com"
            }
        }
    }
};

// Call method:
var result = Api.Email.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [EmailAsFileRequest](EmailAsFileRequest.md)


### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

Converts Email model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailAsFileRequest
{
    Value = new EmailDto
    {
        Attachments = new List<Attachment>
        {
            new Attachment
            {
                Name = "some-file.txt",
                Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
            }
        },
        Body = "Some body",
        BodyType = "Html",
        DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
        {
            "OnSuccess",
            "Delay"
        },
        From = new MailAddress
        {
            DisplayName = "From Address",
            Address = "from@aspose.com"
        },
        HtmlBody = "<b>Some body</b>",
        IsBodyHtml = true,
        IsDraft = true,
        Subject = "Re: Some subject",
        To = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "To Address",
                Address = "to@aspose.com"
            }
        }
    }
};

// Call method:
var result = await Api.Email.AsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [EmailAsFileRequest](EmailAsFileRequest.md)


### Return type

**Task<Stream>**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsMapi"></a>
# AsMapi

Converts EmailDto to MapiMessageDto.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var emailDto = new EmailDto
{
    Attachments = new List<Attachment>
    {
        new Attachment
        {
            Name = "some-file.txt",
            Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
        }
    },
    Body = "Some body",
    BodyType = "Html",
    DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
    {
        "OnSuccess",
        "Delay"
    },
    From = new MailAddress
    {
        DisplayName = "From Address",
        Address = "from@aspose.com"
    },
    HtmlBody = "<b>Some body</b>",
    IsBodyHtml = true,
    IsDraft = true,
    Subject = "Re: Some subject",
    To = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "To Address",
            Address = "to@aspose.com"
        }
    }
};

// Call method:
var result = Api.Email.AsMapi(emailDto);

// Result example:
result = new MapiMessageDto
{
    MessageBody = "Some body",
    ClientSubmitTime = DateTime.Today,
    DeliveryTime = DateTime.Today,
    DisplayTo = "To Address",
    Flags = new List<MapiMessageFlag>
    {
        "MsgFlagRead",
        "MsgFlagUnsent",
        "MsgFlagHasAttach"
    },
    NormalizedSubject = "Some subject",
    SenderAddressType = "SMTP",
    SenderEmailAddress = "from@aspose.com",
    SenderName = "From Address",
    SenderSmtpAddress = "from@aspose.com",
    Attachments = new List<MapiAttachmentDto>
    {
        new MapiAttachmentDto
        {
            Name = "some-file.txt",
            DataBase64 = "U29tZSBmaWxlIHRleHQ="
        }
    },
    Body = "Some body",
    MessageClass = "IPM.Note",
    Recipients = new List<MapiRecipientDto>
    {
        new MapiRecipientDto
        {
            EmailAddress = "to@aspose.com",
            AddressType = "SMTP",
            DisplayName = "To Address",
            RecipientType = "MapiTo"
        }
    },
    Subject = "Re: Some subject",
    SubjectPrefix = "Re: "
};
```

</details>

### emailDto Parameter
See parameter model documentation at [EmailDto](EmailDto.md)


### Return type

[**MapiMessageDto**](MapiMessageDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
# AsMapiAsync

Converts EmailDto to MapiMessageDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var emailDto = new EmailDto
{
    Attachments = new List<Attachment>
    {
        new Attachment
        {
            Name = "some-file.txt",
            Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
        }
    },
    Body = "Some body",
    BodyType = "Html",
    DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
    {
        "OnSuccess",
        "Delay"
    },
    From = new MailAddress
    {
        DisplayName = "From Address",
        Address = "from@aspose.com"
    },
    HtmlBody = "<b>Some body</b>",
    IsBodyHtml = true,
    IsDraft = true,
    Subject = "Re: Some subject",
    To = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "To Address",
            Address = "to@aspose.com"
        }
    }
};

// Call method:
var result = await Api.Email.AsMapiAsync(emailDto);

// Result example:
result = new MapiMessageDto
{
    MessageBody = "Some body",
    ClientSubmitTime = DateTime.Today,
    DeliveryTime = DateTime.Today,
    DisplayTo = "To Address",
    Flags = new List<MapiMessageFlag>
    {
        "MsgFlagRead",
        "MsgFlagUnsent",
        "MsgFlagHasAttach"
    },
    NormalizedSubject = "Some subject",
    SenderAddressType = "SMTP",
    SenderEmailAddress = "from@aspose.com",
    SenderName = "From Address",
    SenderSmtpAddress = "from@aspose.com",
    Attachments = new List<MapiAttachmentDto>
    {
        new MapiAttachmentDto
        {
            Name = "some-file.txt",
            DataBase64 = "U29tZSBmaWxlIHRleHQ="
        }
    },
    Body = "Some body",
    MessageClass = "IPM.Note",
    Recipients = new List<MapiRecipientDto>
    {
        new MapiRecipientDto
        {
            EmailAddress = "to@aspose.com",
            AddressType = "SMTP",
            DisplayName = "To Address",
            RecipientType = "MapiTo"
        }
    },
    Subject = "Re: Some subject",
    SubjectPrefix = "Re: "
};
```

</details>

### emailDto Parameter
See parameter model documentation at [EmailDto](EmailDto.md)


### Return type

Task<[**MapiMessageDto**](MapiMessageDto.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Convert"></a>
# Convert

Converts email document to specified format and returns as file             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConvertRequest
{ 
    FromFormat = "Msg",
    ToFormat = "Mhtml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};

// Call method:
var result = Api.Email.Convert(request);

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
 **fromFormat** | **string**| File format to convert to Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **toFormat** | **string**| File format to convert from Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
# ConvertAsync

Converts email document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailConvertRequest
{ 
    FromFormat = "Msg",
    ToFormat = "Mhtml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};

// Call method:
var result = await Api.Email.ConvertAsync(request);

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
 **fromFormat** | **string**| File format to convert to Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **toFormat** | **string**| File format to convert from Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
# FromFile

Converts email document to a model representation             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailFromFileRequest
{ 
    Format = "Eml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml"))
};

// Call method:
var result = Api.Email.FromFile(request);

// Result example:
result = new EmailDto
{
    Attachments = new List<Attachment>
    {
        new Attachment
        {
            Name = "some-file.txt",
            Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
        }
    },
    Body = "Some body",
    BodyType = "Html",
    DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
    {
        "OnSuccess",
        "Delay"
    },
    From = new MailAddress
    {
        DisplayName = "From Address",
        Address = "from@aspose.com"
    },
    HtmlBody = "<b>Some body</b>",
    IsBodyHtml = true,
    IsDraft = true,
    Subject = "Re: Some subject",
    To = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "To Address",
            Address = "to@aspose.com"
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**|  Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**EmailDto**](EmailDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

Converts email document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailFromFileRequest
{ 
    Format = "Eml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml"))
};

// Call method:
var result = await Api.Email.FromFileAsync(request);

// Result example:
result = new EmailDto
{
    Attachments = new List<Attachment>
    {
        new Attachment
        {
            Name = "some-file.txt",
            Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
        }
    },
    Body = "Some body",
    BodyType = "Html",
    DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
    {
        "OnSuccess",
        "Delay"
    },
    From = new MailAddress
    {
        DisplayName = "From Address",
        Address = "from@aspose.com"
    },
    HtmlBody = "<b>Some body</b>",
    IsBodyHtml = true,
    IsDraft = true,
    Subject = "Re: Some subject",
    To = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "To Address",
            Address = "to@aspose.com"
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**|  Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**EmailDto**](EmailDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
# Get

Get email document from storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Email.Get(request);

// Result example:
result = new EmailDto
{
    Attachments = new List<Attachment>
    {
        new Attachment
        {
            Name = "some-file.txt",
            Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
        }
    },
    Body = "Some body",
    BodyType = "Html",
    DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
    {
        "OnSuccess",
        "Delay"
    },
    From = new MailAddress
    {
        DisplayName = "From Address",
        Address = "from@aspose.com"
    },
    HtmlBody = "<b>Some body</b>",
    IsBodyHtml = true,
    IsDraft = true,
    Subject = "Re: Some subject",
    To = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "To Address",
            Address = "to@aspose.com"
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **fileName** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**EmailDto**](EmailDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

Get email document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Email.GetAsync(request);

// Result example:
result = new EmailDto
{
    Attachments = new List<Attachment>
    {
        new Attachment
        {
            Name = "some-file.txt",
            Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
        }
    },
    Body = "Some body",
    BodyType = "Html",
    DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
    {
        "OnSuccess",
        "Delay"
    },
    From = new MailAddress
    {
        DisplayName = "From Address",
        Address = "from@aspose.com"
    },
    HtmlBody = "<b>Some body</b>",
    IsBodyHtml = true,
    IsDraft = true,
    Subject = "Re: Some subject",
    To = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "To Address",
            Address = "to@aspose.com"
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **fileName** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**EmailDto**](EmailDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsFile"></a>
# GetAsFile

Converts email document from storage to specified format and returns as file             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailGetAsFileRequest
{ 
    FileName = "email.eml",
    Format = "Mhtml",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};

// Call method:
var result = Api.Email.GetAsFile(request);

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
 **fileName** | **string**| Email document file name | 
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
# GetAsFileAsync

Converts email document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailGetAsFileRequest
{ 
    FileName = "email.eml",
    Format = "Mhtml",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};

// Call method:
var result = await Api.Email.GetAsFileAsync(request);

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
 **fileName** | **string**| Email document file name | 
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
# GetList

Get email list from storage folder.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailGetListRequest
{ 
    Format = "Eml",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};

// Call method:
var result = Api.Email.GetList(request);

// Result example:
result = new EmailStorageList
{
    Value = new List<StorageModel<EmailDto>>
    {
        new EmailSaveRequest
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "message.eml",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new EmailDto
            {
                Attachments = new List<Attachment>
                {
                    new Attachment
                    {
                        Name = "some-file.txt",
                        Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                    }
                },
                Body = "Some body",
                BodyType = "Html",
                DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
                {
                    "OnSuccess",
                    "Delay"
                },
                From = new MailAddress
                {
                    DisplayName = "From Address",
                    Address = "from@aspose.com"
                },
                HtmlBody = "<b>Some body</b>",
                IsBodyHtml = true,
                IsDraft = true,
                Subject = "Re: Some subject",
                To = new List<MailAddress>
                {
                    new MailAddress
                    {
                        DisplayName = "To Address",
                        Address = "to@aspose.com"
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
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

### Return type

[**EmailStorageList**](EmailStorageList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

Get email list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailGetListRequest
{ 
    Format = "Eml",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};

// Call method:
var result = await Api.Email.GetListAsync(request);

// Result example:
result = new EmailStorageList
{
    Value = new List<StorageModel<EmailDto>>
    {
        new EmailSaveRequest
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "message.eml",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new EmailDto
            {
                Attachments = new List<Attachment>
                {
                    new Attachment
                    {
                        Name = "some-file.txt",
                        Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
                    }
                },
                Body = "Some body",
                BodyType = "Html",
                DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
                {
                    "OnSuccess",
                    "Delay"
                },
                From = new MailAddress
                {
                    DisplayName = "From Address",
                    Address = "from@aspose.com"
                },
                HtmlBody = "<b>Some body</b>",
                IsBodyHtml = true,
                IsDraft = true,
                Subject = "Re: Some subject",
                To = new List<MailAddress>
                {
                    new MailAddress
                    {
                        DisplayName = "To Address",
                        Address = "to@aspose.com"
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
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

### Return type

[**EmailStorageList**](EmailStorageList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
# Save

Save email document to storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "email.eml",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailDto
    {
        Attachments = new List<Attachment>
        {
            new Attachment
            {
                Name = "some-file.txt",
                Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
            }
        },
        Body = "Some body",
        BodyType = "Html",
        DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
        {
            "OnSuccess",
            "Delay"
        },
        From = new MailAddress
        {
            DisplayName = "From Address",
            Address = "from@aspose.com"
        },
        HtmlBody = "<b>Some body</b>",
        IsBodyHtml = true,
        IsDraft = true,
        Subject = "Re: Some subject",
        To = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "To Address",
                Address = "to@aspose.com"
            }
        }
    }
};

// Call method:
Api.Email.Save(request);

```

</details>

### request Parameter
See parameter model documentation at [EmailSaveRequest](EmailSaveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

Save email document to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new EmailSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "email.eml",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new EmailDto
    {
        Attachments = new List<Attachment>
        {
            new Attachment
            {
                Name = "some-file.txt",
                Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
            }
        },
        Body = "Some body",
        BodyType = "Html",
        DeliveryNotificationOptions = new List<EmailDeliveryNotificationOptions>
        {
            "OnSuccess",
            "Delay"
        },
        From = new MailAddress
        {
            DisplayName = "From Address",
            Address = "from@aspose.com"
        },
        HtmlBody = "<b>Some body</b>",
        IsBodyHtml = true,
        IsDraft = true,
        Subject = "Re: Some subject",
        To = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "To Address",
                Address = "to@aspose.com"
            }
        }
    }
};

// Call method:
await Api.Email.SaveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [EmailSaveRequest](EmailSaveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
