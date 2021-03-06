# MapiCalendarEventRecurrenceDto
Recurrence properties of calendar object.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppointmentTimeZoneDefinitionRecur** | [**MapiCalendarTimeZoneDto**](MapiCalendarTimeZoneDto.md) | Time zone information that describes how to convert the meeting date and time on a recurring series to and from UTC.              | [optional] 
**ClipEnd** | **DateTime?** | Date of the last instance.              | 
**ClipStart** | **DateTime?** | Date of the first instance.              | 
**IsException** | **bool?** | Value indicating whether the object represents an exception.              | 
**RecurrencePattern** | [**MapiCalendarRecurrencePatternDto**](MapiCalendarRecurrencePatternDto.md) | Recurrence pattern.              | [optional] 
**TimeZoneStruct** | [**MapiCalendarTimeZoneDto**](MapiCalendarTimeZoneDto.md) | Time zone information for a recurring meeting.              | [optional] 


[[Back to Model list]](Models.md) [[Back to README]](README.md)

