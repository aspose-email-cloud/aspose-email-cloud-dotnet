// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiNameOptions.cs">
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
    /// AiName parser options             
    /// </summary>
    public class AiNameOptions 
    {
        /// <summary>
        /// An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \"it\" or \"ita\" for Italian)             
        /// </summary>  
        public string Language { get; set; }

        /// <summary>
        /// A geographic code such as an ISO-3166 two letter country code, for example \"FR\" for France             
        /// </summary>  
        public string Location { get; set; }

        /// <summary>
        /// A writing system code; starts with the ISO-15924 script name             
        /// </summary>  
        public string Script { get; set; }

        /// <summary>
        /// A character encoding name             
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Name writing style. Allowed values are: \"Formal\", \"Informal\", \"Legal\", \"Academic\"             
        /// </summary>  
        public string Style { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiNameOptions {\n");
          sb.Append("  Language: ").Append(this.Language).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  Script: ").Append(this.Script).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
