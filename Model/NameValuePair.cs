// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NameValuePair.cs">
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
    /// An extended property.
    /// </summary>
    public class NameValuePair 
    {
        /// <summary>
        /// Name of the property 
        /// </summary>  
        public string Value { get; set; }

        /// <summary>
        /// Value of the property
        /// </summary>  
        public string Name { get; set; }

        /// <summary>NameValuePair constructor</summary>
        public NameValuePair() {}

        /// <summary>NameValuePair constructor</summary>
        /// <param name="value">Name of the property </param>
        /// <param name="name">Value of the property</param>
        public NameValuePair(string value, string name)
        {
            Value = value;
            Name = name;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class NameValuePair {\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
