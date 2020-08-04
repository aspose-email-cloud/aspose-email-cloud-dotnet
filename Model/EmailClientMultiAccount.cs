
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientMultiAccount.cs">
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
    /// Email client virtual account, which contains several accounts             
    /// </summary>
    public class EmailClientMultiAccount 
    {
        /// <summary>
        /// Email client receive accounts             
        /// </summary>
        public List<EmailClientAccount> ReceiveAccounts { get; set; }

        /// <summary>
        /// Email client send account             
        /// </summary>
        public EmailClientAccount SendAccount { get; set; }


        /// <summary>EmailClientMultiAccount constructor</summary>
        public EmailClientMultiAccount() {}


        /// <summary>EmailClientMultiAccount constructor</summary>
        /// <param name="receiveAccounts">Email client receive accounts             </param>
        /// <param name="sendAccount">Email client send account             </param>
        public EmailClientMultiAccount(
            List<EmailClientAccount> receiveAccounts,
            EmailClientAccount sendAccount
        )
        { 
            ReceiveAccounts = receiveAccounts;
            SendAccount = sendAccount;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailClientMultiAccount {\n");
          sb.Append("  ReceiveAccounts: ").Append(this.ReceiveAccounts).Append("\n");
          sb.Append("  SendAccount: ").Append(this.SendAccount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
