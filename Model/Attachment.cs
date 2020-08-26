// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Attachment.cs">
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
    /// Document attachment.             
    /// </summary>
    public class Attachment : AttachmentBase 
    {
        /// <summary>
        /// Content-Disposition header. Read only.             
        /// </summary>
        public string ContentDisposition { get; set; }

        /// <summary>
        /// Determines if attachment is an embedded message. Read only.             
        /// </summary>
        public bool? IsEmbeddedMessage { get; set; }

        /// <summary>
        /// Attachment name.             
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Encoding of attachment name.             
        /// </summary>
        public string NameEncoding { get; set; }

        /// <summary>
        /// Preferred text encoding.             
        /// </summary>
        public string PreferredTextEncoding { get; set; }


        /// <summary>Attachment constructor</summary>
        public Attachment() {}


        /// <summary>Attachment constructor</summary>
        /// <param name="base64Data">Attachment file content as Base64 string.             </param>
        /// <param name="contentId">Attachment content id             </param>
        /// <param name="contentType">Content type             </param>
        /// <param name="headers">Attachment headers.             </param>
        /// <param name="contentDisposition">Content-Disposition header. Read only.             </param>
        /// <param name="isEmbeddedMessage">Determines if attachment is an embedded message. Read only.             </param>
        /// <param name="name">Attachment name.             </param>
        /// <param name="nameEncoding">Encoding of attachment name.             </param>
        /// <param name="preferredTextEncoding">Preferred text encoding.             </param>
        public Attachment(
            string base64Data,
            string contentId,
            ContentType contentType,
            Dictionary<string, string> headers,
            string contentDisposition,
            bool? isEmbeddedMessage,
            string name,
            string nameEncoding,
            string preferredTextEncoding
        )
        { 
            Base64Data = base64Data;
            ContentId = contentId;
            ContentType = contentType;
            Headers = headers;
            ContentDisposition = contentDisposition;
            IsEmbeddedMessage = isEmbeddedMessage;
            Name = name;
            NameEncoding = nameEncoding;
            PreferredTextEncoding = preferredTextEncoding;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Attachment {\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("  ContentId: ").Append(this.ContentId).Append("\n");
          sb.Append("  ContentType: ").Append(this.ContentType).Append("\n");
          sb.Append("  Headers: ").Append(this.Headers).Append("\n");
          sb.Append("  ContentDisposition: ").Append(this.ContentDisposition).Append("\n");
          sb.Append("  IsEmbeddedMessage: ").Append(this.IsEmbeddedMessage).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  NameEncoding: ").Append(this.NameEncoding).Append("\n");
          sb.Append("  PreferredTextEncoding: ").Append(this.PreferredTextEncoding).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
