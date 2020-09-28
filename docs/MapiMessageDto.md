# MapiMessageDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageBody** | **string** | Message text              | [optional] 
**ClientSubmitTime** | **DateTime?** | Date and time the message sender submitted a message.              | 
**ConversationTopic** | **string** | Topic of the first message in a conversation thread.              | [optional] 
**DeliveryTime** | **DateTime?** | Date and time a message was delivered.              | 
**DisplayBcc** | **string** | List of the display names of any blind carbon copy (BCC) message recipients, separated by semicolons (;).              | [optional] 
**DisplayCc** | **string** | List of the display names of any carbon copy (CC) message recipients, separated by semicolons (;).              | [optional] 
**DisplayName** | **string** | Display name for the message.              | [optional] 
**DisplayNamePrefix** | **string** | Prefix of the display name.              | [optional] 
**DisplayTo** | **string** | List of the display names of the primary (To) message recipients, separated by semicolons (;).              | [optional] 
**Flags** | **List&lt;string&gt;** | Message flags.              Items: Mapi message flags. Enum, available values: MsgFlagZero, MsgFlagRead, MsgFlagUnmodified, MsgFlagSubmit, MsgFlagUnsent, MsgFlagHasAttach, MsgFlagFromMe, MsgFlagAssociated, MsgFlagResend, MsgFlagNotifyRead, MsgFlagNotifyUnread, MsgFlagEverRead, MsgFlagOriginX400, MsgFlagOriginInternet, MsgFlagOriginMiscExt | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Transport message headers              | [optional] 
**InternetMessageId** | **string** | Internet message id of the message.              | [optional] 
**MessageFormat** | **string** | Represents outlook message format. Enum, available values: Ascii, Unicode | 
**NormalizedSubject** | **string** | Normalized subject of the message.              | [optional] 
**ReadReceiptRequested** | **bool?** | Value indicating whether the read receipt is requested. | 
**ReplyTo** | **string** | Reply to names. | [optional] 
**SenderAddressType** | **string** | Message sender&#39;s e-mail address type. | [optional] 
**SenderEmailAddress** | **string** | Message sender&#39;s e-mail address. | [optional] 
**SenderName** | **string** | Message sender&#39;s display name. | [optional] 
**SenderSmtpAddress** | **string** | Message sender&#39;s e-mail address. | [optional] 
**SentRepresentingAddressType** | **string** | Address type for the messaging user represented by the sender. | [optional] 
**SentRepresentingEmailAddress** | **string** | E-mail address for the messaging user represented by the sender. | [optional] 
**SentRepresentingName** | **string** | Display name for the messaging user represented by the sender. | [optional] 
**SentRepresentingSmtpAddress** | **string** | E-mail address for the messaging user represented by the sender. | [optional] 
**TransportMessageHeaders** | **string** | Transport-specific message envelope information. | [optional] 

## Parent class

See: [MapiMessageItemBaseDto](MapiMessageItemBaseDto.md)

## Example
```csharp
var mapiMessageDto = new MapiMessageDto
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

[[Back to Model list]](Models.md) [[Back to README]](README.md)

