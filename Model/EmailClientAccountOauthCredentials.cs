// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientAccountOauthCredentials.cs">
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
    /// Represents email client account OAuth 2.0 credentials             
    /// </summary>
    public class EmailClientAccountOauthCredentials : EmailClientAccountCredentials 
    {
        /// <summary>
        /// The client ID obtained from the Google Cloud Console during application registration.             
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The client secret obtained during application registration.             
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// OAuth 2.0 refresh token             
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// The url to obtain access token. If not specified, will try to discover from email client account host.             
        /// </summary>
        public string RequestUrl { get; set; }


        /// <summary>EmailClientAccountOauthCredentials constructor</summary>
        public EmailClientAccountOauthCredentials() {}


        /// <summary>EmailClientAccountOauthCredentials constructor</summary>
        /// <param name="login">Email client account login             </param>
        /// <param name="clientId">The client ID obtained from the Google Cloud Console during application registration.             </param>
        /// <param name="clientSecret">The client secret obtained during application registration.             </param>
        /// <param name="refreshToken">OAuth 2.0 refresh token             </param>
        /// <param name="requestUrl">The url to obtain access token. If not specified, will try to discover from email client account host.             </param>
        public EmailClientAccountOauthCredentials(
            string login
            ,
            string clientId,
            string clientSecret,
            string refreshToken,
            string requestUrl
        )
        { 
            Login = login;
            ClientId = clientId;
            ClientSecret = clientSecret;
            RefreshToken = refreshToken;
            RequestUrl = requestUrl;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailClientAccountOauthCredentials {\n");
          sb.Append("  Login: ").Append(this.Login).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  ClientId: ").Append(this.ClientId).Append("\n");
          sb.Append("  ClientSecret: ").Append(this.ClientSecret).Append("\n");
          sb.Append("  RefreshToken: ").Append(this.RefreshToken).Append("\n");
          sb.Append("  RequestUrl: ").Append(this.RequestUrl).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
