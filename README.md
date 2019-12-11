Aspose.Email Cloud is a REST API for creating email applications that work with common email file formats.
- Lets developers manipulate formats related to emailing such as Outlook MSG, EML, VCard and iCalendar files
- Has built-in email client
- Supports AI functionalities:
    - Business card recognition
    - Name API for parsing and handling personal names

To use these SDKs, you will need App SID and App Key which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

## How to use the SDK?
The complete source code is available in the GIT repository. 
Use reference documentation available [**here**](docs/README.md)

### Usage examples
To use API you should create EmailApi object:
```csharp
using Aspose.Email.Cloud.Sdk.Api; //EmailApi class is here
using Aspose.Email.Cloud.Sdk.Model; //REST API models here
using Aspose.Email.Cloud.Sdk.Model.Requests; //Request models here (all API calls use corresponding request model class)

...
var appKey = "Your App Key";
var appSid = "Your App SID";
var emailApi = new EmailApi(appKey, appSid);
```

API calls could be synchronous or asynchronous (if supported by framework):
```csharp
var result = emailApi.GetCalendar(new GetCalendarRequest(calendarFile, folder, StorageName));
// or
var result = await emailApi.GetCalendarAsync(new GetCalendarRequest(calendarFile, folder, StorageName));
```

#### Business card recognition API
See examples below:

<details open>
    <summary>Parse business card images to VCard contact files</summary>

```csharp
// Upload business card image to storage
var storageName = "First Storage"; //Your storage name
var imageFileName = "someFileName.png"; //Different image formats are supported (PNG, JPEG, BMP, TIFF, GIF...)
using (var stream = File.OpenRead("some/business/card/image/file/on/disk"))
{
    await emailApi.UploadFileAsync(new UploadFileRequest(imageFileName, stream, storageName));
}

var outFolder = "some/folder/on/storage"; //Business card recognition results will be placed here
await emailApi.CreateFolderAsync(new CreateFolderRequest(outFolder, storageName));
// Call business card recognition action
var result = await emailApi.AiBcrParseStorageAsync(new AiBcrParseStorageRequest(
    new AiBcrParseStorageRq
    {
        Images = new List<AiBcrImageStorageFile> //We can process multiple images in just one request
        {
            new AiBcrImageStorageFile
            {
                File = new StorageFileLocation
                {
                    Storage = storageName,
                    FileName = imageFileName,
                    FolderPath = string.Empty //image was uploaded to the root directory of storage
                },
                IsSingle = true //image contains only one business card (you can upload image with multiple cards on it)
            }
        },
        OutFolder = new StorageFolderLocation
        {
            Storage = storageName,
            FolderPath = outFolder
        }
    }));
// Get file name from recognition result
var contactFile = result.Value.First(); //result.Value can contain multiple files, if we sent multicard images or multiple images

// You can download VCard file, produced by recognition method ...
using (var contactFileStream = await emailApi.DownloadFileAsync(new DownloadFileRequest(
    $"{contactFile.FolderPath}/{contactFile.FileName}", contactFile.Storage)))
//... and save it to a "contact.vcf" file
using (var fileStream = File.Create("path/to/contact.vcf"))
{
    contactFileStream.CopyTo(fileStream);
}

// Or get VCard object properties list using Contact API
var contactProperties = await emailApi.GetContactPropertiesAsync(new GetContactPropertiesRequest(
    "vcard", contactFile.FileName, contactFile.FolderPath, contactFile.Storage));
//All VCard properties available as a list. Complex properties represented as hierarchical structures.
//Let's print all primitive property values:
var primitiveProperties = contactProperties.InternalProperties
    .Where(property => property is PrimitiveObject)
    .Select(property => property as PrimitiveObject)
    .ToList();
foreach(var primitiveProperty in primitiveProperties)
{
    System.Console.WriteLine($"Property name: {primitiveProperty.Name}, value: {primitiveProperty.Value}");
}
```
</details>


<details>
    <summary>Parse images directly, without use of storage</summary>

