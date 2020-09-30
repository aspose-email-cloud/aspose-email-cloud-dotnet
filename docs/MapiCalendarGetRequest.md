
# MapiCalendarGetRequest

Request model for MapiCalendarApi.Get

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**fileName** |**string**|Calendar file name in storage. |
**folder** |**string**|Path to folder in storage. |[optional] 
**storage** |**string**|Storage name. |[optional] 

## Example
```csharp
var request = new MapiCalendarGetRequest
{ 
    FileName = "calendar.msg",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
