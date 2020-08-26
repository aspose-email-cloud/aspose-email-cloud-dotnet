// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarTimeZoneDto.cs">
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
    /// Represents the mapi calendar time zone information.             
    /// </summary>
    public class MapiCalendarTimeZoneDto 
    {
        /// <summary>
        /// Human-readable description of the time zone.             
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Time zone rules             
        /// </summary>
        public List<MapiCalendarTimeZoneInfoDto> TimeZoneRules { get; set; }


        /// <summary>MapiCalendarTimeZoneDto constructor</summary>
        public MapiCalendarTimeZoneDto() {}


        /// <summary>MapiCalendarTimeZoneDto constructor</summary>
        /// <param name="keyName">Human-readable description of the time zone.             </param>
        /// <param name="timeZoneRules">Time zone rules             </param>
        public MapiCalendarTimeZoneDto(
            string keyName,
            List<MapiCalendarTimeZoneInfoDto> timeZoneRules
        )
        { 
            KeyName = keyName;
            TimeZoneRules = timeZoneRules;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarTimeZoneDto {\n");
          sb.Append("  KeyName: ").Append(this.KeyName).Append("\n");
          sb.Append("  TimeZoneRules: ").Append(this.TimeZoneRules).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
