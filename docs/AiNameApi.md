# Aspose.Email.Cloud.Sdk.AiNameApi

        ﻿<a name="Complete"></a>
# Complete

```csharp
AiNameWeightedVariants Complete(AiNameCompleteRequest request)
```

The call proposes k most probable names for given starting characters             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### request Parameter
```csharp
new AiNameCompleteRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to complete (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="CompleteAsync"></a>
# CompleteAsync

```csharp
async Task<AiNameWeightedVariants> CompleteAsync(AiNameCompleteRequest request)
```

The call proposes k most probable names for given starting characters             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### request Parameter
```csharp
new AiNameCompleteRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to complete (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Expand"></a>
# Expand

```csharp
AiNameWeightedVariants Expand(AiNameExpandRequest request)
```

Expands a person's name into a list of possible alternatives using options for expanding instructions             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### request Parameter
```csharp
new AiNameExpandRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExpandAsync"></a>
# ExpandAsync

```csharp
async Task<AiNameWeightedVariants> ExpandAsync(AiNameExpandRequest request)
```

Expands a person's name into a list of possible alternatives using options for expanding instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### request Parameter
```csharp
new AiNameExpandRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="ExpandParsed"></a>
# ExpandParsed

```csharp
AiNameWeightedVariants ExpandParsed(AiNameParsedRequest request)
```

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### request Parameter

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ExpandParsedAsync"></a>
# ExpandParsedAsync

```csharp
async Task<AiNameWeightedVariants> ExpandParsedAsync(AiNameParsedRequest request)
```

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### request Parameter

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Format"></a>
# Format

```csharp
AiNameFormatted Format(AiNameFormatRequest request)
```

Formats a person's name in correct case and name order using options for formatting instructions             

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

### request Parameter
```csharp
new AiNameFormatRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    format=format,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **format** | **string**| Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (&#x3D; &#39;%t%F%m%N%L%p&#39;)     /format/FN+LN/ (&#x3D; &#39;%F%L&#39;)     /format/title+FN+LN/ (&#x3D; &#39;%t%F%L&#39;)     /format/FN+MN+LN/ (&#x3D; &#39;%F%M%N%L&#39;)     /format/title+FN+MN+LN/ (&#x3D; &#39;%t%F%M%N%L&#39;)     /format/FN+MI+LN/ (&#x3D; &#39;%F%m%N%L&#39;)     /format/title+FN+MI+LN/ (&#x3D; &#39;%t%F%m%N%L&#39;)     /format/LN/ (&#x3D; &#39;%L&#39;)     /format/title+LN/ (&#x3D; &#39;%t%L&#39;)     /format/LN+FN+MN/ (&#x3D; &#39;%L,%F%M%N&#39;)     /format/LN+title+FN+MN/ (&#x3D; &#39;%L,%t%F%M%N&#39;)     /format/LN+FN+MI/ (&#x3D; &#39;%L,%F%m%N&#39;)     /format/LN+title+FN+MI/ (&#x3D; &#39;%L,%t%F%m%N&#39;)  Custom format string - custom combination of characters and the next term placeholders:      &#39;%t&#39; - Title (prefix)     &#39;%F&#39; - First name     &#39;%f&#39; - First initial     &#39;%M&#39; - Middle name(s)     &#39;%m&#39; - Middle initial(s)     &#39;%N&#39; - Nickname     &#39;%L&#39; - Last name     &#39;%l&#39; - Last initial     &#39;%p&#39; - Postfix  If no value for format option was provided, its default value is &#39;%t%F%m%N%L%p&#39;              | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FormatAsync"></a>
# FormatAsync

```csharp
async Task<AiNameFormatted> FormatAsync(AiNameFormatRequest request)
```

Formats a person's name in correct case and name order using options for formatting instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

### request Parameter
```csharp
new AiNameFormatRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    format=format,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **format** | **string**| Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (&#x3D; &#39;%t%F%m%N%L%p&#39;)     /format/FN+LN/ (&#x3D; &#39;%F%L&#39;)     /format/title+FN+LN/ (&#x3D; &#39;%t%F%L&#39;)     /format/FN+MN+LN/ (&#x3D; &#39;%F%M%N%L&#39;)     /format/title+FN+MN+LN/ (&#x3D; &#39;%t%F%M%N%L&#39;)     /format/FN+MI+LN/ (&#x3D; &#39;%F%m%N%L&#39;)     /format/title+FN+MI+LN/ (&#x3D; &#39;%t%F%m%N%L&#39;)     /format/LN/ (&#x3D; &#39;%L&#39;)     /format/title+LN/ (&#x3D; &#39;%t%L&#39;)     /format/LN+FN+MN/ (&#x3D; &#39;%L,%F%M%N&#39;)     /format/LN+title+FN+MN/ (&#x3D; &#39;%L,%t%F%M%N&#39;)     /format/LN+FN+MI/ (&#x3D; &#39;%L,%F%m%N&#39;)     /format/LN+title+FN+MI/ (&#x3D; &#39;%L,%t%F%m%N&#39;)  Custom format string - custom combination of characters and the next term placeholders:      &#39;%t&#39; - Title (prefix)     &#39;%F&#39; - First name     &#39;%f&#39; - First initial     &#39;%M&#39; - Middle name(s)     &#39;%m&#39; - Middle initial(s)     &#39;%N&#39; - Nickname     &#39;%L&#39; - Last name     &#39;%l&#39; - Last initial     &#39;%p&#39; - Postfix  If no value for format option was provided, its default value is &#39;%t%F%m%N%L%p&#39;              | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="FormatParsed"></a>
# FormatParsed

```csharp
AiNameFormatted FormatParsed(AiNameParsedRequest request)
```

Formats a person's parsed name in correct case and name order using options for formatting instructions             

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

### request Parameter

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FormatParsedAsync"></a>
# FormatParsedAsync

```csharp
async Task<AiNameFormatted> FormatParsedAsync(AiNameParsedRequest request)
```

Formats a person's parsed name in correct case and name order using options for formatting instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

### request Parameter

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Genderize"></a>
# Genderize

```csharp
AiNameGenderHypothesisList Genderize(AiNameGenderizeRequest request)
```

Detect person's gender from name string             

### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

### request Parameter
```csharp
new AiNameGenderizeRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeAsync"></a>
# GenderizeAsync

```csharp
async Task<AiNameGenderHypothesisList> GenderizeAsync(AiNameGenderizeRequest request)
```

Detect person's gender from name string             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

### request Parameter
```csharp
new AiNameGenderizeRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="GenderizeParsed"></a>
# GenderizeParsed

```csharp
AiNameGenderHypothesisList GenderizeParsed(AiNameParsedRequest request)
```

Detect person's gender from parsed name             

### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

### request Parameter

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GenderizeParsedAsync"></a>
# GenderizeParsedAsync

```csharp
async Task<AiNameGenderHypothesisList> GenderizeParsedAsync(AiNameParsedRequest request)
```

Detect person's gender from parsed name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

### request Parameter

See parameter model documentation at [AiNameParsedRequest](AiNameParsedRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Match"></a>
# Match

```csharp
AiNameMatchResult Match(AiNameMatchRequest request)
```

Compare people's names. Uses options for comparing instructions             

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

### request Parameter
```csharp
new AiNameMatchRequest(
    name,
    otherName,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to match (required) | 
 **otherName** | **string**| Another name to match (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MatchAsync"></a>
# MatchAsync

```csharp
async Task<AiNameMatchResult> MatchAsync(AiNameMatchRequest request)
```

Compare people's names. Uses options for comparing instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

### request Parameter
```csharp
new AiNameMatchRequest(
    name,
    otherName,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to match (required) | 
 **otherName** | **string**| Another name to match (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="MatchParsed"></a>
# MatchParsed

```csharp
AiNameMatchResult MatchParsed(AiNameParsedMatchRequest request)
```

Compare people's parsed names and attributes. Uses options for comparing instructions             

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

### request Parameter

See parameter model documentation at [AiNameParsedMatchRequest](AiNameParsedMatchRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="MatchParsedAsync"></a>
# MatchParsedAsync

```csharp
async Task<AiNameMatchResult> MatchParsedAsync(AiNameParsedMatchRequest request)
```

Compare people's parsed names and attributes. Uses options for comparing instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

### request Parameter

See parameter model documentation at [AiNameParsedMatchRequest](AiNameParsedMatchRequest.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="Parse"></a>
# Parse

```csharp
AiNameComponentList Parse(AiNameParseRequest request)
```

Parse name to components             

### Return type

[**AiNameComponentList**](AiNameComponentList.md)

### request Parameter
```csharp
new AiNameParseRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseAsync"></a>
# ParseAsync

```csharp
async Task<AiNameComponentList> ParseAsync(AiNameParseRequest request)
```

Parse name to components             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameComponentList**](AiNameComponentList.md)>

### request Parameter
```csharp
new AiNameParseRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
        ﻿<a name="ParseEmailAddress"></a>
# ParseEmailAddress

```csharp
AiNameExtractedList ParseEmailAddress(AiNameParseEmailAddressRequest request)
```

Parse person's name out of an email address             

### Return type

[**AiNameExtractedList**](AiNameExtractedList.md)

### request Parameter
```csharp
new AiNameParseEmailAddressRequest(
    emailAddress,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Email address to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ParseEmailAddressAsync"></a>
# ParseEmailAddressAsync

```csharp
async Task<AiNameExtractedList> ParseEmailAddressAsync(AiNameParseEmailAddressRequest request)
```

Parse person's name out of an email address             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameExtractedList**](AiNameExtractedList.md)>

### request Parameter
```csharp
new AiNameParseEmailAddressRequest(
    emailAddress,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Email address to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
