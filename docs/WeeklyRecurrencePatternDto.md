# WeeklyRecurrencePatternDto
Weekly recurrence pattern.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDays** | **List&lt;string&gt;** | Start days              Items: Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay | [optional] 

## Parent class

See: [RecurrencePatternDto](RecurrencePatternDto.md)

## Example
```csharp
var weeklyRecurrencePatternDto = new WeeklyRecurrencePatternDto
{
    StartDays = new List<CalendarDay>
    {
        "Tuesday",
        "Thursday"
    },
    Interval = -1,
    Occurs = 10,
    WeekStart = "Sunday"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

