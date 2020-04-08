// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AppendEmailModelRq.cs">
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
    /// Append email request             
    /// </summary>
    public class AppendEmailModelRq : AppendEmailAccountBaseRequest 
    {
        /// <summary>
        /// Email document             
        /// </summary>  
        public EmailDto Message { get; set; }

        /// <summary>AppendEmailModelRq constructor</summary>
        public AppendEmailModelRq() {}

        /// <summary>AppendEmailModelRq constructor</summary>
        /// <param name="firstAccount">First account storage file name             </param>
        /// <param name="secondAccount">Additional email account (for example, FirstAccount could be IMAP, and second one could be SMTP)             </param>
        /// <param name="storageFolder">Storage folder location of account files             </param>
        /// <param name="folder">Email account folder to store a message             </param>
        /// <param name="markAsSent">Mark message as sent             </param>
        /// <param name="message">Email document             </param>
        public AppendEmailModelRq(string firstAccount, string secondAccount, StorageFolderLocation storageFolder, string folder, bool? markAsSent, EmailDto message)
        {
            FirstAccount = firstAccount;
            SecondAccount = secondAccount;
            StorageFolder = storageFolder;
            Folder = folder;
            MarkAsSent = markAsSent;
            Message = message;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AppendEmailModelRq {\n");
          sb.Append("  FirstAccount: ").Append(this.FirstAccount).Append("\n");
          sb.Append("  SecondAccount: ").Append(this.SecondAccount).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("  Folder: ").Append(this.Folder).Append("\n");
          sb.Append("  MarkAsSent: ").Append(this.MarkAsSent).Append("\n");
          sb.Append("  Message: ").Append(this.Message).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
