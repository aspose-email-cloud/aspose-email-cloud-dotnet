// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LinkedResource.cs">
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
    /// Represents an embedded resource in a message.             
    /// </summary>
    public class LinkedResource : AttachmentBase 
    {
        /// <summary>
        /// URI that the resource must match.             
        /// </summary>
        public string ContentLink { get; set; }


        /// <summary>LinkedResource constructor</summary>
        public LinkedResource() {}


        /// <summary>LinkedResource constructor</summary>
        /// <param name="base64Data">Attachment file content as Base64 string.             </param>
        /// <param name="contentId">Attachment content id             </param>
        /// <param name="contentType">Content type             </param>
        /// <param name="headers">Attachment headers.             </param>
        /// <param name="contentLink">URI that the resource must match.             </param>
        public LinkedResource(
            string base64Data,
            string contentId,
            ContentType contentType,
            Dictionary<string, string> headers,
            string contentLink
        )
        { 
            Base64Data = base64Data;
            ContentId = contentId;
            ContentType = contentType;
            Headers = headers;
            ContentLink = contentLink;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LinkedResource {\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("  ContentId: ").Append(this.ContentId).Append("\n");
          sb.Append("  ContentType: ").Append(this.ContentType).Append("\n");
          sb.Append("  Headers: ").Append(this.Headers).Append("\n");
          sb.Append("  ContentLink: ").Append(this.ContentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
