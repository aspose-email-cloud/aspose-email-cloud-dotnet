# MapiRecipientDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailAddress** | **string** | Email address of the message recipient or sender.              | [optional] 
**AddressType** | **string** | Type of the address of the message recipient or sender.              | [optional] 
**DisplayName** | **string** | Display name of the message recipient or sender.              | [optional] 
**RecipientType** | **string** | Represent the PR_RECIPIENT_TYPE property which contains the recipient type for a message recipient. Enum, available values: Unknown, MapiBcc, MapiCc, MapiP1, MapiSubmitted, MapiTo | 


## Example
```csharp
var mapiRecipientDto = new MapiRecipientDto
{
    EmailAddress = "to@aspose.com",
    AddressType = "SMTP",
    DisplayName = "To Address",
    RecipientType = "MapiTo"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

