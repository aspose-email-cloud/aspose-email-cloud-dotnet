# MapiResponseTypePropertyDto
Mapi property with response type value             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | Represents the types of recipient responses that are received for a meeting. Enum, available values: Unknown, Organizer, Tentative, Accept, Decline, NoResponseReceived | 

## Parent class

See: [MapiPropertyDto](MapiPropertyDto.md)

## Example
```csharp
var mapiResponseTypePropertyDto = new MapiResponseTypePropertyDto
{
    Value = "Accept",
    Descriptor = new MapiKnownPropertyDescriptor
    {
        Name = "ResponseStatus"
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

