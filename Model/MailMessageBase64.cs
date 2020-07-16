// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MailMessageBase64.cs">
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
    /// Email message represented as file, encoded to Base64 format.             
    /// </summary>
    public class MailMessageBase64 : MailMessageBase 
    {
        /// <summary>
        /// Email message file data encoded to Base64 string.             
        /// </summary>  
        public string ValueBase64 { get; set; }

        /// <summary>
        /// Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef
        /// </summary>  
        public string Format { get; set; }

        /// <summary>MailMessageBase64 constructor</summary>
        public MailMessageBase64() {}

        /// <summary>MailMessageBase64 constructor</summary>
        /// <param name="discriminator"></param>
        /// <param name="valueBase64">Email message file data encoded to Base64 string.             </param>
        /// <param name="format">Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef</param>
        public MailMessageBase64(string discriminator, string valueBase64, string format)
        {
            Discriminator = discriminator;
            ValueBase64 = valueBase64;
            Format = format;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MailMessageBase64 {\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  ValueBase64: ").Append(this.ValueBase64).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}