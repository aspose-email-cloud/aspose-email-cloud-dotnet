// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiNameMismatch.cs">
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
    /// Names mismatch detailed description             
    /// </summary>
    public class AiNameMismatch 
    {
        /// <summary>
        /// Mismatch type. Enum, available values: Unknown, FirstName, MiddleName, MiddleLastName, MiddleNickname, Gender, Context
        /// </summary>  
        public string Category { get; set; }

        /// <summary>
        /// Similarity score             
        /// </summary>  
        public double? Similarity { get; set; }

        /// <summary>
        /// Explanation or mismatch subtype             
        /// </summary>  
        public string Explanation { get; set; }

        /// <summary>AiNameMismatch constructor</summary>
        public AiNameMismatch() {}

        /// <summary>AiNameMismatch constructor</summary>
        /// <param name="category">Mismatch type. Enum, available values: Unknown, FirstName, MiddleName, MiddleLastName, MiddleNickname, Gender, Context</param>
        /// <param name="similarity">Similarity score             </param>
        /// <param name="explanation">Explanation or mismatch subtype             </param>
        public AiNameMismatch(string category, double? similarity, string explanation)
        {
            Category = category;
            Similarity = similarity;
            Explanation = explanation;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiNameMismatch {\n");
          sb.Append("  Category: ").Append(this.Category).Append("\n");
          sb.Append("  Similarity: ").Append(this.Similarity).Append("\n");
          sb.Append("  Explanation: ").Append(this.Explanation).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
