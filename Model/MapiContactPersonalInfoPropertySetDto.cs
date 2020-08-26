// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactPersonalInfoPropertySetDto.cs">
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
    /// Specify other additional contact information.             
    /// </summary>
    public class MapiContactPersonalInfoPropertySetDto 
    {
        /// <summary>
        /// Specifies the name of the contact's spouse/partner             
        /// </summary>
        public string SpouseName { get; set; }

        /// <summary>
        /// Specifies the contact's personal web page URL             
        /// </summary>
        public string PersonalHomePage { get; set; }

        /// <summary>
        /// Specifies the language that the contact uses             
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Specifies the additional notes             
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Specifies the hobbies of the contact             
        /// </summary>
        public string Hobbies { get; set; }

        /// <summary>
        /// Specifies the location of the contact             
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Specifies the contact's instant messaging address             
        /// </summary>
        public string InstantMessagingAddress { get; set; }

        /// <summary>
        /// Specifies an organizational ID number for the contact             
        /// </summary>
        public string OrganizationalIdNumber { get; set; }

        /// <summary>
        /// Specifies the contact's customer ID number             
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Specifies the contact's government ID number             
        /// </summary>
        public string GovernmentIdNumber { get; set; }

        /// <summary>
        /// Specifies a URL path from which a client can retrieve free/busy information for the contact as an iCal file             
        /// </summary>
        public string FreeBusyLocation { get; set; }

        /// <summary>
        /// Specifies the account name of the contact             
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Specifies the contact's business web page URL             
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Specifies the contact's business web page URL             
        /// </summary>
        public string BusinessHomePage { get; set; }

        /// <summary>
        /// Specifies the contact's File Transfer Protocol (FTP) URL             
        /// </summary>
        public string FtpSite { get; set; }

        /// <summary>
        /// Specifies the name of the network to which the contact's computer is connected             
        /// </summary>
        public string ComputerNetworkName { get; set; }

        /// <summary>
        /// Gender of the contact Enum, available values: Unspecified, Female, Male
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Specifies the name of the person who referred this contact to the user             
        /// </summary>
        public string ReferredByName { get; set; }

        /// <summary>
        /// Contains a list of names of children.             
        /// </summary>
        public List<string> Children { get; set; }


        /// <summary>MapiContactPersonalInfoPropertySetDto constructor</summary>
        public MapiContactPersonalInfoPropertySetDto() {}


        /// <summary>MapiContactPersonalInfoPropertySetDto constructor</summary>
        /// <param name="spouseName">Specifies the name of the contact's spouse/partner             </param>
        /// <param name="personalHomePage">Specifies the contact's personal web page URL             </param>
        /// <param name="language">Specifies the language that the contact uses             </param>
        /// <param name="notes">Specifies the additional notes             </param>
        /// <param name="hobbies">Specifies the hobbies of the contact             </param>
        /// <param name="location">Specifies the location of the contact             </param>
        /// <param name="instantMessagingAddress">Specifies the contact's instant messaging address             </param>
        /// <param name="organizationalIdNumber">Specifies an organizational ID number for the contact             </param>
        /// <param name="customerId">Specifies the contact's customer ID number             </param>
        /// <param name="governmentIdNumber">Specifies the contact's government ID number             </param>
        /// <param name="freeBusyLocation">Specifies a URL path from which a client can retrieve free/busy information for the contact as an iCal file             </param>
        /// <param name="account">Specifies the account name of the contact             </param>
        /// <param name="html">Specifies the contact's business web page URL             </param>
        /// <param name="businessHomePage">Specifies the contact's business web page URL             </param>
        /// <param name="ftpSite">Specifies the contact's File Transfer Protocol (FTP) URL             </param>
        /// <param name="computerNetworkName">Specifies the name of the network to which the contact's computer is connected             </param>
        /// <param name="gender">Gender of the contact Enum, available values: Unspecified, Female, Male</param>
        /// <param name="referredByName">Specifies the name of the person who referred this contact to the user             </param>
        /// <param name="children">Contains a list of names of children.             </param>
        public MapiContactPersonalInfoPropertySetDto(
            string spouseName,
            string personalHomePage,
            string language,
            string notes,
            string hobbies,
            string location,
            string instantMessagingAddress,
            string organizationalIdNumber,
            string customerId,
            string governmentIdNumber,
            string freeBusyLocation,
            string account,
            string html,
            string businessHomePage,
            string ftpSite,
            string computerNetworkName,
            string gender,
            string referredByName,
            List<string> children
        )
        { 
            SpouseName = spouseName;
            PersonalHomePage = personalHomePage;
            Language = language;
            Notes = notes;
            Hobbies = hobbies;
            Location = location;
            InstantMessagingAddress = instantMessagingAddress;
            OrganizationalIdNumber = organizationalIdNumber;
            CustomerId = customerId;
            GovernmentIdNumber = governmentIdNumber;
            FreeBusyLocation = freeBusyLocation;
            Account = account;
            Html = html;
            BusinessHomePage = businessHomePage;
            FtpSite = ftpSite;
            ComputerNetworkName = computerNetworkName;
            Gender = gender;
            ReferredByName = referredByName;
            Children = children;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactPersonalInfoPropertySetDto {\n");
          sb.Append("  SpouseName: ").Append(this.SpouseName).Append("\n");
          sb.Append("  PersonalHomePage: ").Append(this.PersonalHomePage).Append("\n");
          sb.Append("  Language: ").Append(this.Language).Append("\n");
          sb.Append("  Notes: ").Append(this.Notes).Append("\n");
          sb.Append("  Hobbies: ").Append(this.Hobbies).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  InstantMessagingAddress: ").Append(this.InstantMessagingAddress).Append("\n");
          sb.Append("  OrganizationalIdNumber: ").Append(this.OrganizationalIdNumber).Append("\n");
          sb.Append("  CustomerId: ").Append(this.CustomerId).Append("\n");
          sb.Append("  GovernmentIdNumber: ").Append(this.GovernmentIdNumber).Append("\n");
          sb.Append("  FreeBusyLocation: ").Append(this.FreeBusyLocation).Append("\n");
          sb.Append("  Account: ").Append(this.Account).Append("\n");
          sb.Append("  Html: ").Append(this.Html).Append("\n");
          sb.Append("  BusinessHomePage: ").Append(this.BusinessHomePage).Append("\n");
          sb.Append("  FtpSite: ").Append(this.FtpSite).Append("\n");
          sb.Append("  ComputerNetworkName: ").Append(this.ComputerNetworkName).Append("\n");
          sb.Append("  Gender: ").Append(this.Gender).Append("\n");
          sb.Append("  ReferredByName: ").Append(this.ReferredByName).Append("\n");
          sb.Append("  Children: ").Append(this.Children).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
