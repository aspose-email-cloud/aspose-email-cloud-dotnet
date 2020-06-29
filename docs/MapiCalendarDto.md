# Model.MapiCalendarDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppointmentCounterProposal** | **bool?** | Value indicating whether a Meeting Response object is a counter proposal.              | 
**Attendees** | **Object** | Attendees              | [optional] 
**BusyStatus** | **string** | Enumerates the mapi calendar possible busy status Enum, available values: Free, Tentative, Busy, OutOfOffice | 
**ClientIntent** | **List&lt;string&gt;** | Actions the user has taken on this Meeting object.              Items: Enumerates the actions the user can taken on the Meeting object Enum, available values: Manager, Delegate, DeletedWithNoResponse, DeletedExceptionWithNoResponse, RespondedTentative, RespondedAccept, RespondedDecline, ModifiedStartTime, ModifiedEndTime, ModifiedLocation, RespondedExceptionDecline, Canceled, ExceptionCanceled | [optional] 
**EndDate** | **DateTime?** | End date and time of the event. If the date is not set, default value for DateTime is returned.              | 
**EndDateTimeZone** | **Object** | Time zone information that indicates the time zone of the EndDate property.              | [optional] 
**IsAllDay** | **bool?** | Value indicating whether the event is an all-day event.              | 
**KeyWords** | **string** | Categories of the calendar object.              | [optional] 
**Location** | **string** | Location of the event.              | [optional] 
**Recurrence** | **Object** | Recurrence properties.              | [optional] 
**ReminderDelta** | **int?** | Interval, in minutes, between the time at which the reminder first becomes overdue and the start time of the Calendar object.              | 
**ReminderFileParameter** | **string** | Full path of the sound that a client SHOULD play when the reminder becomes overdue.              | [optional] 
**ReminderSet** | **bool?** | Value indicating whether a reminder is set on the object.              | 
**Sequence** | **int?** | Sequence number.              | 
**StartDate** | **DateTime?** | Start date and time of the event. If the date is not set, default value for DateTime is returned.              | 
**StartDateTimeZone** | **Object** | Time zone information that indicates the time zone of the StartDate property.              | [optional] 
**Uid** | **string** | Unique identifier.              | [optional] 
**Organizer** | **Object** | Organizer              | [optional] 

 Parent class: [MapiMessageItemBaseDto](MapiMessageItemBaseDto.md)

[[Back to Model list]](README.md#documentation-for-models) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to README]](README.md)


