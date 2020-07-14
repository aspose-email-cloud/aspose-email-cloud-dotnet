// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarTimeZoneInfoDto.cs">
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
    /// Represents the mapi calendar time zone rule.             
    /// </summary>
    public class MapiCalendarTimeZoneInfoDto 
    {
        /// <summary>
        /// Time zone's offset in minutes from UTC.             
        /// </summary>  
        public int? Bias { get; set; }

        /// <summary>
        /// Offset in minutes from lBias during daylight saving time.             
        /// </summary>  
        public int? DaylightBias { get; set; }

        /// <summary>
        /// Date and local time that indicate when to begin using the DaylightBias.             
        /// </summary>  
        public MapiCalendarTimeZoneRuleDto DaylightDate { get; set; }

        /// <summary>
        /// Offset in minutes from lBias during standard time.             
        /// </summary>  
        public int? StandardBias { get; set; }

        /// <summary>
        /// Date and local time that indicate when to begin using the StandardBias.             
        /// </summary>  
        public MapiCalendarTimeZoneRuleDto StandardDate { get; set; }

        /// <summary>
        /// Individual bit flags that specify information about this TimeZoneRule.              Items: Enumerates the individual bit flags that specify information about TimeZoneRule Enum, available values: TzRuleFlagRecurCurrentTzReg, TzRuleFlagEffectiveTzReg
        /// </summary>  
        public List<string> TimeZoneFlags { get; set; }

        /// <summary>
        /// Year in which this rule is scheduled to take effect.             
        /// </summary>  
        public int? Year { get; set; }

        /// <summary>MapiCalendarTimeZoneInfoDto constructor</summary>
        public MapiCalendarTimeZoneInfoDto() {}

        /// <summary>MapiCalendarTimeZoneInfoDto constructor</summary>
        /// <param name="bias">Time zone's offset in minutes from UTC.             </param>
        /// <param name="daylightBias">Offset in minutes from lBias during daylight saving time.             </param>
        /// <param name="daylightDate">Date and local time that indicate when to begin using the DaylightBias.             </param>
        /// <param name="standardBias">Offset in minutes from lBias during standard time.             </param>
        /// <param name="standardDate">Date and local time that indicate when to begin using the StandardBias.             </param>
        /// <param name="timeZoneFlags">Individual bit flags that specify information about this TimeZoneRule.             </param>
        /// <param name="year">Year in which this rule is scheduled to take effect.             </param>
        public MapiCalendarTimeZoneInfoDto(int? bias, int? daylightBias, MapiCalendarTimeZoneRuleDto daylightDate, int? standardBias, MapiCalendarTimeZoneRuleDto standardDate, List<string> timeZoneFlags, int? year)
        {
            Bias = bias;
            DaylightBias = daylightBias;
            DaylightDate = daylightDate;
            StandardBias = standardBias;
            StandardDate = standardDate;
            TimeZoneFlags = timeZoneFlags;
            Year = year;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiCalendarTimeZoneInfoDto {\n");
          sb.Append("  Bias: ").Append(this.Bias).Append("\n");
          sb.Append("  DaylightBias: ").Append(this.DaylightBias).Append("\n");
          sb.Append("  DaylightDate: ").Append(this.DaylightDate).Append("\n");
          sb.Append("  StandardBias: ").Append(this.StandardBias).Append("\n");
          sb.Append("  StandardDate: ").Append(this.StandardDate).Append("\n");
          sb.Append("  TimeZoneFlags: ").Append(this.TimeZoneFlags).Append("\n");
          sb.Append("  Year: ").Append(this.Year).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
