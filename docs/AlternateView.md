# AlternateView
Represents the format to view a message.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseUri** | **string** | Base URI.              | [optional] 
**LinkedResources** | [**List&lt;LinkedResource&gt;**](LinkedResource.md) | Embedded resources referred to by this alternate view.              | [optional] 

## Parent class

See: [AttachmentBase](AttachmentBase.md)

## Example
```csharp
var alternateView = new AlternateView
{
    Base64Data = "<File content represented as Base64 string>",
    ContentId = "fa7a8948-4af1-432a-b4d9-ee0c28542e75",
    ContentType = new ContentType
    {
        CharSet = "utf-8",
        MediaType = "text/calendar",
        Name = "meeting.ics",
        Parameters = new List<ContentTypeParameter>
        {
            new ContentTypeParameter
            {
                Name = "Method",
                Value = "REQUEST"
            },
            new ContentTypeParameter
            {
                Name = "Name",
                Value = "meeting.ics"
            },
            new ContentTypeParameter
            {
                Name = "charset",
                Value = "utf-8"
            }
        }
    }
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

