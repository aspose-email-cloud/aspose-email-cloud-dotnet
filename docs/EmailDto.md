# EmailDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlternateViews** | [**List&lt;AlternateView&gt;**](AlternateView.md) | Collection of alternate views of message.              | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Email message attachments.              | [optional] 
**Bcc** | [**List&lt;MailAddress&gt;**](MailAddress.md) | BCC recipients.              | [optional] 
**Body** | **string** | Email message body as plain text.              | [optional] 
**BodyEncoding** | **string** | Body encoding.              | [optional] 
**BodyType** | **string** | The content type of message body. Enum, available values: PlainText, Html, Rtf | 
**Cc** | [**List&lt;MailAddress&gt;**](MailAddress.md) | CC recipients.              | [optional] 
**Date** | **DateTime?** | Message date.              | 
**DeliveryNotificationOptions** | **List&lt;string&gt;** | Delivery notifications. Items: Email delivery notification options. Enum, available values: Delay, Never, None, OnFailure, OnSuccess | [optional] 
**From** | [**MailAddress**](MailAddress.md) | From address.              | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Document headers.              | [optional] 
**HtmlBody** | **string** | HTML body.              | [optional] 
**HtmlBodyText** | **string** | Html body as plain text. Read only.              | [optional] 
**IsBodyHtml** | **bool?** | Indicates whether the message body is in Html.              | 
**IsDraft** | **bool?** | Indicates whether or not a message has been sent.              | 
**IsEncrypted** | **bool?** | Indicates whether the message is encrypted. Read only.              | 
**IsSigned** | **bool?** | Indicates whether the message is signed. Read only.              | 
**LinkedResources** | [**List&lt;LinkedResource&gt;**](LinkedResource.md) | Linked resources of message.              | [optional] 
**MessageId** | **string** | Message id.              | [optional] 
**OriginalIsTnef** | **bool?** | Indicates whether original EML message is in TNEF format. Read only.              | 
**PreferredTextEncoding** | **string** | Preferred encoding.              | [optional] 
**Priority** | **string** | Email priority status. Enum, available values: High, Low, Normal | 
**ReadReceiptTo** | [**List&lt;MailAddress&gt;**](MailAddress.md) | Read receipt addresses.              | [optional] 
**ReplyToList** | [**List&lt;MailAddress&gt;**](MailAddress.md) | The list of addresses to reply to for the mail message.              | [optional] 
**ReversePath** | [**MailAddress**](MailAddress.md) | ReversePath address.              | [optional] 
**Sender** | [**MailAddress**](MailAddress.md) | Sender address.              | [optional] 
**Sensitivity** | **string** | Specifies the sensitivity of a MailMessage. Enum, available values: None, Normal, Personal, Private, CompanyConfidential | 
**Subject** | **string** | Message subject.              | [optional] 
**SubjectEncoding** | **string** | Subject encoding.              | [optional] 
**TimeZoneOffset** | **long?** | Coordinated Universal Time (UTC) offset for the message dates. This property defines the time zone difference, between the local time and UTC represented as count of ticks (10 000 per millisecond).              | [optional] 
**To** | [**List&lt;MailAddress&gt;**](MailAddress.md) | The address collection that contains the recipients of message.              | [optional] 
**XMailer** | **string** | The X-Mailer the software that created the e-mail message.              | [optional] 


## Example
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

[[Back to Model list]](Models.md) [[Back to README]](README.md)

