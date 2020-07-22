# Model.CalendarDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Document attachments. | [optional] 
**Attendees** | [**List&lt;MailAddress&gt;**](MailAddress.md) | Event attendees. | 
**Description** | **string** | Description. | [optional] 
**EndDate** | **DateTime?** | End date. | 
**EndTimeZone** | **string** | End time zone. | [optional] 
**Flags** | **List&lt;string&gt;** | Appointment flags. Items: Enumerates iCalendar flags. Enum, available values: None, AllDayEvent | [optional] 
**IsDescriptionHtml** | **bool?** | Indicates if description is in HTML format. | 
**Location** | **string** | Location. | 
**Method** | **string** | Defines the iCalendar object method type associated with the calendar document. Enum, available values: None, Publish, Request, Reply, Add, Cancel, Refresh, Counter, DeclineCounter | 
**MicrosoftBusyStatus** | **string** | Specifies the BUSY status. Enum, available values: NotDefined, Free, Tentative, Busy, Oof | 
**MicrosoftIntendedStatus** | **string** | Specifies the INTENDED status. Enum, available values: NotDefined, Free, Tentative, Busy, Oof | 
**OptionalAttendees** | [**List&lt;MailAddress&gt;**](MailAddress.md) | Optional attendees.              | [optional] 
**Organizer** | [**MailAddress**](MailAddress.md) | Event organizer.              | 
**RecurrenceString** | **string** | Deprecated, use &#39;Recurrence&#39; property. String representation of recurrence pattern (See iCalendar RFC, \&quot;Recurrence rule\&quot; section). For example:               For daily recurrence:         \&quot;FREQ&#x3D;DAILY;COUNT&#x3D;10;WKST&#x3D;MO\&quot;                   For monthly recurrence:         \&quot;BYSETPOS&#x3D;1;BYDAY&#x3D;MO,TU,WE,TH,FR;FREQ&#x3D;MONTHLY;INTERVAL&#x3D;10;WKST&#x3D;MO\&quot;                   For yearly recurrence:         \&quot;BYMONTHDAY&#x3D;30;BYMONTH&#x3D;1;FREQ&#x3D;YEARLY;WKST&#x3D;MO\&quot;                    | [optional] 
**Recurrence** | [**RecurrencePatternDto**](RecurrencePatternDto.md) | Recurrence pattern              | [optional] 
**Reminders** | [**List&lt;CalendarReminder&gt;**](CalendarReminder.md) | Reminders. | [optional] 
**SequenceId** | **string** | The sequence id. Read only. | [optional] 
**StartDate** | **DateTime?** | Start date. | 
**StartTimeZone** | **string** | Start time zone. | [optional] 
**Status** | **string** | Defines the overall status or confirmation for the calendar document. Enum, available values: NotDefined, Cancelled, Tentative, Confirmed | 
**Summary** | **string** | Summary. | [optional] 
**Transparency** | **string** | Specifies whether or not this appointment is intended to be visible in availability searches. Enum, available values: NotDefined, Transparent, Opaque | 



[[Back to Model list]](Models.doc) [[Back to README]](README.md)


