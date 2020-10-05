# Url
Url and its category.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | [**EnumWithCustomOfUrlCategory**](EnumWithCustomOfUrlCategory.md) | Url category.              | [optional] 
**Preferred** | **bool?** | Defines whether url is preferred.              | 
**Href** | **string** | URL.              | [optional] 


## Example
```csharp
var url = new Url
{
    Category = new EnumWithCustomOfUrlCategory
    {
        Value = "Work"
    },
    Preferred = true,
    Href = "https://products.aspose.cloud/email"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

