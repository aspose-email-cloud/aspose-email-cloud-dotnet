// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactDto.cs">
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
    /// Represents outlook contact information.             
    /// </summary>
    public class MapiContactDto : MapiMessageItemBaseDto 
    {
        /// <summary>
        /// Specify properties for up to three different e-mail addresses and three different fax addresses.             
        /// </summary>  
        public MapiContactElectronicAddressPropertySetDto ElectronicAddresses { get; set; }

        /// <summary>
        /// Specify events associated with a contact.             
        /// </summary>  
        public MapiContactEventPropertySetDto Events { get; set; }

        /// <summary>
        /// The properties are used to specify the name of the person represented by the contact.             
        /// </summary>  
        public MapiContactNamePropertySetDto NameInfo { get; set; }

        /// <summary>
        /// Specify other fields of contact.             
        /// </summary>  
        public MapiContactOtherPropertySetDto OtherFields { get; set; }

        /// <summary>
        /// Specify other additional contact information.             
        /// </summary>  
        public MapiContactPersonalInfoPropertySetDto PersonalInfo { get; set; }

        /// <summary>
        /// Contact photo.             
        /// </summary>  
        public MapiContactPhotoDto Photo { get; set; }

        /// <summary>
        /// Specify three physical addresses: Home Address, Work Address, and Other Address. One of the addresses can be marked as the Mailing Address.             
        /// </summary>  
        public MapiContactPhysicalAddressPropertySetDto PhysicalAddresses { get; set; }

        /// <summary>
        /// Properties are used to store professional details for the person represented by the contact.             
        /// </summary>  
        public MapiContactProfessionalPropertySetDto ProfessionalInfo { get; set; }

        /// <summary>
        /// Specify telephone numbers for the contact.             
        /// </summary>  
        public MapiContactTelephonePropertySetDto Telephones { get; set; }

        /// <summary>MapiContactDto constructor</summary>
        public MapiContactDto() {}

        /// <summary>MapiContactDto constructor</summary>
        /// <param name="attachments">Message item attachments.             </param>
        /// <param name="billing">Billing information associated with an item.             </param>
        /// <param name="body">Message text.             </param>
        /// <param name="bodyHtml">Gets the BodyRtf of the message converted to HTML, if present, otherwise an empty string.             </param>
        /// <param name="bodyRtf">RTF formatted message text.             </param>
        /// <param name="bodyType">The content type of message body. Enum, available values: PlainText, Html, Rtf</param>
        /// <param name="categories">Contains keywords or categories for the message object.             </param>
        /// <param name="companies">Contains the names of the companies that are associated with an item.             </param>
        /// <param name="itemId">The item id, uses with a server.             </param>
        /// <param name="messageClass">Case-sensitive string that identifies the sender-defined message class, such as IPM.Note. The message class specifies the type, purpose, or content of the message.             </param>
        /// <param name="mileage">Contains the mileage information that is associated with an item.             </param>
        /// <param name="recipients">Recipients of the message.             </param>
        /// <param name="sensitivity">Contains values that indicate the message sensitivity. Enum, available values: None, Personal, Private, CompanyConfidential</param>
        /// <param name="subject">Subject of the message.             </param>
        /// <param name="subjectPrefix">Subject prefix that typically indicates some action on a message, such as \"FW: \" for forwarding.             </param>
        /// <param name="properties">List of MAPI properties             </param>
        /// <param name="discriminator"></param>
        /// <param name="electronicAddresses">Specify properties for up to three different e-mail addresses and three different fax addresses.             </param>
        /// <param name="events">Specify events associated with a contact.             </param>
        /// <param name="nameInfo">The properties are used to specify the name of the person represented by the contact.             </param>
        /// <param name="otherFields">Specify other fields of contact.             </param>
        /// <param name="personalInfo">Specify other additional contact information.             </param>
        /// <param name="photo">Contact photo.             </param>
        /// <param name="physicalAddresses">Specify three physical addresses: Home Address, Work Address, and Other Address. One of the addresses can be marked as the Mailing Address.             </param>
        /// <param name="professionalInfo">Properties are used to store professional details for the person represented by the contact.             </param>
        /// <param name="telephones">Specify telephone numbers for the contact.             </param>
        public MapiContactDto(List<MapiAttachmentDto> attachments, string billing, string body, string bodyHtml, string bodyRtf, string bodyType, List<string> categories, List<string> companies, string itemId, string messageClass, string mileage, List<MapiRecipientDto> recipients, string sensitivity, string subject, string subjectPrefix, List<MapiPropertyDto> properties, string discriminator, MapiContactElectronicAddressPropertySetDto electronicAddresses, MapiContactEventPropertySetDto events, MapiContactNamePropertySetDto nameInfo, MapiContactOtherPropertySetDto otherFields, MapiContactPersonalInfoPropertySetDto personalInfo, MapiContactPhotoDto photo, MapiContactPhysicalAddressPropertySetDto physicalAddresses, MapiContactProfessionalPropertySetDto professionalInfo, MapiContactTelephonePropertySetDto telephones)
        {
            Attachments = attachments;
            Billing = billing;
            Body = body;
            BodyHtml = bodyHtml;
            BodyRtf = bodyRtf;
            BodyType = bodyType;
            Categories = categories;
            Companies = companies;
            ItemId = itemId;
            MessageClass = messageClass;
            Mileage = mileage;
            Recipients = recipients;
            Sensitivity = sensitivity;
            Subject = subject;
            SubjectPrefix = subjectPrefix;
            Properties = properties;
            Discriminator = discriminator;
            ElectronicAddresses = electronicAddresses;
            Events = events;
            NameInfo = nameInfo;
            OtherFields = otherFields;
            PersonalInfo = personalInfo;
            Photo = photo;
            PhysicalAddresses = physicalAddresses;
            ProfessionalInfo = professionalInfo;
            Telephones = telephones;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactDto {\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  Billing: ").Append(this.Billing).Append("\n");
          sb.Append("  Body: ").Append(this.Body).Append("\n");
          sb.Append("  BodyHtml: ").Append(this.BodyHtml).Append("\n");
          sb.Append("  BodyRtf: ").Append(this.BodyRtf).Append("\n");
          sb.Append("  BodyType: ").Append(this.BodyType).Append("\n");
          sb.Append("  Categories: ").Append(this.Categories).Append("\n");
          sb.Append("  Companies: ").Append(this.Companies).Append("\n");
          sb.Append("  ItemId: ").Append(this.ItemId).Append("\n");
          sb.Append("  MessageClass: ").Append(this.MessageClass).Append("\n");
          sb.Append("  Mileage: ").Append(this.Mileage).Append("\n");
          sb.Append("  Recipients: ").Append(this.Recipients).Append("\n");
          sb.Append("  Sensitivity: ").Append(this.Sensitivity).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  SubjectPrefix: ").Append(this.SubjectPrefix).Append("\n");
          sb.Append("  Properties: ").Append(this.Properties).Append("\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  ElectronicAddresses: ").Append(this.ElectronicAddresses).Append("\n");
          sb.Append("  Events: ").Append(this.Events).Append("\n");
          sb.Append("  NameInfo: ").Append(this.NameInfo).Append("\n");
          sb.Append("  OtherFields: ").Append(this.OtherFields).Append("\n");
          sb.Append("  PersonalInfo: ").Append(this.PersonalInfo).Append("\n");
          sb.Append("  Photo: ").Append(this.Photo).Append("\n");
          sb.Append("  PhysicalAddresses: ").Append(this.PhysicalAddresses).Append("\n");
          sb.Append("  ProfessionalInfo: ").Append(this.ProfessionalInfo).Append("\n");
          sb.Append("  Telephones: ").Append(this.Telephones).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
