# ContactDto
VCard document representation.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssociatedPersons** | [**List&lt;AssociatedPerson&gt;**](AssociatedPerson.md) | Associated persons.              | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Document attachments.              | [optional] 
**CompanyName** | **string** | Company name.              | [optional] 
**ComputerNetworkName** | **string** | Computer network.              | [optional] 
**CustomerId** | **string** | Customer id.              | [optional] 
**DepartmentName** | **string** | Department name.              | [optional] 
**DisplayName** | **string** | Display name.              | [optional] 
**EmailAddresses** | [**List&lt;EmailAddress&gt;**](EmailAddress.md) | Person&#39;s email addresses.              | [optional] 
**Events** | [**List&lt;CustomerEvent&gt;**](CustomerEvent.md) | Person&#39;s events.              | [optional] 
**FileAs** | **string** | A name used for sorting.              | [optional] 
**FileAsMapping** | **string** | Specifies how to generate and recompute the value of the dispidFileAs property when other contact name properties change. Coincides MS-OXPROPS revision 16.2 from 7/31/2014. Enum, available values: Empty, DisplayName, FirstName, LastName, Organization, LastFirstMiddle, OrgLastFirstMiddle, LastFirstMiddleOrg, LastFirstMiddle2, LastFirstMiddle3, OrgLastFirstMiddle2, OrgLastFirstMiddle3, LastFirstMiddleOrg2, LastFirstMiddleOrg3, LastFirstMiddleGen, FirstMiddleLastGen, LastFirstMiddleGen2, BestMatch, AccordingToLocale, None | 
**FreeBusyLocation** | **string** | URL path from which a client can retrieve free/busy information for the contact as an iCal file.              | [optional] 
**Gender** | **string** | Enum defines gender of a person. Enum, available values: Unspecified, Female, Male | 
**GivenName** | **string** | Person&#39;s given name.              | [optional] 
**GovernmentIdNumber** | **string** | Government id number.              | [optional] 
**Hobbies** | **string** | Person&#39;s hobbies.              | [optional] 
**Initials** | **string** | Person&#39;s initials.              | [optional] 
**InstantMessengers** | [**List&lt;InstantMessengerAddress&gt;**](InstantMessengerAddress.md) | Person&#39;s instant messenger addresses.              | [optional] 
**JobTitle** | **string** | Person&#39;s job title.              | [optional] 
**Language** | **string** | Language.              | [optional] 
**Location** | **string** | Person&#39;s location.              | [optional] 
**MiddleName** | **string** | Person&#39;s middle name.              | [optional] 
**Nickname** | **string** | Person&#39;s nickname.              | [optional] 
**Notes** | **string** | Notes.              | [optional] 
**NotesFormat** | **string** | Defines format of a text. Enum, available values: Text, Html | 
**OfficeLocation** | **string** | Office location.              | [optional] 
**OrganizationalIdNumber** | **string** | Contains an identifier for the mail user used within the mail user&#39;s organization.              | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) | Person&#39;s phone numbers.              | [optional] 
**Photo** | [**ContactPhoto**](ContactPhoto.md) | Person&#39;s photo.              | [optional] 
**PhysicalAddresses** | [**List&lt;PostalAddress&gt;**](PostalAddress.md) | Person&#39;s physical addresses.              | [optional] 
**PreferredTextEncoding** | **string** | Encoding for all text properties.              | [optional] 
**Prefix** | **string** | A prefix of a full name such like Mr.(mister), Dr.(doctor) and so on.              | [optional] 
**Profession** | **string** | A job position of a person in a company.              | [optional] 
**Suffix** | **string** | A suffix of a full name such like Jr.(junior), Sr.(senior) and so on.              | [optional] 
**Surname** | **string** | Person&#39;s surname.              | [optional] 
**Urls** | [**List&lt;Url&gt;**](Url.md) | Person&#39;s urls.              | [optional] 


## Example
```csharp
var contactDto = new ContactDto
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
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

