// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveContactModelRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.SaveContactModel" /> operation.
  /// </summary>
  public class SaveContactModelRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveContactModelRequest"/> class.
        /// </summary>
        public SaveContactModelRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveContactModelRequest"/> class.
        /// </summary>
        /// <param name="format">Contact document format. Enum, available values: VCard, WebDav, Msg</param>
        /// <param name="name">Contact document file name.</param>
        /// <param name="rq">Create/Update contact request.</param>
        public SaveContactModelRequest(string format, string name, StorageModelRqOfContactDto rq)
        {
            this.format = format;
            this.name = name;
            this.rq = rq;
        }

        /// <summary>
        /// Contact document format. Enum, available values: VCard, WebDav, Msg
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// Contact document file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Create/Update contact request.
        /// </summary>
        public StorageModelRqOfContactDto rq { get; set; }
  }
}
