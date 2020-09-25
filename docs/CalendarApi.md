# Aspose.Email.Cloud.Sdk.CalendarApi

<a name="AsAlternate"></a>
# AsAlternate

Convert iCalendar to AlternateView             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarAsAlternateRequest
{
    Value = new CalendarDto
    {
        Attendees = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "Attendee Name",
                Address = "attendee@aspose.com",
                ParticipationStatus = "Accepted"
            }
        },
        Description = "Some description",
        EndDate = DateTime.Today,
        Location = "Some location",
        Organizer = new MailAddress
        {
            DisplayName = "Organizer Name",
            Address = "organizer@aspose.com"
        },
        Recurrence = new DailyRecurrencePatternDto
        {
            Interval = -1,
            Occurs = 10,
            WeekStart = "Monday"
        },
        StartDate = DateTime.Today,
        Summary = "Some summary"
    },
    SequenceId = "cf4ffb6c-895d-4e58-bdb4-0a3918e96a43"
};

// Call method:
var result = Api.Calendar.AsAlternate(request);

// Result example:
result = new AlternateView
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

</details>

### request Parameter
See parameter model documentation at [CalendarAsAlternateRequest](CalendarAsAlternateRequest.md)


### Return type

[**AlternateView**](AlternateView.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsAlternateAsync"></a>
# AsAlternateAsync

Convert iCalendar to AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarAsAlternateRequest
{
    Value = new CalendarDto
    {
        Attendees = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "Attendee Name",
                Address = "attendee@aspose.com",
                ParticipationStatus = "Accepted"
            }
        },
        Description = "Some description",
        EndDate = DateTime.Today,
        Location = "Some location",
        Organizer = new MailAddress
        {
            DisplayName = "Organizer Name",
            Address = "organizer@aspose.com"
        },
        Recurrence = new DailyRecurrencePatternDto
        {
            Interval = -1,
            Occurs = 10,
            WeekStart = "Monday"
        },
        StartDate = DateTime.Today,
        Summary = "Some summary"
    },
    SequenceId = "cf4ffb6c-895d-4e58-bdb4-0a3918e96a43"
};

// Call method:
var result = await Api.Calendar.AsAlternateAsync(request);

// Result example:
result = new AlternateView
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

</details>

### request Parameter
See parameter model documentation at [CalendarAsAlternateRequest](CalendarAsAlternateRequest.md)


### Return type

Task<[**AlternateView**](AlternateView.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsFile"></a>
# AsFile

Converts calendar model to specified format and returns as file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarAsFileRequest
{
    Value = new CalendarDto
    {
        Attendees = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "Attendee Name",
                Address = "attendee@aspose.com",
                ParticipationStatus = "Accepted"
            }
        },
        Description = "Some description",
        EndDate = DateTime.Today,
        Location = "Some location",
        Organizer = new MailAddress
        {
            DisplayName = "Organizer Name",
            Address = "organizer@aspose.com"
        },
        Recurrence = new DailyRecurrencePatternDto
        {
            Interval = -1,
            Occurs = 10,
            WeekStart = "Monday"
        },
        StartDate = DateTime.Today,
        Summary = "Some summary"
    }
};

// Call method:
var result = Api.Calendar.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [CalendarAsFileRequest](CalendarAsFileRequest.md)


### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

Converts calendar model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarAsFileRequest
{
    Value = new CalendarDto
    {
        Attendees = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "Attendee Name",
                Address = "attendee@aspose.com",
                ParticipationStatus = "Accepted"
            }
        },
        Description = "Some description",
        EndDate = DateTime.Today,
        Location = "Some location",
        Organizer = new MailAddress
        {
            DisplayName = "Organizer Name",
            Address = "organizer@aspose.com"
        },
        Recurrence = new DailyRecurrencePatternDto
        {
            Interval = -1,
            Occurs = 10,
            WeekStart = "Monday"
        },
        StartDate = DateTime.Today,
        Summary = "Some summary"
    }
};

// Call method:
var result = await Api.Calendar.AsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [CalendarAsFileRequest](CalendarAsFileRequest.md)


### Return type

**Task<Stream>**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsMapi"></a>
# AsMapi

