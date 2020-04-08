// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailThread.cs">
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
    /// Email messages thread             
    /// </summary>
    public class EmailThread 
    {
        /// <summary>
        /// Thread identifier             
        /// </summary>  
        public string Id { get; set; }

        /// <summary>
        /// Thread subject             
        /// </summary>  
        public string Subject { get; set; }

        /// <summary>
        /// List of messages in thread             
        /// </summary>  
        public List<EmailDto> Messages { get; set; }

        /// <summary>EmailThread constructor</summary>
        public EmailThread() {}

        /// <summary>EmailThread constructor</summary>
        /// <param name="id">Thread identifier             </param>
        /// <param name="subject">Thread subject             </param>
        /// <param name="messages">List of messages in thread             </param>
        public EmailThread(string id, string subject, List<EmailDto> messages)
        {
            Id = id;
            Subject = subject;
            Messages = messages;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailThread {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  Messages: ").Append(this.Messages).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
