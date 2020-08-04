
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactPhysicalAddressPropertySetDto.cs">
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
    /// Specify three physical addresses: Home Address, Work Address, and Other Address. One of the addresses can be marked as the Mailing Address             
    /// </summary>
    public class MapiContactPhysicalAddressPropertySetDto 
    {
        /// <summary>
        /// Specifies the address of the contact's work             
        /// </summary>
        public MapiContactPhysicalAddressDto WorkAddress { get; set; }

        /// <summary>
        /// Specifies the address of the contact's home             
        /// </summary>
        public MapiContactPhysicalAddressDto HomeAddress { get; set; }

        /// <summary>
        /// Specifies the other contact's address             
        /// </summary>
        public MapiContactPhysicalAddressDto OtherAddress { get; set; }


        /// <summary>MapiContactPhysicalAddressPropertySetDto constructor</summary>
        public MapiContactPhysicalAddressPropertySetDto() {}


        /// <summary>MapiContactPhysicalAddressPropertySetDto constructor</summary>
        /// <param name="workAddress">Specifies the address of the contact's work             </param>
        /// <param name="homeAddress">Specifies the address of the contact's home             </param>
        /// <param name="otherAddress">Specifies the other contact's address             </param>
        public MapiContactPhysicalAddressPropertySetDto(
            MapiContactPhysicalAddressDto workAddress,
            MapiContactPhysicalAddressDto homeAddress,
            MapiContactPhysicalAddressDto otherAddress
        )
        { 
            WorkAddress = workAddress;
            HomeAddress = homeAddress;
            OtherAddress = otherAddress;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactPhysicalAddressPropertySetDto {\n");
          sb.Append("  WorkAddress: ").Append(this.WorkAddress).Append("\n");
          sb.Append("  HomeAddress: ").Append(this.HomeAddress).Append("\n");
          sb.Append("  OtherAddress: ").Append(this.OtherAddress).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
