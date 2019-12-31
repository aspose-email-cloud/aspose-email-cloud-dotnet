// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SetMessageReadFlagAccountBaseRequest.cs">
//   Copyright (c) 2016 Aspose.Email for Cloud
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
    /// Set message is read request             
    /// </summary>
    public class SetMessageReadFlagAccountBaseRequest : AccountBaseRequest 
    {
        /// <summary>
        /// Message identifier             
        /// </summary>  
        public string MessageId { get; set; }

        /// <summary>
        /// Specifies that message should be marked read or unread             
        /// </summary>  
        public bool? IsRead { get; set; }

        /// <summary>SetMessageReadFlagAccountBaseRequest constructor</summary>
        public SetMessageReadFlagAccountBaseRequest() {}

        /// <summary>SetMessageReadFlagAccountBaseRequest constructor</summary>
        /// <param name="firstAccount">First account storage file name for receiving emails (or universal one)             </param>
        /// <param name="secondAccount">Second account storage file name for sending emails (ignored if first is universal)             </param>
        /// <param name="storageFolder">Storage folder location of account files             </param>
        /// <param name="messageId">Message identifier             </param>
        /// <param name="isRead">Specifies that message should be marked read or unread             </param>
        public SetMessageReadFlagAccountBaseRequest(string firstAccount, string secondAccount, StorageFolderLocation storageFolder, string messageId, bool? isRead)
        {
            FirstAccount = firstAccount;
            SecondAccount = secondAccount;
            StorageFolder = storageFolder;
            MessageId = messageId;
            IsRead = isRead;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SetMessageReadFlagAccountBaseRequest {\n");
          sb.Append("  FirstAccount: ").Append(this.FirstAccount).Append("\n");
          sb.Append("  SecondAccount: ").Append(this.SecondAccount).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("  MessageId: ").Append(this.MessageId).Append("\n");
          sb.Append("  IsRead: ").Append(this.IsRead).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
