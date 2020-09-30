
# MapiContactGetRequest

Request model for MapiContactApi.Get

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**format** |**string**|Contact document format. Enum, available values: VCard, WebDav, Msg |
**fileName** |**string**|Contact document file name. |
**folder** |**string**|Path to folder in storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 

## Example
```csharp
var request = new MapiContactGetRequest
{ 
    Format = "VCard",
    FileName = "contact.vcf",
    Folder = "folder/on/storage",
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
