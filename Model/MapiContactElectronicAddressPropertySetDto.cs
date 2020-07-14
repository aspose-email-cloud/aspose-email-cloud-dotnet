// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactElectronicAddressPropertySetDto.cs">
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
    /// Specify properties for up to three different e-mail addresses (Email1, Email2, and Email3) and three different fax addresses (Primary Fax, Business Fax, and Home Fax)             
    /// </summary>
    public class MapiContactElectronicAddressPropertySetDto 
    {
        /// <summary>
        /// Refers to the group of properties that define the business fax address for a contact.
        /// </summary>  
        public MapiContactElectronicAddressDto BusinessFax { get; set; }

        /// <summary>
        /// Default value of electronic address Uses when user does not set any electronic address if UseAutocomplete property is set 'true'             
        /// </summary>  
        public MapiContactElectronicAddressDto DefaultEmailAddress { get; set; }

        /// <summary>
        /// Refers to the group of properties that define the first e-mail address for a contact.             
        /// </summary>  
        public MapiContactElectronicAddressDto Email1 { get; set; }

        /// <summary>
        /// Refers to the group of properties that define the second e-mail address for a contact.             
        /// </summary>  
        public MapiContactElectronicAddressDto Email2 { get; set; }

        /// <summary>
        /// Refers to the group of properties that define the third e-mail address for a contact.             
        /// </summary>  
        public MapiContactElectronicAddressDto Email3 { get; set; }

        /// <summary>
        /// Refers to the group of properties that define the home fax address for a contact.             
        /// </summary>  
        public MapiContactElectronicAddressDto HomeFax { get; set; }

        /// <summary>
        /// Shows if MapiContactElectronicAddressPropertySetDto is empty
        /// </summary>  
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Refers to the group of properties that define the primary fax address for a contact.             
        /// </summary>  
        public MapiContactElectronicAddressDto PrimaryFax { get; set; }

        /// <summary>
        /// Indicates that one electronic address is completed automatically in case if user does not set any electronic address             
        /// </summary>  
        public bool? UseAutocomplete { get; set; }

        /// <summary>MapiContactElectronicAddressPropertySetDto constructor</summary>
        public MapiContactElectronicAddressPropertySetDto() {}

        /// <summary>MapiContactElectronicAddressPropertySetDto constructor</summary>
        /// <param name="businessFax">Refers to the group of properties that define the business fax address for a contact.</param>
        /// <param name="defaultEmailAddress">Default value of electronic address Uses when user does not set any electronic address if UseAutocomplete property is set 'true'             </param>
        /// <param name="email1">Refers to the group of properties that define the first e-mail address for a contact.             </param>
        /// <param name="email2">Refers to the group of properties that define the second e-mail address for a contact.             </param>
        /// <param name="email3">Refers to the group of properties that define the third e-mail address for a contact.             </param>
        /// <param name="homeFax">Refers to the group of properties that define the home fax address for a contact.             </param>
        /// <param name="isEmpty">Shows if MapiContactElectronicAddressPropertySetDto is empty</param>
        /// <param name="primaryFax">Refers to the group of properties that define the primary fax address for a contact.             </param>
        /// <param name="useAutocomplete">Indicates that one electronic address is completed automatically in case if user does not set any electronic address             </param>
        public MapiContactElectronicAddressPropertySetDto(MapiContactElectronicAddressDto businessFax, MapiContactElectronicAddressDto defaultEmailAddress, MapiContactElectronicAddressDto email1, MapiContactElectronicAddressDto email2, MapiContactElectronicAddressDto email3, MapiContactElectronicAddressDto homeFax, bool? isEmpty, MapiContactElectronicAddressDto primaryFax, bool? useAutocomplete)
        {
            BusinessFax = businessFax;
            DefaultEmailAddress = defaultEmailAddress;
            Email1 = email1;
            Email2 = email2;
            Email3 = email3;
            HomeFax = homeFax;
            IsEmpty = isEmpty;
            PrimaryFax = primaryFax;
            UseAutocomplete = useAutocomplete;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactElectronicAddressPropertySetDto {\n");
          sb.Append("  BusinessFax: ").Append(this.BusinessFax).Append("\n");
          sb.Append("  DefaultEmailAddress: ").Append(this.DefaultEmailAddress).Append("\n");
          sb.Append("  Email1: ").Append(this.Email1).Append("\n");
          sb.Append("  Email2: ").Append(this.Email2).Append("\n");
          sb.Append("  Email3: ").Append(this.Email3).Append("\n");
          sb.Append("  HomeFax: ").Append(this.HomeFax).Append("\n");
          sb.Append("  IsEmpty: ").Append(this.IsEmpty).Append("\n");
          sb.Append("  PrimaryFax: ").Append(this.PrimaryFax).Append("\n");
          sb.Append("  UseAutocomplete: ").Append(this.UseAutocomplete).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
