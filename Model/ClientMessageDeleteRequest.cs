// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientMessageDeleteRequest.cs">
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
    /// Email client delete message request.             
    /// </summary>
    public class ClientMessageDeleteRequest : ClientMessageBaseRequest 
    {
        /// <summary>
        /// Folder to delete message from.             
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>ClientMessageDeleteRequest constructor</summary>
        public ClientMessageDeleteRequest() {}

        /// <summary>ClientMessageDeleteRequest constructor</summary>
        /// <param name="accountLocation">Email client account configuration location on storage.             </param>
        /// <param name="messageId">Message identifier.             </param>
        /// <param name="folder">Folder to delete message from.             </param>
        public ClientMessageDeleteRequest(StorageFileLocation accountLocation, string messageId, string folder)
        {
            AccountLocation = accountLocation;
            MessageId = messageId;
            Folder = folder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClientMessageDeleteRequest {\n");
          sb.Append("  AccountLocation: ").Append(this.AccountLocation).Append("\n");
          sb.Append("  MessageId: ").Append(this.MessageId).Append("\n");
          sb.Append("  Folder: ").Append(this.Folder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
