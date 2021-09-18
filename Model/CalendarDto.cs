// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarDto.cs">
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
    /// iCalendar document representation.             
    /// </summary>
    public class CalendarDto 
    {
        /// <summary>
        /// Document attachments.
        /// </summary>
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Event attendees.
        /// </summary>
        public List<MailAddress> Attendees { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// End date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// End time zone.
        /// </summary>
        public string EndTimeZone { get; set; }

        /// <summary>
        /// Appointment flags. Items: Enumerates iCalendar flags./nEnum, available values: None, AllDayEvent
        /// </summary>
        public List<string> Flags { get; set; }

        /// <summary>
        /// Indicates if description is in HTML format.
        /// </summary>
        public bool? IsDescriptionHtml { get; set; }

        /// <summary>
        /// Location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Defines the iCalendar object method type associated with the calendar document./nEnum, available values: None, Publish, Request, Reply, Add, Cancel, Refresh, Counter, DeclineCounter
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Specifies the BUSY status./nEnum, available values: NotDefined, Free, Tentative, Busy, Oof
        /// </summary>
        public string MicrosoftBusyStatus { get; set; }

        /// <summary>
        /// Specifies the INTENDED status./nEnum, available values: NotDefined, Free, Tentative, Busy, Oof
        /// </summary>
        public string MicrosoftIntendedStatus { get; set; }

        /// <summary>
        /// Optional attendees.             
        /// </summary>
        public List<MailAddress> OptionalAttendees { get; set; }

        /// <summary>
        /// Event organizer.             
        /// </summary>
        public MailAddress Organizer { get; set; }

        /// <summary>
        /// Deprecated, use 'Recurrence' property. String representation of recurrence pattern (See iCalendar RFC, \"Recurrence rule\" section). For example:               For daily recurrence:         \"FREQ=DAILY;COUNT=10;WKST=MO\"                   For monthly recurrence:         \"BYSETPOS=1;BYDAY=MO,TU,WE,TH,FR;FREQ=MONTHLY;INTERVAL=10;WKST=MO\"                   For yearly recurrence:         \"BYMONTHDAY=30;BYMONTH=1;FREQ=YEARLY;WKST=MO\"                   
        /// </summary>
        public string RecurrenceString { get; set; }

        /// <summary>
        /// Recurrence pattern             
        /// </summary>
        public RecurrencePatternDto Recurrence { get; set; }

        /// <summary>
        /// Reminders.
        /// </summary>
        public List<CalendarReminder> Reminders { get; set; }

        /// <summary>
        /// The sequence id. Read only.
        /// </summary>
        public string SequenceId { get; set; }

        /// <summary>
        /// Start date.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Start time zone.
        /// </summary>
        public string StartTimeZone { get; set; }

        /// <summary>
        /// Defines the overall status or confirmation for the calendar document./nEnum, available values: NotDefined, Cancelled, Tentative, Confirmed
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Summary.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Specifies whether or not this appointment is intended to be visible in availability searches./nEnum, available values: NotDefined, Transparent, Opaque
        /// </summary>
        public string Transparency { get; set; }

        /// <summary>
        /// Defines the access classification for the calendar./nEnum, available values: Public, Private, Confidential, NotDefined
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Specifies the importance of a calendar object./nEnum, available values: Low, Normal, High, NotDefined
        /// </summary>
        public string MicrosoftImportance { get; set; }


        /// <summary>CalendarDto constructor</summary>
        public CalendarDto() {}


        /// <summary>CalendarDto constructor</summary>
        /// <param name="attachments">Document attachments.</param>
        /// <param name="attendees">Event attendees.</param>
        /// <param name="description">Description.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="endTimeZone">End time zone.</param>
        /// <param name="flags">Appointment flags.</param>
        /// <param name="isDescriptionHtml">Indicates if description is in HTML format.</param>
        /// <param name="location">Location.</param>
        /// <param name="method">Defines the iCalendar object method type associated with the calendar document./nEnum, available values: None, Publish, Request, Reply, Add, Cancel, Refresh, Counter, DeclineCounter</param>
        /// <param name="microsoftBusyStatus">Specifies the BUSY status./nEnum, available values: NotDefined, Free, Tentative, Busy, Oof</param>
        /// <param name="microsoftIntendedStatus">Specifies the INTENDED status./nEnum, available values: NotDefined, Free, Tentative, Busy, Oof</param>
        /// <param name="optionalAttendees">Optional attendees.             </param>
        /// <param name="organizer">Event organizer.             </param>
        /// <param name="recurrenceString">Deprecated, use 'Recurrence' property. String representation of recurrence pattern (See iCalendar RFC, \"Recurrence rule\" section). For example:               For daily recurrence:         \"FREQ=DAILY;COUNT=10;WKST=MO\"                   For monthly recurrence:         \"BYSETPOS=1;BYDAY=MO,TU,WE,TH,FR;FREQ=MONTHLY;INTERVAL=10;WKST=MO\"                   For yearly recurrence:         \"BYMONTHDAY=30;BYMONTH=1;FREQ=YEARLY;WKST=MO\"                   </param>
        /// <param name="recurrence">Recurrence pattern             </param>
        /// <param name="reminders">Reminders.</param>
        /// <param name="sequenceId">The sequence id. Read only.</param>
        /// <param name="startDate">Start date.</param>
        /// <param name="startTimeZone">Start time zone.</param>
        /// <param name="status">Defines the overall status or confirmation for the calendar document./nEnum, available values: NotDefined, Cancelled, Tentative, Confirmed</param>
        /// <param name="summary">Summary.</param>
        /// <param name="transparency">Specifies whether or not this appointment is intended to be visible in availability searches./nEnum, available values: NotDefined, Transparent, Opaque</param>
        /// <param name="_class">Defines the access classification for the calendar./nEnum, available values: Public, Private, Confidential, NotDefined</param>
        /// <param name="microsoftImportance">Specifies the importance of a calendar object./nEnum, available values: Low, Normal, High, NotDefined</param>
        public CalendarDto(
            List<Attachment> attachments,
            List<MailAddress> attendees,
            string description,
            DateTime? endDate,
            string endTimeZone,
            List<string> flags,
            bool? isDescriptionHtml,
            string location,
            string method,
            string microsoftBusyStatus,
            string microsoftIntendedStatus,
            List<MailAddress> optionalAttendees,
            MailAddress organizer,
            string recurrenceString,
            RecurrencePatternDto recurrence,
            List<CalendarReminder> reminders,
            string sequenceId,
            DateTime? startDate,
            string startTimeZone,
            string status,
            string summary,
            string transparency,
            string _class,
            string microsoftImportance
        )
        { 
            Attachments = attachments;
            Attendees = attendees;
            Description = description;
            EndDate = endDate;
            EndTimeZone = endTimeZone;
            Flags = flags;
            IsDescriptionHtml = isDescriptionHtml;
            Location = location;
            Method = method;
            MicrosoftBusyStatus = microsoftBusyStatus;
            MicrosoftIntendedStatus = microsoftIntendedStatus;
            OptionalAttendees = optionalAttendees;
            Organizer = organizer;
            RecurrenceString = recurrenceString;
            Recurrence = recurrence;
            Reminders = reminders;
            SequenceId = sequenceId;
            StartDate = startDate;
            StartTimeZone = startTimeZone;
            Status = status;
            Summary = summary;
            Transparency = transparency;
            Class = _class;
            MicrosoftImportance = microsoftImportance;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CalendarDto {\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  Attendees: ").Append(this.Attendees).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
          sb.Append("  EndTimeZone: ").Append(this.EndTimeZone).Append("\n");
          sb.Append("  Flags: ").Append(this.Flags).Append("\n");
          sb.Append("  IsDescriptionHtml: ").Append(this.IsDescriptionHtml).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  Method: ").Append(this.Method).Append("\n");
          sb.Append("  MicrosoftBusyStatus: ").Append(this.MicrosoftBusyStatus).Append("\n");
          sb.Append("  MicrosoftIntendedStatus: ").Append(this.MicrosoftIntendedStatus).Append("\n");
          sb.Append("  OptionalAttendees: ").Append(this.OptionalAttendees).Append("\n");
          sb.Append("  Organizer: ").Append(this.Organizer).Append("\n");
          sb.Append("  RecurrenceString: ").Append(this.RecurrenceString).Append("\n");
          sb.Append("  Recurrence: ").Append(this.Recurrence).Append("\n");
          sb.Append("  Reminders: ").Append(this.Reminders).Append("\n");
          sb.Append("  SequenceId: ").Append(this.SequenceId).Append("\n");
          sb.Append("  StartDate: ").Append(this.StartDate).Append("\n");
          sb.Append("  StartTimeZone: ").Append(this.StartTimeZone).Append("\n");
          sb.Append("  Status: ").Append(this.Status).Append("\n");
          sb.Append("  Summary: ").Append(this.Summary).Append("\n");
          sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
          sb.Append("  Class: ").Append(this.Class).Append("\n");
          sb.Append("  MicrosoftImportance: ").Append(this.MicrosoftImportance).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
