// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiMessageDto.cs">
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
    /// Represents an Outlook Message format document.             
    /// </summary>
    public class MapiMessageDto : MapiMessageItemBaseDto 
    {
        /// <summary>
        /// Message text             
        /// </summary>  
        public string MessageBody { get; set; }

        /// <summary>
        /// Date and time the message sender submitted a message.             
        /// </summary>  
        public DateTime? ClientSubmitTime { get; set; }

        /// <summary>
        /// Topic of the first message in a conversation thread.             
        /// </summary>  
        public string ConversationTopic { get; set; }

        /// <summary>
        /// Date and time a message was delivered.             
        /// </summary>  
        public DateTime? DeliveryTime { get; set; }

        /// <summary>
        /// List of the display names of any blind carbon copy (BCC) message recipients, separated by semicolons (;).             
        /// </summary>  
        public string DisplayBcc { get; set; }

        /// <summary>
        /// List of the display names of any carbon copy (CC) message recipients, separated by semicolons (;).             
        /// </summary>  
        public string DisplayCc { get; set; }

        /// <summary>
        /// Display name for the message.             
        /// </summary>  
        public string DisplayName { get; set; }

        /// <summary>
        /// Prefix of the display name.             
        /// </summary>  
        public string DisplayNamePrefix { get; set; }

        /// <summary>
        /// List of the display names of the primary (To) message recipients, separated by semicolons (;).             
        /// </summary>  
        public string DisplayTo { get; set; }

        /// <summary>
        /// Message flags.              Items: Mapi message flags. Enum, available values: MsgFlagZero, MsgFlagRead, MsgFlagUnmodified, MsgFlagSubmit, MsgFlagUnsent, MsgFlagHasAttach, MsgFlagFromMe, MsgFlagAssociated, MsgFlagResend, MsgFlagNotifyRead, MsgFlagNotifyUnread, MsgFlagEverRead, MsgFlagOriginX400, MsgFlagOriginInternet, MsgFlagOriginMiscExt
        /// </summary>  
        public List<string> Flags { get; set; }

        /// <summary>
        /// Transport message headers             
        /// </summary>  
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Internet message id of the message.             
        /// </summary>  
        public string InternetMessageId { get; set; }

        /// <summary>
        /// Represents outlook message format. Enum, available values: Ascii, Unicode
        /// </summary>  
        public string MessageFormat { get; set; }

        /// <summary>
        /// Normalized subject of the message.             
        /// </summary>  
        public string NormalizedSubject { get; set; }

        /// <summary>
        /// Value indicating whether the read receipt is requested.
        /// </summary>  
        public bool? ReadReceiptRequested { get; set; }

        /// <summary>
        /// Reply to names.
        /// </summary>  
        public string ReplyTo { get; set; }

        /// <summary>
        /// Message sender's e-mail address type.
        /// </summary>  
        public string SenderAddressType { get; set; }

        /// <summary>
        /// Message sender's e-mail address.
        /// </summary>  
        public string SenderEmailAddress { get; set; }

        /// <summary>
        /// Message sender's display name.
        /// </summary>  
        public string SenderName { get; set; }

        /// <summary>
        /// Message sender's e-mail address.
        /// </summary>  
        public string SenderSmtpAddress { get; set; }

        /// <summary>
        /// Address type for the messaging user represented by the sender.
        /// </summary>  
        public string SentRepresentingAddressType { get; set; }

        /// <summary>
        /// E-mail address for the messaging user represented by the sender.
        /// </summary>  
        public string SentRepresentingEmailAddress { get; set; }

        /// <summary>
        /// Display name for the messaging user represented by the sender.
        /// </summary>  
        public string SentRepresentingName { get; set; }

        /// <summary>
        /// E-mail address for the messaging user represented by the sender.
        /// </summary>  
        public string SentRepresentingSmtpAddress { get; set; }

        /// <summary>
        /// Transport-specific message envelope information.
        /// </summary>  
        public string TransportMessageHeaders { get; set; }

        /// <summary>MapiMessageDto constructor</summary>
        public MapiMessageDto() {}

        /// <summary>MapiMessageDto constructor</summary>
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
        /// <param name="messageBody">Message text             </param>
        /// <param name="clientSubmitTime">Date and time the message sender submitted a message.             </param>
        /// <param name="conversationTopic">Topic of the first message in a conversation thread.             </param>
        /// <param name="deliveryTime">Date and time a message was delivered.             </param>
        /// <param name="displayBcc">List of the display names of any blind carbon copy (BCC) message recipients, separated by semicolons (;).             </param>
        /// <param name="displayCc">List of the display names of any carbon copy (CC) message recipients, separated by semicolons (;).             </param>
        /// <param name="displayName">Display name for the message.             </param>
        /// <param name="displayNamePrefix">Prefix of the display name.             </param>
        /// <param name="displayTo">List of the display names of the primary (To) message recipients, separated by semicolons (;).             </param>
        /// <param name="flags">Message flags.             </param>
        /// <param name="headers">Transport message headers             </param>
        /// <param name="internetMessageId">Internet message id of the message.             </param>
        /// <param name="messageFormat">Represents outlook message format. Enum, available values: Ascii, Unicode</param>
        /// <param name="normalizedSubject">Normalized subject of the message.             </param>
        /// <param name="readReceiptRequested">Value indicating whether the read receipt is requested.</param>
        /// <param name="replyTo">Reply to names.</param>
        /// <param name="senderAddressType">Message sender's e-mail address type.</param>
        /// <param name="senderEmailAddress">Message sender's e-mail address.</param>
        /// <param name="senderName">Message sender's display name.</param>
        /// <param name="senderSmtpAddress">Message sender's e-mail address.</param>
        /// <param name="sentRepresentingAddressType">Address type for the messaging user represented by the sender.</param>
        /// <param name="sentRepresentingEmailAddress">E-mail address for the messaging user represented by the sender.</param>
        /// <param name="sentRepresentingName">Display name for the messaging user represented by the sender.</param>
        /// <param name="sentRepresentingSmtpAddress">E-mail address for the messaging user represented by the sender.</param>
        /// <param name="transportMessageHeaders">Transport-specific message envelope information.</param>
        public MapiMessageDto(List<MapiAttachmentDto> attachments, string billing, string body, string bodyHtml, string bodyRtf, string bodyType, List<string> categories, List<string> companies, string itemId, string messageClass, string mileage, List<MapiRecipientDto> recipients, string sensitivity, string subject, string subjectPrefix, List<MapiPropertyDto> properties, string discriminator, string messageBody, DateTime? clientSubmitTime, string conversationTopic, DateTime? deliveryTime, string displayBcc, string displayCc, string displayName, string displayNamePrefix, string displayTo, List<string> flags, Dictionary<string, string> headers, string internetMessageId, string messageFormat, string normalizedSubject, bool? readReceiptRequested, string replyTo, string senderAddressType, string senderEmailAddress, string senderName, string senderSmtpAddress, string sentRepresentingAddressType, string sentRepresentingEmailAddress, string sentRepresentingName, string sentRepresentingSmtpAddress, string transportMessageHeaders)
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
            MessageBody = messageBody;
            ClientSubmitTime = clientSubmitTime;
            ConversationTopic = conversationTopic;
            DeliveryTime = deliveryTime;
            DisplayBcc = displayBcc;
            DisplayCc = displayCc;
            DisplayName = displayName;
            DisplayNamePrefix = displayNamePrefix;
            DisplayTo = displayTo;
            Flags = flags;
            Headers = headers;
            InternetMessageId = internetMessageId;
            MessageFormat = messageFormat;
            NormalizedSubject = normalizedSubject;
            ReadReceiptRequested = readReceiptRequested;
            ReplyTo = replyTo;
            SenderAddressType = senderAddressType;
            SenderEmailAddress = senderEmailAddress;
            SenderName = senderName;
            SenderSmtpAddress = senderSmtpAddress;
            SentRepresentingAddressType = sentRepresentingAddressType;
            SentRepresentingEmailAddress = sentRepresentingEmailAddress;
            SentRepresentingName = sentRepresentingName;
            SentRepresentingSmtpAddress = sentRepresentingSmtpAddress;
            TransportMessageHeaders = transportMessageHeaders;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiMessageDto {\n");
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
          sb.Append("  MessageBody: ").Append(this.MessageBody).Append("\n");
          sb.Append("  ClientSubmitTime: ").Append(this.ClientSubmitTime).Append("\n");
          sb.Append("  ConversationTopic: ").Append(this.ConversationTopic).Append("\n");
          sb.Append("  DeliveryTime: ").Append(this.DeliveryTime).Append("\n");
          sb.Append("  DisplayBcc: ").Append(this.DisplayBcc).Append("\n");
          sb.Append("  DisplayCc: ").Append(this.DisplayCc).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  DisplayNamePrefix: ").Append(this.DisplayNamePrefix).Append("\n");
          sb.Append("  DisplayTo: ").Append(this.DisplayTo).Append("\n");
          sb.Append("  Flags: ").Append(this.Flags).Append("\n");
          sb.Append("  Headers: ").Append(this.Headers).Append("\n");
          sb.Append("  InternetMessageId: ").Append(this.InternetMessageId).Append("\n");
          sb.Append("  MessageFormat: ").Append(this.MessageFormat).Append("\n");
          sb.Append("  NormalizedSubject: ").Append(this.NormalizedSubject).Append("\n");
          sb.Append("  ReadReceiptRequested: ").Append(this.ReadReceiptRequested).Append("\n");
          sb.Append("  ReplyTo: ").Append(this.ReplyTo).Append("\n");
          sb.Append("  SenderAddressType: ").Append(this.SenderAddressType).Append("\n");
          sb.Append("  SenderEmailAddress: ").Append(this.SenderEmailAddress).Append("\n");
          sb.Append("  SenderName: ").Append(this.SenderName).Append("\n");
          sb.Append("  SenderSmtpAddress: ").Append(this.SenderSmtpAddress).Append("\n");
          sb.Append("  SentRepresentingAddressType: ").Append(this.SentRepresentingAddressType).Append("\n");
          sb.Append("  SentRepresentingEmailAddress: ").Append(this.SentRepresentingEmailAddress).Append("\n");
          sb.Append("  SentRepresentingName: ").Append(this.SentRepresentingName).Append("\n");
          sb.Append("  SentRepresentingSmtpAddress: ").Append(this.SentRepresentingSmtpAddress).Append("\n");
          sb.Append("  TransportMessageHeaders: ").Append(this.TransportMessageHeaders).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
