// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailGetAsFileRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.GetAsFile" /> operation.
  /// </summary>
  public class EmailGetAsFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGetAsFileRequest"/> class.
        /// </summary>
        public EmailGetAsFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGetAsFileRequest"/> class.
        /// </summary>
        /// <param name="fileName">Email document file name</param>
        /// <param name="format">File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft</param>
        /// <param name="storage">Storage name</param>
        /// <param name="folder">Path to folder in storage</param>
        public EmailGetAsFileRequest(string fileName, string format, string storage = null, string folder = null)
        {
            FileName = fileName;
            Format = format;
            Storage = storage;
            Folder = folder;
        }

        /// <summary>
        /// Email document file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Path to folder in storage
        /// </summary>
        public string Folder { get; set; }
  }
}
