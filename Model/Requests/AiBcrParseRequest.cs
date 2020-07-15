// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiBcrParseRequest.cs">
//   Copyright (c) 2018-2020 Aspose.Email for Cloud
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
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedType.Global
// ReSharper disable RedundantUsingDirective
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
namespace Aspose.Email.Cloud.Sdk.Model
{
  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.AiBcrApi.NORPrefix_AiBcr_Parse_NOR_Suffix_p_AiBcrApi_e" /> operation.
  /// </summary>
  public class AiBcrParseRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiBcrParseRequest"/> class.
        /// </summary>
        public AiBcrParseRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiBcrParseRequest"/> class.
        /// </summary>
        /// <param name="file">File to convert</param>
        /// <param name="countries">Comma-separated codes of countries.</param>
        /// <param name="languages">Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \&quot;it\&quot; or \&quot;ita\&quot; for Italian); it&#39;s \&quot;\&quot; by default.</param>
        /// <param name="isSingle">Determines that image contains single VCard or more.</param>
        public AiBcrParseRequest(System.IO.Stream file, string countries = null, string languages = null, bool? isSingle = null)
        {
            this.File = file;
            this.countries = countries;
            this.languages = languages;
            this.isSingle = isSingle;
        }

        /// <summary>
        /// File to convert
        /// </summary>
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Comma-separated codes of countries.
        /// </summary>
        public string countries { get; set; }

        /// <summary>
        /// Comma-separated ISO-639 codes of languages (either 639-1 or 639-3; i.e. \"it\" or \"ita\" for Italian); it's \"\" by default.
        /// </summary>
        public string languages { get; set; }

        /// <summary>
        /// Determines that image contains single VCard or more.
        /// </summary>
        public bool? isSingle { get; set; }
  }
}
