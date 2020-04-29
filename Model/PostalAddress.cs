// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostalAddress.cs">
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
    /// A postal address             
    /// </summary>
    public class PostalAddress 
    {
        /// <summary>
        /// Address.             
        /// </summary>  
        public string Address { get; set; }

        /// <summary>
        /// Address category.             
        /// </summary>  
        public EnumWithCustomOfPostalAddressCategory Category { get; set; }

        /// <summary>
        /// Address's city.             
        /// </summary>  
        public string City { get; set; }

        /// <summary>
        /// Address's country.             
        /// </summary>  
        public string Country { get; set; }

        /// <summary>
        /// Country code.             
        /// </summary>  
        public string CountryCode { get; set; }

        /// <summary>
        /// Defines whether address may be used for mailing.             
        /// </summary>  
        public bool? IsMailingAddress { get; set; }

        /// <summary>
        /// Postal code.             
        /// </summary>  
        public string PostalCode { get; set; }

        /// <summary>
        /// Post Office box.             
        /// </summary>  
        public string PostOfficeBox { get; set; }

        /// <summary>
        /// Defines whether postal address is preferred.             
        /// </summary>  
        public bool? Preferred { get; set; }

        /// <summary>
        /// Address's region.             
        /// </summary>  
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Address's street.             
        /// </summary>  
        public string Street { get; set; }

        /// <summary>PostalAddress constructor</summary>
        public PostalAddress() {}

        /// <summary>PostalAddress constructor</summary>
        /// <param name="address">Address.             </param>
        /// <param name="category">Address category.             </param>
        /// <param name="city">Address's city.             </param>
        /// <param name="country">Address's country.             </param>
        /// <param name="countryCode">Country code.             </param>
        /// <param name="isMailingAddress">Defines whether address may be used for mailing.             </param>
        /// <param name="postalCode">Postal code.             </param>
        /// <param name="postOfficeBox">Post Office box.             </param>
        /// <param name="preferred">Defines whether postal address is preferred.             </param>
        /// <param name="stateOrProvince">Address's region.             </param>
        /// <param name="street">Address's street.             </param>
        public PostalAddress(string address, EnumWithCustomOfPostalAddressCategory category, string city, string country, string countryCode, bool? isMailingAddress, string postalCode, string postOfficeBox, bool? preferred, string stateOrProvince, string street)
        {
            Address = address;
            Category = category;
            City = city;
            Country = country;
            CountryCode = countryCode;
            IsMailingAddress = isMailingAddress;
            PostalCode = postalCode;
            PostOfficeBox = postOfficeBox;
            Preferred = preferred;
            StateOrProvince = stateOrProvince;
            Street = street;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PostalAddress {\n");
          sb.Append("  Address: ").Append(this.Address).Append("\n");
          sb.Append("  Category: ").Append(this.Category).Append("\n");
          sb.Append("  City: ").Append(this.City).Append("\n");
          sb.Append("  Country: ").Append(this.Country).Append("\n");
          sb.Append("  CountryCode: ").Append(this.CountryCode).Append("\n");
          sb.Append("  IsMailingAddress: ").Append(this.IsMailingAddress).Append("\n");
          sb.Append("  PostalCode: ").Append(this.PostalCode).Append("\n");
          sb.Append("  PostOfficeBox: ").Append(this.PostOfficeBox).Append("\n");
          sb.Append("  Preferred: ").Append(this.Preferred).Append("\n");
          sb.Append("  StateOrProvince: ").Append(this.StateOrProvince).Append("\n");
          sb.Append("  Street: ").Append(this.Street).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
