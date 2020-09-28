# YearlyRecurrencePatternDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDay** | **string** | Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay | 
**StartMonth** | **string** | Represents a calendar month. Enum, available values: None, January, February, March, April, May, June, July, August, September, October, November, December | 
**StartOffset** | **int?** | Start offset.              | 
**StartPosition** | **string** | Day positions, typically found in a month. Enum, available values: None, First, Second, Third, Fourth, Last | 

## Parent class

See: [RecurrencePatternDto](RecurrencePatternDto.md)

## Example
```csharp
var yearlyRecurrencePatternDto = new YearlyRecurrencePatternDto
{
    StartMonth = "January",
    StartOffset = 30,
    Interval = -1,
    WeekStart = "Monday"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

