// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetEmailAttachmentRequest.cs">
//   Copyright (c) 2018 Aspose.Email for Cloud
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.GetEmailAttachment" /> operation.
  /// </summary>
  public class GetEmailAttachmentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailAttachmentRequest"/> class.
        /// </summary>
        public GetEmailAttachmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailAttachmentRequest"/> class.
        /// </summary>
        /// <param name="attachment">Attachment name</param>
        /// <param name="fileName">Email document file name</param>
        /// <param name="storage">Storage name</param>
        /// <param name="folder">Path to folder in storage</param>
        public GetEmailAttachmentRequest(string attachment, string fileName, string storage = null, string folder = null)
        {
            this.attachment = attachment;
            this.fileName = fileName;
            this.storage = storage;
            this.folder = folder;
        }

        /// <summary>
        /// Attachment name
        /// </summary>
        public string attachment { get; set; }

        /// <summary>
        /// Email document file name
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        /// Path to folder in storage
        /// </summary>
        public string folder { get; set; }
  }
}
