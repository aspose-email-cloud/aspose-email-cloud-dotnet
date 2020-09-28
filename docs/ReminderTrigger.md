# ReminderTrigger
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateTime** | **DateTime?** | A trigger set to an absolute date/time. | 
**Duration** | **long?** | Specifies a relative time in ticks for the trigger of the alarm.              | [optional] 
**Related** | **string** | Specify the relationship of the alarm trigger with respect to the start or end of the event. Enum, available values: Start, End | 


## Example
```csharp
var reminderTrigger = new ReminderTrigger
{
    DateTime = DateTime.Today,
    Duration = 600000000
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

