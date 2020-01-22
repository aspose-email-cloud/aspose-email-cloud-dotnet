// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EnumWithCustomOfEmailAddressCategory.cs">
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
    /// 
    /// </summary>
    public class EnumWithCustomOfEmailAddressCategory 
    {
        /// <summary>
        /// Represents category for an email address. Enum, available values: Home, Work, Custom, Email1, Email2, Email3
        /// </summary>  
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>  
        public string Description { get; set; }

        /// <summary>EnumWithCustomOfEmailAddressCategory constructor</summary>
        public EnumWithCustomOfEmailAddressCategory() {}

        /// <summary>EnumWithCustomOfEmailAddressCategory constructor</summary>
        /// <param name="value">Represents category for an email address. Enum, available values: Home, Work, Custom, Email1, Email2, Email3</param>
        /// <param name="description"></param>
        public EnumWithCustomOfEmailAddressCategory(string value, string description)
        {
            Value = value;
            Description = description;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EnumWithCustomOfEmailAddressCategory {\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
