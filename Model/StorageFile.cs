// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageFile.cs">
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
    /// File or folder information
    /// </summary>
    public class StorageFile 
    {
        /// <summary>
        /// File or folder name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// True if it is a folder.
        /// </summary>  
        public bool? IsFolder { get; set; }

        /// <summary>
        /// File or folder last modified DateTime.
        /// </summary>  
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// File or folder size.
        /// </summary>  
        public long? Size { get; set; }

        /// <summary>
        /// File or folder path.
        /// </summary>  
        public string Path { get; set; }

        /// <summary>StorageFile constructor</summary>
        public StorageFile() {}

        /// <summary>StorageFile constructor</summary>
        /// <param name="name">File or folder name.</param>
        /// <param name="isFolder">True if it is a folder.</param>
        /// <param name="modifiedDate">File or folder last modified DateTime.</param>
        /// <param name="size">File or folder size.</param>
        /// <param name="path">File or folder path.</param>
        public StorageFile(string name, bool? isFolder, DateTime? modifiedDate, long? size, string path)
        {
            Name = name;
            IsFolder = isFolder;
            ModifiedDate = modifiedDate;
            Size = size;
            Path = path;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StorageFile {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  IsFolder: ").Append(this.IsFolder).Append("\n");
          sb.Append("  ModifiedDate: ").Append(this.ModifiedDate).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  Path: ").Append(this.Path).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
