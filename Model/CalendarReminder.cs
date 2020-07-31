// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarReminder.cs">
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
    /// Provides a grouping of component properties that define an alarm.             
    /// </summary>
    public class CalendarReminder 
    {
        /// <summary>
        /// Defines the action to be invoked when an alarm is triggered. Enum, available values: Audio, Display, Email, Procedure, None
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Collection of Reminder Attachments. Could be an absolute URI or Base64 string representation of attachment content             
        /// </summary>
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Contains collection of ReminderAttendee objects.             
        /// </summary>
        public List<ReminderAttendee> Attendees { get; set; }

        /// <summary>
        /// Provides a more complete description of the alarm.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Specifies the delay period in ticks, after which the alarm will repeat.             
        /// </summary>
        public long? Duration { get; set; }

        /// <summary>
        /// Defines the number of time the alarm should be repeated, after the initial trigger.             
        /// </summary>
        public int? Repeat { get; set; }

        /// <summary>
        /// Defines a short summary or subject for the alarm.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Specifies when an alarm will trigger.
        /// </summary>
        public ReminderTrigger Trigger { get; set; }


        /// <summary>CalendarReminder constructor</summary>
        public CalendarReminder() {}


        /// <summary>CalendarReminder constructor</summary>
        /// <param name="action">Defines the action to be invoked when an alarm is triggered. Enum, available values: Audio, Display, Email, Procedure, None</param>
        /// <param name="attachments">Collection of Reminder Attachments. Could be an absolute URI or Base64 string representation of attachment content             </param>
        /// <param name="attendees">Contains collection of ReminderAttendee objects.             </param>
        /// <param name="description">Provides a more complete description of the alarm.</param>
        /// <param name="duration">Specifies the delay period in ticks, after which the alarm will repeat.             </param>
        /// <param name="repeat">Defines the number of time the alarm should be repeated, after the initial trigger.             </param>
        /// <param name="summary">Defines a short summary or subject for the alarm.</param>
        /// <param name="trigger">Specifies when an alarm will trigger.</param>
        public CalendarReminder(
            string action,
            List<string> attachments,
            List<ReminderAttendee> attendees,
            string description,
            long? duration,
            int? repeat,
            string summary,
            ReminderTrigger trigger
        )
        { 
            Action = action;
            Attachments = attachments;
            Attendees = attendees;
            Description = description;
            Duration = duration;
            Repeat = repeat;
            Summary = summary;
            Trigger = trigger;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CalendarReminder {\n");
          sb.Append("  Action: ").Append(this.Action).Append("\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  Attendees: ").Append(this.Attendees).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  Duration: ").Append(this.Duration).Append("\n");
          sb.Append("  Repeat: ").Append(this.Repeat).Append("\n");
          sb.Append("  Summary: ").Append(this.Summary).Append("\n");
          sb.Append("  Trigger: ").Append(this.Trigger).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
