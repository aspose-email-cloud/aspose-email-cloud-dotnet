# ContactStorageList
Contact models list with corresponding storage locations.             

## Properties
Class has no properties

## Parent class

See: [ListResponseOfStorageModelOfContactDto](ListResponseOfStorageModelOfContactDto.md)

## Example
```csharp
var contactStorageList = new ContactStorageList
{
    Value = new List<StorageModelOfContactDto>
    {
        new StorageModelOfContactDto
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
                        Category = new EnumWithCustomOfEmailAddressCategory
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
                        Category = new EnumWithCustomOfPhoneNumberCategory
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
                        Category = new EnumWithCustomOfUrlCategory
                        {
                            Value = "Work"
                        },
                        Preferred = true,
                        Href = "www.aspose.com"
                    }
                }
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

