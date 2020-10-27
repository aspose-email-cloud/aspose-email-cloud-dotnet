# Manage Emails in Cloud via .NET REST SDK
[![NuGet](https://img.shields.io/nuget/v/Aspose.Email-Cloud.svg)](https://www.nuget.org/packages/Aspose.Email-Cloud/) [![License](https://img.shields.io/github/license/aspose-email-cloud/aspose-email-cloud-dotnet)](https://www.nuget.org/packages/Aspose.Email-Cloud/)

[Aspose.Email Cloud SDK for .NET](https://products.aspose.cloud/email/net) is a REST API SDK for creating email applications that work with standard email file formats such as Outlook MSG, EML, iCalendar files and VCard.

This SDK allows you to work with Aspose.Email Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

[Aspose.Email Cloud home](https://products.aspose.cloud/email/family)  
[API Reference](https://apireference.aspose.cloud/email/)  

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

## New features in version 20.10

Aspose.Email Cloud 20.10.0 comes with SDK improvements:

- Typescript, PHP, Java SDKs now have model builders to simplify their initialization.
- All SDK methods now have code examples with parameters initialization.
- Some models now have initialization examples for all SDKs.
- SDK reference documentation with examples now available at url [docs.aspose.cloud/email/reference-api](https://docs.aspose.cloud/email/reference-api/) 

See [Release notes](https://docs.aspose.cloud/email/aspose-email-cloud-20-10-release-notes/).


## How to use the SDK?
The complete source code is available in the [GIT repository](https://github.com/aspose-email-cloud/aspose-email-cloud-dotnet/tree/master/Api).

Use [SDK tutorials](https://docs.aspose.cloud/display/emailcloud/SDK+Tutorials).

SDK reference documentation is available in [this README](https://github.com/aspose-email-cloud/aspose-email-cloud-dotnet/blob/master/docs/README.md).

### Prerequisites

To use this SDK, you need:
- One of supported (or compatible with supported) .NET frameworks:
    - .NETFramework 2.0
    - .NETFramework 4.5.2
    - .NETStandard 2.0
    - MonoAndroid 6.0
    - Xamarin.iOS 1.0
    - Xamarin.Mac 2.0
- An App SID and an App Key; they can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (it requires free registration in Aspose Cloud for this).

### Installation
You can use SDK directly in your project via the source code or get a [NuGet Package](https://www.nuget.org/packages/Aspose.Email-Cloud/).
From the Package Manager:

    PM> Install-Package Aspose.Email-Cloud

Using .NET CLI:

    dotnet add package Aspose.Email-Cloud

Or as a Package reference:

    <PackageReference Include="Aspose.Email-Cloud"/>

See more details about SDK installation in this tutorial: [SDK setup](https://docs.aspose.cloud/display/emailcloud/SDK+setup).

### Usage examples
To use the API, you should create an EmailCloud object:
```csharp
using Aspose.Email.Cloud.Sdk.Api; //EmailApi class is here
using Aspose.Email.Cloud.Sdk.Model; //REST API models are here

...
var appKey = "Your App Key";
var appSid = "Your App SID";
var api = new EmailCloud(appKey, appSid);

var result = await api.Calendar.GetAsync(new CalendarGetRequest(calendarFile, folder, StorageName));
```

#### Business cards recognition API

Use `EmailCloud.Ai.Bcr.Parse` method to parse business card image to VCard DTO:

```csharp
var imageFilePath = "path/to/image/to/parse.png";
using (var file = File.OpenRead(imageFilePath))
{
    var result = await api.Ai.Bcr.ParseAsync(
        new AiBcrParseRequest(file, isSingle: true));
    ContactDto contact = result.Value.First();
    Assert.AreEqual("Parsed Display Name", contact.DisplayName);
}
```

[Product Page](https://products.aspose.cloud/email/net) | [Documentation](https://docs.aspose.cloud/display/Emailcloud/Home) | [Demo](https://products.aspose.app/email/family) | [API Reference](https://apireference.aspose.cloud/email/) | [Blog](https://blog.aspose.cloud/category/email/) | [Free support](https://forum.aspose.cloud/c/email) | [Free trial](https://dashboard.aspose.cloud/#/apps)