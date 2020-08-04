
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ContactDto.cs">
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
    /// VCard document representation.             
    /// </summary>
    public class ContactDto 
    {
        /// <summary>
        /// Associated persons.             
        /// </summary>
        public List<AssociatedPerson> AssociatedPersons { get; set; }

        /// <summary>
        /// Document attachments.             
        /// </summary>
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Company name.             
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Computer network.             
        /// </summary>
        public string ComputerNetworkName { get; set; }

        /// <summary>
        /// Customer id.             
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Department name.             
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Display name.             
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Person's email addresses.             
        /// </summary>
        public List<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// Person's events.             
        /// </summary>
        public List<CustomerEvent> Events { get; set; }

        /// <summary>
        /// A name used for sorting.             
        /// </summary>
        public string FileAs { get; set; }

        /// <summary>
        /// Specifies how to generate and recompute the value of the dispidFileAs property when other contact name properties change. Coincides MS-OXPROPS revision 16.2 from 7/31/2014. Enum, available values: Empty, DisplayName, FirstName, LastName, Organization, LastFirstMiddle, OrgLastFirstMiddle, LastFirstMiddleOrg, LastFirstMiddle2, LastFirstMiddle3, OrgLastFirstMiddle2, OrgLastFirstMiddle3, LastFirstMiddleOrg2, LastFirstMiddleOrg3, LastFirstMiddleGen, FirstMiddleLastGen, LastFirstMiddleGen2, BestMatch, AccordingToLocale, None
        /// </summary>
        public string FileAsMapping { get; set; }

        /// <summary>
        /// URL path from which a client can retrieve free/busy information for the contact as an iCal file.             
        /// </summary>
        public string FreeBusyLocation { get; set; }

        /// <summary>
        /// Enum defines gender of a person. Enum, available values: Unspecified, Female, Male
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Person's given name.             
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Government id number.             
        /// </summary>
        public string GovernmentIdNumber { get; set; }

        /// <summary>
        /// Person's hobbies.             
        /// </summary>
        public string Hobbies { get; set; }

        /// <summary>
        /// Person's initials.             
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// Person's instant messenger addresses.             
        /// </summary>
        public List<InstantMessengerAddress> InstantMessengers { get; set; }

        /// <summary>
        /// Person's job title.             
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Language.             
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Person's location.             
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Person's middle name.             
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Person's nickname.             
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Notes.             
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Defines format of a text. Enum, available values: Text, Html
        /// </summary>
        public string NotesFormat { get; set; }

        /// <summary>
        /// Office location.             
        /// </summary>
        public string OfficeLocation { get; set; }

        /// <summary>
        /// Contains an identifier for the mail user used within the mail user's organization.             
        /// </summary>
        public string OrganizationalIdNumber { get; set; }

        /// <summary>
        /// Person's phone numbers.             
        /// </summary>
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Person's photo.             
        /// </summary>
        public ContactPhoto Photo { get; set; }

        /// <summary>
        /// Person's physical addresses.             
        /// </summary>
        public List<PostalAddress> PhysicalAddresses { get; set; }

        /// <summary>
        /// Encoding for all text properties.             
        /// </summary>
        public string PreferredTextEncoding { get; set; }

        /// <summary>
        /// A prefix of a full name such like Mr.(mister), Dr.(doctor) and so on.             
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// A job position of a person in a company.             
        /// </summary>
        public string Profession { get; set; }

        /// <summary>
        /// A suffix of a full name such like Jr.(junior), Sr.(senior) and so on.             
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// Person's surname.             
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Person's urls.             
        /// </summary>
        public List<Url> Urls { get; set; }


        /// <summary>ContactDto constructor</summary>
        public ContactDto() {}


        /// <summary>ContactDto constructor</summary>
        /// <param name="associatedPersons">Associated persons.             </param>
        /// <param name="attachments">Document attachments.             </param>
        /// <param name="companyName">Company name.             </param>
        /// <param name="computerNetworkName">Computer network.             </param>
        /// <param name="customerId">Customer id.             </param>
        /// <param name="departmentName">Department name.             </param>
        /// <param name="displayName">Display name.             </param>
        /// <param name="emailAddresses">Person's email addresses.             </param>
        /// <param name="events">Person's events.             </param>
        /// <param name="fileAs">A name used for sorting.             </param>
        /// <param name="fileAsMapping">Specifies how to generate and recompute the value of the dispidFileAs property when other contact name properties change. Coincides MS-OXPROPS revision 16.2 from 7/31/2014. Enum, available values: Empty, DisplayName, FirstName, LastName, Organization, LastFirstMiddle, OrgLastFirstMiddle, LastFirstMiddleOrg, LastFirstMiddle2, LastFirstMiddle3, OrgLastFirstMiddle2, OrgLastFirstMiddle3, LastFirstMiddleOrg2, LastFirstMiddleOrg3, LastFirstMiddleGen, FirstMiddleLastGen, LastFirstMiddleGen2, BestMatch, AccordingToLocale, None</param>
        /// <param name="freeBusyLocation">URL path from which a client can retrieve free/busy information for the contact as an iCal file.             </param>
        /// <param name="gender">Enum defines gender of a person. Enum, available values: Unspecified, Female, Male</param>
        /// <param name="givenName">Person's given name.             </param>
        /// <param name="governmentIdNumber">Government id number.             </param>
        /// <param name="hobbies">Person's hobbies.             </param>
        /// <param name="initials">Person's initials.             </param>
        /// <param name="instantMessengers">Person's instant messenger addresses.             </param>
        /// <param name="jobTitle">Person's job title.             </param>
        /// <param name="language">Language.             </param>
        /// <param name="location">Person's location.             </param>
        /// <param name="middleName">Person's middle name.             </param>
        /// <param name="nickname">Person's nickname.             </param>
        /// <param name="notes">Notes.             </param>
        /// <param name="notesFormat">Defines format of a text. Enum, available values: Text, Html</param>
        /// <param name="officeLocation">Office location.             </param>
        /// <param name="organizationalIdNumber">Contains an identifier for the mail user used within the mail user's organization.             </param>
        /// <param name="phoneNumbers">Person's phone numbers.             </param>
        /// <param name="photo">Person's photo.             </param>
        /// <param name="physicalAddresses">Person's physical addresses.             </param>
        /// <param name="preferredTextEncoding">Encoding for all text properties.             </param>
        /// <param name="prefix">A prefix of a full name such like Mr.(mister), Dr.(doctor) and so on.             </param>
        /// <param name="profession">A job position of a person in a company.             </param>
        /// <param name="suffix">A suffix of a full name such like Jr.(junior), Sr.(senior) and so on.             </param>
        /// <param name="surname">Person's surname.             </param>
        /// <param name="urls">Person's urls.             </param>
        public ContactDto(
            List<AssociatedPerson> associatedPersons,
            List<Attachment> attachments,
            string companyName,
            string computerNetworkName,
            string customerId,
            string departmentName,
            string displayName,
            List<EmailAddress> emailAddresses,
            List<CustomerEvent> events,
            string fileAs,
            string fileAsMapping,
            string freeBusyLocation,
            string gender,
            string givenName,
            string governmentIdNumber,
            string hobbies,
            string initials,
            List<InstantMessengerAddress> instantMessengers,
            string jobTitle,
            string language,
            string location,
            string middleName,
            string nickname,
            string notes,
            string notesFormat,
            string officeLocation,
            string organizationalIdNumber,
            List<PhoneNumber> phoneNumbers,
            ContactPhoto photo,
            List<PostalAddress> physicalAddresses,
            string preferredTextEncoding,
            string prefix,
            string profession,
            string suffix,
            string surname,
            List<Url> urls
        )
        { 
            AssociatedPersons = associatedPersons;
            Attachments = attachments;
            CompanyName = companyName;
            ComputerNetworkName = computerNetworkName;
            CustomerId = customerId;
            DepartmentName = departmentName;
            DisplayName = displayName;
            EmailAddresses = emailAddresses;
            Events = events;
            FileAs = fileAs;
            FileAsMapping = fileAsMapping;
            FreeBusyLocation = freeBusyLocation;
            Gender = gender;
            GivenName = givenName;
            GovernmentIdNumber = governmentIdNumber;
            Hobbies = hobbies;
            Initials = initials;
            InstantMessengers = instantMessengers;
            JobTitle = jobTitle;
            Language = language;
            Location = location;
            MiddleName = middleName;
            Nickname = nickname;
            Notes = notes;
            NotesFormat = notesFormat;
            OfficeLocation = officeLocation;
            OrganizationalIdNumber = organizationalIdNumber;
            PhoneNumbers = phoneNumbers;
            Photo = photo;
            PhysicalAddresses = physicalAddresses;
            PreferredTextEncoding = preferredTextEncoding;
            Prefix = prefix;
            Profession = profession;
            Suffix = suffix;
            Surname = surname;
            Urls = urls;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ContactDto {\n");
          sb.Append("  AssociatedPersons: ").Append(this.AssociatedPersons).Append("\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  CompanyName: ").Append(this.CompanyName).Append("\n");
          sb.Append("  ComputerNetworkName: ").Append(this.ComputerNetworkName).Append("\n");
          sb.Append("  CustomerId: ").Append(this.CustomerId).Append("\n");
          sb.Append("  DepartmentName: ").Append(this.DepartmentName).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  EmailAddresses: ").Append(this.EmailAddresses).Append("\n");
          sb.Append("  Events: ").Append(this.Events).Append("\n");
          sb.Append("  FileAs: ").Append(this.FileAs).Append("\n");
          sb.Append("  FileAsMapping: ").Append(this.FileAsMapping).Append("\n");
          sb.Append("  FreeBusyLocation: ").Append(this.FreeBusyLocation).Append("\n");
          sb.Append("  Gender: ").Append(this.Gender).Append("\n");
          sb.Append("  GivenName: ").Append(this.GivenName).Append("\n");
          sb.Append("  GovernmentIdNumber: ").Append(this.GovernmentIdNumber).Append("\n");
          sb.Append("  Hobbies: ").Append(this.Hobbies).Append("\n");
          sb.Append("  Initials: ").Append(this.Initials).Append("\n");
          sb.Append("  InstantMessengers: ").Append(this.InstantMessengers).Append("\n");
          sb.Append("  JobTitle: ").Append(this.JobTitle).Append("\n");
          sb.Append("  Language: ").Append(this.Language).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  MiddleName: ").Append(this.MiddleName).Append("\n");
          sb.Append("  Nickname: ").Append(this.Nickname).Append("\n");
          sb.Append("  Notes: ").Append(this.Notes).Append("\n");
          sb.Append("  NotesFormat: ").Append(this.NotesFormat).Append("\n");
          sb.Append("  OfficeLocation: ").Append(this.OfficeLocation).Append("\n");
          sb.Append("  OrganizationalIdNumber: ").Append(this.OrganizationalIdNumber).Append("\n");
          sb.Append("  PhoneNumbers: ").Append(this.PhoneNumbers).Append("\n");
          sb.Append("  Photo: ").Append(this.Photo).Append("\n");
          sb.Append("  PhysicalAddresses: ").Append(this.PhysicalAddresses).Append("\n");
          sb.Append("  PreferredTextEncoding: ").Append(this.PreferredTextEncoding).Append("\n");
          sb.Append("  Prefix: ").Append(this.Prefix).Append("\n");
          sb.Append("  Profession: ").Append(this.Profession).Append("\n");
          sb.Append("  Suffix: ").Append(this.Suffix).Append("\n");
          sb.Append("  Surname: ").Append(this.Surname).Append("\n");
          sb.Append("  Urls: ").Append(this.Urls).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
