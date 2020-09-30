
# AiNameFormatRequest

Request model for AiNameApi.Format

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**name** |**string**|A name to format. |
**language** |**string**|An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \"it\" or \"ita\" for Italian).              |[optional] 
**location** |**string**|A geographic code such as an ISO-3166 two letter country code, for example \"FR\" for France.              |[optional] 
**encoding** |**string**|A character encoding name. |[optional] 
**script** |**string**|A writing system code; starts with the ISO-15924 script name. |[optional] 
**format** |**string**|Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (= '%t%F%m%N%L%p')     /format/FN+LN/ (= '%F%L')     /format/title+FN+LN/ (= '%t%F%L')     /format/FN+MN+LN/ (= '%F%M%N%L')     /format/title+FN+MN+LN/ (= '%t%F%M%N%L')     /format/FN+MI+LN/ (= '%F%m%N%L')     /format/title+FN+MI+LN/ (= '%t%F%m%N%L')     /format/LN/ (= '%L')     /format/title+LN/ (= '%t%L')     /format/LN+FN+MN/ (= '%L,%F%M%N')     /format/LN+title+FN+MN/ (= '%L,%t%F%M%N')     /format/LN+FN+MI/ (= '%L,%F%m%N')     /format/LN+title+FN+MI/ (= '%L,%t%F%m%N')  Custom format string - custom combination of characters and the next term placeholders:      '%t' - Title (prefix)     '%F' - First name     '%f' - First initial     '%M' - Middle name(s)     '%m' - Middle initial(s)     '%N' - Nickname     '%L' - Last name     '%l' - Last initial     '%p' - Postfix  If no value for format option was provided, its default value is '%t%F%m%N%L%p'              |[optional] 
**style** |**string**|Name writing style. Enum, available values: Formal, Informal, Legal, Academic |[optional] [default to 0]

## Example
```csharp
var request = new AiNameFormatRequest
{ 
    Name = "Mr. John Michael Cane",
    Format = "%t%L%f%m"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
