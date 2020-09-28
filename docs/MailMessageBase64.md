# MailMessageBase64
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValueBase64** | **string** | Email message file data encoded to Base64 string.              | 
**Format** | **string** | Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft | 

## Parent class

See: [MailMessageBase](MailMessageBase.md)

## Example
```csharp
var mailMessageBase64 = new MailMessageBase64
{
    ValueBase64 = "RnJvbTogZkBmLnVzClRvOiB0QHQudXMKU3ViamVjdDogUwoKQm9keQ=="
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

