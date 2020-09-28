# Aspose.Email.Cloud.Sdk.AiNameApi

<a name="Complete"></a>
## Complete

The call proposes k most probable names for given starting characters.             

Returns: List of name variations.

Method call example:
```csharp
var result = Api.Ai.Name.Complete(request);
```

### request Parameter

Complete method request.

See parameter model documentation at [AiNameCompleteRequest](AiNameCompleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameCompleteRequest
{ 
    Name = "Dav",
};
```

</details>

### Result

*Returns:* List of name variations.

*Return type:* [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameWeightedVariants
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameCompleteRequest
{ 
    Name = "Dav",
};

// Call method:
var result = Api.Ai.Name.Complete(request);

// Result example:
result = new AiNameWeightedVariants
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CompleteAsync"></a>
## CompleteAsync

The call proposes k most probable names for given starting characters.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: List of name variations.

Method call example:
```csharp
var result = await Api.Ai.Name.CompleteAsync(request);
```

### request Parameter

CompleteAsync method request.

See parameter model documentation at [AiNameCompleteRequest](AiNameCompleteRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameCompleteRequest
{ 
    Name = "Dav",
};
```

</details>

### Result

*Returns:* List of name variations.

*Return type:* [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameWeightedVariants
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameCompleteRequest
{ 
    Name = "Dav",
};

// Call method:
var result = await Api.Ai.Name.CompleteAsync(request);

// Result example:
result = new AiNameWeightedVariants
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Expand"></a>
## Expand

Expands a person's name into a list of possible alternatives using options for expanding instructions.             

Returns: List of name variations.

Method call example:
```csharp
var result = Api.Ai.Name.Expand(request);
```

### request Parameter

Expand method request.

See parameter model documentation at [AiNameExpandRequest](AiNameExpandRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameExpandRequest
{ 
    Name = "John Cane",
};
```

</details>

### Result

*Returns:* List of name variations.

*Return type:* [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameWeightedVariants
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameExpandRequest
{ 
    Name = "John Cane",
};

// Call method:
var result = Api.Ai.Name.Expand(request);

// Result example:
result = new AiNameWeightedVariants
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExpandAsync"></a>
## ExpandAsync

Expands a person's name into a list of possible alternatives using options for expanding instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: List of name variations.

Method call example:
```csharp
var result = await Api.Ai.Name.ExpandAsync(request);
```

### request Parameter

ExpandAsync method request.

See parameter model documentation at [AiNameExpandRequest](AiNameExpandRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameExpandRequest
{ 
    Name = "John Cane",
};
```

</details>

### Result

*Returns:* List of name variations.

*Return type:* [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameWeightedVariants
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameExpandRequest
{ 
    Name = "John Cane",
};

// Call method:
var result = await Api.Ai.Name.ExpandAsync(request);

// Result example:
result = new AiNameWeightedVariants
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ExpandParsed"></a>
## ExpandParsed

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions.             

Returns: List of name variations.

Method call example:
```csharp
var result = Api.Ai.Name.ExpandParsed(request);
```

### request Parameter

Parsed name with options.

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* List of name variations.

*Return type:* [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameWeightedVariants
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = Api.Ai.Name.ExpandParsed(request);

// Result example:
result = new AiNameWeightedVariants
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExpandParsedAsync"></a>
## ExpandParsedAsync

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: List of name variations.

Method call example:
```csharp
var result = await Api.Ai.Name.ExpandParsedAsync(request);
```

### request Parameter

Parsed name with options.

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* List of name variations.

*Return type:* Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameWeightedVariants
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = await Api.Ai.Name.ExpandParsedAsync(request);

// Result example:
result = new AiNameWeightedVariants
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Format"></a>
## Format

Formats a person's name in correct case and name order using options for formatting instructions.             

Returns: Formatted name.

Method call example:
```csharp
var result = Api.Ai.Name.Format(request);
```

### request Parameter

Format method request.

See parameter model documentation at [AiNameFormatRequest](AiNameFormatRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m",
};
```

</details>

### Result

*Returns:* Formatted name.

*Return type:* [**AiNameFormatted**](AiNameFormatted.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m",
};

// Call method:
var result = Api.Ai.Name.Format(request);

// Result example:
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FormatAsync"></a>
## FormatAsync

Formats a person's name in correct case and name order using options for formatting instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Formatted name.

Method call example:
```csharp
var result = await Api.Ai.Name.FormatAsync(request);
```

### request Parameter

FormatAsync method request.

See parameter model documentation at [AiNameFormatRequest](AiNameFormatRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m",
};
```

</details>

### Result

*Returns:* Formatted name.

*Return type:* [**AiNameFormatted**](AiNameFormatted.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m",
};

// Call method:
var result = await Api.Ai.Name.FormatAsync(request);

// Result example:
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FormatParsed"></a>
## FormatParsed

Formats a person's parsed name in correct case and name order using options for formatting instructions.             

Returns: Formatted name.

Method call example:
```csharp
var result = Api.Ai.Name.FormatParsed(request);
```

### request Parameter

Parsed name with options.

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* Formatted name.

*Return type:* [**AiNameFormatted**](AiNameFormatted.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = Api.Ai.Name.FormatParsed(request);

// Result example:
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FormatParsedAsync"></a>
## FormatParsedAsync

Formats a person's parsed name in correct case and name order using options for formatting instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Formatted name.

Method call example:
```csharp
var result = await Api.Ai.Name.FormatParsedAsync(request);
```

### request Parameter

Parsed name with options.

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* Formatted name.

*Return type:* Task<[**AiNameFormatted**](AiNameFormatted.md)>

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = await Api.Ai.Name.FormatParsedAsync(request);

// Result example:
result = new AiNameFormatted
{
    Name = "Mr. Cane J. M.",
    Comments = "format: %t%L%f%m; source: parsed format"
};
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Genderize"></a>
## Genderize

Detect person's gender from name string.             

Returns: Hypotheses about person&#39;s gender.

Method call example:
```csharp
var result = Api.Ai.Name.Genderize(request);
```

### request Parameter

Genderize method request.

See parameter model documentation at [AiNameGenderizeRequest](AiNameGenderizeRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane",
};
```

</details>

### Result

*Returns:* Hypotheses about person&#39;s gender.

*Return type:* [**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane",
};

// Call method:
var result = Api.Ai.Name.Genderize(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeAsync"></a>
## GenderizeAsync

Detect person's gender from name string.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Hypotheses about person&#39;s gender.

Method call example:
```csharp
var result = await Api.Ai.Name.GenderizeAsync(request);
```

### request Parameter

GenderizeAsync method request.

See parameter model documentation at [AiNameGenderizeRequest](AiNameGenderizeRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane",
};
```

</details>

### Result

*Returns:* Hypotheses about person&#39;s gender.

*Return type:* [**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane",
};

// Call method:
var result = await Api.Ai.Name.GenderizeAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GenderizeParsed"></a>
## GenderizeParsed

Detect person's gender from parsed name.             

Returns: Hypotheses about person&#39;s gender.

Method call example:
```csharp
var result = Api.Ai.Name.GenderizeParsed(request);
```

### request Parameter

Gender detection request data.

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* Hypotheses about person&#39;s gender.

*Return type:* [**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = Api.Ai.Name.GenderizeParsed(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeParsedAsync"></a>
## GenderizeParsedAsync

Detect person's gender from parsed name.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Hypotheses about person&#39;s gender.

Method call example:
```csharp
var result = await Api.Ai.Name.GenderizeParsedAsync(request);
```

### request Parameter

Gender detection request data.

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* Hypotheses about person&#39;s gender.

*Return type:* Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = await Api.Ai.Name.GenderizeParsedAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Match"></a>
## Match

Compare people's names. Uses options for comparing instructions.             

Returns: Match result.

Method call example:
```csharp
var result = Api.Ai.Name.Match(request);
```

### request Parameter

Match method request.

See parameter model documentation at [AiNameMatchRequest](AiNameMatchRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J.",
};
```

</details>

### Result

*Returns:* Match result.

*Return type:* [**AiNameMatchResult**](AiNameMatchResult.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameMatchResult
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J.",
};

// Call method:
var result = Api.Ai.Name.Match(request);

// Result example:
result = new AiNameMatchResult
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MatchAsync"></a>
## MatchAsync

Compare people's names. Uses options for comparing instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Match result.

Method call example:
```csharp
var result = await Api.Ai.Name.MatchAsync(request);
```

### request Parameter

MatchAsync method request.

See parameter model documentation at [AiNameMatchRequest](AiNameMatchRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J.",
};
```

</details>

### Result

*Returns:* Match result.

*Return type:* [**AiNameMatchResult**](AiNameMatchResult.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameMatchResult
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J.",
};

// Call method:
var result = await Api.Ai.Name.MatchAsync(request);

// Result example:
result = new AiNameMatchResult
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="MatchParsed"></a>
## MatchParsed

Compare people's parsed names and attributes. Uses options for comparing instructions.             

Returns: Match result.

Method call example:
```csharp
var result = Api.Ai.Name.MatchParsed(request);
```

### request Parameter

Parsed names to match.

See parameter model documentation at [AiNameMatchParsedRequest](AiNameMatchParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* Match result.

*Return type:* [**AiNameMatchResult**](AiNameMatchResult.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameMatchResult
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = Api.Ai.Name.MatchParsed(request);

// Result example:
result = new AiNameMatchResult
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MatchParsedAsync"></a>
## MatchParsedAsync

Compare people's parsed names and attributes. Uses options for comparing instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Match result.

Method call example:
```csharp
var result = await Api.Ai.Name.MatchParsedAsync(request);
```

### request Parameter

Parsed names to match.

See parameter model documentation at [AiNameMatchParsedRequest](AiNameMatchParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = ;
```

</details>


### Result

*Returns:* Match result.

*Return type:* Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameMatchResult
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = ;

// Call method:
var result = await Api.Ai.Name.MatchParsedAsync(request);

// Result example:
result = new AiNameMatchResult
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Parse"></a>
## Parse

Parse name to components.             

Returns: List of name components.

Method call example:
```csharp
var result = Api.Ai.Name.Parse(request);
```

### request Parameter

Parse method request.

See parameter model documentation at [AiNameParseRequest](AiNameParseRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA",
};
```

</details>

### Result

*Returns:* List of name components.

*Return type:* [**AiNameComponentList**](AiNameComponentList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA",
};

// Call method:
var result = Api.Ai.Name.Parse(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
## ParseAsync

Parse name to components.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: List of name components.

Method call example:
```csharp
var result = await Api.Ai.Name.ParseAsync(request);
```

### request Parameter

ParseAsync method request.

See parameter model documentation at [AiNameParseRequest](AiNameParseRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA",
};
```

</details>

### Result

*Returns:* List of name components.

*Return type:* [**AiNameComponentList**](AiNameComponentList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA",
};

// Call method:
var result = await Api.Ai.Name.ParseAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ParseEmailAddress"></a>
## ParseEmailAddress

Parse person's name out of an email address.             

Returns: Match result.

Method call example:
```csharp
var result = Api.Ai.Name.ParseEmailAddress(request);
```

### request Parameter

ParseEmailAddress method request.

See parameter model documentation at [AiNameParseEmailAddressRequest](AiNameParseEmailAddressRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com",
};
```

</details>

### Result

*Returns:* Match result.

*Return type:* [**AiNameExtractedList**](AiNameExtractedList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com",
};

// Call method:
var result = Api.Ai.Name.ParseEmailAddress(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseEmailAddressAsync"></a>
## ParseEmailAddressAsync

Parse person's name out of an email address.             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: Match result.

Method call example:
```csharp
var result = await Api.Ai.Name.ParseEmailAddressAsync(request);
```

### request Parameter

ParseEmailAddressAsync method request.

See parameter model documentation at [AiNameParseEmailAddressRequest](AiNameParseEmailAddressRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com",
};
```

</details>

### Result

*Returns:* Match result.

*Return type:* [**AiNameExtractedList**](AiNameExtractedList.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com",
};

// Call method:
var result = await Api.Ai.Name.ParseEmailAddressAsync(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