Converts CalendarDto to MapiCalendarDto.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var calendarDto = new CalendarDto
{
    Attendees = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "Attendee Name",
            Address = "attendee@aspose.com",
            ParticipationStatus = "Accepted"
        }
    },
    Description = "Some description",
    EndDate = DateTime.Today,
    Location = "Some location",
    Organizer = new MailAddress
    {
        DisplayName = "Organizer Name",
        Address = "organizer@aspose.com"
    },
    Recurrence = new DailyRecurrencePatternDto
    {
        Interval = -1,
        Occurs = 10,
        WeekStart = "Monday"
    },
    StartDate = DateTime.Today,
    Summary = "Some summary"
};

// Call method:
var result = Api.Calendar.AsMapi(calendarDto);

// Result example:
result = new MapiCalendarDto
{
    Attendees = new MapiCalendarAttendeesDto
    {
        AppointmentRecipients = new List<MapiRecipientDto>
        {
            new MapiRecipientDto
            {
                EmailAddress = "organizer@aspose.com",
                AddressType = "SMTP",
                DisplayName = "Organizer Name",
                RecipientType = "MapiTo"
            },
            new MapiRecipientDto
            {
                EmailAddress = "attendee@aspose.com",
                AddressType = "SMTP",
                DisplayName = "Attendee Name",
                RecipientType = "MapiTo"
            }
        }
    },
    BusyStatus = "Tentative",
    ClientIntent = new List<MapiCalendarClientIntent>
    {
        "Manager"
    },
    EndDate = DateTime.Today,
    Location = "Some location",
    Recurrence = new MapiCalendarEventRecurrenceDto
    {
        RecurrencePattern = new MapiCalendarDailyRecurrencePatternDto
        {
            Frequency = "Daily",
            OccurrenceCount = 10,
            WeekStartDay = "Monday"
        }
    },
    StartDate = DateTime.Today,
    Organizer = new MapiElectronicAddressDto
    {
        EmailAddress = "organizer@aspose.com"
    },
    Body = "Some description",
    Subject = "Some summary"
};
```

</details>

### calendarDto Parameter
See parameter model documentation at [CalendarDto](CalendarDto.md)


### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
# AsMapiAsync

Converts CalendarDto to MapiCalendarDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var calendarDto = new CalendarDto
{
    Attendees = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "Attendee Name",
            Address = "attendee@aspose.com",
            ParticipationStatus = "Accepted"
        }
    },
    Description = "Some description",
    EndDate = DateTime.Today,
    Location = "Some location",
    Organizer = new MailAddress
    {
        DisplayName = "Organizer Name",
        Address = "organizer@aspose.com"
    },
    Recurrence = new DailyRecurrencePatternDto
    {
        Interval = -1,
        Occurs = 10,
        WeekStart = "Monday"
    },
    StartDate = DateTime.Today,
    Summary = "Some summary"
};

// Call method:
var result = await Api.Calendar.AsMapiAsync(calendarDto);

// Result example:
result = new MapiCalendarDto
{
    Attendees = new MapiCalendarAttendeesDto
    {
        AppointmentRecipients = new List<MapiRecipientDto>
        {
            new MapiRecipientDto
            {
                EmailAddress = "organizer@aspose.com",
                AddressType = "SMTP",
                DisplayName = "Organizer Name",
                RecipientType = "MapiTo"
            },
            new MapiRecipientDto
            {
                EmailAddress = "attendee@aspose.com",
                AddressType = "SMTP",
                DisplayName = "Attendee Name",
                RecipientType = "MapiTo"
            }
        }
    },
    BusyStatus = "Tentative",
    ClientIntent = new List<MapiCalendarClientIntent>
    {
        "Manager"
    },
    EndDate = DateTime.Today,
    Location = "Some location",
    Recurrence = new MapiCalendarEventRecurrenceDto
    {
        RecurrencePattern = new MapiCalendarDailyRecurrencePatternDto
        {
            Frequency = "Daily",
            OccurrenceCount = 10,
            WeekStartDay = "Monday"
        }
    },
    StartDate = DateTime.Today,
    Organizer = new MapiElectronicAddressDto
    {
        EmailAddress = "organizer@aspose.com"
    },
    Body = "Some description",
    Subject = "Some summary"
};
```

</details>

### calendarDto Parameter
See parameter model documentation at [CalendarDto](CalendarDto.md)


