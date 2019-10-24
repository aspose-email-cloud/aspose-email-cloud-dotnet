// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailAccountRequest.cs">
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
  /// Email account settings request
  /// </summary>
  public class EmailAccountRequest 
  {
        /// <summary>
        /// Email account security options
        /// </summary>
        /// <value>Email account security options</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecurityOptionsEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum SSLExplicit for "SSLExplicit"
            /// </summary>            
            SSLExplicit,
            
            /// <summary>
            /// Enum SSLImplicit for "SSLImplicit"
            /// </summary>            
            SSLImplicit,
            
            /// <summary>
            /// Enum SSLAuto for "SSLAuto"
            /// </summary>            
            SSLAuto,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>            
            Auto            
        }

        /// <summary>
        /// Email account protocol type
        /// </summary>
        /// <value>Email account protocol type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolTypeEnum
        { 
            /// <summary>
            /// Enum IMAP for "IMAP"
            /// </summary>            
            IMAP,
            
            /// <summary>
            /// Enum POP3 for "POP3"
            /// </summary>            
            POP3,
            
            /// <summary>
            /// Enum SMTP for "SMTP"
            /// </summary>            
            SMTP,
            
            /// <summary>
            /// Enum EWS for "EWS"
            /// </summary>            
            EWS,
            
            /// <summary>
            /// Enum WebDav for "WebDav"
            /// </summary>            
            WebDav            
        }

        /// <summary>
        /// Email account security options
        /// </summary>
        public SecurityOptionsEnum? SecurityOptions { get; set; }

        /// <summary>
        /// Email account protocol type
        /// </summary>
        public ProtocolTypeEnum? ProtocolType { get; set; }

        /// <summary>
        /// Email account host
        /// </summary>  
        public string Host { get; set; }

        /// <summary>
        /// Email account port
        /// </summary>  
        public int? Port { get; set; }

        /// <summary>
        /// Email account login
        /// </summary>  
        public string Login { get; set; }

        /// <summary>
        /// Email account description
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// A storage file location info to store email account
        /// </summary>  
        public StorageFile StorageFile { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailAccountRequest {\n");
          sb.Append("  Host: ").Append(this.Host).Append("\n");
          sb.Append("  Port: ").Append(this.Port).Append("\n");
          sb.Append("  Login: ").Append(this.Login).Append("\n");
          sb.Append("  SecurityOptions: ").Append(this.SecurityOptions).Append("\n");
          sb.Append("  ProtocolType: ").Append(this.ProtocolType).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  StorageFile: ").Append(this.StorageFile).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
