# EmailThreadList
## Properties
Class has no properties

## Parent class

See: [ListResponseOfEmailThread](ListResponseOfEmailThread.md)

## Example
```csharp
var emailThreadList = new EmailThreadList
{
    Value = new List<EmailThread>
    {
        new EmailThread
        {
            Id = "123",
            Subject = "Some email subject",
            Messages = new List<EmailDto>
            {
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "1",
                    Subject = "Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                },
                new EmailDto
                {
                    Date = DateTime.Today,
                    From = new MailAddress
                    {
                        Address = "from@aspose.com"
                    },
                    MessageId = "3",
                    Subject = "Re: Some email subject",
                    To = new List<MailAddress>
                    {
                        new MailAddress
                        {
                            Address = "to@aspose.com"
                        }
                    }
                }
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

