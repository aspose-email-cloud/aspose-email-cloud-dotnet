# Model.MapiMessageItemBaseDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | [**List&lt;MapiAttachmentDto&gt;**](MapiAttachmentDto.md) | Message item attachments.              | [optional] 
**Billing** | **string** | Billing information associated with an item.              | [optional] 
**Body** | **string** | Message text.              | [optional] 
**BodyHtml** | **string** | Gets the BodyRtf of the message converted to HTML, if present, otherwise an empty string.              | [optional] 
**BodyRtf** | **string** | RTF formatted message text.              | [optional] 
**BodyType** | **string** | The content type of message body. Enum, available values: PlainText, Html, Rtf | 
**Categories** | **List&lt;string&gt;** | Contains keywords or categories for the message object.              | [optional] 
**Companies** | **List&lt;string&gt;** | Contains the names of the companies that are associated with an item.              | [optional] 
**ItemId** | **string** | The item id, uses with a server.              | [optional] 
**MessageClass** | **string** | Case-sensitive string that identifies the sender-defined message class, such as IPM.Note. The message class specifies the type, purpose, or content of the message.              | [optional] 
**Mileage** | **string** | Contains the mileage information that is associated with an item.              | [optional] 
**Recipients** | [**List&lt;MapiRecipientDto&gt;**](MapiRecipientDto.md) | Recipients of the message.              | [optional] 
**Sensitivity** | **string** | Contains values that indicate the message sensitivity. Enum, available values: None, Personal, Private, CompanyConfidential | 
**Subject** | **string** | Subject of the message.              | [optional] 
**SubjectPrefix** | **string** | Subject prefix that typically indicates some action on a message, such as \&quot;FW: \&quot; for forwarding.              | [optional] 
**Properties** | [**List&lt;MapiPropertyDto&gt;**](MapiPropertyDto.md) | List of MAPI properties              | [optional] 
**Discriminator** | **string** |  | 



[[Back to Model list]](Models.doc) [[Back to README]](README.md)


