# EmailAccountConfigList
## Properties
Class has no properties

## Parent class

See: [ListResponseOfEmailAccountConfig](ListResponseOfEmailAccountConfig.md)

## Example
```csharp
var emailAccountConfigList = new EmailAccountConfigList
{
    Value = new List<EmailAccountConfig>
    {
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            Host = "imap.gmail.com",
            Port = 993,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "SMTP",
            Host = "smtp.gmail.com",
            Port = 465,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        },
        new EmailAccountConfig
        {
            DisplayName = "Google Mail",
            ProtocolType = "POP3",
            Host = "pop.gmail.com",
            Port = 995,
            SocketType = "SSLAuto",
            AuthenticationTypes = new List<AuthenticationType>
            {
                "PasswordCleartext",
                "OAuth2"
            },
            ExtraInfo = new List<NameValuePair>
            {
                new NameValuePair
                {
                    Name = "Enable: You need to enable IMAP access",
                    Value = "https://mail.google.com/mail/?ui=2&shva=1#settings/fwdandpop"
                }
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

