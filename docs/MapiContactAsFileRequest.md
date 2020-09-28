# MapiContactAsFileRequest
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | Enumerates contact formats. Enum, available values: VCard, WebDav, Msg | 
**Value** | [**MapiContactDto**](MapiContactDto.md) | MAPI contact model.              | 


## Example
```csharp
var mapiContactAsFileRequest = new MapiContactAsFileRequest
{
    Format = "Msg",
    Value = new MapiContactDto
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
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

