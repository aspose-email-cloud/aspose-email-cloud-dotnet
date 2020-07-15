// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiBcrBase64Image.cs">
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
    /// Image to recognize             
    /// </summary>
    public class AiBcrBase64Image : AiBcrImage 
    {
        /// <summary>
        /// Image data in base64             
        /// </summary>  
        public string Base64Data { get; set; }

        /// <summary>AiBcrBase64Image constructor</summary>
        public AiBcrBase64Image() {}

        /// <summary>AiBcrBase64Image constructor</summary>
        /// <param name="isSingle">Determines that image contains single VCard or more. Ignored in current version. Multiple cards on image support will be added soon             </param>
        /// <param name="base64Data">Image data in base64             </param>
        public AiBcrBase64Image(bool? isSingle, string base64Data)
        {
            IsSingle = isSingle;
            Base64Data = base64Data;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiBcrBase64Image {\n");
          sb.Append("  IsSingle: ").Append(this.IsSingle).Append("\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
