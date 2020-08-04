
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactProfessionalPropertySetDto.cs">
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
    /// Properties are used to store professional details for the person represented by the contact             
    /// </summary>
    public class MapiContactProfessionalPropertySetDto 
    {
        /// <summary>
        /// Gets or sets the job title of the contact             
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the company that employs the contact             
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the name of the department to which the contact belongs             
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets the location of the office that the contact works in             
        /// </summary>
        public string OfficeLocation { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact's manager             
        /// </summary>
        public string ManagerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact's assistant             
        /// </summary>
        public string Assistant { get; set; }

        /// <summary>
        /// Gets or sets the profession of the contact             
        /// </summary>
        public string Profession { get; set; }


        /// <summary>MapiContactProfessionalPropertySetDto constructor</summary>
        public MapiContactProfessionalPropertySetDto() {}


        /// <summary>MapiContactProfessionalPropertySetDto constructor</summary>
        /// <param name="title">Gets or sets the job title of the contact             </param>
        /// <param name="companyName">Gets or sets the company that employs the contact             </param>
        /// <param name="departmentName">Gets or sets the name of the department to which the contact belongs             </param>
        /// <param name="officeLocation">Gets or sets the location of the office that the contact works in             </param>
        /// <param name="managerName">Gets or sets the name of the contact's manager             </param>
        /// <param name="assistant">Gets or sets the name of the contact's assistant             </param>
        /// <param name="profession">Gets or sets the profession of the contact             </param>
        public MapiContactProfessionalPropertySetDto(
            string title,
            string companyName,
            string departmentName,
            string officeLocation,
            string managerName,
            string assistant,
            string profession
        )
        { 
            Title = title;
            CompanyName = companyName;
            DepartmentName = departmentName;
            OfficeLocation = officeLocation;
            ManagerName = managerName;
            Assistant = assistant;
            Profession = profession;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactProfessionalPropertySetDto {\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("  CompanyName: ").Append(this.CompanyName).Append("\n");
          sb.Append("  DepartmentName: ").Append(this.DepartmentName).Append("\n");
          sb.Append("  OfficeLocation: ").Append(this.OfficeLocation).Append("\n");
          sb.Append("  ManagerName: ").Append(this.ManagerName).Append("\n");
          sb.Append("  Assistant: ").Append(this.Assistant).Append("\n");
          sb.Append("  Profession: ").Append(this.Profession).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
