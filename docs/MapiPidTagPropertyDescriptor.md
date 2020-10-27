# MapiPidTagPropertyDescriptor
A property that is defined by a 16-bit property ID and a 16-bit property type. The property ID for a tagged property is in the range 0x001 - 0x7FFF. Property IDs in the range 0x8000 - 0x8FFF are reserved for assignment to named properties             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | An unsigned 16-bit quantity that identifies a tagged property. Property IDs are not necessarily unique. With the exception of property IDs in the range from 0x6800 to 0x7BFF, the combination of property ID and data type are unique. Property IDs in the range from 0x6800 to 0x7BFF are defined by the message class.              | 
**Tag** | **long?** | A property tag is a 32-bit number that contains a unique property identifier in bits 16 through 31 and a property type in bits 0 through 15.              | 

## Parent class

See: [MapiPidPropertyDescriptor](MapiPidPropertyDescriptor.md)

[[Back to Model list]](Models.md) [[Back to README]](README.md)

