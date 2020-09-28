# MailMessageMapi
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**MapiMessageDto**](MapiMessageDto.md) | Email message object.              | 

## Parent class

See: [MailMessageBase](MailMessageBase.md)

## Example
```csharp
var mailMessageMapi = new MailMessageMapi
{
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

[[Back to Model list]](Models.md) [[Back to README]](README.md)

