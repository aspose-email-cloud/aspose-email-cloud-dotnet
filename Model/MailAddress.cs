// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MailAddress.cs">
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
    /// Represents the address of a message.
    /// </summary>
    public class MailAddress 
    {
        /// <summary>
        /// Display name             
        /// </summary>  
        public string DisplayName { get; set; }

        /// <summary>
        /// Address             
        /// </summary>  
        public string Address { get; set; }

        /// <summary>
        /// Identifies the participation status for the calendar user. Enum, available values: NeedsAction, Accepted, Declined, Tentative, Delegated
        /// </summary>  
        public string ParticipationStatus { get; set; }

        /// <summary>
        /// The original e-mail address string             
        /// </summary>  
        public string OriginalAddressString { get; set; }

        /// <summary>MailAddress constructor</summary>
        public MailAddress() {}

        /// <summary>MailAddress constructor</summary>
        /// <param name="displayName">Display name             </param>
        /// <param name="address">Address             </param>
        /// <param name="participationStatus">Identifies the participation status for the calendar user. Enum, available values: NeedsAction, Accepted, Declined, Tentative, Delegated</param>
        /// <param name="originalAddressString">The original e-mail address string             </param>
        public MailAddress(string displayName, string address, string participationStatus, string originalAddressString)
        {
            DisplayName = displayName;
            Address = address;
            ParticipationStatus = participationStatus;
            OriginalAddressString = originalAddressString;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MailAddress {\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  Address: ").Append(this.Address).Append("\n");
          sb.Append("  ParticipationStatus: ").Append(this.ParticipationStatus).Append("\n");
          sb.Append("  OriginalAddressString: ").Append(this.OriginalAddressString).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
