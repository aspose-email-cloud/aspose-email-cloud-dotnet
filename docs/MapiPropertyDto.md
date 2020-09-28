# MapiPropertyDto
Mapi property             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Descriptor** | [**MapiPropertyDescriptor**](MapiPropertyDescriptor.md) | Property descriptor              | [optional] 
**Discriminator** | **string** |  | 


## Example
```csharp
var mapiPropertyDto = new MapiPropertyDto
{
    Descriptor = new MapiKnownPropertyDescriptor
    {
        Name = "DisplayName"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

