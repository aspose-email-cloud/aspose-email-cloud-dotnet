# EmailStorageList
## Properties
Class has no properties

## Parent class

See: [ListResponseOfStorageModelOfEmailDto](ListResponseOfStorageModelOfEmailDto.md)

## Example
```csharp
var emailStorageList = new EmailStorageList
{
    Value = new List<StorageModel<EmailDto>>
    {
        new EmailSaveRequest
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "message.eml",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new EmailDto
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
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

