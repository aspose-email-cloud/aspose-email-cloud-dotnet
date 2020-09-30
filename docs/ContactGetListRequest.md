
# ContactGetListRequest

Request model for ContactApi.GetList

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**format** |**string**|Contact document format. Enum, available values: VCard, WebDav, Msg |
**folder** |**string**|Path to folder in storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 
**itemsPerPage** |**int?**|Count of items on page. |[optional] [default to 10]
**pageNumber** |**int?**|Page number. |[optional] [default to 0]

## Example
```csharp
var request = new ContactGetListRequest
{ 
    Format = "VCard",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
