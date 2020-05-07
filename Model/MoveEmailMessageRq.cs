// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MoveEmailMessageRq.cs">
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
    /// Move email message request             
    /// </summary>
    public class MoveEmailMessageRq : AccountBaseRequest 
    {
        /// <summary>
        /// Message identifier             
        /// </summary>  
        public string MessageId { get; set; }

        /// <summary>
        /// Message source folder. Account root folder by default             
        /// </summary>  
        public string SourceFolder { get; set; }

        /// <summary>
        /// Folder in email account to move message to             
        /// </summary>  
        public string DestinationFolder { get; set; }

        /// <summary>MoveEmailMessageRq constructor</summary>
        public MoveEmailMessageRq() {}

        /// <summary>MoveEmailMessageRq constructor</summary>
        /// <param name="firstAccount">First account storage file name             </param>
        /// <param name="secondAccount">Additional email account (for example, FirstAccount could be IMAP, and second one could be SMTP)             </param>
        /// <param name="storageFolder">Storage folder location of account files             </param>
        /// <param name="messageId">Message identifier             </param>
        /// <param name="sourceFolder">Message source folder. Account root folder by default             </param>
        /// <param name="destinationFolder">Folder in email account to move message to             </param>
        public MoveEmailMessageRq(string firstAccount, string secondAccount, StorageFolderLocation storageFolder, string messageId, string sourceFolder, string destinationFolder)
        {
            FirstAccount = firstAccount;
            SecondAccount = secondAccount;
            StorageFolder = storageFolder;
            MessageId = messageId;
            SourceFolder = sourceFolder;
            DestinationFolder = destinationFolder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MoveEmailMessageRq {\n");
          sb.Append("  FirstAccount: ").Append(this.FirstAccount).Append("\n");
          sb.Append("  SecondAccount: ").Append(this.SecondAccount).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("  MessageId: ").Append(this.MessageId).Append("\n");
          sb.Append("  SourceFolder: ").Append(this.SourceFolder).Append("\n");
          sb.Append("  DestinationFolder: ").Append(this.DestinationFolder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}