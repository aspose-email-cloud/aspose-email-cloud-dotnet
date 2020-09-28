# AiNameMismatch
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | Mismatch type. Enum, available values: Unknown, FirstName, MiddleName, MiddleLastName, MiddleNickname, Gender, Context | 
**Similarity** | **double?** | Similarity score              | 
**Explanation** | **string** | Explanation or mismatch subtype              | [optional] 


## Example
```csharp
var aiNameMismatch = new AiNameMismatch
{
    Category = "Gender",
    Explanation = "no_match"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

