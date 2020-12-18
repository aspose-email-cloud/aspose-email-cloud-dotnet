# AiNameApi (EmailCloud.Ai.Name)

AI Name operations.

<a name="Complete"></a>
## Complete
**Descrption:** The call proposes k most probable names for given starting characters.             


**Returns:** List of name variations.

**Method call example:**
```csharp
var result = api.Ai.Name.Complete(request);
```

### Parameter: *request*

**Description:** Complete method request.

**See also** parameter model documentation at [**AiNameCompleteRequest**](AiNameCompleteRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameCompleteRequest
{ 
    Name = "Dav"
};
```

</details>

### Result

**Description:** List of name variations.

**Return type:** [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameCompleteRequest
{ 
    Name = "Dav"
};

// Call method:
var result = api.Ai.Name.Complete(request);

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

**Description:** The call proposes k most probable names for given starting characters.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of name variations.

**Method call example:**
```csharp
var result = await api.Ai.Name.CompleteAsync(request);
```

### Parameter: *request*

**Description:** CompleteAsync method request.

**See also** parameter model documentation at [**AiNameCompleteRequest**](AiNameCompleteRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameCompleteRequest
{ 
    Name = "Dav"
};
```

</details>

### Result

**Returns:** List of name variations.

**Return type:** [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameCompleteRequest
{ 
    Name = "Dav"
};

// Call method:
var result = await api.Ai.Name.CompleteAsync(request);

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
**Descrption:** Expands a person's name into a list of possible alternatives using options for expanding instructions.             


**Returns:** List of name variations.

**Method call example:**
```csharp
var result = api.Ai.Name.Expand(request);
```

### Parameter: *request*

**Description:** Expand method request.

**See also** parameter model documentation at [**AiNameExpandRequest**](AiNameExpandRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameExpandRequest
{ 
    Name = "John Cane"
};
```

</details>

### Result

**Description:** List of name variations.

**Return type:** [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameExpandRequest
{ 
    Name = "John Cane"
};

// Call method:
var result = api.Ai.Name.Expand(request);

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

**Description:** Expands a person's name into a list of possible alternatives using options for expanding instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of name variations.

**Method call example:**
```csharp
var result = await api.Ai.Name.ExpandAsync(request);
```

### Parameter: *request*

**Description:** ExpandAsync method request.

**See also** parameter model documentation at [**AiNameExpandRequest**](AiNameExpandRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameExpandRequest
{ 
    Name = "John Cane"
};
```

</details>

### Result

**Returns:** List of name variations.

**Return type:** [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameExpandRequest
{ 
    Name = "John Cane"
};

// Call method:
var result = await api.Ai.Name.ExpandAsync(request);

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

**Description**: Expands a person's parsed name into a list of possible alternatives using options for expanding instructions.             


**Returns:** List of name variations.

**Method call example:**
```csharp
var result = api.Ai.Name.ExpandParsed(request);
```

### Parameter: *request*

**Description:** Parsed name with options.

**See also** parameter model documentation at [**AiNameParsedRequest**](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParsedRequest
{
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

</details>


### Result

**Description:** List of name variations.

**Return type:** [**AiNameWeightedVariants**](AiNameWeightedVariants.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParsedRequest
{
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

// Call method:
var result = api.Ai.Name.ExpandParsed(request);

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

**Description:** Expands a person's parsed name into a list of possible alternatives using options for expanding instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of name variations.

**Method call example:**
```csharp
var result = await api.Ai.Name.ExpandParsedAsync(request);
```

### Parameter: *request*

**Description:** Parsed name with options.

**See also** parameter model documentation at [**AiNameParsedRequest**](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParsedRequest
{
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

</details>


### Result

**Description:** List of name variations.

**Return type:** Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParsedRequest
{
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

// Call method:
var result = await api.Ai.Name.ExpandParsedAsync(request);

//Result example:
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
**Descrption:** Formats a person's name in correct case and name order using options for formatting instructions.             


**Returns:** Formatted name.

**Method call example:**
```csharp
var result = api.Ai.Name.Format(request);
```

### Parameter: *request*

**Description:** Format method request.

**See also** parameter model documentation at [**AiNameFormatRequest**](AiNameFormatRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m"
};
```

</details>

### Result

**Description:** Formatted name.

**Return type:** [**AiNameFormatted**](AiNameFormatted.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m"
};

// Call method:
var result = api.Ai.Name.Format(request);

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

**Description:** Formats a person's name in correct case and name order using options for formatting instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Formatted name.

**Method call example:**
```csharp
var result = await api.Ai.Name.FormatAsync(request);
```

### Parameter: *request*

**Description:** FormatAsync method request.

**See also** parameter model documentation at [**AiNameFormatRequest**](AiNameFormatRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m"
};
```

</details>

### Result

**Returns:** Formatted name.

**Return type:** [**AiNameFormatted**](AiNameFormatted.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m"
};

// Call method:
var result = await api.Ai.Name.FormatAsync(request);

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

**Description**: Formats a person's parsed name in correct case and name order using options for formatting instructions.             


**Returns:** Formatted name.

**Method call example:**
```csharp
var result = api.Ai.Name.FormatParsed(request);
```

### Parameter: *request*

**Description:** Parsed name with options.

**See also** parameter model documentation at [**AiNameParsedRequest**](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParsedRequest
{
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

</details>


### Result

**Description:** Formatted name.

**Return type:** [**AiNameFormatted**](AiNameFormatted.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParsedRequest
{
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

// Call method:
var result = api.Ai.Name.FormatParsed(request);

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

**Description:** Formats a person's parsed name in correct case and name order using options for formatting instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Formatted name.

**Method call example:**
```csharp
var result = await api.Ai.Name.FormatParsedAsync(request);
```

### Parameter: *request*

**Description:** Parsed name with options.

**See also** parameter model documentation at [**AiNameParsedRequest**](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParsedRequest
{
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

</details>


### Result

**Description:** Formatted name.

**Return type:** Task<[**AiNameFormatted**](AiNameFormatted.md)>

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParsedRequest
{
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

// Call method:
var result = await api.Ai.Name.FormatParsedAsync(request);

//Result example:
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
**Descrption:** Detect person's gender from name string.             


**Returns:** Hypotheses about person&#39;s gender.

**Method call example:**
```csharp
var result = api.Ai.Name.Genderize(request);
```

### Parameter: *request*

**Description:** Genderize method request.

**See also** parameter model documentation at [**AiNameGenderizeRequest**](AiNameGenderizeRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane"
};
```

</details>

### Result

**Description:** Hypotheses about person's gender.

**Return type:** [**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane"
};

// Call method:
var result = api.Ai.Name.Genderize(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeAsync"></a>
## GenderizeAsync

**Description:** Detect person's gender from name string.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Hypotheses about person's gender.

**Method call example:**
```csharp
var result = await api.Ai.Name.GenderizeAsync(request);
```

### Parameter: *request*

**Description:** GenderizeAsync method request.

**See also** parameter model documentation at [**AiNameGenderizeRequest**](AiNameGenderizeRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane"
};
```

</details>

### Result

**Returns:** Hypotheses about person's gender.

**Return type:** [**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameGenderizeRequest
{ 
    Name = "John Cane"
};

// Call method:
var result = await api.Ai.Name.GenderizeAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GenderizeParsed"></a>
## GenderizeParsed

**Description**: Detect person's gender from parsed name.             


**Returns:** Hypotheses about person's gender.

**Method call example:**
```csharp
var result = api.Ai.Name.GenderizeParsed(request);
```

### Parameter: *request*

**Description:** Gender detection request data.

**See also** parameter model documentation at [**AiNameParsedRequest**](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParsedRequest
{
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

</details>


### Result

**Description:** Hypotheses about person's gender.

**Return type:** [**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParsedRequest
{
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

// Call method:
var result = api.Ai.Name.GenderizeParsed(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeParsedAsync"></a>
## GenderizeParsedAsync

**Description:** Detect person's gender from parsed name.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Hypotheses about person's gender.

**Method call example:**
```csharp
var result = await api.Ai.Name.GenderizeParsedAsync(request);
```

### Parameter: *request*

**Description:** Gender detection request data.

**See also** parameter model documentation at [**AiNameParsedRequest**](AiNameParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParsedRequest
{
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

</details>


### Result

**Description:** Hypotheses about person's gender.

**Return type:** Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParsedRequest
{
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

// Call method:
var result = await api.Ai.Name.GenderizeParsedAsync(request);

//Result example:
result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Match"></a>
## Match
**Descrption:** Compare people's names. Uses options for comparing instructions.             


**Returns:** Match result.

**Method call example:**
```csharp
var result = api.Ai.Name.Match(request);
```

### Parameter: *request*

**Description:** Match method request.

**See also** parameter model documentation at [**AiNameMatchRequest**](AiNameMatchRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J."
};
```

</details>

### Result

**Description:** Match result.

**Return type:** [**AiNameMatchResult**](AiNameMatchResult.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J."
};

// Call method:
var result = api.Ai.Name.Match(request);

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

**Description:** Compare people's names. Uses options for comparing instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Match result.

**Method call example:**
```csharp
var result = await api.Ai.Name.MatchAsync(request);
```

### Parameter: *request*

**Description:** MatchAsync method request.

**See also** parameter model documentation at [**AiNameMatchRequest**](AiNameMatchRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J."
};
```

</details>

### Result

**Returns:** Match result.

**Return type:** [**AiNameMatchResult**](AiNameMatchResult.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameMatchRequest
{ 
    Name = "John Michael Cane",
    OtherName = "Cane J."
};

// Call method:
var result = await api.Ai.Name.MatchAsync(request);

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

**Description**: Compare people's parsed names and attributes. Uses options for comparing instructions.             


**Returns:** Match result.

**Method call example:**
```csharp
var result = api.Ai.Name.MatchParsed(request);
```

### Parameter: *request*

**Description:** Parsed names to match.

**See also** parameter model documentation at [**AiNameMatchParsedRequest**](AiNameMatchParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameMatchParsedRequest
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

</details>


### Result

**Description:** Match result.

**Return type:** [**AiNameMatchResult**](AiNameMatchResult.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameMatchParsedRequest
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

// Call method:
var result = api.Ai.Name.MatchParsed(request);

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

**Description:** Compare people's parsed names and attributes. Uses options for comparing instructions.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Match result.

**Method call example:**
```csharp
var result = await api.Ai.Name.MatchParsedAsync(request);
```

### Parameter: *request*

**Description:** Parsed names to match.

**See also** parameter model documentation at [**AiNameMatchParsedRequest**](AiNameMatchParsedRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameMatchParsedRequest
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

</details>


### Result

**Description:** Match result.

**Return type:** Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameMatchParsedRequest
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

// Call method:
var result = await api.Ai.Name.MatchParsedAsync(request);

//Result example:
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
**Descrption:** Parse name to components.             


**Returns:** List of name components.

**Method call example:**
```csharp
var result = api.Ai.Name.Parse(request);
```

### Parameter: *request*

**Description:** Parse method request.

**See also** parameter model documentation at [**AiNameParseRequest**](AiNameParseRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA"
};
```

</details>

### Result

**Description:** List of name components.

**Return type:** [**AiNameComponentList**](AiNameComponentList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameComponentList
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA"
};

// Call method:
var result = api.Ai.Name.Parse(request);

// Result example:
result = new AiNameComponentList
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
## ParseAsync

**Description:** Parse name to components.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** List of name components.

**Method call example:**
```csharp
var result = await api.Ai.Name.ParseAsync(request);
```

### Parameter: *request*

**Description:** ParseAsync method request.

**See also** parameter model documentation at [**AiNameParseRequest**](AiNameParseRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA"
};
```

</details>

### Result

**Returns:** List of name components.

**Return type:** [**AiNameComponentList**](AiNameComponentList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new AiNameComponentList
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

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParseRequest
{ 
    Name = "John Cane",
    Language = "eng",
    Location = "USA"
};

// Call method:
var result = await api.Ai.Name.ParseAsync(request);

result = new AiNameComponentList
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

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="ParseEmailAddress"></a>
## ParseEmailAddress
**Descrption:** Parse person's name out of an email address.             


**Returns:** Match result.

**Method call example:**
```csharp
var result = api.Ai.Name.ParseEmailAddress(request);
```

### Parameter: *request*

**Description:** ParseEmailAddress method request.

**See also** parameter model documentation at [**AiNameParseEmailAddressRequest**](AiNameParseEmailAddressRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com"
};
```

</details>

### Result

**Description:** Match result.

**Return type:** [**AiNameExtractedList**](AiNameExtractedList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com"
};

// Call method:
var result = api.Ai.Name.ParseEmailAddress(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseEmailAddressAsync"></a>
## ParseEmailAddressAsync

**Description:** Parse person's name out of an email address.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** Match result.

**Method call example:**
```csharp
var result = await api.Ai.Name.ParseEmailAddressAsync(request);
```

### Parameter: *request*

**Description:** ParseEmailAddressAsync method request.

**See also** parameter model documentation at [**AiNameParseEmailAddressRequest**](AiNameParseEmailAddressRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com"
};
```

</details>

### Result

**Returns:** Match result.

**Return type:** [**AiNameExtractedList**](AiNameExtractedList.md)

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
var api = new EmailCloud(clientSecret, clientId);

// Prepare parameters:
var request = new AiNameParseEmailAddressRequest
{ 
    EmailAddress = "john-cane@gmail.com"
};

// Call method:
var result = await api.Ai.Name.ParseEmailAddressAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
