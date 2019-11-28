// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiBcrOcrData.cs">
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
    /// Image OCR results             
    /// </summary>
    public class AiBcrOcrData 
    {
        /// <summary>
        /// Image identifier             
        /// </summary>  
        public string Id { get; set; }

        /// <summary>
        /// Image with possible pre-processing in Base64             
        /// </summary>  
        public string Image { get; set; }

        /// <summary>
        /// Additional details from OCR engine             
        /// </summary>  
        public Dictionary<string, string> Details { get; set; }

        /// <summary>
        /// OCR results             
        /// </summary>  
        public List<AiBcrOcrDataPart> Data { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiBcrOcrData {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Image: ").Append(this.Image).Append("\n");
          sb.Append("  Details: ").Append(this.Details).Append("\n");
          sb.Append("  Data: ").Append(this.Data).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
