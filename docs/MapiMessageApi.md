# MapiMessageApi (EmailCloud.Mapi.Message)

MAPI message operations

<a name="AsEmailDto"></a>
## AsEmailDto

**Description**: Converts MAPI message model to EmailDto model             


**Returns:** EmailDto model

**Method call example:**
```csharp
var result = api.Mapi.Message.AsEmailDto(mapiMessage);
```

### Parameter: *mapiMessage*

**Description:** MAPI message model to convert

**See also** parameter model documentation at [**MapiMessageDto**](MapiMessageDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var mapiMessage = new MapiMessageDto
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


### Result

**Description:** EmailDto model

**Return type:** [**EmailDto**](EmailDto.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var mapiMessage = new MapiMessageDto
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

// Call method:
var result = api.Mapi.Message.AsEmailDto(mapiMessage);

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

<a name="AsEmailDtoAsync"></a>
## AsEmailDtoAsync

**Description:** Converts MAPI message model to EmailDto model             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** EmailDto model

**Method call example:**
```csharp
var result = await api.Mapi.Message.AsEmailDtoAsync(mapiMessage);
```

### Parameter: *mapiMessage*

**Description:** MAPI message model to convert

**See also** parameter model documentation at [**MapiMessageDto**](MapiMessageDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var mapiMessage = new MapiMessageDto
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


### Result

**Description:** EmailDto model

**Return type:** Task<[**EmailDto**](EmailDto.md)>

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var mapiMessage = new MapiMessageDto
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

// Call method:
var result = await api.Mapi.Message.AsEmailDtoAsync(mapiMessage);

//Result example:
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
<a name="AsFile"></a>
## AsFile

**Description**: Converts MAPI message model to specified format and returns as file.             


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = api.Mapi.Message.AsFile(request);
```

### Parameter: *request*

**Description:** MAPI message model to convert.

**See also** parameter model documentation at [**MapiMessageAsFileRequest**](MapiMessageAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageAsFileRequest
{
    Format = "Msg",
    Value = new MapiMessageDto
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageAsFileRequest
{
    Format = "Msg",
    Value = new MapiMessageDto
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
    }
};

// Call method:
var result = api.Mapi.Message.AsFile(request);

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

**Description:** Converts MAPI message model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = await api.Mapi.Message.AsFileAsync(request);
```

### Parameter: *request*

**Description:** MAPI message model to convert.

**See also** parameter model documentation at [**MapiMessageAsFileRequest**](MapiMessageAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageAsFileRequest
{
    Format = "Msg",
    Value = new MapiMessageDto
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageAsFileRequest
{
    Format = "Msg",
    Value = new MapiMessageDto
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
    }
};

// Call method:
var result = await api.Mapi.Message.AsFileAsync(request);
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
## FromFile
**Descrption:** Converts email file to a MAPI model representation             


**Returns:** MAPI model

**Method call example:**
```csharp
var result = api.Mapi.Message.FromFile(request);
```

### Parameter: *request*

**Description:** FromFile method request.

**See also** parameter model documentation at [**MapiMessageFromFileRequest**](MapiMessageFromFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};
```

</details>

### Result

**Description:** MAPI model

**Return type:** [**MapiMessageDto**](MapiMessageDto.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};

// Call method:
var result = api.Mapi.Message.FromFile(request);

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

<a name="FromFileAsync"></a>
## FromFileAsync

**Description:** Converts email file to a MAPI model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** MAPI model

**Method call example:**
```csharp
var result = await api.Mapi.Message.FromFileAsync(request);
```

### Parameter: *request*

**Description:** FromFileAsync method request.

**See also** parameter model documentation at [**MapiMessageFromFileRequest**](MapiMessageFromFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};
```

</details>

### Result

**Returns:** MAPI model

**Return type:** [**MapiMessageDto**](MapiMessageDto.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageFromFileRequest
{ 
    Format = "Msg",
    File = new MemoryStream(File.ReadAllBytes("/path/to/message.msg"))
};

// Call method:
var result = await api.Mapi.Message.FromFileAsync(request);

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
<a name="Get"></a>
## Get
**Descrption:** Get MAPI message document.             


**Returns:** MAPI message document.

**Method call example:**
```csharp
var result = api.Mapi.Message.Get(request);
```

### Parameter: *request*

**Description:** Get method request.

**See also** parameter model documentation at [**MapiMessageGetRequest**](MapiMessageGetRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Description:** MAPI message document.

**Return type:** [**MapiMessageDto**](MapiMessageDto.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = api.Mapi.Message.Get(request);

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

<a name="GetAsync"></a>
## GetAsync

**Description:** Get MAPI message document.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** MAPI message document.

**Method call example:**
```csharp
var result = await api.Mapi.Message.GetAsync(request);
```

### Parameter: *request*

**Description:** GetAsync method request.

**See also** parameter model documentation at [**MapiMessageGetRequest**](MapiMessageGetRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Returns:** MAPI message document.

**Return type:** [**MapiMessageDto**](MapiMessageDto.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageGetRequest
{ 
    Format = "Eml",
    FileName = "email.eml",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await api.Mapi.Message.GetAsync(request);

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
<a name="Save"></a>
## Save

**Description**: Save MAPI message to storage.             


**Method call example:**
```csharp
api.Mapi.Message.Save(request);
```

### Parameter: *request*

**Description:** Message create/update request.

**See also** parameter model documentation at [**MapiMessageSaveRequest**](MapiMessageSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "message.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiMessageDto
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "message.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiMessageDto
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
    }
};

// Call method:
api.Mapi.Message.Save(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
## SaveAsync

**Description:** Save MAPI message to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Mapi.Message.SaveAsync(request);
```

### Parameter: *request*

**Description:** Message create/update request.

**See also** parameter model documentation at [**MapiMessageSaveRequest**](MapiMessageSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new MapiMessageSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "message.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiMessageDto
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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new MapiMessageSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "message.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiMessageDto
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
    }
};

// Call method:
await api.Mapi.Message.SaveAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
