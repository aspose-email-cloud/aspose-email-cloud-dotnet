// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailAddress.cs">
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
    /// Email address.             
    /// </summary>
    public class EmailAddress 
    {
        /// <summary>
        /// Address category.             
        /// </summary>
        public EnumWithCustomOfEmailAddressCategory Category { get; set; }

        /// <summary>
        /// Display name.             
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Defines whether email address is preferred.             
        /// </summary>
        public bool? Preferred { get; set; }

        /// <summary>
        /// A routing type for an email.             
        /// </summary>
        public string RoutingType { get; set; }

        /// <summary>
        /// Email address.             
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The original e-mail address string             
        /// </summary>
        public string OriginalAddressString { get; set; }


        /// <summary>EmailAddress constructor</summary>
        public EmailAddress() {}


        /// <summary>EmailAddress constructor</summary>
        /// <param name="category">Address category.             </param>
        /// <param name="displayName">Display name.             </param>
        /// <param name="preferred">Defines whether email address is preferred.             </param>
        /// <param name="routingType">A routing type for an email.             </param>
        /// <param name="address">Email address.             </param>
        /// <param name="originalAddressString">The original e-mail address string             </param>
        public EmailAddress(
            EnumWithCustomOfEmailAddressCategory category,
            string displayName,
            bool? preferred,
            string routingType,
            string address,
            string originalAddressString
        )
        { 
            Category = category;
            DisplayName = displayName;
            Preferred = preferred;
            RoutingType = routingType;
            Address = address;
            OriginalAddressString = originalAddressString;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailAddress {\n");
          sb.Append("  Category: ").Append(this.Category).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  Preferred: ").Append(this.Preferred).Append("\n");
          sb.Append("  RoutingType: ").Append(this.RoutingType).Append("\n");
          sb.Append("  Address: ").Append(this.Address).Append("\n");
          sb.Append("  OriginalAddressString: ").Append(this.OriginalAddressString).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
