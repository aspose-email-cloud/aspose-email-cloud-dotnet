# Aspose.Email Cloud SDK for .NET
[![NuGet](https://img.shields.io/nuget/v/Aspose.Email-Cloud.svg)](https://www.nuget.org/packages/Aspose.Email-Cloud/) [![License](https://img.shields.io/github/license/aspose-email-cloud/aspose-email-cloud-dotnet)](https://www.nuget.org/packages/Aspose.Email-Cloud/)

This repository contains Aspose.Email Cloud SDK for .NET source code. This SDK allows you to work with Aspose.Email Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

[Aspose.Email Cloud home](https://products.aspose.cloud/email/family "Aspose.Email Cloud")  
[API Reference](https://apireference.aspose.cloud/email/)  

# Key features
Aspose.Email Cloud is a REST API for creating email applications that work with standard email file formats. This SDK:
- Lets developers manipulate different emails' formats such as Outlook MSG, EML, VCard, and iCalendar files
- Supports AI functions:
    - The Business card recognition
    - The Name API for parsing and handling personal names
- Has a built-in email client. This client provides:
    - Unified REST API for different email protocols: IMAP, POP3, SMTP, EWS, WebDav
    - Virtual multi-account
    - Message threads (POP3 accounts are also supported)
- Email configuration discovery
- Disposable email address detection

## New features in version 20.5
- [Manipulating message threads using Aspose.Email Cloud build-in client](https://docs.aspose.cloud/display/emailcloud/Email+Client+Threads)
- [File converters](https://docs.aspose.cloud/display/emailcloud/Convert+Email%2C+Calendar+and+Contact+Files):
    - EmailDto<->EML<->MSG<->MHTML
    - ContactDto<->VCard VCF<->MapiContact MSG
    - CalendarDto<->iCalendar ICS<->MapiCalendar MSG

See [Release notes](https://docs.aspose.cloud/display/emailcloud/Aspose.Email+Cloud+20.5+Release+Notes)


## How to use the SDK?
The complete source code is available in the GIT repository.

Use [SDK tutorials](https://docs.aspose.cloud/display/emailcloud/SDK+Tutorials):
- [SDK setup](https://docs.aspose.cloud/display/emailcloud/SDK+setup) - installation, account setup, first API calls
- [Business Cards Recognition API](https://docs.aspose.cloud/display/emailcloud/Business+Cards+Recognition+API) - convert captured business cards and name card images, into a vCard format
- [Working with Name API](https://docs.aspose.cloud/display/emailcloud/Working+with+Name+API) - format, genderize, compare, parse, autocomplete names
- [Email Message Files](https://docs.aspose.cloud/display/emailcloud/Email+Message+Files) - Convert EML to MSG and back, edit EML files, etc.
- [Quick Start With iCalendar API](https://docs.aspose.cloud/display/emailcloud/Quick+Start+With+iCalendar+API) - Crate and edit iCalendar files
- [Quick Start With VCard API](https://docs.aspose.cloud/display/emailcloud/Quick+Start+With+VCard+API) - Create and edit VCard files, business card recognition
- [Quick Start With Email Client](https://docs.aspose.cloud/display/emailcloud/Quick+Start+With+Email+Client) - Setup builtin email client, search/fetch/send/move/delete messages
- [Email Client Threads](https://docs.aspose.cloud/display/emailcloud/Email+Client+Threads) - Fetch/Move/Delete email message threads using builtin email client
- [File converters](https://docs.aspose.cloud/display/emailcloud/Convert+Email%2C+Calendar+and+Contact+Files)

SDK reference documentation is available in [this README](https://github.com/aspose-email-cloud/aspose-email-cloud-dotnet/blob/master/docs/README.md)

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

See more details about SDK installation in this tutorial: [SDK setup](https://docs.aspose.cloud/display/emailcloud/SDK+setup)

### Usage examples
To use the API, you should create an EmailApi object:
```csharp
using Aspose.Email.Cloud.Sdk.Api; //EmailApi class is here
using Aspose.Email.Cloud.Sdk.Model; //REST API models are here
using Aspose.Email.Cloud.Sdk.Model.Requests; //Request models are here (all API calls use corresponding request model class)

...
var appKey = "Your App Key";
var appSid = "Your App SID";
var emailApi = new EmailApi(appKey, appSid);

var result = await emailApi.GetCalendarAsync(new GetCalendarRequest(calendarFile, folder, StorageName));
```

#### Business cards recognition API

Use `AiBcrParseModel` method to parse business card image to VCard DTO:

```csharp
var bytes = File.ReadAllBytes(imageFilePath);
var imageBase64 = Convert.ToBase64String(bytes);
var result = await emailApi.AiBcrParseModelAsync(new AiBcrParseModelRequest(
    new AiBcrBase64Rq(null,
        new List<AiBcrBase64Image>
        {
            new AiBcrBase64Image(true, imageBase64)
        })));
ContactDto firstVCard = result.Value.First();
```

See more details [here](https://docs.aspose.cloud/display/emailcloud/Parse+Image+To+VCard+File) and [here](https://docs.aspose.cloud/display/emailcloud/Business+Cards+Recognition+API)

# Licensing
All Aspose.Email Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

# Resources
+ [**SDK Reference documentation**](docs/README.md)
+ [**Website**](https://www.aspose.cloud)
+ [**Product Home**](https://products.aspose.cloud/Email)
+ [**Documentation**](https://docs.aspose.cloud/display/Emailcloud/Home)
+ [**API Reference**](https://apireference.aspose.cloud/email/)
+ [**Free Support Forum**](https://forum.aspose.cloud/c/email)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
+ [**Blog**](https://blog.aspose.cloud/category/aspose-products/aspose-email-cloud/)
+ [**Git repository: Aspose.Email Cloud SDK for .Net**](https://github.com/aspose-email-cloud/aspose-email-cloud-dotnet)
+ [**Git repository: Aspose.Email Cloud SDK for Ruby**](https://github.com/aspose-email-cloud/aspose-email-cloud-ruby)
+ [**Git repository: Aspose.Email Cloud SDK for Python**](https://github.com/aspose-email-cloud/aspose-email-cloud-python)
+ [**Git repository: Aspose.Email Cloud SDK for PHP**](https://github.com/aspose-email-cloud/aspose-email-cloud-php)
+ [**Git repository: Aspose.Email Cloud SDK for Typescript**](https://github.com/aspose-email-cloud/aspose-email-cloud-node)
+ [**Git repository: Aspose.Email Cloud SDK for Java**](https://github.com/aspose-email-cloud/aspose-email-cloud-java)
