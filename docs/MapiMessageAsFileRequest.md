# MapiMessageAsFileRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 
**Value** | [**MapiMessageDto**](MapiMessageDto.md) | MAPI message model.              | 


## Example
```csharp
var mapiMessageAsFileRequest = new MapiMessageAsFileRequest
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

[[Back to Model list]](Models.md) [[Back to README]](README.md)

