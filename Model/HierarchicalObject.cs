// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HierarchicalObject.cs">
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
    /// Objects&#39; properties hierarchical representation             
    /// </summary>
    public class HierarchicalObject : BaseObject 
    {
        /// <summary>
        /// List of internal properties             
        /// </summary>  
        public List<BaseObject> InternalProperties { get; set; }

        /// <summary>HierarchicalObject constructor</summary>
        public HierarchicalObject() {}

        /// <summary>HierarchicalObject constructor</summary>
        /// <param name="name">Gets or sets the name of an object.             </param>
        /// <param name="type">Property type. Used for deserialization purposes             </param>
        /// <param name="internalProperties">List of internal properties             </param>
        public HierarchicalObject(string name, string type, List<BaseObject> internalProperties)
        {
            Name = name;
            Type = type;
            InternalProperties = internalProperties;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HierarchicalObject {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  InternalProperties: ").Append(this.InternalProperties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
