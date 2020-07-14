// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AlternateView.cs">
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
    /// Represents the format to view a message.             
    /// </summary>
    public class AlternateView : AttachmentBase 
    {
        /// <summary>
        /// Base URI.             
        /// </summary>  
        public string BaseUri { get; set; }

        /// <summary>
        /// Embedded resources referred to by this alternate view.             
        /// </summary>  
        public List<LinkedResource> LinkedResources { get; set; }

        /// <summary>AlternateView constructor</summary>
        public AlternateView() {}

        /// <summary>AlternateView constructor</summary>
        /// <param name="base64Data">Attachment file content as Base64 string.             </param>
        /// <param name="contentId">Attachment content id             </param>
        /// <param name="contentType">Content type             </param>
        /// <param name="headers">Attachment headers.             </param>
        /// <param name="baseUri">Base URI.             </param>
        /// <param name="linkedResources">Embedded resources referred to by this alternate view.             </param>
        public AlternateView(string base64Data, string contentId, ContentType contentType, Dictionary<string, string> headers, string baseUri, List<LinkedResource> linkedResources)
        {
            Base64Data = base64Data;
            ContentId = contentId;
            ContentType = contentType;
            Headers = headers;
            BaseUri = baseUri;
            LinkedResources = linkedResources;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AlternateView {\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("  ContentId: ").Append(this.ContentId).Append("\n");
          sb.Append("  ContentType: ").Append(this.ContentType).Append("\n");
          sb.Append("  Headers: ").Append(this.Headers).Append("\n");
          sb.Append("  BaseUri: ").Append(this.BaseUri).Append("\n");
          sb.Append("  LinkedResources: ").Append(this.LinkedResources).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
