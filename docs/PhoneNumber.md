# PhoneNumber
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | [**EnumWithCustomOfPhoneNumberCategory**](EnumWithCustomOfPhoneNumberCategory.md) | Phone number category.              | [optional] 
**Number** | **string** | Phone number.              | [optional] 
**Preferred** | **bool?** | Defines whether phone number is preferred.              | 


## Example
```csharp
var phoneNumber = new PhoneNumber
{
    Category = new EnumWithCustom<PhoneNumberCategory>
    {
        Value = "Company"
    },
    Number = "+44 141 628 8900",
    Preferred = true
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

