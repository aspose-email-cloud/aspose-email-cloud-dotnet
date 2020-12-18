
# EmailConfigDiscoverRequest

Request model for EmailConfigApi.Discover

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**address** |**string**|Email address. |
**fastProcessing** |**bool?**|Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.              |[optional] [default to false]

## Example
```csharp
var request = new EmailConfigDiscoverRequest
{ 
    Address = "address@gmail.com"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
