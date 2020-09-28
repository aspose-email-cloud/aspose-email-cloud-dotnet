# RecurrencePatternDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **int?** | Number of recurrence units.              | 
**Occurs** | **int?** | Number of occurrences of the recurrence pattern.              | 
**EndDate** | **DateTime?** | End date.              | 
**WeekStart** | **string** | Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay | 
**Discriminator** | **string** |  | 


## Example
```csharp
var recurrencePatternDto = new RecurrencePatternDto
{
    Interval = -1,
    WeekStart = "Monday"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

