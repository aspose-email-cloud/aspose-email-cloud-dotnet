
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiMessageItemBaseDto.cs">
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
    /// Base Dto for MapiMessage, MapiCalendar or MapiContact             
    /// </summary>
    public class MapiMessageItemBaseDto 
    {
        /// <summary>
        /// Message item attachments.             
        /// </summary>
        public List<MapiAttachmentDto> Attachments { get; set; }

        /// <summary>
        /// Billing information associated with an item.             
        /// </summary>
        public string Billing { get; set; }

        /// <summary>
        /// Message text.             
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets the BodyRtf of the message converted to HTML, if present, otherwise an empty string.             
        /// </summary>
        public string BodyHtml { get; set; }

        /// <summary>
        /// RTF formatted message text.             
        /// </summary>
        public string BodyRtf { get; set; }

        /// <summary>
        /// The content type of message body. Enum, available values: PlainText, Html, Rtf
        /// </summary>
        public string BodyType { get; set; }

        /// <summary>
        /// Contains keywords or categories for the message object.             
        /// </summary>
        public List<string> Categories { get; set; }

        /// <summary>
        /// Contains the names of the companies that are associated with an item.             
        /// </summary>
        public List<string> Companies { get; set; }

        /// <summary>
        /// The item id, uses with a server.             
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Case-sensitive string that identifies the sender-defined message class, such as IPM.Note. The message class specifies the type, purpose, or content of the message.             
        /// </summary>
        public string MessageClass { get; set; }

        /// <summary>
        /// Contains the mileage information that is associated with an item.             
        /// </summary>
        public string Mileage { get; set; }

        /// <summary>
        /// Recipients of the message.             
        /// </summary>
        public List<MapiRecipientDto> Recipients { get; set; }

        /// <summary>
        /// Contains values that indicate the message sensitivity. Enum, available values: None, Personal, Private, CompanyConfidential
        /// </summary>
        public string Sensitivity { get; set; }

        /// <summary>
        /// Subject of the message.             
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Subject prefix that typically indicates some action on a message, such as \"FW: \" for forwarding.             
        /// </summary>
        public string SubjectPrefix { get; set; }

        /// <summary>
        /// List of MAPI properties             
        /// </summary>
        public List<MapiPropertyDto> Properties { get; set; }

        /// <summary>
        /// Gets or sets Discriminator
        /// </summary>
        public string Discriminator
        {
            get { return GetType().Name; }
            set { /*do nothing*/}
        }


        /// <summary>MapiMessageItemBaseDto constructor</summary>
        public MapiMessageItemBaseDto() {}


        /// <summary>MapiMessageItemBaseDto constructor</summary>
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
        public MapiMessageItemBaseDto(
            List<MapiAttachmentDto> attachments,
            string billing,
            string body,
            string bodyHtml,
            string bodyRtf,
            string bodyType,
            List<string> categories,
            List<string> companies,
            string itemId,
            string messageClass,
            string mileage,
            List<MapiRecipientDto> recipients,
            string sensitivity,
            string subject,
            string subjectPrefix,
            List<MapiPropertyDto> properties
            
        )
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
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiMessageItemBaseDto {\n");
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
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
