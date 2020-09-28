# PostalAddress
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Address.              | [optional] 
**Category** | [**EnumWithCustomOfPostalAddressCategory**](EnumWithCustomOfPostalAddressCategory.md) | Address category.              | [optional] 
**City** | **string** | Address&#39;s city.              | [optional] 
**Country** | **string** | Address&#39;s country.              | [optional] 
**CountryCode** | **string** | Country code.              | [optional] 
**IsMailingAddress** | **bool?** | Defines whether address may be used for mailing.              | 
**PostalCode** | **string** | Postal code.              | [optional] 
**PostOfficeBox** | **string** | Post Office box.              | [optional] 
**Preferred** | **bool?** | Defines whether postal address is preferred.              | 
**StateOrProvince** | **string** | Address&#39;s region.              | [optional] 
**Street** | **string** | Address&#39;s street.              | [optional] 


## Example
```csharp
var postalAddress = new PostalAddress
{
    Address = "221b",
    Category = new EnumWithCustom<PostalAddressCategory>
    {
        
    },
    City = "London",
    Country = "United Kingdom",
    IsMailingAddress = true,
    PostalCode = "NW1 6XE",
    Preferred = true,
    Street = "Baker St"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

