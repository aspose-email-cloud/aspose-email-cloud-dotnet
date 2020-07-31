// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarExceptionInfoDto.cs">
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
    /// An exception specifies changes to an instance of a recurring series.             
    /// </summary>
    public class MapiCalendarExceptionInfoDto 
    {
        /// <summary>
        /// Attachments in the recurrence exception.             
        /// </summary>
        public List<MapiAttachmentDto> Attachments { get; set; }

        /// <summary>
        /// Body.             
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Enumerates the mapi calendar possible busy status Enum, available values: Free, Tentative, Busy, OutOfOffice
        /// </summary>
        public string BusyStatus { get; set; }

        /// <summary>
        /// End date.             
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Value of this field specifies whether the Exception Embedded Message object contains attachments.             
        /// </summary>
        public bool? HasAttachment { get; set; }

        /// <summary>
        /// Location.             
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Enumerates the appointment state Enum, available values: Meeting, Received, Canceled
        /// </summary>
        public string MeetingType { get; set; }

        /// <summary>
        /// Original start date.             
        /// </summary>
        public DateTime? OriginalStartDate { get; set; }

        /// <summary>
        /// Override flags.              Items: Specifies what data in the MapiCalendarOverride structure has a value different from the recurring series. Enum, available values: Subject, MeetingType, ReminderDelta, Reminder, Location, BusyStatus, Attachment, Subtype, AppointmentColor, ExceptionalBody
        /// </summary>
        public List<string> OverrideFlags { get; set; }

        /// <summary>
        /// Reminder delta.             
        /// </summary>
        public int? ReminderDelta { get; set; }

        /// <summary>
        /// Value for the PidLidReminderSet property.             
        /// </summary>
        public bool? ReminderSet { get; set; }

        /// <summary>
        /// Start date.             
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Subject.             
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// SubType.             
        /// </summary>
        public int? SubType { get; set; }


        /// <summary>MapiCalendarExceptionInfoDto constructor</summary>
        public MapiCalendarExceptionInfoDto() {}


        /// <summary>MapiCalendarExceptionInfoDto constructor</summary>
        /// <param name="attachments">Attachments in the recurrence exception.             </param>
        /// <param name="body">Body.             </param>
        /// <param name="busyStatus">Enumerates the mapi calendar possible busy status Enum, available values: Free, Tentative, Busy, OutOfOffice</param>
        /// <param name="endDateTime">End date.             </param>
        /// <param name="hasAttachment">Value of this field specifies whether the Exception Embedded Message object contains attachments.             </param>
        /// <param name="location">Location.             </param>
        /// <param name="meetingType">Enumerates the appointment state Enum, available values: Meeting, Received, Canceled</param>
        /// <param name="originalStartDate">Original start date.             </param>
        /// <param name="overrideFlags">Override flags.             </param>
        /// <param name="reminderDelta">Reminder delta.             </param>
        /// <param name="reminderSet">Value for the PidLidReminderSet property.             </param>
        /// <param name="startDateTime">Start date.             </param>
        /// <param name="subject">Subject.             </param>
        /// <param name="subType">SubType.             </param>
        public MapiCalendarExceptionInfoDto(
            List<MapiAttachmentDto> attachments,
            string body,
            string busyStatus,
            DateTime? endDateTime,
            bool? hasAttachment,
            string location,
            string meetingType,
            DateTime? originalStartDate,
            List<string> overrideFlags,
            int? reminderDelta,
            bool? reminderSet,
            DateTime? startDateTime,
            string subject,
            int? subType
        )
        { 
            Attachments = attachments;
            Body = body;
            BusyStatus = busyStatus;
            EndDateTime = endDateTime;
            HasAttachment = hasAttachment;
            Location = location;
            MeetingType = meetingType;
            OriginalStartDate = originalStartDate;
            OverrideFlags = overrideFlags;
            ReminderDelta = reminderDelta;
            ReminderSet = reminderSet;
            StartDateTime = startDateTime;
            Subject = subject;
            SubType = subType;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarExceptionInfoDto {\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  Body: ").Append(this.Body).Append("\n");
          sb.Append("  BusyStatus: ").Append(this.BusyStatus).Append("\n");
          sb.Append("  EndDateTime: ").Append(this.EndDateTime).Append("\n");
          sb.Append("  HasAttachment: ").Append(this.HasAttachment).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  MeetingType: ").Append(this.MeetingType).Append("\n");
          sb.Append("  OriginalStartDate: ").Append(this.OriginalStartDate).Append("\n");
          sb.Append("  OverrideFlags: ").Append(this.OverrideFlags).Append("\n");
          sb.Append("  ReminderDelta: ").Append(this.ReminderDelta).Append("\n");
          sb.Append("  ReminderSet: ").Append(this.ReminderSet).Append("\n");
          sb.Append("  StartDateTime: ").Append(this.StartDateTime).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  SubType: ").Append(this.SubType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
