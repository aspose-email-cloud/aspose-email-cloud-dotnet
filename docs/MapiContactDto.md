# MapiContactDto
Represents outlook contact information.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectronicAddresses** | [**MapiContactElectronicAddressPropertySetDto**](MapiContactElectronicAddressPropertySetDto.md) | Specify properties for up to three different e-mail addresses and three different fax addresses.              | [optional] 
**Events** | [**MapiContactEventPropertySetDto**](MapiContactEventPropertySetDto.md) | Specify events associated with a contact.              | [optional] 
**NameInfo** | [**MapiContactNamePropertySetDto**](MapiContactNamePropertySetDto.md) | The properties are used to specify the name of the person represented by the contact.              | [optional] 
**OtherFields** | [**MapiContactOtherPropertySetDto**](MapiContactOtherPropertySetDto.md) | Specify other fields of contact.              | [optional] 
**PersonalInfo** | [**MapiContactPersonalInfoPropertySetDto**](MapiContactPersonalInfoPropertySetDto.md) | Specify other additional contact information.              | [optional] 
**Photo** | [**MapiContactPhotoDto**](MapiContactPhotoDto.md) | Contact photo.              | [optional] 
**PhysicalAddresses** | [**MapiContactPhysicalAddressPropertySetDto**](MapiContactPhysicalAddressPropertySetDto.md) | Specify three physical addresses: Home Address, Work Address, and Other Address. One of the addresses can be marked as the Mailing Address.              | [optional] 
**ProfessionalInfo** | [**MapiContactProfessionalPropertySetDto**](MapiContactProfessionalPropertySetDto.md) | Properties are used to store professional details for the person represented by the contact.              | [optional] 
**Telephones** | [**MapiContactTelephonePropertySetDto**](MapiContactTelephonePropertySetDto.md) | Specify telephone numbers for the contact.              | [optional] 

## Parent class

See: [MapiMessageItemBaseDto](MapiMessageItemBaseDto.md)

## Example
```csharp
var mapiContactDto = new MapiContactDto
{
    ElectronicAddresses = new MapiContactElectronicAddressPropertySetDto
    {
        DefaultEmailAddress = new MapiContactElectronicAddressDto
        {
            EmailAddress = "email@aspose.com"
        }
    },
    NameInfo = new MapiContactNamePropertySetDto
    {
        GivenName = "Alex",
        Surname = "Thomas"
    },
    PersonalInfo = new MapiContactPersonalInfoPropertySetDto
    {
        BusinessHomePage = "www.aspose.com"
    },
    ProfessionalInfo = new MapiContactProfessionalPropertySetDto
    {
        Profession = "GENERAL DIRECTOR"
    },
    Telephones = new MapiContactTelephonePropertySetDto
    {
        PrimaryTelephoneNumber = "+49 211 4247 21"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

