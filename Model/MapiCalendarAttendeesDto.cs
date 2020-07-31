// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarAttendeesDto.cs">
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
    /// Mapi calendar attendees.             
    /// </summary>
    public class MapiCalendarAttendeesDto 
    {
        /// <summary>
        /// List of attendees.             
        /// </summary>
        public List<MapiRecipientDto> AppointmentRecipients { get; set; }

        /// <summary>
        /// List of unsendable attendees.             
        /// </summary>
        public List<MapiRecipientDto> AppointmentUnsendableRecipients { get; set; }

        /// <summary>
        /// Value indicating whether attendees are not allowed to propose a new date and/or time for the meeting.             
        /// </summary>
        public bool? NotAllowPropose { get; set; }

        /// <summary>
        /// Value indicating whether a response is requested to a Message object.             
        /// </summary>
        public bool? ResponseRequested { get; set; }


        /// <summary>MapiCalendarAttendeesDto constructor</summary>
        public MapiCalendarAttendeesDto() {}


        /// <summary>MapiCalendarAttendeesDto constructor</summary>
        /// <param name="appointmentRecipients">List of attendees.             </param>
        /// <param name="appointmentUnsendableRecipients">List of unsendable attendees.             </param>
        /// <param name="notAllowPropose">Value indicating whether attendees are not allowed to propose a new date and/or time for the meeting.             </param>
        /// <param name="responseRequested">Value indicating whether a response is requested to a Message object.             </param>
        public MapiCalendarAttendeesDto(
            List<MapiRecipientDto> appointmentRecipients,
            List<MapiRecipientDto> appointmentUnsendableRecipients,
            bool? notAllowPropose,
            bool? responseRequested
        )
        { 
            AppointmentRecipients = appointmentRecipients;
            AppointmentUnsendableRecipients = appointmentUnsendableRecipients;
            NotAllowPropose = notAllowPropose;
            ResponseRequested = responseRequested;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarAttendeesDto {\n");
          sb.Append("  AppointmentRecipients: ").Append(this.AppointmentRecipients).Append("\n");
          sb.Append("  AppointmentUnsendableRecipients: ").Append(this.AppointmentUnsendableRecipients).Append("\n");
          sb.Append("  NotAllowPropose: ").Append(this.NotAllowPropose).Append("\n");
          sb.Append("  ResponseRequested: ").Append(this.ResponseRequested).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
