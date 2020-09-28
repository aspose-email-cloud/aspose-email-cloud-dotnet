# AiNameExtracted
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | [**List&lt;AiNameExtractedComponent&gt;**](AiNameExtractedComponent.md) | Extracted name components              | [optional] 
**Score** | **double?** | Extracted name score              | 


## Example
```csharp
var aiNameExtracted = new AiNameExtracted
{
    Name = new List<AiNameExtractedComponent>
    {
        new AiNameExtractedComponent
        {
            Category = "Surname",
            Value = "Cane"
        },
        new AiNameExtractedComponent
        {
            Category = "SomeName",
            Value = "John"
        }
    },
    Score = 0.5
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

