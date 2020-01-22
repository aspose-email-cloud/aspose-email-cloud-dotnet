// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SendEmailModelRequest.cs">
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
    /// Send email model request             
    /// </summary>
    public class SendEmailModelRequest : AccountBaseRequest 
    {
        /// <summary>
        /// Message to send             
        /// </summary>  
        public EmailDto Message { get; set; }

        /// <summary>SendEmailModelRequest constructor</summary>
        public SendEmailModelRequest() {}

        /// <summary>SendEmailModelRequest constructor</summary>
        /// <param name="firstAccount">First account storage file name for receiving emails (or universal one)             </param>
        /// <param name="secondAccount">Second account storage file name for sending emails (ignored if first is universal)             </param>
        /// <param name="storageFolder">Storage folder location of account files             </param>
        /// <param name="message">Message to send             </param>
        public SendEmailModelRequest(string firstAccount, string secondAccount, StorageFolderLocation storageFolder, EmailDto message)
        {
            FirstAccount = firstAccount;
            SecondAccount = secondAccount;
            StorageFolder = storageFolder;
            Message = message;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SendEmailModelRequest {\n");
          sb.Append("  FirstAccount: ").Append(this.FirstAccount).Append("\n");
          sb.Append("  SecondAccount: ").Append(this.SecondAccount).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("  Message: ").Append(this.Message).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
