// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RecurrencePatternDto.cs">
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
    /// iCalendar recurrence pattern.             
    /// </summary>
    public class RecurrencePatternDto 
    {
        /// <summary>
        /// Number of recurrence units.             
        /// </summary>  
        public int? Interval { get; set; }

        /// <summary>
        /// Number of occurrences of the recurrence pattern.             
        /// </summary>  
        public int? Occurs { get; set; }

        /// <summary>
        /// End date.             
        /// </summary>  
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay
        /// </summary>  
        public string WeekStart { get; set; }

        /// <summary>
        /// Gets or sets Discriminator
        /// </summary>  
        
        public string Discriminator
        {
            get { return GetType().Name; }
            set { /*do nothing*/}
        }

        /// <summary>RecurrencePatternDto constructor</summary>
        public RecurrencePatternDto() {}

        /// <summary>RecurrencePatternDto constructor</summary>
        /// <param name="interval">Number of recurrence units.             </param>
        /// <param name="occurs">Number of occurrences of the recurrence pattern.             </param>
        /// <param name="endDate">End date.             </param>
        /// <param name="weekStart">Represents the day of the week. Enum, available values: None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Day, WeekDay, WeekendDay</param>
        /// <param name="discriminator"></param>
        public RecurrencePatternDto(int? interval, int? occurs, DateTime? endDate, string weekStart, string discriminator)
        {
            Interval = interval;
            Occurs = occurs;
            EndDate = endDate;
            WeekStart = weekStart;
            Discriminator = discriminator;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RecurrencePatternDto {\n");
          sb.Append("  Interval: ").Append(this.Interval).Append("\n");
          sb.Append("  Occurs: ").Append(this.Occurs).Append("\n");
          sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
          sb.Append("  WeekStart: ").Append(this.WeekStart).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
