# AiNameWeightedVariants
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Names** | [**List&lt;AiNameWeighted&gt;**](AiNameWeighted.md) | List of name variations              | [optional] 
**Comments** | **string** | Usually empty; can contain extra message describing some issue occurred during processing              | [optional] 


## Example
```csharp
var aiNameWeightedVariants = new AiNameWeightedVariants
{
    Names = new List<AiNameWeighted>
    {
        new AiNameWeighted
        {
            Name = "J. Cane",
            Score = 1
        },
        new AiNameWeighted
        {
            Name = "Mr. Cane",
            Score = 0.75
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

