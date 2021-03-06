# TaskRegeneratingPatternDto
Represents the regenerating recurrence pattern that specifies how many days, weeks, months or years after the completion of the current task the next occurrence will be due.             

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegeneratingType** | **string** | Enumerates the types of regenerating pattern. Enum, available values: Daily, Weekly, Monthly, Yearly | 

## Parent class

See: [RecurrencePatternDto](RecurrencePatternDto.md)

## Example
```csharp
var taskRegeneratingPatternDto = new TaskRegeneratingPatternDto
{
    Interval = 1,
    Occurs = 2,
    EndDate = DateTime.Today,
    WeekStart = "Sunday"
};
```

[[Back to Model list]](Models.md) [[Back to README]](README.md)

