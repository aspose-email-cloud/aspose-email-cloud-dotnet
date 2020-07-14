// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactOtherPropertySetDto.cs">
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
    /// The properties are used to specify additional properties of contact.             
    /// </summary>
    public class MapiContactOtherPropertySetDto 
    {
        /// <summary>
        /// Indicates whether the end-user wants this message object hidden from other users who have access to the message object.             
        /// </summary>  
        public bool? Private { get; set; }

        /// <summary>
        /// Specifies whether to create a journal for each action associated with this contact.             
        /// </summary>  
        public bool? Journal { get; set; }

        /// <summary>
        /// Specifies the initial signal time for a reminder.             
        /// </summary>  
        public DateTime? ReminderTime { get; set; }

        /// <summary>
        /// Represents the status of a meeting request.             
        /// </summary>  
        public string ReminderTopic { get; set; }

        /// <summary>
        /// Specifies the first field on the contact that is intended for miscellaneous use for the contact.             
        /// </summary>  
        public string UserField1 { get; set; }

        /// <summary>
        /// Specifies the second field on the contact that is intended for miscellaneous use for the contact.             
        /// </summary>  
        public string UserField2 { get; set; }

        /// <summary>
        /// Specifies the third field on the contact that is intended for miscellaneous use for the contact.             
        /// </summary>  
        public string UserField3 { get; set; }

        /// <summary>
        /// Specifies the forth field on the contact that is intended for miscellaneous use for the contact.             
        /// </summary>  
        public string UserField4 { get; set; }

        /// <summary>MapiContactOtherPropertySetDto constructor</summary>
        public MapiContactOtherPropertySetDto() {}

        /// <summary>MapiContactOtherPropertySetDto constructor</summary>
        /// <param name="_private">Indicates whether the end-user wants this message object hidden from other users who have access to the message object.             </param>
        /// <param name="journal">Specifies whether to create a journal for each action associated with this contact.             </param>
        /// <param name="reminderTime">Specifies the initial signal time for a reminder.             </param>
        /// <param name="reminderTopic">Represents the status of a meeting request.             </param>
        /// <param name="userField1">Specifies the first field on the contact that is intended for miscellaneous use for the contact.             </param>
        /// <param name="userField2">Specifies the second field on the contact that is intended for miscellaneous use for the contact.             </param>
        /// <param name="userField3">Specifies the third field on the contact that is intended for miscellaneous use for the contact.             </param>
        /// <param name="userField4">Specifies the forth field on the contact that is intended for miscellaneous use for the contact.             </param>
        public MapiContactOtherPropertySetDto(bool? _private, bool? journal, DateTime? reminderTime, string reminderTopic, string userField1, string userField2, string userField3, string userField4)
        {
            Private = _private;
            Journal = journal;
            ReminderTime = reminderTime;
            ReminderTopic = reminderTopic;
            UserField1 = userField1;
            UserField2 = userField2;
            UserField3 = userField3;
            UserField4 = userField4;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactOtherPropertySetDto {\n");
          sb.Append("  Private: ").Append(this.Private).Append("\n");
          sb.Append("  Journal: ").Append(this.Journal).Append("\n");
          sb.Append("  ReminderTime: ").Append(this.ReminderTime).Append("\n");
          sb.Append("  ReminderTopic: ").Append(this.ReminderTopic).Append("\n");
          sb.Append("  UserField1: ").Append(this.UserField1).Append("\n");
          sb.Append("  UserField2: ").Append(this.UserField2).Append("\n");
          sb.Append("  UserField3: ").Append(this.UserField3).Append("\n");
          sb.Append("  UserField4: ").Append(this.UserField4).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
