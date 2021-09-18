// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiRecipientDto.cs">
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
    /// Represents the recipient information in the Microsoft Outlook Message.             
    /// </summary>
    public class MapiRecipientDto 
    {
        /// <summary>
        /// Email address of the message recipient or sender.             
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Type of the address of the message recipient or sender.             
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Display name of the message recipient or sender.             
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Represent the PR_RECIPIENT_TYPE property which contains the recipient type for a message recipient./nEnum, available values: Unknown, MapiBcc, MapiCc, MapiP1, MapiSubmitted, MapiTo
        /// </summary>
        public string RecipientType { get; set; }


        /// <summary>MapiRecipientDto constructor</summary>
        public MapiRecipientDto() {}


        /// <summary>MapiRecipientDto constructor</summary>
        /// <param name="emailAddress">Email address of the message recipient or sender.             </param>
        /// <param name="addressType">Type of the address of the message recipient or sender.             </param>
        /// <param name="displayName">Display name of the message recipient or sender.             </param>
        /// <param name="recipientType">Represent the PR_RECIPIENT_TYPE property which contains the recipient type for a message recipient./nEnum, available values: Unknown, MapiBcc, MapiCc, MapiP1, MapiSubmitted, MapiTo</param>
        public MapiRecipientDto(
            string emailAddress,
            string addressType,
            string displayName,
            string recipientType
        )
        { 
            EmailAddress = emailAddress;
            AddressType = addressType;
            DisplayName = displayName;
            RecipientType = recipientType;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiRecipientDto {\n");
          sb.Append("  EmailAddress: ").Append(this.EmailAddress).Append("\n");
          sb.Append("  AddressType: ").Append(this.AddressType).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  RecipientType: ").Append(this.RecipientType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
