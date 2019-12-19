// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateFolderBaseRequest.cs">
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
    /// Create folder request             
    /// </summary>
    public class CreateFolderBaseRequest : AccountBaseRequest 
    {
        /// <summary>
        /// Folder name             
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Parent folder path             
        /// </summary>  
        public string ParentFolder { get; set; }

        /// <summary>CreateFolderBaseRequest constructor</summary>
        public CreateFolderBaseRequest() {}

        /// <summary>CreateFolderBaseRequest constructor</summary>
        /// <param name="firstAccount">First account storage file name for receiving emails (or universal one)             </param>
        /// <param name="secondAccount">Second account storage file name for sending emails (ignored if first is universal)             </param>
        /// <param name="storageFolder">Storage folder location of account files             </param>
        /// <param name="folder">Folder name             </param>
        /// <param name="parentFolder">Parent folder path             </param>
        public CreateFolderBaseRequest(string firstAccount, string secondAccount, StorageFolderLocation storageFolder, string folder, string parentFolder)
        {
            FirstAccount = firstAccount;
            SecondAccount = secondAccount;
            StorageFolder = storageFolder;
            Folder = folder;
            ParentFolder = parentFolder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CreateFolderBaseRequest {\n");
          sb.Append("  FirstAccount: ").Append(this.FirstAccount).Append("\n");
          sb.Append("  SecondAccount: ").Append(this.SecondAccount).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("  Folder: ").Append(this.Folder).Append("\n");
          sb.Append("  ParentFolder: ").Append(this.ParentFolder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
