// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailDto.cs">
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
    /// Email message representation.             
    /// </summary>
    public class EmailDto 
    {
        /// <summary>
        /// Collection of alternate views of message.             
        /// </summary>
        public List<AlternateView> AlternateViews { get; set; }

        /// <summary>
        /// Email message attachments.             
        /// </summary>
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// BCC recipients.             
        /// </summary>
        public List<MailAddress> Bcc { get; set; }

        /// <summary>
        /// Email message body as plain text.             
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Body encoding.             
        /// </summary>
        public string BodyEncoding { get; set; }

        /// <summary>
        /// The content type of message body./nEnum, available values: PlainText, Html, Rtf
        /// </summary>
        public string BodyType { get; set; }

        /// <summary>
        /// CC recipients.             
        /// </summary>
        public List<MailAddress> Cc { get; set; }

        /// <summary>
        /// Message date.             
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Delivery notifications. Items: Email delivery notification options./nEnum, available values: Delay, Never, None, OnFailure, OnSuccess
        /// </summary>
        public List<string> DeliveryNotificationOptions { get; set; }

        /// <summary>
        /// From address.             
        /// </summary>
        public MailAddress From { get; set; }

        /// <summary>
        /// Document headers.             
        /// </summary>
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// HTML body.             
        /// </summary>
        public string HtmlBody { get; set; }

        /// <summary>
        /// Html body as plain text. Read only.             
        /// </summary>
        public string HtmlBodyText { get; set; }

        /// <summary>
        /// Indicates whether the message body is in Html.             
        /// </summary>
        public bool? IsBodyHtml { get; set; }

        /// <summary>
        /// Indicates whether or not a message has been sent.             
        /// </summary>
        public bool? IsDraft { get; set; }

        /// <summary>
        /// Indicates whether the message is encrypted. Read only.             
        /// </summary>
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Indicates whether the message is signed. Read only.             
        /// </summary>
        public bool? IsSigned { get; set; }

        /// <summary>
        /// Linked resources of message.             
        /// </summary>
        public List<LinkedResource> LinkedResources { get; set; }

        /// <summary>
        /// Message id.             
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Indicates whether original EML message is in TNEF format. Read only.             
        /// </summary>
        public bool? OriginalIsTnef { get; set; }

        /// <summary>
        /// Preferred encoding.             
        /// </summary>
        public string PreferredTextEncoding { get; set; }

        /// <summary>
        /// Email priority status./nEnum, available values: High, Low, Normal
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// Read receipt addresses.             
        /// </summary>
        public List<MailAddress> ReadReceiptTo { get; set; }

        /// <summary>
        /// The list of addresses to reply to for the mail message.             
        /// </summary>
        public List<MailAddress> ReplyToList { get; set; }

        /// <summary>
        /// ReversePath address.             
        /// </summary>
        public MailAddress ReversePath { get; set; }

        /// <summary>
        /// Sender address.             
        /// </summary>
        public MailAddress Sender { get; set; }

        /// <summary>
        /// Specifies the sensitivity of a MailMessage./nEnum, available values: None, Normal, Personal, Private, CompanyConfidential
        /// </summary>
        public string Sensitivity { get; set; }

        /// <summary>
        /// Message subject.             
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Subject encoding.             
        /// </summary>
        public string SubjectEncoding { get; set; }

        /// <summary>
        /// Coordinated Universal Time (UTC) offset for the message dates. This property defines the time zone difference, between the local time and UTC represented as count of ticks (10 000 per millisecond).             
        /// </summary>
        public long? TimeZoneOffset { get; set; }

        /// <summary>
        /// The address collection that contains the recipients of message.             
        /// </summary>
        public List<MailAddress> To { get; set; }

        /// <summary>
        /// The X-Mailer the software that created the e-mail message.             
        /// </summary>
        public string XMailer { get; set; }

        /// <summary>
        /// Gets or sets an epilogue text. It is located after the last boundary.
        /// </summary>
        public string Epilogue { get; set; }

        /// <summary>
        /// Gets or sets a preamble text. It is located before the first boundary and generally includes an explanatory note to non-MIME conformant readers.
        /// </summary>
        public string Preamble { get; set; }


        /// <summary>EmailDto constructor</summary>
        public EmailDto() {}


        /// <summary>EmailDto constructor</summary>
        /// <param name="alternateViews">Collection of alternate views of message.             </param>
        /// <param name="attachments">Email message attachments.             </param>
        /// <param name="bcc">BCC recipients.             </param>
        /// <param name="body">Email message body as plain text.             </param>
        /// <param name="bodyEncoding">Body encoding.             </param>
        /// <param name="bodyType">The content type of message body./nEnum, available values: PlainText, Html, Rtf</param>
        /// <param name="cc">CC recipients.             </param>
        /// <param name="date">Message date.             </param>
        /// <param name="deliveryNotificationOptions">Delivery notifications.</param>
        /// <param name="from">From address.             </param>
        /// <param name="headers">Document headers.             </param>
        /// <param name="htmlBody">HTML body.             </param>
        /// <param name="htmlBodyText">Html body as plain text. Read only.             </param>
        /// <param name="isBodyHtml">Indicates whether the message body is in Html.             </param>
        /// <param name="isDraft">Indicates whether or not a message has been sent.             </param>
        /// <param name="isEncrypted">Indicates whether the message is encrypted. Read only.             </param>
        /// <param name="isSigned">Indicates whether the message is signed. Read only.             </param>
        /// <param name="linkedResources">Linked resources of message.             </param>
        /// <param name="messageId">Message id.             </param>
        /// <param name="originalIsTnef">Indicates whether original EML message is in TNEF format. Read only.             </param>
        /// <param name="preferredTextEncoding">Preferred encoding.             </param>
        /// <param name="priority">Email priority status./nEnum, available values: High, Low, Normal</param>
        /// <param name="readReceiptTo">Read receipt addresses.             </param>
        /// <param name="replyToList">The list of addresses to reply to for the mail message.             </param>
        /// <param name="reversePath">ReversePath address.             </param>
        /// <param name="sender">Sender address.             </param>
        /// <param name="sensitivity">Specifies the sensitivity of a MailMessage./nEnum, available values: None, Normal, Personal, Private, CompanyConfidential</param>
        /// <param name="subject">Message subject.             </param>
        /// <param name="subjectEncoding">Subject encoding.             </param>
        /// <param name="timeZoneOffset">Coordinated Universal Time (UTC) offset for the message dates. This property defines the time zone difference, between the local time and UTC represented as count of ticks (10 000 per millisecond).             </param>
        /// <param name="to">The address collection that contains the recipients of message.             </param>
        /// <param name="xMailer">The X-Mailer the software that created the e-mail message.             </param>
        /// <param name="epilogue">Gets or sets an epilogue text. It is located after the last boundary.</param>
        /// <param name="preamble">Gets or sets a preamble text. It is located before the first boundary and generally includes an explanatory note to non-MIME conformant readers.</param>
        public EmailDto(
            List<AlternateView> alternateViews,
            List<Attachment> attachments,
            List<MailAddress> bcc,
            string body,
            string bodyEncoding,
            string bodyType,
            List<MailAddress> cc,
            DateTime? date,
            List<string> deliveryNotificationOptions,
            MailAddress from,
            Dictionary<string, string> headers,
            string htmlBody,
            string htmlBodyText,
            bool? isBodyHtml,
            bool? isDraft,
            bool? isEncrypted,
            bool? isSigned,
            List<LinkedResource> linkedResources,
            string messageId,
            bool? originalIsTnef,
            string preferredTextEncoding,
            string priority,
            List<MailAddress> readReceiptTo,
            List<MailAddress> replyToList,
            MailAddress reversePath,
            MailAddress sender,
            string sensitivity,
            string subject,
            string subjectEncoding,
            long? timeZoneOffset,
            List<MailAddress> to,
            string xMailer,
            string epilogue,
            string preamble
        )
        { 
            AlternateViews = alternateViews;
            Attachments = attachments;
            Bcc = bcc;
            Body = body;
            BodyEncoding = bodyEncoding;
            BodyType = bodyType;
            Cc = cc;
            Date = date;
            DeliveryNotificationOptions = deliveryNotificationOptions;
            From = from;
            Headers = headers;
            HtmlBody = htmlBody;
            HtmlBodyText = htmlBodyText;
            IsBodyHtml = isBodyHtml;
            IsDraft = isDraft;
            IsEncrypted = isEncrypted;
            IsSigned = isSigned;
            LinkedResources = linkedResources;
            MessageId = messageId;
            OriginalIsTnef = originalIsTnef;
            PreferredTextEncoding = preferredTextEncoding;
            Priority = priority;
            ReadReceiptTo = readReceiptTo;
            ReplyToList = replyToList;
            ReversePath = reversePath;
            Sender = sender;
            Sensitivity = sensitivity;
            Subject = subject;
            SubjectEncoding = subjectEncoding;
            TimeZoneOffset = timeZoneOffset;
            To = to;
            XMailer = xMailer;
            Epilogue = epilogue;
            Preamble = preamble;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailDto {\n");
          sb.Append("  AlternateViews: ").Append(this.AlternateViews).Append("\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  Bcc: ").Append(this.Bcc).Append("\n");
          sb.Append("  Body: ").Append(this.Body).Append("\n");
          sb.Append("  BodyEncoding: ").Append(this.BodyEncoding).Append("\n");
          sb.Append("  BodyType: ").Append(this.BodyType).Append("\n");
          sb.Append("  Cc: ").Append(this.Cc).Append("\n");
          sb.Append("  Date: ").Append(this.Date).Append("\n");
          sb.Append("  DeliveryNotificationOptions: ").Append(this.DeliveryNotificationOptions).Append("\n");
          sb.Append("  From: ").Append(this.From).Append("\n");
          sb.Append("  Headers: ").Append(this.Headers).Append("\n");
          sb.Append("  HtmlBody: ").Append(this.HtmlBody).Append("\n");
          sb.Append("  HtmlBodyText: ").Append(this.HtmlBodyText).Append("\n");
          sb.Append("  IsBodyHtml: ").Append(this.IsBodyHtml).Append("\n");
          sb.Append("  IsDraft: ").Append(this.IsDraft).Append("\n");
          sb.Append("  IsEncrypted: ").Append(this.IsEncrypted).Append("\n");
          sb.Append("  IsSigned: ").Append(this.IsSigned).Append("\n");
          sb.Append("  LinkedResources: ").Append(this.LinkedResources).Append("\n");
          sb.Append("  MessageId: ").Append(this.MessageId).Append("\n");
          sb.Append("  OriginalIsTnef: ").Append(this.OriginalIsTnef).Append("\n");
          sb.Append("  PreferredTextEncoding: ").Append(this.PreferredTextEncoding).Append("\n");
          sb.Append("  Priority: ").Append(this.Priority).Append("\n");
          sb.Append("  ReadReceiptTo: ").Append(this.ReadReceiptTo).Append("\n");
          sb.Append("  ReplyToList: ").Append(this.ReplyToList).Append("\n");
          sb.Append("  ReversePath: ").Append(this.ReversePath).Append("\n");
          sb.Append("  Sender: ").Append(this.Sender).Append("\n");
          sb.Append("  Sensitivity: ").Append(this.Sensitivity).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  SubjectEncoding: ").Append(this.SubjectEncoding).Append("\n");
          sb.Append("  TimeZoneOffset: ").Append(this.TimeZoneOffset).Append("\n");
          sb.Append("  To: ").Append(this.To).Append("\n");
          sb.Append("  XMailer: ").Append(this.XMailer).Append("\n");
          sb.Append("  Epilogue: ").Append(this.Epilogue).Append("\n");
          sb.Append("  Preamble: ").Append(this.Preamble).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
