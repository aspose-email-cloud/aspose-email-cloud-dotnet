// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailConfigDiscoverPasswordRequest.cs">
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
    /// 
    /// </summary>
    public class EmailConfigDiscoverPasswordRequest : DiscoverEmailConfigRequest 
    {
        /// <summary>
        /// Email account password.             
        /// </summary>
        public string Password { get; set; }


        /// <summary>EmailConfigDiscoverPasswordRequest constructor</summary>
        public EmailConfigDiscoverPasswordRequest() {}


        /// <summary>EmailConfigDiscoverPasswordRequest constructor</summary>
        /// <param name="address">Email address to discover.             </param>
        /// <param name="fastProcessing">Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned.             </param>
        /// <param name="login">Email account login. If not specified, address used as a login.             </param>
        /// <param name="password">Email account password.             </param>
        public EmailConfigDiscoverPasswordRequest(
            string address,
            bool? fastProcessing,
            string login,
            string password
        )
        { 
            Address = address;
            FastProcessing = fastProcessing;
            Login = login;
            Password = password;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailConfigDiscoverPasswordRequest {\n");
          sb.Append("  Address: ").Append(this.Address).Append("\n");
          sb.Append("  FastProcessing: ").Append(this.FastProcessing).Append("\n");
          sb.Append("  Login: ").Append(this.Login).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
