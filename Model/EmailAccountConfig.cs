// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailAccountConfig.cs">
//   Copyright (c) 2016-2023 Aspose.Email for Cloud
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
    /// Email account configuration.             
    /// </summary>
    public class EmailAccountConfig 
    {
        /// <summary>
        /// Email account display name             
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav
        /// </summary>
        public string ProtocolType { get; set; }

        /// <summary>
        /// Email account host.             
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port.             
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Email account security mode. Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto
        /// </summary>
        public string SocketType { get; set; }

        /// <summary>
        /// Supported authentication types.              Items: Email account authentication types. Enum, available values: NoAuth, OAuth2, PasswordCleartext, PasswordEncrypted, SmtpAfterPop, ClientIpAddress
        /// </summary>
        public List<string> AuthenticationTypes { get; set; }

        /// <summary>
        /// Extra account information.             
        /// </summary>
        public List<NameValuePair> ExtraInfo { get; set; }

        /// <summary>
        /// Determines that configuration validated. Set to false if validation skipped.             
        /// </summary>
        public bool? IsValidated { get; set; }


        /// <summary>EmailAccountConfig constructor</summary>
        public EmailAccountConfig() {}


        /// <summary>EmailAccountConfig constructor</summary>
        /// <param name="displayName">Email account display name             </param>
        /// <param name="protocolType">Type of connection protocol. Enum, available values: IMAP, POP3, SMTP, EWS, WebDav</param>
        /// <param name="host">Email account host.             </param>
        /// <param name="port">Port.             </param>
        /// <param name="socketType">Email account security mode. Enum, available values: None, SSLExplicit, SSLImplicit, SSLAuto, Auto</param>
        /// <param name="authenticationTypes">Supported authentication types.             </param>
        /// <param name="extraInfo">Extra account information.             </param>
        /// <param name="isValidated">Determines that configuration validated. Set to false if validation skipped.             </param>
        public EmailAccountConfig(
            string displayName,
            string protocolType,
            string host,
            int? port,
            string socketType,
            List<string> authenticationTypes,
            List<NameValuePair> extraInfo,
            bool? isValidated
        )
        { 
            DisplayName = displayName;
            ProtocolType = protocolType;
            Host = host;
            Port = port;
            SocketType = socketType;
            AuthenticationTypes = authenticationTypes;
            ExtraInfo = extraInfo;
            IsValidated = isValidated;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailAccountConfig {\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  ProtocolType: ").Append(this.ProtocolType).Append("\n");
          sb.Append("  Host: ").Append(this.Host).Append("\n");
          sb.Append("  Port: ").Append(this.Port).Append("\n");
          sb.Append("  SocketType: ").Append(this.SocketType).Append("\n");
          sb.Append("  AuthenticationTypes: ").Append(this.AuthenticationTypes).Append("\n");
          sb.Append("  ExtraInfo: ").Append(this.ExtraInfo).Append("\n");
          sb.Append("  IsValidated: ").Append(this.IsValidated).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
