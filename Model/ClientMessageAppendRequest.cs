// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientMessageAppendRequest.cs">
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
    /// Email client append message request.             
    /// </summary>
    public class ClientMessageAppendRequest : ClientAccountBaseRequest 
    {
        /// <summary>
        /// Path to folder on email server to append message to.             
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Message to append.             
        /// </summary>
        public MailMessageBase Message { get; set; }

        /// <summary>
        /// Determines that appended message should be market as sent or not.             
        /// </summary>
        public bool? MarkAsSent { get; set; }


        /// <summary>ClientMessageAppendRequest constructor</summary>
        public ClientMessageAppendRequest() {}


        /// <summary>ClientMessageAppendRequest constructor</summary>
        /// <param name="accountLocation">Email client account configuration location on storage.             </param>
        /// <param name="folder">Path to folder on email server to append message to.             </param>
        /// <param name="message">Message to append.             </param>
        /// <param name="markAsSent">Determines that appended message should be market as sent or not.             </param>
        public ClientMessageAppendRequest(
            StorageFileLocation accountLocation,
            string folder,
            MailMessageBase message,
            bool? markAsSent
        )
        { 
            AccountLocation = accountLocation;
            Folder = folder;
            Message = message;
            MarkAsSent = markAsSent;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClientMessageAppendRequest {\n");
          sb.Append("  AccountLocation: ").Append(this.AccountLocation).Append("\n");
          sb.Append("  Folder: ").Append(this.Folder).Append("\n");
          sb.Append("  Message: ").Append(this.Message).Append("\n");
          sb.Append("  MarkAsSent: ").Append(this.MarkAsSent).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
