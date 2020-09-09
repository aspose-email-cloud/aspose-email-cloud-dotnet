// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiNameCompleteRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.AiNameApi.Complete" /> operation.
  /// </summary>
  public class AiNameCompleteRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiNameCompleteRequest"/> class.
        /// </summary>
        public AiNameCompleteRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiNameCompleteRequest"/> class.
        /// </summary>
        /// <param name="name">A name to complete.</param>
        /// <param name="language">An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian).             </param>
        /// <param name="location">A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France.             </param>
        /// <param name="encoding">A character encoding name.</param>
        /// <param name="script">A writing system code; starts with the ISO-15924 script name.</param>
        /// <param name="style">Name writing style. Enum, available values: Formal, Informal, Legal, Academic</param>
        public AiNameCompleteRequest(string name, string language = null, string location = null, string encoding = null, string script = null, string style = null)
        {
            Name = name;
            Language = language;
            Location = location;
            Encoding = encoding;
            Script = script;
            Style = style;
        }

        /// <summary>
        /// A name to complete.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \"it\" or \"ita\" for Italian).             
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// A geographic code such as an ISO-3166 two letter country code, for example \"FR\" for France.             
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// A character encoding name.
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// A writing system code; starts with the ISO-15924 script name.
        /// </summary>
        public string Script { get; set; }

        /// <summary>
        /// Name writing style. Enum, available values: Formal, Informal, Legal, Academic
        /// </summary>
        public string Style { get; set; }
  }
}
