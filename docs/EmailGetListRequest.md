
# EmailGetListRequest

Request model for EmailApi.GetList

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**format** |**string**|Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft |
**folder** |**string**|Path to folder in storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 
**itemsPerPage** |**int?**|Count of items on page. |[optional] [default to 10]
**pageNumber** |**int?**|Page number. |[optional] [default to 0]

## Example
```csharp
var request = new EmailGetListRequest
{ 
    Format = "Eml",
    Folder = "folder/on/storage",
    Storage = "First Storage",
    ItemsPerPage = 10,
    PageNumber = 0
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
