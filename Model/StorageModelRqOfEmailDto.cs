// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageModelRqOfEmailDto.cs">
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
    public class StorageModelRqOfEmailDto 
    {
        /// <summary>
        /// Gets or sets Value
        /// </summary>  
        public EmailDto Value { get; set; }

        /// <summary>
        /// Gets or sets StorageFolder
        /// </summary>  
        public StorageFolderLocation StorageFolder { get; set; }

        /// <summary>StorageModelRqOfEmailDto constructor</summary>
        public StorageModelRqOfEmailDto() {}

        /// <summary>StorageModelRqOfEmailDto constructor</summary>
        /// <param name="value"></param>
        /// <param name="storageFolder"></param>
        public StorageModelRqOfEmailDto(EmailDto value, StorageFolderLocation storageFolder)
        {
            Value = value;
            StorageFolder = storageFolder;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StorageModelRqOfEmailDto {\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  StorageFolder: ").Append(this.StorageFolder).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}