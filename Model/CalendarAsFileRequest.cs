// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarAsFileRequest.cs">
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
    /// iCalendar model to file request.             
    /// </summary>
    public class CalendarAsFileRequest 
    {
        /// <summary>
        /// Calendar file format Enum, available values: Ics, Msg
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// iCalendar model             
        /// </summary>  
        public CalendarDto Value { get; set; }

        /// <summary>CalendarAsFileRequest constructor</summary>
        public CalendarAsFileRequest() {}

        /// <summary>CalendarAsFileRequest constructor</summary>
        /// <param name="format">Calendar file format Enum, available values: Ics, Msg</param>
        /// <param name="value">iCalendar model             </param>
        public CalendarAsFileRequest(string format, CalendarDto value)
        {
            Format = format;
            Value = value;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CalendarAsFileRequest {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}