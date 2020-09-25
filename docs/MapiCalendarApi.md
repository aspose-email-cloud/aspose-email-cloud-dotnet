# Aspose.Email.Cloud.Sdk.MapiCalendarApi

<a name="AsCalendarDto"></a>
# AsCalendarDto

Converts MAPI calendar model to CalendarDto model.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var mapiCalendarDto = new MapiCalendarDto
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

// Call method:
var result = Api.Mapi.Calendar.AsCalendarDto(mapiCalendarDto);

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

### mapiCalendarDto Parameter
See parameter model documentation at [MapiCalendarDto](MapiCalendarDto.md)


### Return type

[**CalendarDto**](CalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsCalendarDtoAsync"></a>
# AsCalendarDtoAsync

Converts MAPI calendar model to CalendarDto model.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var mapiCalendarDto = new MapiCalendarDto
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

// Call method:
var result = await Api.Mapi.Calendar.AsCalendarDtoAsync(mapiCalendarDto);

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

### mapiCalendarDto Parameter
See parameter model documentation at [MapiCalendarDto](MapiCalendarDto.md)


### Return type

Task<[**CalendarDto**](CalendarDto.md)>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsFile"></a>
# AsFile

Converts MAPI calendar model to specified format and returns as file.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarAsFileRequest
{
    Format = "Msg",
    Value = new MapiCalendarDto
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
    }
};

// Call method:
var result = Api.Mapi.Calendar.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [MapiCalendarAsFileRequest](MapiCalendarAsFileRequest.md)


### Return type

**Stream**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
# AsFileAsync

Converts MAPI calendar model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarAsFileRequest
{
    Format = "Msg",
    Value = new MapiCalendarDto
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
    }
};

// Call method:
var result = await Api.Mapi.Calendar.AsFileAsync(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### request Parameter
See parameter model documentation at [MapiCalendarAsFileRequest](MapiCalendarAsFileRequest.md)


### Return type

**Task<Stream>**

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
# FromFile

Converts calendar file to a MAPI model representation.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};

// Call method:
var result = Api.Mapi.Calendar.FromFile(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
# FromFileAsync

Converts calendar file to a MAPI model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};

// Call method:
var result = await Api.Mapi.Calendar.FromFileAsync(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
# Get

Get MAPI calendar document.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarGetRequest
{ 
    FileName = "calendar.msg",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = Api.Mapi.Calendar.Get(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
# GetAsync

Get MAPI calendar document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarGetRequest
{ 
    FileName = "calendar.msg",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await Api.Mapi.Calendar.GetAsync(request);

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

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar file name in storage. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

### Return type

[**MapiCalendarDto**](MapiCalendarDto.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
# Save

Save MAPI Calendar to storage.             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "calendar.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiCalendarDto
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
    }
};

// Call method:
Api.Mapi.Calendar.Save(request);

```

</details>

### request Parameter
See parameter model documentation at [MapiCalendarSaveRequest](MapiCalendarSaveRequest.md)


### Return type

void (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
# SaveAsync

Save MAPI Calendar to storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new MapiCalendarSaveRequest
{
    Format = "Msg",
    StorageFile = new StorageFileLocation
    {
        FileName = "calendar.msg",
        Storage = "First Storage",
        FolderPath = "file/location/folder/on/storage"
    },
    Value = new MapiCalendarDto
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
    }
};

// Call method:
await Api.Mapi.Calendar.SaveAsync(request);

```

</details>

### request Parameter
See parameter model documentation at [MapiCalendarSaveRequest](MapiCalendarSaveRequest.md)


### Return type

Task (empty response body)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
