// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiElectronicAddressDto.cs">
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
    /// Refers to the group of properties that define the e-mail address or fax address.             
    /// </summary>
    public class MapiElectronicAddressDto 
    {
        /// <summary>
        /// Address type.             
        /// </summary>  
        public string AddressType { get; set; }

        /// <summary>
        /// Email address.             
        /// </summary>  
        public string EmailAddress { get; set; }

        /// <summary>
        /// User-readable display name for the e-mail address.             
        /// </summary>  
        public string DisplayName { get; set; }

        /// <summary>
        /// Telephone number of the mail user's primary fax machine.             
        /// </summary>  
        public string FaxNumber { get; set; }

        /// <summary>
        /// SMTP e-mail address that  corresponds to the e-mail address.             
        /// </summary>  
        public string OriginalDisplayName { get; set; }

        /// <summary>MapiElectronicAddressDto constructor</summary>
        public MapiElectronicAddressDto() {}

        /// <summary>MapiElectronicAddressDto constructor</summary>
        /// <param name="addressType">Address type.             </param>
        /// <param name="emailAddress">Email address.             </param>
        /// <param name="displayName">User-readable display name for the e-mail address.             </param>
        /// <param name="faxNumber">Telephone number of the mail user's primary fax machine.             </param>
        /// <param name="originalDisplayName">SMTP e-mail address that  corresponds to the e-mail address.             </param>
        public MapiElectronicAddressDto(string addressType, string emailAddress, string displayName, string faxNumber, string originalDisplayName)
        {
            AddressType = addressType;
            EmailAddress = emailAddress;
            DisplayName = displayName;
            FaxNumber = faxNumber;
            OriginalDisplayName = originalDisplayName;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiElectronicAddressDto {\n");
          sb.Append("  AddressType: ").Append(this.AddressType).Append("\n");
          sb.Append("  EmailAddress: ").Append(this.EmailAddress).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  FaxNumber: ").Append(this.FaxNumber).Append("\n");
          sb.Append("  OriginalDisplayName: ").Append(this.OriginalDisplayName).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
