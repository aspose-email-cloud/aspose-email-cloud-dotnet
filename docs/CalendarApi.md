# CalendarApi (EmailCloud.Calendar)

iCalendar document operations.

<a name="AsAlternate"></a>
## AsAlternate

**Description**: Convert iCalendar to AlternateView             


**Returns:** iCalendar document represented as AlternateView

**Method call example:**
```csharp
var result = api.Calendar.AsAlternate(request);
```

### Parameter: *request*

**Description:** iCalendar to AlternateView request

**See also** parameter model documentation at [**CalendarAsAlternateRequest**](CalendarAsAlternateRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** iCalendar document represented as AlternateView

**Return type:** [**AlternateView**](AlternateView.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = api.Calendar.AsAlternate(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsAlternateAsync"></a>
## AsAlternateAsync

**Description:** Convert iCalendar to AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** iCalendar document represented as AlternateView

**Method call example:**
```csharp
var result = await api.Calendar.AsAlternateAsync(request);
```

### Parameter: *request*

**Description:** iCalendar to AlternateView request

**See also** parameter model documentation at [**CalendarAsAlternateRequest**](CalendarAsAlternateRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** iCalendar document represented as AlternateView

**Return type:** Task<[**AlternateView**](AlternateView.md)>

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = await api.Calendar.AsAlternateAsync(request);

//Result example:
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsFile"></a>
## AsFile

**Description**: Converts calendar model to specified format and returns as file.             


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = api.Calendar.AsFile(request);
```

### Parameter: *request*

**Description:** Calendar model and format to convert.

**See also** parameter model documentation at [**CalendarAsFileRequest**](CalendarAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** File stream in specified format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = api.Calendar.AsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsFileAsync"></a>
## AsFileAsync

**Description:** Converts calendar model to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = await api.Calendar.AsFileAsync(request);
```

### Parameter: *request*

**Description:** Calendar model and format to convert.

**See also** parameter model documentation at [**CalendarAsFileRequest**](CalendarAsFileRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** File stream in specified format.

**Return type:** **Task<Stream>**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = await api.Calendar.AsFileAsync(request);
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="AsMapi"></a>
## AsMapi

**Description**: Converts CalendarDto to MapiCalendarDto.             


**Returns:** MAPI model calendar representation.

**Method call example:**
```csharp
var result = api.Calendar.AsMapi(calendarDto);
```

### Parameter: *calendarDto*

**Description:** iCalendar model calendar representation.

**See also** parameter model documentation at [**CalendarDto**](CalendarDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** MAPI model calendar representation.

**Return type:** [**MapiCalendarDto**](MapiCalendarDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = api.Calendar.AsMapi(calendarDto);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="AsMapiAsync"></a>
## AsMapiAsync

**Description:** Converts CalendarDto to MapiCalendarDto.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** MAPI model calendar representation.

**Method call example:**
```csharp
var result = await api.Calendar.AsMapiAsync(calendarDto);
```

### Parameter: *calendarDto*

**Description:** iCalendar model calendar representation.

**See also** parameter model documentation at [**CalendarDto**](CalendarDto.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Description:** MAPI model calendar representation.

**Return type:** Task<[**MapiCalendarDto**](MapiCalendarDto.md)>

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
var result = await api.Calendar.AsMapiAsync(calendarDto);

//Result example:
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Convert"></a>
## Convert
**Descrption:** Converts calendar document to specified format and returns as file.             


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = api.Calendar.Convert(request);
```

### Parameter: *request*

**Description:** Convert method request.

**See also** parameter model documentation at [**CalendarConvertRequest**](CalendarConvertRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};
```

</details>

### Result

**Description:** File stream in specified format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};

// Call method:
var result = api.Calendar.Convert(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="ConvertAsync"></a>
## ConvertAsync

**Description:** Converts calendar document to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = await api.Calendar.ConvertAsync(request);
```

### Parameter: *request*

**Description:** ConvertAsync method request.

**See also** parameter model documentation at [**CalendarConvertRequest**](CalendarConvertRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};
```

</details>

### Result

**Returns:** File stream in specified format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarConvertRequest
{ 
    Format = "Ics",
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.msg"))
};

// Call method:
var result = await api.Calendar.ConvertAsync(request);

using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="FromFile"></a>
## FromFile
**Descrption:** Converts calendar document to a model representation.             


**Returns:** iCalendar model.

**Method call example:**
```csharp
var result = api.Calendar.FromFile(request);
```

### Parameter: *request*

**Description:** FromFile method request.

**See also** parameter model documentation at [**CalendarFromFileRequest**](CalendarFromFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};
```

</details>

### Result

**Description:** iCalendar model.

**Return type:** [**CalendarDto**](CalendarDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};

// Call method:
var result = api.Calendar.FromFile(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="FromFileAsync"></a>
## FromFileAsync

**Description:** Converts calendar document to a model representation.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** iCalendar model.

**Method call example:**
```csharp
var result = await api.Calendar.FromFileAsync(request);
```

### Parameter: *request*

**Description:** FromFileAsync method request.

**See also** parameter model documentation at [**CalendarFromFileRequest**](CalendarFromFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};
```

</details>

### Result

**Returns:** iCalendar model.

**Return type:** [**CalendarDto**](CalendarDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarFromFileRequest
{ 
    File = new MemoryStream(File.ReadAllBytes("/path/to/calendar.ics"))
};

// Call method:
var result = await api.Calendar.FromFileAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Get"></a>
## Get
**Descrption:** Get calendar file from storage.             


**Returns:** iCalendar model.

**Method call example:**
```csharp
var result = api.Calendar.Get(request);
```

### Parameter: *request*

**Description:** Get method request.

**See also** parameter model documentation at [**CalendarGetRequest**](CalendarGetRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Description:** iCalendar model.

**Return type:** [**CalendarDto**](CalendarDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = api.Calendar.Get(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsync"></a>
## GetAsync

**Description:** Get calendar file from storage.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** iCalendar model.

**Method call example:**
```csharp
var result = await api.Calendar.GetAsync(request);
```

### Parameter: *request*

**Description:** GetAsync method request.

**See also** parameter model documentation at [**CalendarGetRequest**](CalendarGetRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Returns:** iCalendar model.

**Return type:** [**CalendarDto**](CalendarDto.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetRequest
{ 
    FileName = "calendar.ics",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await api.Calendar.GetAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsAlternate"></a>
## GetAsAlternate
**Descrption:** Get iCalendar from storage as AlternateView             


**Returns:** iCalendar document represented as AlternateView

**Method call example:**
```csharp
var result = api.Calendar.GetAsAlternate(request);
```

### Parameter: *request*

**Description:** GetAsAlternate method request.

**See also** parameter model documentation at [**CalendarGetAsAlternateRequest**](CalendarGetAsAlternateRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Description:** iCalendar document represented as AlternateView

**Return type:** [**AlternateView**](AlternateView.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = api.Calendar.GetAsAlternate(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsAlternateAsync"></a>
## GetAsAlternateAsync

**Description:** Get iCalendar from storage as AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** iCalendar document represented as AlternateView

**Method call example:**
```csharp
var result = await api.Calendar.GetAsAlternateAsync(request);
```

### Parameter: *request*

**Description:** GetAsAlternateAsync method request.

**See also** parameter model documentation at [**CalendarGetAsAlternateRequest**](CalendarGetAsAlternateRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};
```

</details>

### Result

**Returns:** iCalendar document represented as AlternateView

**Return type:** [**AlternateView**](AlternateView.md)

<details>
    <summary>Result example</summary>

```csharp
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetAsAlternateRequest
{ 
    FileName = "calendar.ics",
    CalendarAction = "Create",
    Folder = "calendar/location/on/storage",
    Storage = "First Storage"
};

// Call method:
var result = await api.Calendar.GetAsAlternateAsync(request);

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetAsFile"></a>
## GetAsFile
**Descrption:** Converts calendar document from storage to specified format and returns as file.             


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = api.Calendar.GetAsFile(request);
```

### Parameter: *request*

**Description:** GetAsFile method request.

**See also** parameter model documentation at [**CalendarGetAsFileRequest**](CalendarGetAsFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};
```

</details>

### Result

**Description:** File stream in specified format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};

// Call method:
var result = api.Calendar.GetAsFile(request);

// Result can be saved to file:
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    result.CopyTo(resultFileStream);
}
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetAsFileAsync"></a>
## GetAsFileAsync

**Description:** Converts calendar document from storage to specified format and returns as file.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** File stream in specified format.

**Method call example:**
```csharp
var result = await api.Calendar.GetAsFileAsync(request);
```

### Parameter: *request*

**Description:** GetAsFileAsync method request.

**See also** parameter model documentation at [**CalendarGetAsFileRequest**](CalendarGetAsFileRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};
```

</details>

### Result

**Returns:** File stream in specified format.

**Return type:** **Stream**

<details>
    <summary>Result can be saved to file:</summary>

```csharp
using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}
```

</details>

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetAsFileRequest
{ 
    FileName = "calendar.msg",
    Format = "Ics",
    Storage = "First Storage",
    Folder = "calendar/file/location/on/storage"
};

// Call method:
var result = await api.Calendar.GetAsFileAsync(request);

using(var resultFileStream = File.OpenWrite("/path/to/local/file/to/write/to"))
{
    await result.CopyToAsync(resultFileStream);
}

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="GetList"></a>
## GetList
**Descrption:** Get iCalendar list from storage folder.             


**Returns:** iCalendar document list.

**Method call example:**
```csharp
var result = api.Calendar.GetList(request);
```

### Parameter: *request*

**Description:** GetList method request.

**See also** parameter model documentation at [**CalendarGetListRequest**](CalendarGetListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};
```

</details>

### Result

**Description:** iCalendar document list.

**Return type:** [**CalendarStorageList**](CalendarStorageList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new CalendarStorageList
{
    Value = new List<StorageModelOfCalendarDto>
    {
        new StorageModelOfCalendarDto
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};

// Call method:
var result = api.Calendar.GetList(request);

// Result example:
result = new CalendarStorageList
{
    Value = new List<StorageModelOfCalendarDto>
    {
        new StorageModelOfCalendarDto
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="GetListAsync"></a>
## GetListAsync

**Description:** Get iCalendar list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** iCalendar document list.

**Method call example:**
```csharp
var result = await api.Calendar.GetListAsync(request);
```

### Parameter: *request*

**Description:** GetListAsync method request.

**See also** parameter model documentation at [**CalendarGetListRequest**](CalendarGetListRequest.md).

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};
```

</details>

### Result

**Returns:** iCalendar document list.

**Return type:** [**CalendarStorageList**](CalendarStorageList.md)

<details>
    <summary>Result example</summary>

```csharp
result = new CalendarStorageList
{
    Value = new List<StorageModelOfCalendarDto>
    {
        new StorageModelOfCalendarDto
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

### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new CalendarGetListRequest
{ 
    Folder = "some/folder/on/storage",
    ItemsPerPage = 10,
    PageNumber = 0,
    Storage = "First Storage"
};

// Call method:
var result = await api.Calendar.GetListAsync(request);

result = new CalendarStorageList
{
    Value = new List<StorageModelOfCalendarDto>
    {
        new StorageModelOfCalendarDto
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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
<a name="Save"></a>
## Save

**Description**: Save iCalendar             


**Method call example:**
```csharp
api.Calendar.Save(request);
```

### Parameter: *request*

**Description:** iCalendar create/update request

**See also** parameter model documentation at [**CalendarSaveRequest**](CalendarSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** void (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
api.Calendar.Save(request);
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="SaveAsync"></a>
## SaveAsync

**Description:** Save iCalendar             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Method call example:**
```csharp
await api.Calendar.SaveAsync(request);
```

### Parameter: *request*

**Description:** iCalendar create/update request

**See also** parameter model documentation at [**CalendarSaveRequest**](CalendarSaveRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
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
```

</details>


### Result

**Return type:** Task (empty response body)


### Complete example:

<details>
    <summary>Method call example:</summary>

```csharp
var api = new EmailCloud(appKey, appSid);

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
await api.Calendar.SaveAsync(request);

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
