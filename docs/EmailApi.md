# Aspose.Email.Cloud.Sdk.EmailApi

<a name="AsFile"></a>
## AsFile

Converts Email model to specified format and returns as file.             

Returns: File stream in specified format.

Method call example:
```csharp
var result = Api.Email.AsFile(request);
```

### request Parameter

Email model and format to convert.

See parameter model documentation at [EmailAsFileRequest](EmailAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* File stream in specified format.

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
## AsFileAsync

Converts Email model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File stream in specified format.

Method call example:
```csharp
var result = await Api.Email.AsFileAsync(request);
```

### request Parameter

Email model and format to convert.

See parameter model documentation at [EmailAsFileRequest](EmailAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* File stream in specified format.

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsMapi"></a>
## AsMapi

Converts EmailDto to MapiMessageDto.             

Returns: MAPI model message representation

Method call example:
```csharp
var result = Api.Email.AsMapi(emailDto);
```

### emailDto Parameter

Email model to convert

See parameter model documentation at [EmailDto](EmailDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* MAPI model message representation

*Return type:* [**MapiMessageDto**](MapiMessageDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
## AsMapiAsync

Converts EmailDto to MapiMessageDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: MAPI model message representation

Method call example:
```csharp
var result = await Api.Email.AsMapiAsync(emailDto);
```

### emailDto Parameter

Email model to convert

See parameter model documentation at [EmailDto](EmailDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* MAPI model message representation

*Return type:* Task<[**MapiMessageDto**](MapiMessageDto.md)>

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Convert"></a>
## Convert

Converts email document to specified format and returns as file             

Returns: File stream in specified format

Method call example:
```csharp
var result = Api.Email.Convert(request);
```

### request Parameter

Convert method request.

See parameter model documentation at [EmailConvertRequest](EmailConvertRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConvertRequest
{ 
    FromFormat = "Msg",
    ToFormat = "Mhtml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
## ConvertAsync

Converts email document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File stream in specified format

Method call example:
```csharp
var result = await Api.Email.ConvertAsync(request);
```

### request Parameter

ConvertAsync method request.

See parameter model documentation at [EmailConvertRequest](EmailConvertRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailConvertRequest
{ 
    FromFormat = "Msg",
    ToFormat = "Mhtml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
## FromFile

Converts email document to a model representation             

Returns: Email document model

Method call example:
```csharp
var result = Api.Email.FromFile(request);
```

### request Parameter

FromFile method request.

See parameter model documentation at [EmailFromFileRequest](EmailFromFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailFromFileRequest
{ 
    Format = "Eml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml"))
};
```

</details>

### Result

*Returns:* Email document model

*Return type:* [**EmailDto**](EmailDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
## FromFileAsync

Converts email document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Email document model

Method call example:
```csharp
var result = await Api.Email.FromFileAsync(request);
```

### request Parameter

FromFileAsync method request.

See parameter model documentation at [EmailFromFileRequest](EmailFromFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailFromFileRequest
{ 
    Format = "Eml",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.eml"))
};
```

</details>

### Result

*Returns:* Email document model

*Return type:* [**EmailDto**](EmailDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
## Get

Get email document from storage.             

Returns: Email document.

Method call example:
```csharp
var result = Api.Email.Get(request);
```

### request Parameter

Get method request.

See parameter model documentation at [EmailGetRequest](EmailGetRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Email document.

*Return type:* [**EmailDto**](EmailDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
## GetAsync

Get email document from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Email document.

Method call example:
```csharp
var result = await Api.Email.GetAsync(request);
```

### request Parameter

GetAsync method request.

See parameter model documentation at [EmailGetRequest](EmailGetRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

*Returns:* Email document.

*Return type:* [**EmailDto**](EmailDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsFile"></a>
## GetAsFile

Converts email document from storage to specified format and returns as file             

Returns: File stream in specified format

Method call example:
```csharp
var result = Api.Email.GetAsFile(request);
```

### request Parameter

GetAsFile method request.

See parameter model documentation at [EmailGetAsFileRequest](EmailGetAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailGetAsFileRequest
{ 
    FileName = "email.eml",
    Format = "Mhtml",
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
## GetAsFileAsync

Converts email document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: File stream in specified format

Method call example:
```csharp
var result = await Api.Email.GetAsFileAsync(request);
```

### request Parameter

GetAsFileAsync method request.

See parameter model documentation at [EmailGetAsFileRequest](EmailGetAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailGetAsFileRequest
{ 
    FileName = "email.eml",
    Format = "Mhtml",
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList

Get email list from storage folder.             

Returns: Email document list.

Method call example:
```csharp
var result = Api.Email.GetList(request);
```

### request Parameter

GetList method request.

See parameter model documentation at [EmailGetListRequest](EmailGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailGetListRequest
{ 
    Format = "Eml",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};
```

</details>

### Result

*Returns:* Email document list.

*Return type:* [**EmailStorageList**](EmailStorageList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
## GetListAsync

Get email list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Email document list.

Method call example:
```csharp
var result = await Api.Email.GetListAsync(request);
```

### request Parameter

GetListAsync method request.

See parameter model documentation at [EmailGetListRequest](EmailGetListRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new EmailGetListRequest
{ 
    Format = "Eml",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};
```

</details>

### Result

*Returns:* Email document list.

*Return type:* [**EmailStorageList**](EmailStorageList.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
## Save

Save email document to storage.             

Returns: Returns 200 if update is successful.

Method call example:
```csharp
Api.Email.Save(request);
```

### request Parameter

Email document create/update request.

See parameter model documentation at [EmailSaveRequest](EmailSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* Returns 200 if update is successful.

*Return type:* void (empty response body)


### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
## SaveAsync

Save email document to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Returns 200 if update is successful.

Method call example:
```csharp
await Api.Email.SaveAsync(request);
```

### request Parameter

Email document create/update request.

See parameter model documentation at [EmailSaveRequest](EmailSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

*Returns:* Returns 200 if update is successful.

*Return type:* Task (empty response body)


### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
