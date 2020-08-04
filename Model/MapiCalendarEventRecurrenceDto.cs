
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarEventRecurrenceDto.cs">
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
    /// Recurrence properties of calendar object.             
    /// </summary>
    public class MapiCalendarEventRecurrenceDto 
    {
        /// <summary>
        /// Time zone information that describes how to convert the meeting date and time on a recurring series to and from UTC.             
        /// </summary>
        public MapiCalendarTimeZoneDto AppointmentTimeZoneDefinitionRecur { get; set; }

        /// <summary>
        /// Date of the last instance.             
        /// </summary>
        public DateTime? ClipEnd { get; set; }

        /// <summary>
        /// Date of the first instance.             
        /// </summary>
        public DateTime? ClipStart { get; set; }

        /// <summary>
        /// Value indicating whether the object represents an exception.             
        /// </summary>
        public bool? IsException { get; set; }

        /// <summary>
        /// Recurrence pattern.             
        /// </summary>
        public MapiCalendarRecurrencePatternDto RecurrencePattern { get; set; }

        /// <summary>
        /// Time zone information for a recurring meeting.             
        /// </summary>
        public MapiCalendarTimeZoneDto TimeZoneStruct { get; set; }


        /// <summary>MapiCalendarEventRecurrenceDto constructor</summary>
        public MapiCalendarEventRecurrenceDto() {}


        /// <summary>MapiCalendarEventRecurrenceDto constructor</summary>
        /// <param name="appointmentTimeZoneDefinitionRecur">Time zone information that describes how to convert the meeting date and time on a recurring series to and from UTC.             </param>
        /// <param name="clipEnd">Date of the last instance.             </param>
        /// <param name="clipStart">Date of the first instance.             </param>
        /// <param name="isException">Value indicating whether the object represents an exception.             </param>
        /// <param name="recurrencePattern">Recurrence pattern.             </param>
        /// <param name="timeZoneStruct">Time zone information for a recurring meeting.             </param>
        public MapiCalendarEventRecurrenceDto(
            MapiCalendarTimeZoneDto appointmentTimeZoneDefinitionRecur,
            DateTime? clipEnd,
            DateTime? clipStart,
            bool? isException,
            MapiCalendarRecurrencePatternDto recurrencePattern,
            MapiCalendarTimeZoneDto timeZoneStruct
        )
        { 
            AppointmentTimeZoneDefinitionRecur = appointmentTimeZoneDefinitionRecur;
            ClipEnd = clipEnd;
            ClipStart = clipStart;
            IsException = isException;
            RecurrencePattern = recurrencePattern;
            TimeZoneStruct = timeZoneStruct;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarEventRecurrenceDto {\n");
          sb.Append("  AppointmentTimeZoneDefinitionRecur: ").Append(this.AppointmentTimeZoneDefinitionRecur).Append("\n");
          sb.Append("  ClipEnd: ").Append(this.ClipEnd).Append("\n");
          sb.Append("  ClipStart: ").Append(this.ClipStart).Append("\n");
          sb.Append("  IsException: ").Append(this.IsException).Append("\n");
          sb.Append("  RecurrencePattern: ").Append(this.RecurrencePattern).Append("\n");
          sb.Append("  TimeZoneStruct: ").Append(this.TimeZoneStruct).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
