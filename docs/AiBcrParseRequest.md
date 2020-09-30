
# AiBcrParseRequest

Request model for AiBcrApi.Parse

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**file** |**System.IO.Stream**|File to parse |
**countries** |**string**|Comma-separated codes of countries. |[optional] 
**languages** |**string**|Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \"it\" or \"ita\" for Italian); it's \"\" by default.              |[optional] 
**isSingle** |**bool?**|Determines that image contains single VCard or more. |[optional] [default to true]

## Example
```csharp
var request = new AiBcrParseRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/image.png")),
    Countries = "us",
    Languages = "en",
    IsSingle = true
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
