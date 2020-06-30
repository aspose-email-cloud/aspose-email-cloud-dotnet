// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarWeeklyRecurrencePatternDto.cs">
//   Copyright (c) 2016-2020 Aspose.Email for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Email.Cloud.Sdk.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    /// <summary>
    /// Represents the weekly recurrence pattern of the mapi calendar             
    /// </summary>
    public class MapiCalendarWeeklyRecurrencePatternDto : MapiCalendarRecurrencePatternDto 
    {
        /// <summary>
        /// Days of week at which the event occurs.              Items: Enumerates the days of week of the mapi calendar recurrence pattern Enum, available values: Saturday, Friday, Thursday, Wednesday, Tuesday, Monday, Sunday
        /// </summary>  
        public List<string> DayOfWeek { get; set; }

        /// <summary>MapiCalendarWeeklyRecurrencePatternDto constructor</summary>
        public MapiCalendarWeeklyRecurrencePatternDto() {}

        /// <summary>MapiCalendarWeeklyRecurrencePatternDto constructor</summary>
        /// <param name="calendarType">Enumerated the calendar type of the mapi recurrence Enum, available values: Default, CalGregorian, CalGregorianUs, CalJapan, CalTaiwan, CalKorea, CalHijri, CalThai, CalHebrew, CalGregorianMeFrench, CalGregorianArabic, CalGregorianXLitEnglish, CalGregorianXLitFrench, CalLunarJapanese, CalChineseLunar, CalSaka, CalLunarEtoChn, CalLunarEtoKor, CalLunarRokuyou, CalLunarKorean, CalUmAlQura</param>
        /// <param name="deletedInstanceDates">An array of dates, each of which is the original instance date of either a deleted instance or a modified instance for this recurrence.             </param>
        /// <param name="endDate">End date of an item recurrence pattern.             </param>
        /// <param name="endType">Enumerates the ending type for the recurrence. Enum, available values: None, EndAfterDate, EndAfterNOccurrences, NeverEnd</param>
        /// <param name="exceptions">An exception specifies changes to an instance of a recurring series.             </param>
        /// <param name="frequency">Enumerates mapi calendar recurrence frequency Enum, available values: None, Daily, Weekly, Monthly, Yearly</param>
        /// <param name="modifiedInstanceDates">An array of dates, each of which is the date of a modified instance.             </param>
        /// <param name="occurrenceCount">Number of occurrences in a recurrence.             </param>
        /// <param name="patternType">Enumerates the mapi calendar recurrence pattern types Enum, available values: Day, Week, Month, MonthEnd, MonthNth, HjMonth, HjMonthNth, HjMonthEnd</param>
        /// <param name="period">Interval at which the meeting pattern repeats.             </param>
        /// <param name="slidingFlag">Defines whether pattern is sliding or not.             </param>
        /// <param name="startDate">Start date of an item recurrence pattern.             </param>
        /// <param name="weekStartDay">Enum, available values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday</param>
        /// <param name="discriminator"></param>
        /// <param name="dayOfWeek">Days of week at which the event occurs.             </param>
        public MapiCalendarWeeklyRecurrencePatternDto(string calendarType, List<DateTime?> deletedInstanceDates, DateTime? endDate, string endType, List<MapiCalendarExceptionInfoDto> exceptions, string frequency, List<DateTime?> modifiedInstanceDates, long? occurrenceCount, string patternType, long? period, bool? slidingFlag, DateTime? startDate, string weekStartDay, string discriminator, List<string> dayOfWeek)
        {
            CalendarType = calendarType;
            DeletedInstanceDates = deletedInstanceDates;
            EndDate = endDate;
            EndType = endType;
            Exceptions = exceptions;
            Frequency = frequency;
            ModifiedInstanceDates = modifiedInstanceDates;
            OccurrenceCount = occurrenceCount;
            PatternType = patternType;
            Period = period;
            SlidingFlag = slidingFlag;
            StartDate = startDate;
            WeekStartDay = weekStartDay;
            Discriminator = discriminator;
            DayOfWeek = dayOfWeek;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarWeeklyRecurrencePatternDto {\n");
          sb.Append("  CalendarType: ").Append(this.CalendarType).Append("\n");
          sb.Append("  DeletedInstanceDates: ").Append(this.DeletedInstanceDates).Append("\n");
          sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
          sb.Append("  EndType: ").Append(this.EndType).Append("\n");
          sb.Append("  Exceptions: ").Append(this.Exceptions).Append("\n");
          sb.Append("  Frequency: ").Append(this.Frequency).Append("\n");
          sb.Append("  ModifiedInstanceDates: ").Append(this.ModifiedInstanceDates).Append("\n");
          sb.Append("  OccurrenceCount: ").Append(this.OccurrenceCount).Append("\n");
          sb.Append("  PatternType: ").Append(this.PatternType).Append("\n");
          sb.Append("  Period: ").Append(this.Period).Append("\n");
          sb.Append("  SlidingFlag: ").Append(this.SlidingFlag).Append("\n");
          sb.Append("  StartDate: ").Append(this.StartDate).Append("\n");
          sb.Append("  WeekStartDay: ").Append(this.WeekStartDay).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  DayOfWeek: ").Append(this.DayOfWeek).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
