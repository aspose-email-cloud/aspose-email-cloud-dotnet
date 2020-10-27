# AiNameComponentList
List of name components             

## Properties
Class has no properties

## Parent class

See: [ListResponseOfAiNameComponent](ListResponseOfAiNameComponent.md)

## Example
```csharp
var aiNameComponentList = new AiNameComponentList
{
    Value = new List<AiNameComponent>
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

