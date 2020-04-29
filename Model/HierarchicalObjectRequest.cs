// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HierarchicalObjectRequest.cs">
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
    /// Object represented as hierarchical properties request             
    /// </summary>
    public class HierarchicalObjectRequest 
    {
        /// <summary>
        /// Hierarchical properties of document             
        /// </summary>  
        public HierarchicalObject HierarchicalObject { get; set; }

        /// <summary>
        /// Document location in storage             
        /// </summary>  
        public StorageFolderLocation StorageFolder { get; set; }

        /// <summary>HierarchicalObjectRequest constructor</summary>
        public HierarchicalObjectRequest() {}

        /// <summary>HierarchicalObjectRequest constructor</summary>
        /// <param name="hierarchicalObject">Hierarchical properties of document             </param>
        /// <param name="storageFolder">Document location in storage             </param>
        public HierarchicalObjectRequest(HierarchicalObject hierarchicalObject, StorageFolderLocation storageFolder)
        {
            HierarchicalObject = hierarchicalObject;
            StorageFolder = storageFolder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HierarchicalObjectRequest {\n");
          sb.Append("  HierarchicalObject: ").Append(this.HierarchicalObject).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