### Return type

Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Convert"></a>
# Convert

Converts calendar document to specified format and returns as file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};

// Call method:
var result = Api.Calendar.Convert(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
# ConvertAsync

Converts calendar document to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};

// Call method:
var result = await Api.Calendar.ConvertAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
# FromFile

Converts calendar document to a model representation.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};

// Call method:
var result = Api.Calendar.FromFile(request);

// Result example:
result = new CalendarDto
{
    Attendees = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "Attendee Name",
            Address = "attendee@aspose.com",
            ParticipationStatus = "Accepted"
        }
    },
    Description = "Some description",
    EndDate = DateTime.Today,
    Location = "Some location",
    Organizer = new MailAddress
    {
        DisplayName = "Organizer Name",
        Address = "organizer@aspose.com"
    },
    Recurrence = new DailyRecurrencePatternDto
    {
        Interval = -1,
        Occurs = 10,
        WeekStart = "Monday"
    },
    StartDate = DateTime.Today,
    Summary = "Some summary"
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**CalendarDto**](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

Converts calendar document to a model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};

// Call method:
var result = await Api.Calendar.FromFileAsync(request);

// Result example:
result = new CalendarDto
{
    Attendees = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "Attendee Name",
            Address = "attendee@aspose.com",
            ParticipationStatus = "Accepted"
        }
    },
    Description = "Some description",
    EndDate = DateTime.Today,
    Location = "Some location",
    Organizer = new MailAddress
    {
        DisplayName = "Organizer Name",
        Address = "organizer@aspose.com"
    },
    Recurrence = new DailyRecurrencePatternDto
    {
        Interval = -1,
        Occurs = 10,
        WeekStart = "Monday"
    },
    StartDate = DateTime.Today,
    Summary = "Some summary"
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**CalendarDto**](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
# Get

Get calendar file from storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Calendar.Get(request);

// Result example:
result = new CalendarDto
{
    Attendees = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "Attendee Name",
            Address = "attendee@aspose.com",
            ParticipationStatus = "Accepted"
        }
    },
    Description = "Some description",
    EndDate = DateTime.Today,
    Location = "Some location",
    Organizer = new MailAddress
    {
        DisplayName = "Organizer Name",
        Address = "organizer@aspose.com"
    },
    Recurrence = new DailyRecurrencePatternDto
    {
        Interval = -1,
        Occurs = 10,
        WeekStart = "Monday"
    },
    StartDate = DateTime.Today,
    Summary = "Some summary"
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**CalendarDto**](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

Get calendar file from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Calendar.GetAsync(request);

// Result example:
result = new CalendarDto
{
    Attendees = new List<MailAddress>
    {
        new MailAddress
        {
            DisplayName = "Attendee Name",
            Address = "attendee@aspose.com",
            ParticipationStatus = "Accepted"
        }
    },
    Description = "Some description",
    EndDate = DateTime.Today,
    Location = "Some location",
    Organizer = new MailAddress
    {
        DisplayName = "Organizer Name",
        Address = "organizer@aspose.com"
    },
    Recurrence = new DailyRecurrencePatternDto
    {
        Interval = -1,
        Occurs = 10,
        WeekStart = "Monday"
    },
    StartDate = DateTime.Today,
    Summary = "Some summary"
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**CalendarDto**](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsAlternate"></a>
# GetAsAlternate

Get iCalendar from storage as AlternateView             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Calendar.GetAsAlternate(request);

// Result example:
result = new AlternateView
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

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

### Return type

[**AlternateView**](AlternateView.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsAlternateAsync"></a>
# GetAsAlternateAsync

Get iCalendar from storage as AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Calendar.GetAsAlternateAsync(request);

// Result example:
result = new AlternateView
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

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

### Return type

[**AlternateView**](AlternateView.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsFile"></a>
# GetAsFile

Converts calendar document from storage to specified format and returns as file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};

// Call method:
var result = Api.Calendar.GetAsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name. | 
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **storage** | **string**| Storage name. | [optional] 
 **folder** | **string**| Path to folder in storage. | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
# GetAsFileAsync

Converts calendar document from storage to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};

// Call method:
var result = await Api.Calendar.GetAsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name. | 
 **format** | **string**| File format. Enum, available values: Ics, Msg | 
 **storage** | **string**| Storage name. | [optional] 
 **folder** | **string**| Path to folder in storage. | [optional] 

### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
# GetList

Get iCalendar list from storage folder.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};

// Call method:
var result = Api.Calendar.GetList(request);

// Result example:
result = new CalendarStorageList
{
    Value = new List<StorageModel<CalendarDto>>
    {
        new StorageModel<CalendarDto>
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "calendar.ics",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new CalendarDto
            {
                Attendees = new List<MailAddress>
                {
                    new MailAddress
                    {
                        DisplayName = "Attendee Name",
                        Address = "attendee@aspose.com",
                        ParticipationStatus = "Accepted"
                    }
                },
                Description = "Some description",
                EndDate = DateTime.Today,
                Location = "Some location",
                Organizer = new MailAddress
                {
                    DisplayName = "Organizer Name",
                    Address = "organizer@aspose.com"
                },
                Recurrence = new DailyRecurrencePatternDto
                {
                    Interval = -1,
                    Occurs = 10,
                    WeekStart = "Monday"
                },
                StartDate = DateTime.Today,
                Summary = "Some summary"
            }
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage. | 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**CalendarStorageList**](CalendarStorageList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
# GetListAsync

Get iCalendar list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};

// Call method:
var result = await Api.Calendar.GetListAsync(request);

// Result example:
result = new CalendarStorageList
{
    Value = new List<StorageModel<CalendarDto>>
    {
        new StorageModel<CalendarDto>
        {
            StorageFile = new StorageFileLocation
            {
                FileName = "calendar.ics",
                Storage = "First Storage",
                FolderPath = "file/location/folder/on/storage"
            },
            Value = new CalendarDto
            {
                Attendees = new List<MailAddress>
                {
                    new MailAddress
                    {
                        DisplayName = "Attendee Name",
                        Address = "attendee@aspose.com",
                        ParticipationStatus = "Accepted"
                    }
                },
                Description = "Some description",
                EndDate = DateTime.Today,
                Location = "Some location",
                Organizer = new MailAddress
                {
                    DisplayName = "Organizer Name",
                    Address = "organizer@aspose.com"
                },
                Recurrence = new DailyRecurrencePatternDto
                {
                    Interval = -1,
                    Occurs = 10,
                    WeekStart = "Monday"
                },
                StartDate = DateTime.Today,
                Summary = "Some summary"
            }
        }
    }
};
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage. | 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**CalendarStorageList**](CalendarStorageList.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
# Save

Save iCalendar             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "calendar.ics",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new CalendarDto
    {
        Attendees = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "Attendee Name",
                Address = "attendee@aspose.com",
                ParticipationStatus = "Accepted"
            }
        },
        Description = "Some description",
        EndDate = DateTime.Today,
        Location = "Some location",
        Organizer = new MailAddress
        {
            DisplayName = "Organizer Name",
            Address = "organizer@aspose.com"
        },
        Recurrence = new DailyRecurrencePatternDto
        {
            Interval = -1,
            Occurs = 10,
            WeekStart = "Monday"
        },
        StartDate = DateTime.Today,
        Summary = "Some summary"
    }
};

// Call method:
Api.Calendar.Save(request);

```

</details>

### request Parameter
See parameter model documentation at [CalendarSaveRequest](CalendarSaveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

Save iCalendar             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new CalendarSaveRequest
{
    StorageFile = new StorageFileLocation
    {
        FileName = "calendar.ics",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new CalendarDto
    {
        Attendees = new List<MailAddress>
        {
            new MailAddress
            {
                DisplayName = "Attendee Name",
                Address = "attendee@aspose.com",
                ParticipationStatus = "Accepted"
            }
        },
        Description = "Some description",
        EndDate = DateTime.Today,
        Location = "Some location",
        Organizer = new MailAddress
        {
            DisplayName = "Organizer Name",
            Address = "organizer@aspose.com"
        },
        Recurrence = new DailyRecurrencePatternDto
        {
            Interval = -1,
            Occurs = 10,
            WeekStart = "Monday"
        },
        StartDate = DateTime.Today,
        Summary = "Some summary"
    }
};

// Call method:
await Api.Calendar.SaveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [CalendarSaveRequest](CalendarSaveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
