// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactNamePropertySetDto.cs">
//   Copyright (c) 2016-2023 Aspose.Email for Cloud
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
    /// The properties are used to specify the name of the person represented by the contact             
    /// </summary>
    public class MapiContactNamePropertySetDto 
    {
        /// <summary>
        /// Full name of the contact             
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Title of the contact             
        /// </summary>
        public string DisplayNamePrefix { get; set; }

        /// <summary>
        /// Name under which to file this contact when displaying a list of contacts             
        /// </summary>
        public string FileUnder { get; set; }

        /// <summary>
        /// Value specifying how to generate and recompute the property when other properties are changed             
        /// </summary>
        public long? FileUnderId { get; set; }

        /// <summary>
        /// Generation suffix of the contact             
        /// </summary>
        public string Generation { get; set; }

        /// <summary>
        /// Given name (first name) of the contact             
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Initials of the contact             
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// Middle name of the contact             
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Nickname of the contact             
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Surname (family name) of the contact             
        /// </summary>
        public string Surname { get; set; }


        /// <summary>MapiContactNamePropertySetDto constructor</summary>
        public MapiContactNamePropertySetDto() {}


        /// <summary>MapiContactNamePropertySetDto constructor</summary>
        /// <param name="displayName">Full name of the contact             </param>
        /// <param name="displayNamePrefix">Title of the contact             </param>
        /// <param name="fileUnder">Name under which to file this contact when displaying a list of contacts             </param>
        /// <param name="fileUnderId">Value specifying how to generate and recompute the property when other properties are changed             </param>
        /// <param name="generation">Generation suffix of the contact             </param>
        /// <param name="givenName">Given name (first name) of the contact             </param>
        /// <param name="initials">Initials of the contact             </param>
        /// <param name="middleName">Middle name of the contact             </param>
        /// <param name="nickname">Nickname of the contact             </param>
        /// <param name="surname">Surname (family name) of the contact             </param>
        public MapiContactNamePropertySetDto(
            string displayName,
            string displayNamePrefix,
            string fileUnder,
            long? fileUnderId,
            string generation,
            string givenName,
            string initials,
            string middleName,
            string nickname,
            string surname
        )
        { 
            DisplayName = displayName;
            DisplayNamePrefix = displayNamePrefix;
            FileUnder = fileUnder;
            FileUnderId = fileUnderId;
            Generation = generation;
            GivenName = givenName;
            Initials = initials;
            MiddleName = middleName;
            Nickname = nickname;
            Surname = surname;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiContactNamePropertySetDto {\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  DisplayNamePrefix: ").Append(this.DisplayNamePrefix).Append("\n");
          sb.Append("  FileUnder: ").Append(this.FileUnder).Append("\n");
          sb.Append("  FileUnderId: ").Append(this.FileUnderId).Append("\n");
          sb.Append("  Generation: ").Append(this.Generation).Append("\n");
          sb.Append("  GivenName: ").Append(this.GivenName).Append("\n");
          sb.Append("  Initials: ").Append(this.Initials).Append("\n");
          sb.Append("  MiddleName: ").Append(this.MiddleName).Append("\n");
          sb.Append("  Nickname: ").Append(this.Nickname).Append("\n");
          sb.Append("  Surname: ").Append(this.Surname).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
