// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientThreadSetIsReadRequest.cs">
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
    /// Mark thread messages as read or unread request.             
    /// </summary>
    public class ClientThreadSetIsReadRequest : ClientThreadBaseRequest 
    {
        /// <summary>
        /// Message is read flag.             
        /// </summary>  
        public bool? IsRead { get; set; }

        /// <summary>
        /// Folder on email server, where thread is stored.             
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>ClientThreadSetIsReadRequest constructor</summary>
        public ClientThreadSetIsReadRequest() {}

        /// <summary>ClientThreadSetIsReadRequest constructor</summary>
        /// <param name="accountLocation">Email client account configuration location on storage.             </param>
        /// <param name="threadId">Thread identifier.             </param>
        /// <param name="isRead">Message is read flag.             </param>
        /// <param name="folder">Folder on email server, where thread is stored.             </param>
        public ClientThreadSetIsReadRequest(StorageFileLocation accountLocation, string threadId, bool? isRead, string folder)
        {
            AccountLocation = accountLocation;
            ThreadId = threadId;
            IsRead = isRead;
            Folder = folder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClientThreadSetIsReadRequest {\n");
          sb.Append("  AccountLocation: ").Append(this.AccountLocation).Append("\n");
          sb.Append("  ThreadId: ").Append(this.ThreadId).Append("\n");
          sb.Append("  IsRead: ").Append(this.IsRead).Append("\n");
          sb.Append("  Folder: ").Append(this.Folder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
