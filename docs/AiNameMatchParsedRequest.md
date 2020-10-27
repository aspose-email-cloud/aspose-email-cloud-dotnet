# AiNameMatchParsedRequest
Two parsed names to match request             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OtherParsedName** | [**List&lt;AiNameComponent&gt;**](AiNameComponent.md) | Other parsed name to match              | 

## Parent class

See: [AiNameParsedRequest](AiNameParsedRequest.md)

## Example
```csharp
var aiNameMatchParsedRequest = new AiNameMatchParsedRequest
{
    OtherParsedName = new List<AiNameComponent>
    {
        new AiNameComponent
        {
            Value = "J",
            Category = "FirstInitial",
            Score = 1
        },
        new AiNameComponent
        {
            Value = "Cane",
            Category = "LastName",
            Score = 0.5,
            Position = 3
        },
        new AiNameComponent
        {
            Value = "%f%L",
            Category = "Format"
        },
        new AiNameComponent
        {
            Value = "0.5",
            Category = "Score",
            Score = 0.5
        }
    },
    ParsedName = new List<AiNameComponent>
    {
        new AiNameComponent
        {
            Value = "John",
            Category = "FirstName",
            Score = 0.95
        },
        new AiNameComponent
        {
            Value = "Cane",
            Category = "LastName",
            Score = 0.5,
            Position = 5
        },
        new AiNameComponent
        {
            Value = "%F%L",
            Category = "Format"
        },
        new AiNameComponent
        {
            Value = "0.5",
            Category = "Score",
            Score = 0.5
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

