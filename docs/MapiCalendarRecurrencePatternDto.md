# Model.MapiCalendarRecurrencePatternDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalendarType** | **string** | Enumerated the calendar type of the mapi recurrence Enum, available values: Default, CalGregorian, CalGregorianUs, CalJapan, CalTaiwan, CalKorea, CalHijri, CalThai, CalHebrew, CalGregorianMeFrench, CalGregorianArabic, CalGregorianXLitEnglish, CalGregorianXLitFrench, CalLunarJapanese, CalChineseLunar, CalSaka, CalLunarEtoChn, CalLunarEtoKor, CalLunarRokuyou, CalLunarKorean, CalUmAlQura | 
**DeletedInstanceDates** | **List&lt;DateTime?&gt;** | An array of dates, each of which is the original instance date of either a deleted instance or a modified instance for this recurrence.              | [optional] 
**EndDate** | **DateTime?** | End date of an item recurrence pattern.              | 
**EndType** | **string** | Enumerates the ending type for the recurrence. Enum, available values: None, EndAfterDate, EndAfterNOccurrences, NeverEnd | 
**Exceptions** | [**List&lt;MapiCalendarExceptionInfoDto&gt;**](MapiCalendarExceptionInfoDto.md) | An exception specifies changes to an instance of a recurring series.              | [optional] 
**Frequency** | **string** | Enumerates mapi calendar recurrence frequency Enum, available values: None, Daily, Weekly, Monthly, Yearly | 
**ModifiedInstanceDates** | **List&lt;DateTime?&gt;** | An array of dates, each of which is the date of a modified instance.              | [optional] 
**OccurrenceCount** | **long?** | Number of occurrences in a recurrence.              | 
**PatternType** | **string** | Enumerates the mapi calendar recurrence pattern types Enum, available values: Day, Week, Month, MonthEnd, MonthNth, HjMonth, HjMonthNth, HjMonthEnd | 
**Period** | **long?** | Interval at which the meeting pattern repeats.              | 
**SlidingFlag** | **bool?** | Defines whether pattern is sliding or not.              | 
**StartDate** | **DateTime?** | Start date of an item recurrence pattern.              | 
**WeekStartDay** | **string** | Enum, available values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday | 
**Discriminator** | **string** |  | 



[[Back to Model list]](README.md#documentation-for-models) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to README]](README.md)