```csharp
//Read image from file and convert it to Base64 string
var bytes = File.ReadAllBytes("some/business/card/image/file/on/disk");
var base64Image = Convert.ToBase64String(bytes);
var result = await emailApi.AiBcrParseAsync(
    new AiBcrParseRequest(
        new AiBcrBase64Rq
        {
            Images = new List<AiBcrBase64Image>
            {
                new AiBcrBase64Image
                {
                    Base64Data = base64Image,
                    IsSingle = true
                }
            }
        }));
//Result contains all recognized VCard objects (only one in our case)
var contactProperties = result.Value.First();

//VCard object is available as list of properties, without any external calls:
var primitiveProperties = contactProperties.InternalProperties
    .Where(property => property is PrimitiveObject)
    .Select(property => property as PrimitiveObject)
    .ToList();
foreach(var primitiveProperty in primitiveProperties)
{
    System.Console.WriteLine($"Property name: {primitiveProperty.Name}, value: {primitiveProperty.Value}");
}
```
</details>

#### Name API
See examples below:
<details open>
    <summary>Detect person's gender by name</summary>

```csharp
var name = "John Cane";
var result = await emailApi.AiNameGenderizeAsync(
    new AiNameGenderizeRequest(name));
//result contains list of hypothesis about person's gender.
//all hypothesis include score, so you can use most scored version, which will be first in list:
System.Console.WriteLine(result.Value.First().Gender); //prints "Male"
```
</details>

<details>
    <summary>Format person's name using defined format</summary>

```csharp
var result = await emailApi.AiNameFormatAsync(
    new AiNameFormatRequest(
        "Mr. John Michael Cane",
        format:"%t%L%f%m"));
System.Console.WriteLine(result.Name); //prints "Mr. Cane J. M."
```
</details>

<details>
    <summary>Compare names to detect that they related to same person or not</summary>

```csharp
const string first = "John Michael Cane";
const string second = "Cane J.";
var result = await emailApi.AiNameMatchAsync(
    new AiNameMatchRequest(first, second));
System.Console.WriteLine(result.Similarity > 0.5); //prints "true", names look similar
```
</details>

<details>
    <summary>Expand a person's name into a list of possible alternatives</summary>


```csharp
const string name = "Smith Bobby";
var result = await emailApi.AiNameExpandAsync(
    new AiNameExpandRequest(name));
var expandedNames = result
    .Names
    .Select(weightedName => weightedName.Name)
    .ToList();
foreach(var expandedName in expandedNames)
{
    System.Console.WriteLine(expandedName); //prints "Mr. Smith", "B. Smith", etc.
}
```
</details>

<details>
    <summary>Get k most probable names for given starting characters</summary>

```csharp
const string prefix = "Dav";
var result = await emailApi.AiNameCompleteAsync(
    new AiNameCompleteRequest(prefix));
var names = result.Names
    .Select(weightedName => $"{prefix}{weightedName.Name}")
    .ToList();
foreach(var name in names)
{
    System.Console.WriteLine(name); //prints David", "Dave", "Davis", etc.
}
```
</details>

<details>
    <summary>Parse the person's name out of an email address.</summary>

```csharp
const string address = "john-cane@gmail.com";
var result = await emailApi.AiNameParseEmailAddressAsync(
    new AiNameParseEmailAddressRequest(address));
var extractedValues = result.Value
    .SelectMany(value => value.Name)
    .ToList();
var givenName = extractedValues.First(value => value.Category == "GivenName");
var surName = extractedValues.First(value => value.Category == "Surname");

System.Console.WriteLine(givenName.Value); // "John"
System.Console.WriteLine(surName.Value); // "Cane"
```
</details>

### Install Aspose.Email for Cloud via NuGet
You can either directly use it in your project via source code or get [NuGet Package](https://www.nuget.org/packages/Aspose.Email-Cloud/).
From Package Manager:
`PM> Install-Package Aspose.Email-Cloud`
Using .NET CLI:
`dotnet add package Aspose.Email-Cloud`
Or as Package reference:
`<PackageReference Include="Aspose.Email-Cloud"/>`

# Licensing
All Aspose.Email Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

# Resources
+ [**SDK Reference documentation**](docs/README.md)
+ [**Website**](https://www.aspose.cloud)
+ [**Product Home**](https://products.aspose.cloud/Email/cloud)
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
