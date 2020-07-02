// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiResponseTypePropertyDto.cs">
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
    /// Mapi property with response type value             
    /// </summary>
    public class MapiResponseTypePropertyDto : MapiPropertyDto 
    {
        /// <summary>
        /// Represents the types of recipient responses that are received for a meeting. Enum, available values: Unknown, Organizer, Tentative, Accept, Decline, NoResponseReceived
        /// </summary>  
        public string Value { get; set; }

        /// <summary>MapiResponseTypePropertyDto constructor</summary>
        public MapiResponseTypePropertyDto() {}

        /// <summary>MapiResponseTypePropertyDto constructor</summary>
        /// <param name="descriptor">Property descriptor             </param>
        /// <param name="discriminator"></param>
        /// <param name="value">Represents the types of recipient responses that are received for a meeting. Enum, available values: Unknown, Organizer, Tentative, Accept, Decline, NoResponseReceived</param>
        public MapiResponseTypePropertyDto(MapiPropertyDescriptor descriptor, string discriminator, string value)
        {
            Descriptor = descriptor;
            Discriminator = discriminator;
            Value = value;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiResponseTypePropertyDto {\n");
          sb.Append("  Descriptor: ").Append(this.Descriptor).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}