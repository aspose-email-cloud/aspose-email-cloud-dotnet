[![NuGet](https://img.shields.io/nuget/v/Aspose.Email-Cloud.svg)](https://www.nuget.org/packages/Aspose.Email-Cloud/) [![License](https://img.shields.io/github/license/aspose-email-cloud/aspose-email-cloud-dotnet)](https://www.nuget.org/packages/Aspose.Email-Cloud/)

# Manage Emails in Cloud via .NET REST SDK

[Aspose.Email Cloud SDK for .NET](https://products.aspose.cloud/email/net) is a REST API SDK for creating email applications that work with standard email file formats such as Outlook MSG, EML, iCalendar files and VCard.

This SDK allows you to work with Aspose.Email Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

[Aspose.Email Cloud home](https://products.aspose.cloud/email/family)

[Swagger UI](https://apireference.aspose.cloud/email/)  

# Cloud Email Processing Features
Aspose.Email Cloud is a REST API for creating email applications that work with standard email file formats. This SDK:
- Lets developers manipulate different emails' formats such as Outlook MSG, EML, VCard, and iCalendar files.
- Supports AI functions:
    - The Business card recognition.
    - The Name API for parsing and handling personal names.
- Has a built-in email client. This client provides:
    - Unified REST API for different email protocols: IMAP, POP3, SMTP, EWS, WebDav.
    - Virtual multi-account.
    - Message threads (POP3 accounts are also supported).
- Email configuration discovery.
- Disposable email address detection.

## Improvements in version 21.9

Aspose.Email Cloud 21.9.0 comes with improvements described below:

- `EmailCloud.Email.Convert` method documentation fixed.
- Some documentation improvements.
- SDK dependencies updated.

See [Release notes](https://docs.aspose.cloud/email/aspose-email-cloud-21-9-release-notes/).



## How to use the SDK?
The complete source code is available in the [GIT repository](https://github.com/aspose-email-cloud/aspose-email-cloud-dotnet/tree/master/Api).

Use [SDK tutorials](https://docs.aspose.cloud/email/sdk-tutorials/) and [SDK reference documentation](https://docs.aspose.cloud/email/reference-api/).

### Prerequisites

To use this SDK, you need:
- One of supported (or compatible with supported) .NET frameworks:
    - .NETFramework 2.0
    - .NETFramework 4.5.2
    - .NETStandard 2.0
    - MonoAndroid 6.0
    - Xamarin.iOS 1.0
    - Xamarin.Mac 2.0
- A Client id and a Client secret; they can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (it requires free registration in Aspose Cloud for this).

### Installation
You can use SDK directly in your project via the source code or get a [NuGet Package](https://www.nuget.org/packages/Aspose.Email-Cloud/).
From the Package Manager:

    PM> Install-Package Aspose.Email-Cloud

Using .NET CLI:

    dotnet add package Aspose.Email-Cloud

Or as a Package reference:

    <PackageReference Include="Aspose.Email-Cloud"/>

See more details about SDK installation in this tutorial: [SDK setup](https://docs.aspose.cloud/email/sdk-setup/).

### Usage examples
To use the API, you should create an EmailCloud object:
```csharp
using Aspose.Email.Cloud.Sdk.Api; //EmailApi class is here
using Aspose.Email.Cloud.Sdk.Model; //REST API models are here

...
var clientSecret = "Your client secret";
var clientId = "Your client id";
var api = new EmailCloud(clientSecret, clientId);

var result = await api.Calendar.GetAsync(new CalendarGetRequest(calendarFile, folder, StorageName));
```

#### Business cards recognition API

Use `EmailCloud.Ai.Bcr.Parse` method to parse business card image to VCard DTO:

```csharp
var imageFilePath = "path/to/image/to/parse.png";
using (var file = File.OpenRead(imageFilePath))
{
    var result = await api.Ai.Bcr.ParseAsync(
        new AiBcrParseRequest
        {
            File = file,
            IsSingle = true
        });
    ContactDto contact = result.Value.First();
    Assert.AreEqual("Parsed Display Name", contact.DisplayName);
}
```

## Aspose.Email Cloud SDKs in Popular Languages

| .NET | Java | PHP | Python | Ruby | Node.js |
|------|------|-----|--------|------|---------|
| [GitHub](https://github.com/aspose-email-cloud/aspose-email-cloud-dotnet) | [GitHub](https://github.com/aspose-email-cloud/aspose-email-cloud-java) | [GitHub](https://github.com/aspose-email-cloud/aspose-email-cloud-php) | [GitHub](https://github.com/aspose-email-cloud/aspose-email-cloud-python) | [GitHub](https://github.com/aspose-email-cloud/aspose-email-cloud-ruby)  | [GitHub](https://github.com/aspose-email-cloud/aspose-email-cloud-node) |
| [NuGet](https://www.nuget.org/packages/Aspose.Email-Cloud/) | [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-email-cloud) | [Composer](https://packagist.org/packages/aspose/aspose-email-cloud) | [PIP](https://pypi.org/project/aspose.email-cloud/) | [GEM](https://rubygems.org/gems/aspose_email_cloud)  | [NPM](https://www.npmjs.com/package/@asposecloud/aspose-email-cloud) |

[Product Page](https://products.aspose.cloud/email/net) | [Documentation](https://docs.aspose.cloud/email/) | [Demo](https://products.aspose.app/email/family) | [Swagger UI](https://apireference.aspose.cloud/email/) | [Blog](https://blog.aspose.cloud/category/email/) | [Free support](https://forum.aspose.cloud/c/email) | [Free trial](https://dashboard.aspose.cloud/#/apps) | [SDK reference documentation](https://docs.aspose.cloud/email/reference-api)