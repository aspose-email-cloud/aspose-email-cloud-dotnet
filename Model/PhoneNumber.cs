// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PhoneNumber.cs">
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
    /// A phone number.             
    /// </summary>
    public class PhoneNumber 
    {
        /// <summary>
        /// Phone number category.             
        /// </summary>  
        public EnumWithCustomOfPhoneNumberCategory Category { get; set; }

        /// <summary>
        /// Phone number.             
        /// </summary>  
        public string Number { get; set; }

        /// <summary>
        /// Defines whether phone number is preferred.             
        /// </summary>  
        public bool? Preferred { get; set; }

        /// <summary>PhoneNumber constructor</summary>
        public PhoneNumber() {}

        /// <summary>PhoneNumber constructor</summary>
        /// <param name="category">Phone number category.             </param>
        /// <param name="number">Phone number.             </param>
        /// <param name="preferred">Defines whether phone number is preferred.             </param>
        public PhoneNumber(EnumWithCustomOfPhoneNumberCategory category, string number, bool? preferred)
        {
            Category = category;
            Number = number;
            Preferred = preferred;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PhoneNumber {\n");
          sb.Append("  Category: ").Append(this.Category).Append("\n");
          sb.Append("  Number: ").Append(this.Number).Append("\n");
          sb.Append("  Preferred: ").Append(this.Preferred).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}