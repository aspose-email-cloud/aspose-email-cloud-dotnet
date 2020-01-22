// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ContactPhoto.cs">
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
    /// Person&#39;s photo.             
    /// </summary>
    public class ContactPhoto 
    {
        /// <summary>
        /// MapiContact photo image format. Enum, available values: Undefined, Jpeg, Gif, Wmf, Bmp, Tiff
        /// </summary>  
        public string PhotoImageFormat { get; set; }

        /// <summary>
        /// Photo serialized as base64 string.             
        /// </summary>  
        public string Base64Data { get; set; }

        /// <summary>ContactPhoto constructor</summary>
        public ContactPhoto() {}

        /// <summary>ContactPhoto constructor</summary>
        /// <param name="photoImageFormat">MapiContact photo image format. Enum, available values: Undefined, Jpeg, Gif, Wmf, Bmp, Tiff</param>
        /// <param name="base64Data">Photo serialized as base64 string.             </param>
        public ContactPhoto(string photoImageFormat, string base64Data)
        {
            PhotoImageFormat = photoImageFormat;
            Base64Data = base64Data;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ContactPhoto {\n");
          sb.Append("  PhotoImageFormat: ").Append(this.PhotoImageFormat).Append("\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
