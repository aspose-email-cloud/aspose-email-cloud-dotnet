// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiBcrParseStorageRq.cs">
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
    /// Parse business card images from Storage request             
    /// </summary>
    public class AiBcrParseStorageRq : AiBcrStorageImageRq 
    {
        /// <summary>
        /// Parse output folder location on storage             
        /// </summary>  
        public StorageFolderLocation OutFolder { get; set; }

        /// <summary>AiBcrParseStorageRq constructor</summary>
        public AiBcrParseStorageRq() {}

        /// <summary>AiBcrParseStorageRq constructor</summary>
        /// <param name="options">Recognition options             </param>
        /// <param name="images">List of images with business cards             </param>
        /// <param name="outFolder">Parse output folder location on storage             </param>
        public AiBcrParseStorageRq(AiBcrOptions options, List<AiBcrImageStorageFile> images, StorageFolderLocation outFolder)
        {
            Options = options;
            Images = images;
            OutFolder = outFolder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiBcrParseStorageRq {\n");
          sb.Append("  Options: ").Append(this.Options).Append("\n");
          sb.Append("  Images: ").Append(this.Images).Append("\n");
          sb.Append("  OutFolder: ").Append(this.OutFolder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
