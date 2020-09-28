
# CalendarGetListRequest

Request model for CalendarApi.GetList

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**folder** | **string**| Path to folder in storage. | 
**itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
**pageNumber** | **int?**| Page number. | [optional] [default to 0]
**storage** | **string**| Storage name. | [optional] 

## Example
```csharp
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
