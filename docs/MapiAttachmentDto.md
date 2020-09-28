# MapiAttachmentDto
Mapi attachment             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Attachment&#39;s name              | [optional] 
**DataBase64** | **string** | Attachment data represented as Base64 string.              | [optional] 


## Example
```csharp
var mapiAttachmentDto = new MapiAttachmentDto
{
    Name = "some-file.txt",
    DataBase64 = "U29tZSBmaWxlIHRleHQ="
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

