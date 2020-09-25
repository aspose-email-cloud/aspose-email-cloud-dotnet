# Aspose.Email.Cloud.Sdk.AiNameApi

<a name="Complete"></a>
# Complete

The call proposes k most probable names for given starting characters.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to complete. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CompleteAsync"></a>
# CompleteAsync

The call proposes k most probable names for given starting characters.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to complete. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Expand"></a>
# Expand

Expands a person's name into a list of possible alternatives using options for expanding instructions.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to expand. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExpandAsync"></a>
# ExpandAsync

Expands a person's name into a list of possible alternatives using options for expanding instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to expand. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ExpandParsed"></a>
# ExpandParsed

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions.             

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

### request Parameter
See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)


### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExpandParsedAsync"></a>
# ExpandParsedAsync

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)


### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Format"></a>
# Format

Formats a person's name in correct case and name order using options for formatting instructions.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **format** | **string**| Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (&#x3D; &#39;%t%F%m%N%L%p&#39;)     /format/FN+LN/ (&#x3D; &#39;%F%L&#39;)     /format/title+FN+LN/ (&#x3D; &#39;%t%F%L&#39;)     /format/FN+MN+LN/ (&#x3D; &#39;%F%M%N%L&#39;)     /format/title+FN+MN+LN/ (&#x3D; &#39;%t%F%M%N%L&#39;)     /format/FN+MI+LN/ (&#x3D; &#39;%F%m%N%L&#39;)     /format/title+FN+MI+LN/ (&#x3D; &#39;%t%F%m%N%L&#39;)     /format/LN/ (&#x3D; &#39;%L&#39;)     /format/title+LN/ (&#x3D; &#39;%t%L&#39;)     /format/LN+FN+MN/ (&#x3D; &#39;%L,%F%M%N&#39;)     /format/LN+title+FN+MN/ (&#x3D; &#39;%L,%t%F%M%N&#39;)     /format/LN+FN+MI/ (&#x3D; &#39;%L,%F%m%N&#39;)     /format/LN+title+FN+MI/ (&#x3D; &#39;%L,%t%F%m%N&#39;)  Custom format string - custom combination of characters and the next term placeholders:      &#39;%t&#39; - Title (prefix)     &#39;%F&#39; - First name     &#39;%f&#39; - First initial     &#39;%M&#39; - Middle name(s)     &#39;%m&#39; - Middle initial(s)     &#39;%N&#39; - Nickname     &#39;%L&#39; - Last name     &#39;%l&#39; - Last initial     &#39;%p&#39; - Postfix  If no value for format option was provided, its default value is &#39;%t%F%m%N%L%p&#39;              | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FormatAsync"></a>
# FormatAsync

Formats a person's name in correct case and name order using options for formatting instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **format** | **string**| Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (&#x3D; &#39;%t%F%m%N%L%p&#39;)     /format/FN+LN/ (&#x3D; &#39;%F%L&#39;)     /format/title+FN+LN/ (&#x3D; &#39;%t%F%L&#39;)     /format/FN+MN+LN/ (&#x3D; &#39;%F%M%N%L&#39;)     /format/title+FN+MN+LN/ (&#x3D; &#39;%t%F%M%N%L&#39;)     /format/FN+MI+LN/ (&#x3D; &#39;%F%m%N%L&#39;)     /format/title+FN+MI+LN/ (&#x3D; &#39;%t%F%m%N%L&#39;)     /format/LN/ (&#x3D; &#39;%L&#39;)     /format/title+LN/ (&#x3D; &#39;%t%L&#39;)     /format/LN+FN+MN/ (&#x3D; &#39;%L,%F%M%N&#39;)     /format/LN+title+FN+MN/ (&#x3D; &#39;%L,%t%F%M%N&#39;)     /format/LN+FN+MI/ (&#x3D; &#39;%L,%F%m%N&#39;)     /format/LN+title+FN+MI/ (&#x3D; &#39;%L,%t%F%m%N&#39;)  Custom format string - custom combination of characters and the next term placeholders:      &#39;%t&#39; - Title (prefix)     &#39;%F&#39; - First name     &#39;%f&#39; - First initial     &#39;%M&#39; - Middle name(s)     &#39;%m&#39; - Middle initial(s)     &#39;%N&#39; - Nickname     &#39;%L&#39; - Last name     &#39;%l&#39; - Last initial     &#39;%p&#39; - Postfix  If no value for format option was provided, its default value is &#39;%t%F%m%N%L%p&#39;              | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FormatParsed"></a>
# FormatParsed

Formats a person's parsed name in correct case and name order using options for formatting instructions.             

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

### request Parameter
See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)


### Return type

[**AiNameFormatted**](AiNameFormatted.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FormatParsedAsync"></a>
# FormatParsedAsync

Formats a person's parsed name in correct case and name order using options for formatting instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)


### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Genderize"></a>
# Genderize

Detect person's gender from name string.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to genderize. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeAsync"></a>
# GenderizeAsync

Detect person's gender from name string.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to genderize. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GenderizeParsed"></a>
# GenderizeParsed

Detect person's gender from parsed name.             

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

### request Parameter
See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)


### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeParsedAsync"></a>
# GenderizeParsedAsync

Detect person's gender from parsed name.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)


### Return type

Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Match"></a>
# Match

Compare people's names. Uses options for comparing instructions.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to match. | 
 **otherName** | **string**| Another name to match. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MatchAsync"></a>
# MatchAsync

Compare people's names. Uses options for comparing instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to match. | 
 **otherName** | **string**| Another name to match. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="MatchParsed"></a>
# MatchParsed

Compare people's parsed names and attributes. Uses options for comparing instructions.             

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

### request Parameter
See parameter model documentation at [AiNameMatchParsedRequest](AiNameMatchParsedRequest.md)


### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MatchParsedAsync"></a>
# MatchParsedAsync

Compare people's parsed names and attributes. Uses options for comparing instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter
See parameter model documentation at [AiNameMatchParsedRequest](AiNameMatchParsedRequest.md)


### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Parse"></a>
# Parse

Parse name to components.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameComponentList**](AiNameComponentList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
# ParseAsync

Parse name to components.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameComponentList**](AiNameComponentList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ParseEmailAddress"></a>
# ParseEmailAddress

Parse person's name out of an email address.             

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Email address to parse. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameExtractedList**](AiNameExtractedList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseEmailAddressAsync"></a>
# ParseEmailAddressAsync

Parse person's name out of an email address.             

Performs operation asynchronously. Not available on .NETFramework v2.0

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Email address to parse. | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
 **encoding** | **string**| A character encoding name. | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

### Return type

[**AiNameExtractedList**](AiNameExtractedList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
