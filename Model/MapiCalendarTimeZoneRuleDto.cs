// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarTimeZoneRuleDto.cs">
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
    /// Represents time zone rule that indicate when to begin using the Standard/Daylight time.             
    /// </summary>
    public class MapiCalendarTimeZoneRuleDto 
    {
        /// <summary>
        /// Date and time that indicate when to begin using the Standard/Daylight time.             
        /// </summary>  
        public DateTime? Date { get; set; }

        /// <summary>
        /// Day of week. Enum, available values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>  
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Hour.             
        /// </summary>  
        public int? Hour { get; set; }

        /// <summary>
        /// Milliseconds.             
        /// </summary>  
        public int? Milliseconds { get; set; }

        /// <summary>
        /// Minute.             
        /// </summary>  
        public int? Minute { get; set; }

        /// <summary>
        /// Month.             
        /// </summary>  
        public int? Month { get; set; }

        /// <summary>
        /// Day positions, typically found in a month. Enum, available values: None, First, Second, Third, Fourth, Last
        /// </summary>  
        public string Position { get; set; }

        /// <summary>
        /// Seconds.             
        /// </summary>  
        public int? Seconds { get; set; }

        /// <summary>
        /// Year.             
        /// </summary>  
        public int? Year { get; set; }

        /// <summary>MapiCalendarTimeZoneRuleDto constructor</summary>
        public MapiCalendarTimeZoneRuleDto() {}

        /// <summary>MapiCalendarTimeZoneRuleDto constructor</summary>
        /// <param name="date">Date and time that indicate when to begin using the Standard/Daylight time.             </param>
        /// <param name="dayOfWeek">Day of week. Enum, available values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday</param>
        /// <param name="hour">Hour.             </param>
        /// <param name="milliseconds">Milliseconds.             </param>
        /// <param name="minute">Minute.             </param>
        /// <param name="month">Month.             </param>
        /// <param name="position">Day positions, typically found in a month. Enum, available values: None, First, Second, Third, Fourth, Last</param>
        /// <param name="seconds">Seconds.             </param>
        /// <param name="year">Year.             </param>
        public MapiCalendarTimeZoneRuleDto(DateTime? date, string dayOfWeek, int? hour, int? milliseconds, int? minute, int? month, string position, int? seconds, int? year)
        {
            Date = date;
            DayOfWeek = dayOfWeek;
            Hour = hour;
            Milliseconds = milliseconds;
            Minute = minute;
            Month = month;
            Position = position;
            Seconds = seconds;
            Year = year;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarTimeZoneRuleDto {\n");
          sb.Append("  Date: ").Append(this.Date).Append("\n");
          sb.Append("  DayOfWeek: ").Append(this.DayOfWeek).Append("\n");
          sb.Append("  Hour: ").Append(this.Hour).Append("\n");
          sb.Append("  Milliseconds: ").Append(this.Milliseconds).Append("\n");
          sb.Append("  Minute: ").Append(this.Minute).Append("\n");
          sb.Append("  Month: ").Append(this.Month).Append("\n");
          sb.Append("  Position: ").Append(this.Position).Append("\n");
          sb.Append("  Seconds: ").Append(this.Seconds).Append("\n");
          sb.Append("  Year: ").Append(this.Year).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
