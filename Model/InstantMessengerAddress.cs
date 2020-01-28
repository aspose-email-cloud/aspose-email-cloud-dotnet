// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InstantMessengerAddress.cs">
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
    /// Instant messenger address.             
    /// </summary>
    public class InstantMessengerAddress 
    {
        /// <summary>
        /// Address category.             
        /// </summary>  
        public EnumWithCustomOfInstantMessengerCategory Category { get; set; }

        /// <summary>
        /// Address.             
        /// </summary>  
        public string Address { get; set; }

        /// <summary>
        /// Determines whether this address is preferred.             
        /// </summary>  
        public bool? Preferred { get; set; }

        /// <summary>InstantMessengerAddress constructor</summary>
        public InstantMessengerAddress() {}

        /// <summary>InstantMessengerAddress constructor</summary>
        /// <param name="category">Address category.             </param>
        /// <param name="address">Address.             </param>
        /// <param name="preferred">Determines whether this address is preferred.             </param>
        public InstantMessengerAddress(EnumWithCustomOfInstantMessengerCategory category, string address, bool? preferred)
        {
            Category = category;
            Address = address;
            Preferred = preferred;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class InstantMessengerAddress {\n");
          sb.Append("  Category: ").Append(this.Category).Append("\n");
          sb.Append("  Address: ").Append(this.Address).Append("\n");
          sb.Append("  Preferred: ").Append(this.Preferred).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
