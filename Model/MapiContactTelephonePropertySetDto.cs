// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactTelephonePropertySetDto.cs">
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
    /// Specify optional telephone numbers for the contact.             
    /// </summary>
    public class MapiContactTelephonePropertySetDto 
    {
        /// <summary>
        /// Shows if MapiContactTelephonePropertySet is empty             
        /// </summary>  
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Default value of electronic address Uses when user does not set any electronic address if UseAutocomplete property is set 'true'             
        /// </summary>  
        public string DefaultTelephoneNumber { get; set; }

        /// <summary>
        /// Indicates that one electronic address is completed automatically in case if user does not set any electronic address             
        /// </summary>  
        public bool? UseAutocomplete { get; set; }

        /// <summary>
        /// Gets or sets the callback telephone number             
        /// </summary>  
        public string CallbackTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the business telephone number             
        /// </summary>  
        public string BusinessTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the home telephone number             
        /// </summary>  
        public string HomeTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the primary telephone number             
        /// </summary>  
        public string PrimaryTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the second business telephone number             
        /// </summary>  
        public string Business2TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the mobile telephone number             
        /// </summary>  
        public string MobileTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the radio telephone number             
        /// </summary>  
        public string RadioTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the car telephone number             
        /// </summary>  
        public string CarTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets an alternate telephone number             
        /// </summary>  
        public string OtherTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the telephone number of the contact's assistant             
        /// </summary>  
        public string AssistantTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a second home telephone number             
        /// </summary>  
        public string Home2TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the telephone number for the contact's text telephone (TTY) or telecommunication device for the deaf (TDD)             
        /// </summary>  
        public string TtyTddPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the company phone number             
        /// </summary>  
        public string CompanyMainTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the telex number             
        /// </summary>  
        public string TelexNumber { get; set; }

        /// <summary>
        /// Gets or sets the integrated services digital network (ISDN) number             
        /// </summary>  
        public string IsdnNumber { get; set; }

        /// <summary>
        /// Gets or sets a pager telephone number             
        /// </summary>  
        public string PagerTelephoneNumber { get; set; }

        /// <summary>MapiContactTelephonePropertySetDto constructor</summary>
        public MapiContactTelephonePropertySetDto() {}

        /// <summary>MapiContactTelephonePropertySetDto constructor</summary>
        /// <param name="isEmpty">Shows if MapiContactTelephonePropertySet is empty             </param>
        /// <param name="defaultTelephoneNumber">Default value of electronic address Uses when user does not set any electronic address if UseAutocomplete property is set 'true'             </param>
        /// <param name="useAutocomplete">Indicates that one electronic address is completed automatically in case if user does not set any electronic address             </param>
        /// <param name="callbackTelephoneNumber">Gets or sets the callback telephone number             </param>
        /// <param name="businessTelephoneNumber">Gets or sets the business telephone number             </param>
        /// <param name="homeTelephoneNumber">Gets or sets the home telephone number             </param>
        /// <param name="primaryTelephoneNumber">Gets or sets the primary telephone number             </param>
        /// <param name="business2TelephoneNumber">Gets or sets the second business telephone number             </param>
        /// <param name="mobileTelephoneNumber">Gets or sets the mobile telephone number             </param>
        /// <param name="radioTelephoneNumber">Gets or sets the radio telephone number             </param>
        /// <param name="carTelephoneNumber">Gets or sets the car telephone number             </param>
        /// <param name="otherTelephoneNumber">Gets or sets an alternate telephone number             </param>
        /// <param name="assistantTelephoneNumber">Gets or sets the telephone number of the contact's assistant             </param>
        /// <param name="home2TelephoneNumber">Gets or sets a second home telephone number             </param>
        /// <param name="ttyTddPhoneNumber">Gets or sets the telephone number for the contact's text telephone (TTY) or telecommunication device for the deaf (TDD)             </param>
        /// <param name="companyMainTelephoneNumber">Gets or sets the company phone number             </param>
        /// <param name="telexNumber">Gets or sets the telex number             </param>
        /// <param name="isdnNumber">Gets or sets the integrated services digital network (ISDN) number             </param>
        /// <param name="pagerTelephoneNumber">Gets or sets a pager telephone number             </param>
        public MapiContactTelephonePropertySetDto(bool? isEmpty, string defaultTelephoneNumber, bool? useAutocomplete, string callbackTelephoneNumber, string businessTelephoneNumber, string homeTelephoneNumber, string primaryTelephoneNumber, string business2TelephoneNumber, string mobileTelephoneNumber, string radioTelephoneNumber, string carTelephoneNumber, string otherTelephoneNumber, string assistantTelephoneNumber, string home2TelephoneNumber, string ttyTddPhoneNumber, string companyMainTelephoneNumber, string telexNumber, string isdnNumber, string pagerTelephoneNumber)
        {
            IsEmpty = isEmpty;
            DefaultTelephoneNumber = defaultTelephoneNumber;
            UseAutocomplete = useAutocomplete;
            CallbackTelephoneNumber = callbackTelephoneNumber;
            BusinessTelephoneNumber = businessTelephoneNumber;
            HomeTelephoneNumber = homeTelephoneNumber;
            PrimaryTelephoneNumber = primaryTelephoneNumber;
            Business2TelephoneNumber = business2TelephoneNumber;
            MobileTelephoneNumber = mobileTelephoneNumber;
            RadioTelephoneNumber = radioTelephoneNumber;
            CarTelephoneNumber = carTelephoneNumber;
            OtherTelephoneNumber = otherTelephoneNumber;
            AssistantTelephoneNumber = assistantTelephoneNumber;
            Home2TelephoneNumber = home2TelephoneNumber;
            TtyTddPhoneNumber = ttyTddPhoneNumber;
            CompanyMainTelephoneNumber = companyMainTelephoneNumber;
            TelexNumber = telexNumber;
            IsdnNumber = isdnNumber;
            PagerTelephoneNumber = pagerTelephoneNumber;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactTelephonePropertySetDto {\n");
          sb.Append("  IsEmpty: ").Append(this.IsEmpty).Append("\n");
          sb.Append("  DefaultTelephoneNumber: ").Append(this.DefaultTelephoneNumber).Append("\n");
          sb.Append("  UseAutocomplete: ").Append(this.UseAutocomplete).Append("\n");
          sb.Append("  CallbackTelephoneNumber: ").Append(this.CallbackTelephoneNumber).Append("\n");
          sb.Append("  BusinessTelephoneNumber: ").Append(this.BusinessTelephoneNumber).Append("\n");
          sb.Append("  HomeTelephoneNumber: ").Append(this.HomeTelephoneNumber).Append("\n");
          sb.Append("  PrimaryTelephoneNumber: ").Append(this.PrimaryTelephoneNumber).Append("\n");
          sb.Append("  Business2TelephoneNumber: ").Append(this.Business2TelephoneNumber).Append("\n");
          sb.Append("  MobileTelephoneNumber: ").Append(this.MobileTelephoneNumber).Append("\n");
          sb.Append("  RadioTelephoneNumber: ").Append(this.RadioTelephoneNumber).Append("\n");
          sb.Append("  CarTelephoneNumber: ").Append(this.CarTelephoneNumber).Append("\n");
          sb.Append("  OtherTelephoneNumber: ").Append(this.OtherTelephoneNumber).Append("\n");
          sb.Append("  AssistantTelephoneNumber: ").Append(this.AssistantTelephoneNumber).Append("\n");
          sb.Append("  Home2TelephoneNumber: ").Append(this.Home2TelephoneNumber).Append("\n");
          sb.Append("  TtyTddPhoneNumber: ").Append(this.TtyTddPhoneNumber).Append("\n");
          sb.Append("  CompanyMainTelephoneNumber: ").Append(this.CompanyMainTelephoneNumber).Append("\n");
          sb.Append("  TelexNumber: ").Append(this.TelexNumber).Append("\n");
          sb.Append("  IsdnNumber: ").Append(this.IsdnNumber).Append("\n");
          sb.Append("  PagerTelephoneNumber: ").Append(this.PagerTelephoneNumber).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
