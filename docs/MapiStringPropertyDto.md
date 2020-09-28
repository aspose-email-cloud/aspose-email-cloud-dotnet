# MapiStringPropertyDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | Property value              | [optional] 

## Parent class

See: [MapiPropertyDto](MapiPropertyDto.md)

## Example
```csharp
var mapiStringPropertyDto = new MapiStringPropertyDto
{
    Value = "SomeName",
    Descriptor = new MapiKnownPropertyDescriptor
    {
        Name = "DisplayName"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

