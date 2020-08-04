
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ContentType.cs">
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
    /// Represents a Content-Type header.             
    /// </summary>
    public class ContentType 
    {
        /// <summary>
        /// The boundary parameter included in the Content-Type header.             
        /// </summary>
        public string Boundary { get; set; }

        /// <summary>
        /// CharSet parameter.             
        /// </summary>
        public string CharSet { get; set; }

        /// <summary>
        /// The internet media type.             
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// Name parameter.             
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Full list of parameters             
        /// </summary>
        public List<ContentTypeParameter> Parameters { get; set; }


        /// <summary>ContentType constructor</summary>
        public ContentType() {}


        /// <summary>ContentType constructor</summary>
        /// <param name="boundary">The boundary parameter included in the Content-Type header.             </param>
        /// <param name="charSet">CharSet parameter.             </param>
        /// <param name="mediaType">The internet media type.             </param>
        /// <param name="name">Name parameter.             </param>
        /// <param name="parameters">Full list of parameters             </param>
        public ContentType(
            string boundary,
            string charSet,
            string mediaType,
            string name,
            List<ContentTypeParameter> parameters
        )
        { 
            Boundary = boundary;
            CharSet = charSet;
            MediaType = mediaType;
            Name = name;
            Parameters = parameters;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ContentType {\n");
          sb.Append("  Boundary: ").Append(this.Boundary).Append("\n");
          sb.Append("  CharSet: ").Append(this.CharSet).Append("\n");
          sb.Append("  MediaType: ").Append(this.MediaType).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Parameters: ").Append(this.Parameters).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
