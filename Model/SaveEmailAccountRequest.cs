// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveEmailAccountRequest.cs">
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
    /// Save email account settings with login/password authentication request             
    /// </summary>
    public class SaveEmailAccountRequest : EmailAccountRequest 
    {
        /// <summary>
        /// Email account password             
        /// </summary>  
        public string Password { get; set; }

        /// <summary>SaveEmailAccountRequest constructor</summary>
        public SaveEmailAccountRequest() {}

        /// <summary>SaveEmailAccountRequest constructor</summary>
        /// <param name="host">Email account host             </param>
        /// <param name="port">Email account port             </param>
        /// <param name="login">Email account login             </param>
        /// <param name="securityOptions">Email account security mode Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto</param>
        /// <param name="protocolType">Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav</param>
        /// <param name="description">Email account description             </param>
        /// <param name="storageFile">A storage file location info to store email account             </param>
        /// <param name="password">Email account password             </param>
        public SaveEmailAccountRequest(string host, int? port, string login, string securityOptions, string protocolType, string description, StorageFileLocation storageFile, string password)
        {
            Host = host;
            Port = port;
            Login = login;
            SecurityOptions = securityOptions;
            ProtocolType = protocolType;
            Description = description;
            StorageFile = storageFile;
            Password = password;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveEmailAccountRequest {\n");
          sb.Append("  Host: ").Append(this.Host).Append("\n");
          sb.Append("  Port: ").Append(this.Port).Append("\n");
          sb.Append("  Login: ").Append(this.Login).Append("\n");
          sb.Append("  SecurityOptions: ").Append(this.SecurityOptions).Append("\n");
          sb.Append("  ProtocolType: ").Append(this.ProtocolType).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  StorageFile: ").Append(this.StorageFile).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
