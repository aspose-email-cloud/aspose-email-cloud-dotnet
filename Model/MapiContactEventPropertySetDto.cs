// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactEventPropertySetDto.cs">
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
    /// Specify events associated with a contact.             
    /// </summary>
    public class MapiContactEventPropertySetDto 
    {
        /// <summary>
        /// Specifies the birthday of the contact.
        /// </summary>  
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Specifies the wedding anniversary of the contact.             
        /// </summary>  
        public DateTime? WeddingAnniversary { get; set; }

        /// <summary>MapiContactEventPropertySetDto constructor</summary>
        public MapiContactEventPropertySetDto() {}

        /// <summary>MapiContactEventPropertySetDto constructor</summary>
        /// <param name="birthday">Specifies the birthday of the contact.</param>
        /// <param name="weddingAnniversary">Specifies the wedding anniversary of the contact.             </param>
        public MapiContactEventPropertySetDto(DateTime? birthday, DateTime? weddingAnniversary)
        {
            Birthday = birthday;
            WeddingAnniversary = weddingAnniversary;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactEventPropertySetDto {\n");
          sb.Append("  Birthday: ").Append(this.Birthday).Append("\n");
          sb.Append("  WeddingAnniversary: ").Append(this.WeddingAnniversary).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}