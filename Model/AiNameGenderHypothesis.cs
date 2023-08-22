// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiNameGenderHypothesis.cs">
//   Copyright (c) 2016-2023 Aspose.Email for Cloud
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
    /// Name gender hypothesis             
    /// </summary>
    public class AiNameGenderHypothesis 
    {
        /// <summary>
        /// Recognized name gender. Enum, available values: Male, Female, Unknown
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Hypothesis score             
        /// </summary>
        public double? Score { get; set; }


        /// <summary>AiNameGenderHypothesis constructor</summary>
        public AiNameGenderHypothesis() {}


        /// <summary>AiNameGenderHypothesis constructor</summary>
        /// <param name="gender">Recognized name gender. Enum, available values: Male, Female, Unknown</param>
        /// <param name="score">Hypothesis score             </param>
        public AiNameGenderHypothesis(
            string gender,
            double? score
        )
        { 
            Gender = gender;
            Score = score;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiNameGenderHypothesis {\n");
          sb.Append("  Gender: ").Append(this.Gender).Append("\n");
          sb.Append("  Score: ").Append(this.Score).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
