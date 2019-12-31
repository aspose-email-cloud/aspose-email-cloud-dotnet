// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageFileLocation.cs">
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
    /// A storage file location information             
    /// </summary>
    public class StorageFileLocation : StorageFolderLocation 
    {
        /// <summary>
        /// A file name in storage             
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>StorageFileLocation constructor</summary>
        public StorageFileLocation() {}

        /// <summary>StorageFileLocation constructor</summary>
        /// <param name="storage">A storage name             </param>
        /// <param name="folderPath">A path to a folder in specified storage             </param>
        /// <param name="fileName">A file name in storage             </param>
        public StorageFileLocation(string storage, string folderPath, string fileName)
        {
            Storage = storage;
            FolderPath = folderPath;
            FileName = fileName;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StorageFileLocation {\n");
          sb.Append("  Storage: ").Append(this.Storage).Append("\n");
          sb.Append("  FolderPath: ").Append(this.FolderPath).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
