// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertContactModelToFileRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests
{
  using Model;

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.ConvertContactModelToFile" /> operation.
  /// </summary>
  public class ConvertContactModelToFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertContactModelToFileRequest"/> class.
        /// </summary>
        public ConvertContactModelToFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertContactModelToFileRequest"/> class.
        /// </summary>
        /// <param name="destinationFormat">File format Enum, available values: VCard, WebDav, Msg</param>
        /// <param name="contactDto">Contact model to convert</param>
        public ConvertContactModelToFileRequest(string destinationFormat, ContactDto contactDto)
        {
            this.destinationFormat = destinationFormat;
            this.contactDto = contactDto;
        }

        /// <summary>
        /// File format Enum, available values: VCard, WebDav, Msg
        /// </summary>
        public string destinationFormat { get; set; }

        /// <summary>
        /// Contact model to convert
        /// </summary>
        public ContactDto contactDto { get; set; }
  }
}