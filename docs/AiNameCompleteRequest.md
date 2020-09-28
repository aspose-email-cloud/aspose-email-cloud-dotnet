
# AiNameCompleteRequest

Request model for AiNameApi.Complete

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**name** | **string**| A name to complete. | 
**language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).              | [optional] 
**location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.              | [optional] 
**encoding** | **string**| A character encoding name. | [optional] 
**script** | **string**| A writing system code; starts with the ISO-15924 script name. | [optional] 
**style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

## Example
```csharp
var request = new AiNameCompleteRequest
{ 
    Name = "Dav",
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
