// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactPhysicalAddressDto.cs">
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
    /// Refers to the group of properties that define physical address for a contact.             
    /// </summary>
    public class MapiContactPhysicalAddressDto 
    {
        /// <summary>
        /// Gets or sets a value indicating whether this address is mailing address             
        /// </summary>
        public bool? IsMailingAddress { get; set; }

        /// <summary>
        /// Specifies the street portion of the contact's address             
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Specifies the city or locality portion of the contact's address             
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Specifies the state or province portion of the contact's address             
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Specifies the postal code (ZIP code) portion of the contact's address             
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Specifies the country or region portion of the contact's address             
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Specifies the country code portion of the contact's address             
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Specifies the complete address of the contact's address             
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the post office box             
        /// </summary>
        public string PostOfficeBox { get; set; }


        /// <summary>MapiContactPhysicalAddressDto constructor</summary>
        public MapiContactPhysicalAddressDto() {}


        /// <summary>MapiContactPhysicalAddressDto constructor</summary>
        /// <param name="isMailingAddress">Gets or sets a value indicating whether this address is mailing address             </param>
        /// <param name="street">Specifies the street portion of the contact's address             </param>
        /// <param name="city">Specifies the city or locality portion of the contact's address             </param>
        /// <param name="stateOrProvince">Specifies the state or province portion of the contact's address             </param>
        /// <param name="postalCode">Specifies the postal code (ZIP code) portion of the contact's address             </param>
        /// <param name="country">Specifies the country or region portion of the contact's address             </param>
        /// <param name="countryCode">Specifies the country code portion of the contact's address             </param>
        /// <param name="address">Specifies the complete address of the contact's address             </param>
        /// <param name="postOfficeBox">Gets or sets the post office box             </param>
        public MapiContactPhysicalAddressDto(
            bool? isMailingAddress,
            string street,
            string city,
            string stateOrProvince,
            string postalCode,
            string country,
            string countryCode,
            string address,
            string postOfficeBox
        )
        { 
            IsMailingAddress = isMailingAddress;
            Street = street;
            City = city;
            StateOrProvince = stateOrProvince;
            PostalCode = postalCode;
            Country = country;
            CountryCode = countryCode;
            Address = address;
            PostOfficeBox = postOfficeBox;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactPhysicalAddressDto {\n");
          sb.Append("  IsMailingAddress: ").Append(this.IsMailingAddress).Append("\n");
          sb.Append("  Street: ").Append(this.Street).Append("\n");
          sb.Append("  City: ").Append(this.City).Append("\n");
          sb.Append("  StateOrProvince: ").Append(this.StateOrProvince).Append("\n");
          sb.Append("  PostalCode: ").Append(this.PostalCode).Append("\n");
          sb.Append("  Country: ").Append(this.Country).Append("\n");
          sb.Append("  CountryCode: ").Append(this.CountryCode).Append("\n");
          sb.Append("  Address: ").Append(this.Address).Append("\n");
          sb.Append("  PostOfficeBox: ").Append(this.PostOfficeBox).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
