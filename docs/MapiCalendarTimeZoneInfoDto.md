# Model.MapiCalendarTimeZoneInfoDto
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bias** | **int?** | Time zone&#39;s offset in minutes from UTC.              | 
**DaylightBias** | **int?** | Offset in minutes from lBias during daylight saving time.              | 
**DaylightDate** | [**MapiCalendarTimeZoneRuleDto**](MapiCalendarTimeZoneRuleDto.md) | Date and local time that indicate when to begin using the DaylightBias.              | [optional] 
**StandardBias** | **int?** | Offset in minutes from lBias during standard time.              | 
**StandardDate** | [**MapiCalendarTimeZoneRuleDto**](MapiCalendarTimeZoneRuleDto.md) | Date and local time that indicate when to begin using the StandardBias.              | [optional] 
**TimeZoneFlags** | **List&lt;string&gt;** | Individual bit flags that specify information about this TimeZoneRule.              Items: Enumerates the individual bit flags that specify information about TimeZoneRule Enum, available values: TzRuleFlagRecurCurrentTzReg, TzRuleFlagEffectiveTzReg | [optional] 
**Year** | **int?** | Year in which this rule is scheduled to take effect.              | 



[[Back to Model list]](Models.doc) [[Back to README]](README.md)


