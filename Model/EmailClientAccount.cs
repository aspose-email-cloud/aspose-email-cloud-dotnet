// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientAccount.cs">
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
    /// A universal email client account             
    /// </summary>
    public class EmailClientAccount 
    {
        /// <summary>
        /// Mail server host name or IP address             
        /// </summary>  
        public string Host { get; set; }

        /// <summary>
        /// Mail server port             
        /// </summary>  
        public int? Port { get; set; }

        /// <summary>
        /// Email account security mode Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto
        /// </summary>  
        public string SecurityOptions { get; set; }

        /// <summary>
        /// Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav
        /// </summary>  
        public string ProtocolType { get; set; }

        /// <summary>
        /// Email client account credentials             
        /// </summary>  
        public EmailClientAccountCredentials Credentials { get; set; }

        /// <summary>EmailClientAccount constructor</summary>
        public EmailClientAccount() {}

        /// <summary>EmailClientAccount constructor</summary>
        /// <param name="host">Mail server host name or IP address             </param>
        /// <param name="port">Mail server port             </param>
        /// <param name="securityOptions">Email account security mode Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto</param>
        /// <param name="protocolType">Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav</param>
        /// <param name="credentials">Email client account credentials             </param>
        public EmailClientAccount(string host, int? port, string securityOptions, string protocolType, EmailClientAccountCredentials credentials)
        {
            Host = host;
            Port = port;
            SecurityOptions = securityOptions;
            ProtocolType = protocolType;
            Credentials = credentials;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailClientAccount {\n");
          sb.Append("  Host: ").Append(this.Host).Append("\n");
          sb.Append("  Port: ").Append(this.Port).Append("\n");
          sb.Append("  SecurityOptions: ").Append(this.SecurityOptions).Append("\n");
          sb.Append("  ProtocolType: ").Append(this.ProtocolType).Append("\n");
          sb.Append("  Credentials: ").Append(this.Credentials).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
