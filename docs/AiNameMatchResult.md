# AiNameMatchResult
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Similarity** | **double?** | Similarity score              | 
**Mismatches** | [**List&lt;AiNameMismatch&gt;**](AiNameMismatch.md) | Detailed description of mismatches              | [optional] 


## Example
```csharp
var aiNameMatchResult = new AiNameMatchResult
{
    Similarity = 0.6,
    Mismatches = new List<AiNameMismatch>
    {
        new AiNameMismatch
        {
            Category = "Gender",
            Explanation = "no_match"
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

