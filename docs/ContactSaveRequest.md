# ContactSaveRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | Enumerates contact formats. Enum, available values: VCard, WebDav, Msg | 

## Parent class

See: [StorageModelOfContactDto](StorageModelOfContactDto.md)

## Example
```csharp
var contactSaveRequest = new ContactSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "contact.vcf",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new ContactDto
    {
        Attachments = new List<Attachment>
        {
            new Attachment
            {
                Name = "attachment.txt",
                Base64Data = "U29tZSBmaWxlIGNvbnRlbnQ="
            }
        },
        DisplayName = "Alex Thomas",
        EmailAddresses = new List<EmailAddress>
        {
            new EmailAddress
            {
                Category = new EnumWithCustom<EmailAddressCategory>
                {
                    Value = "Custom",
                    Description = "Partners"
                },
                DisplayName = "Alex Thomas Partners",
                Preferred = true,
                Address = "email@aspose.com"
            }
        },
        Gender = "Male",
        GivenName = "Alex",
        PhoneNumbers = new List<PhoneNumber>
        {
            new PhoneNumber
            {
                Category = new EnumWithCustom<PhoneNumberCategory>
                {
                    Value = "Office"
                },
                Number = "+49 211 4247 21",
                Preferred = true
            }
        },
        Profession = "GENERAL DIRECTOR",
        Surname = "Thomas",
        Urls = new List<Url>
        {
            new Url
            {
                Category = new EnumWithCustom<UrlCategory>
                {
                    Value = "Work"
                },
                Preferred = true,
                Href = "www.aspose.com"
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

