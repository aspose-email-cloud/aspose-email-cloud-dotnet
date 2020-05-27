// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarDtoAlternateRq.cs">
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
    /// iCalendar document as AlternateView request             
    /// </summary>
    public class CalendarDtoAlternateRq 
    {
        /// <summary>
        /// iCalendar document model             
        /// </summary>  
        public CalendarDto Value { get; set; }

        /// <summary>
        /// iCalendar actions. Enum, available values: Create, Update, Cancel
        /// </summary>  
        public string Action { get; set; }

        /// <summary>
        /// iCalendar sequence id             
        /// </summary>  
        public string SequenceId { get; set; }

        /// <summary>CalendarDtoAlternateRq constructor</summary>
        public CalendarDtoAlternateRq() {}

        /// <summary>CalendarDtoAlternateRq constructor</summary>
        /// <param name="value">iCalendar document model             </param>
        /// <param name="action">iCalendar actions. Enum, available values: Create, Update, Cancel</param>
        /// <param name="sequenceId">iCalendar sequence id             </param>
        public CalendarDtoAlternateRq(CalendarDto value, string action, string sequenceId)
        {
            Value = value;
            Action = action;
            SequenceId = sequenceId;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CalendarDtoAlternateRq {\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  Action: ").Append(this.Action).Append("\n");
          sb.Append("  SequenceId: ").Append(this.SequenceId).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
