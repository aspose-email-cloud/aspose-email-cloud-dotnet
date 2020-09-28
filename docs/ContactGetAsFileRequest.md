
# ContactGetAsFileRequest

Request model for ContactApi.GetAsFile

## Properties

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**fileName** | **string**| Calendar document file name | 
**toFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
**fromFormat** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
**storage** | **string**| Storage name | [optional] 
**folder** | **string**| Path to folder in storage | [optional] 

## Example
```csharp
var request = new ContactGetAsFileRequest
{ 
    FileName = "contact.msg",
    ToFormat = "VCard",
    FromFormat = "Msg",
    Storage = "First Storage",
    Folder = "folder/on/storage"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)
