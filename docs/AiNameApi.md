# Aspose.Email.Cloud.Sdk.AiNameApi

<a name="ainamecomplete"></a>
# **AiNameComplete**

```csharp
AiNameWeightedVariants AiNameComplete(AiNameCompleteRequest request)
```

The call proposes k most probable names for given starting characters             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamecomplete"></a>
# **AiNameCompleteAsync**

```csharp
async Task<AiNameWeightedVariants> AiNameCompleteAsync(AiNameCompleteRequest request)
```

The call proposes k most probable names for given starting characters             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpand"></a>
# **AiNameExpand**

```csharp
AiNameWeightedVariants AiNameExpand(AiNameExpandRequest request)
```

Expands a person's name into a list of possible alternatives using options for expanding instructions             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpand"></a>
# **AiNameExpandAsync**

```csharp
async Task<AiNameWeightedVariants> AiNameExpandAsync(AiNameExpandRequest request)
```

Expands a person's name into a list of possible alternatives using options for expanding instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpandparsed"></a>
# **AiNameExpandParsed**

```csharp
AiNameWeightedVariants AiNameExpandParsed(AiNameExpandParsedRequest request)
```

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### Request Parameters
```csharp
new AiNameExpandParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedRequest**](AiNameParsedRequest.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpandparsed"></a>
# **AiNameExpandParsedAsync**

```csharp
async Task<AiNameWeightedVariants> AiNameExpandParsedAsync(AiNameExpandParsedRequest request)
```

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### Request Parameters
```csharp
new AiNameExpandParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedRequest**](AiNameParsedRequest.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformat"></a>
# **AiNameFormat**

```csharp
AiNameFormatted AiNameFormat(AiNameFormatRequest request)
```

Formats a person's name in correct case and name order using options for formatting instructions             

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformat"></a>
# **AiNameFormatAsync**

```csharp
async Task<AiNameFormatted> AiNameFormatAsync(AiNameFormatRequest request)
```

Formats a person's name in correct case and name order using options for formatting instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformatparsed"></a>
# **AiNameFormatParsed**

```csharp
AiNameFormatted AiNameFormatParsed(AiNameFormatParsedRequest request)
```

Formats a person's parsed name in correct case and name order using options for formatting instructions             

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

### Request Parameters
```csharp
new AiNameFormatParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedRequest**](AiNameParsedRequest.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformatparsed"></a>
# **AiNameFormatParsedAsync**

```csharp
async Task<AiNameFormatted> AiNameFormatParsedAsync(AiNameFormatParsedRequest request)
```

Formats a person's parsed name in correct case and name order using options for formatting instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

### Request Parameters
```csharp
new AiNameFormatParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedRequest**](AiNameParsedRequest.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderize"></a>
# **AiNameGenderize**

```csharp
AiNameGenderHypothesisList AiNameGenderize(AiNameGenderizeRequest request)
```

Detect person's gender from name string             

### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderize"></a>
# **AiNameGenderizeAsync**

```csharp
async Task<AiNameGenderHypothesisList> AiNameGenderizeAsync(AiNameGenderizeRequest request)
```

Detect person's gender from name string             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderizeparsed"></a>
# **AiNameGenderizeParsed**

```csharp
AiNameGenderHypothesisList AiNameGenderizeParsed(AiNameGenderizeParsedRequest request)
```

Detect person's gender from parsed name             

### Return type

[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)

### Request Parameters
```csharp
new AiNameGenderizeParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedRequest**](AiNameParsedRequest.md)| Gender detection request data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderizeparsed"></a>
# **AiNameGenderizeParsedAsync**

```csharp
async Task<AiNameGenderHypothesisList> AiNameGenderizeParsedAsync(AiNameGenderizeParsedRequest request)
```

Detect person's gender from parsed name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameGenderHypothesisList**](AiNameGenderHypothesisList.md)>

### Request Parameters
```csharp
new AiNameGenderizeParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedRequest**](AiNameParsedRequest.md)| Gender detection request data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematch"></a>
# **AiNameMatch**

```csharp
AiNameMatchResult AiNameMatch(AiNameMatchRequest request)
```

Compare people's names. Uses options for comparing instructions             

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematch"></a>
# **AiNameMatchAsync**

```csharp
async Task<AiNameMatchResult> AiNameMatchAsync(AiNameMatchRequest request)
```

Compare people's names. Uses options for comparing instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematchparsed"></a>
# **AiNameMatchParsed**

```csharp
AiNameMatchResult AiNameMatchParsed(AiNameMatchParsedRequest request)
```

Compare people's parsed names and attributes. Uses options for comparing instructions             

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

### Request Parameters
```csharp
new AiNameMatchParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedMatchRequest**](AiNameParsedMatchRequest.md)| Parsed names to match | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematchparsed"></a>
# **AiNameMatchParsedAsync**

```csharp
async Task<AiNameMatchResult> AiNameMatchParsedAsync(AiNameMatchParsedRequest request)
```

Compare people's parsed names and attributes. Uses options for comparing instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

### Request Parameters
```csharp
new AiNameMatchParsedRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AiNameParsedMatchRequest**](AiNameParsedMatchRequest.md)| Parsed names to match | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparse"></a>
# **AiNameParse**

```csharp
AiNameComponentList AiNameParse(AiNameParseRequest request)
```

Parse name to components             

### Return type

[**AiNameComponentList**](AiNameComponentList.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparse"></a>
# **AiNameParseAsync**

```csharp
async Task<AiNameComponentList> AiNameParseAsync(AiNameParseRequest request)
```

Parse name to components             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameComponentList**](AiNameComponentList.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparseemailaddress"></a>
# **AiNameParseEmailAddress**

```csharp
AiNameExtractedList AiNameParseEmailAddress(AiNameParseEmailAddressRequest request)
```

Parse person's name out of an email address             

### Return type

[**AiNameExtractedList**](AiNameExtractedList.md)

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparseemailaddress"></a>
# **AiNameParseEmailAddressAsync**

```csharp
async Task<AiNameExtractedList> AiNameParseEmailAddressAsync(AiNameParseEmailAddressRequest request)
```

Parse person's name out of an email address             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameExtractedList**](AiNameExtractedList.md)>

### Request Parameters
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

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

