// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MonthlyRecurrencePatternDto.cs">
//   Copyright (c) 2016-2023 Aspose.Email for Cloud
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

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantUsingDirective
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
namespace Aspose.Email.Cloud.Sdk.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    /// <summary>
    /// Monthly recurrence pattern.             
    /// </summary>
    public class MonthlyRecurrencePatternDto : RecurrencePatternDto 
    {
        /// <summary>
        /// Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay
        /// </summary>
        public string StartDay { get; set; }

        /// <summary>
        /// Start offset.             
        /// </summary>
        public int? StartOffset { get; set; }

        /// <summary>
        /// Day positions, typically found in a month. Enum, available values: None, First, Second, Third, Fourth, Last
        /// </summary>
        public string StartPosition { get; set; }


        /// <summary>MonthlyRecurrencePatternDto constructor</summary>
        public MonthlyRecurrencePatternDto() {}


        /// <summary>MonthlyRecurrencePatternDto constructor</summary>
        /// <param name="interval">Number of recurrence units.             </param>
        /// <param name="occurs">Number of occurrences of the recurrence pattern.             </param>
        /// <param name="endDate">End date.             </param>
        /// <param name="weekStart">Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay</param>
        /// <param name="startDay">Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay</param>
        /// <param name="startOffset">Start offset.             </param>
        /// <param name="startPosition">Day positions, typically found in a month. Enum, available values: None, First, Second, Third, Fourth, Last</param>
        public MonthlyRecurrencePatternDto(
            int? interval,
            int? occurs,
            DateTime? endDate,
            string weekStart
            ,
            string startDay,
            int? startOffset,
            string startPosition
        )
        { 
            Interval = interval;
            Occurs = occurs;
            EndDate = endDate;
            WeekStart = weekStart;
            StartDay = startDay;
            StartOffset = startOffset;
            StartPosition = startPosition;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MonthlyRecurrencePatternDto {\n");
          sb.Append("  Interval: ").Append(this.Interval).Append("\n");
          sb.Append("  Occurs: ").Append(this.Occurs).Append("\n");
          sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
          sb.Append("  WeekStart: ").Append(this.WeekStart).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  StartDay: ").Append(this.StartDay).Append("\n");
          sb.Append("  StartOffset: ").Append(this.StartOffset).Append("\n");
          sb.Append("  StartPosition: ").Append(this.StartPosition).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
