// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarDto.cs">
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
    /// Represents the mapi calendar object             
    /// </summary>
    public class MapiCalendarDto : MapiMessageItemBaseDto 
    {
        /// <summary>
        /// Value indicating whether a Meeting Response object is a counter proposal.             
        /// </summary>  
        public bool? AppointmentCounterProposal { get; set; }

        /// <summary>
        /// Attendees             
        /// </summary>  
        public MapiCalendarAttendeesDto Attendees { get; set; }

        /// <summary>
        /// Enumerates the mapi calendar possible busy status Enum, available values: Free, Tentative, Busy, OutOfOffice
        /// </summary>  
        public string BusyStatus { get; set; }

        /// <summary>
        /// Actions the user has taken on this Meeting object.              Items: Enumerates the actions the user can taken on the Meeting object Enum, available values: Manager, Delegate, DeletedWithNoResponse, DeletedExceptionWithNoResponse, RespondedTentative, RespondedAccept, RespondedDecline, ModifiedStartTime, ModifiedEndTime, ModifiedLocation, RespondedExceptionDecline, Canceled, ExceptionCanceled
        /// </summary>  
        public List<string> ClientIntent { get; set; }

        /// <summary>
        /// End date and time of the event. If the date is not set, default value for DateTime is returned.             
        /// </summary>  
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Time zone information that indicates the time zone of the EndDate property.             
        /// </summary>  
        public MapiCalendarTimeZoneDto EndDateTimeZone { get; set; }

        /// <summary>
        /// Value indicating whether the event is an all-day event.             
        /// </summary>  
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// Categories of the calendar object.             
        /// </summary>  
        public string KeyWords { get; set; }

        /// <summary>
        /// Location of the event.             
        /// </summary>  
        public string Location { get; set; }

        /// <summary>
        /// Recurrence properties.             
        /// </summary>  
        public MapiCalendarEventRecurrenceDto Recurrence { get; set; }

        /// <summary>
        /// Interval, in minutes, between the time at which the reminder first becomes overdue and the start time of the Calendar object.             
        /// </summary>  
        public int? ReminderDelta { get; set; }

        /// <summary>
        /// Full path of the sound that a client SHOULD play when the reminder becomes overdue.             
        /// </summary>  
        public string ReminderFileParameter { get; set; }

        /// <summary>
        /// Value indicating whether a reminder is set on the object.             
        /// </summary>  
        public bool? ReminderSet { get; set; }

        /// <summary>
        /// Sequence number.             
        /// </summary>  
        public int? Sequence { get; set; }

        /// <summary>
        /// Start date and time of the event. If the date is not set, default value for DateTime is returned.             
        /// </summary>  
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Time zone information that indicates the time zone of the StartDate property.             
        /// </summary>  
        public MapiCalendarTimeZoneDto StartDateTimeZone { get; set; }

        /// <summary>
        /// Unique identifier.             
        /// </summary>  
        public string Uid { get; set; }

        /// <summary>
        /// Organizer             
        /// </summary>  
        public MapiElectronicAddressDto Organizer { get; set; }

        /// <summary>MapiCalendarDto constructor</summary>
        public MapiCalendarDto() {}

        /// <summary>MapiCalendarDto constructor</summary>
        /// <param name="attachments">Message item attachments.             </param>
        /// <param name="billing">Billing information associated with an item.             </param>
        /// <param name="body">Message text.             </param>
        /// <param name="bodyHtml">Gets the BodyRtf of the message converted to HTML, if present, otherwise an empty string.             </param>
        /// <param name="bodyRtf">RTF formatted message text.             </param>
        /// <param name="bodyType">The content type of message body. Enum, available values: PlainText, Html, Rtf</param>
        /// <param name="categories">Contains keywords or categories for the message object.             </param>
        /// <param name="companies">Contains the names of the companies that are associated with an item.             </param>
        /// <param name="itemId">The item id, uses with a server.             </param>
        /// <param name="messageClass">Case-sensitive string that identifies the sender-defined message class, such as IPM.Note. The message class specifies the type, purpose, or content of the message.             </param>
        /// <param name="mileage">Contains the mileage information that is associated with an item.             </param>
        /// <param name="recipients">Recipients of the message.             </param>
        /// <param name="sensitivity">Contains values that indicate the message sensitivity. Enum, available values: None, Personal, Private, CompanyConfidential</param>
        /// <param name="subject">Subject of the message.             </param>
        /// <param name="subjectPrefix">Subject prefix that typically indicates some action on a message, such as \"FW: \" for forwarding.             </param>
        /// <param name="properties">List of MAPI properties             </param>
        /// <param name="discriminator"></param>
        /// <param name="appointmentCounterProposal">Value indicating whether a Meeting Response object is a counter proposal.             </param>
        /// <param name="attendees">Attendees             </param>
        /// <param name="busyStatus">Enumerates the mapi calendar possible busy status Enum, available values: Free, Tentative, Busy, OutOfOffice</param>
        /// <param name="clientIntent">Actions the user has taken on this Meeting object.             </param>
        /// <param name="endDate">End date and time of the event. If the date is not set, default value for DateTime is returned.             </param>
        /// <param name="endDateTimeZone">Time zone information that indicates the time zone of the EndDate property.             </param>
        /// <param name="isAllDay">Value indicating whether the event is an all-day event.             </param>
        /// <param name="keyWords">Categories of the calendar object.             </param>
        /// <param name="location">Location of the event.             </param>
        /// <param name="recurrence">Recurrence properties.             </param>
        /// <param name="reminderDelta">Interval, in minutes, between the time at which the reminder first becomes overdue and the start time of the Calendar object.             </param>
        /// <param name="reminderFileParameter">Full path of the sound that a client SHOULD play when the reminder becomes overdue.             </param>
        /// <param name="reminderSet">Value indicating whether a reminder is set on the object.             </param>
        /// <param name="sequence">Sequence number.             </param>
        /// <param name="startDate">Start date and time of the event. If the date is not set, default value for DateTime is returned.             </param>
        /// <param name="startDateTimeZone">Time zone information that indicates the time zone of the StartDate property.             </param>
        /// <param name="uid">Unique identifier.             </param>
        /// <param name="organizer">Organizer             </param>
        public MapiCalendarDto(List<MapiAttachmentDto> attachments, string billing, string body, string bodyHtml, string bodyRtf, string bodyType, List<string> categories, List<string> companies, string itemId, string messageClass, string mileage, List<MapiRecipientDto> recipients, string sensitivity, string subject, string subjectPrefix, List<MapiPropertyDto> properties, string discriminator, bool? appointmentCounterProposal, MapiCalendarAttendeesDto attendees, string busyStatus, List<string> clientIntent, DateTime? endDate, MapiCalendarTimeZoneDto endDateTimeZone, bool? isAllDay, string keyWords, string location, MapiCalendarEventRecurrenceDto recurrence, int? reminderDelta, string reminderFileParameter, bool? reminderSet, int? sequence, DateTime? startDate, MapiCalendarTimeZoneDto startDateTimeZone, string uid, MapiElectronicAddressDto organizer)
        {
            Attachments = attachments;
            Billing = billing;
            Body = body;
            BodyHtml = bodyHtml;
            BodyRtf = bodyRtf;
            BodyType = bodyType;
            Categories = categories;
            Companies = companies;
            ItemId = itemId;
            MessageClass = messageClass;
            Mileage = mileage;
            Recipients = recipients;
            Sensitivity = sensitivity;
            Subject = subject;
            SubjectPrefix = subjectPrefix;
            Properties = properties;
            Discriminator = discriminator;
            AppointmentCounterProposal = appointmentCounterProposal;
            Attendees = attendees;
            BusyStatus = busyStatus;
            ClientIntent = clientIntent;
            EndDate = endDate;
            EndDateTimeZone = endDateTimeZone;
            IsAllDay = isAllDay;
            KeyWords = keyWords;
            Location = location;
            Recurrence = recurrence;
            ReminderDelta = reminderDelta;
            ReminderFileParameter = reminderFileParameter;
            ReminderSet = reminderSet;
            Sequence = sequence;
            StartDate = startDate;
            StartDateTimeZone = startDateTimeZone;
            Uid = uid;
            Organizer = organizer;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarDto {\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  Billing: ").Append(this.Billing).Append("\n");
          sb.Append("  Body: ").Append(this.Body).Append("\n");
          sb.Append("  BodyHtml: ").Append(this.BodyHtml).Append("\n");
          sb.Append("  BodyRtf: ").Append(this.BodyRtf).Append("\n");
          sb.Append("  BodyType: ").Append(this.BodyType).Append("\n");
          sb.Append("  Categories: ").Append(this.Categories).Append("\n");
          sb.Append("  Companies: ").Append(this.Companies).Append("\n");
          sb.Append("  ItemId: ").Append(this.ItemId).Append("\n");
          sb.Append("  MessageClass: ").Append(this.MessageClass).Append("\n");
          sb.Append("  Mileage: ").Append(this.Mileage).Append("\n");
          sb.Append("  Recipients: ").Append(this.Recipients).Append("\n");
          sb.Append("  Sensitivity: ").Append(this.Sensitivity).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  SubjectPrefix: ").Append(this.SubjectPrefix).Append("\n");
          sb.Append("  Properties: ").Append(this.Properties).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  AppointmentCounterProposal: ").Append(this.AppointmentCounterProposal).Append("\n");
          sb.Append("  Attendees: ").Append(this.Attendees).Append("\n");
          sb.Append("  BusyStatus: ").Append(this.BusyStatus).Append("\n");
          sb.Append("  ClientIntent: ").Append(this.ClientIntent).Append("\n");
          sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
          sb.Append("  EndDateTimeZone: ").Append(this.EndDateTimeZone).Append("\n");
          sb.Append("  IsAllDay: ").Append(this.IsAllDay).Append("\n");
          sb.Append("  KeyWords: ").Append(this.KeyWords).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  Recurrence: ").Append(this.Recurrence).Append("\n");
          sb.Append("  ReminderDelta: ").Append(this.ReminderDelta).Append("\n");
          sb.Append("  ReminderFileParameter: ").Append(this.ReminderFileParameter).Append("\n");
          sb.Append("  ReminderSet: ").Append(this.ReminderSet).Append("\n");
          sb.Append("  Sequence: ").Append(this.Sequence).Append("\n");
          sb.Append("  StartDate: ").Append(this.StartDate).Append("\n");
          sb.Append("  StartDateTimeZone: ").Append(this.StartDateTimeZone).Append("\n");
          sb.Append("  Uid: ").Append(this.Uid).Append("\n");
          sb.Append("  Organizer: ").Append(this.Organizer).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
