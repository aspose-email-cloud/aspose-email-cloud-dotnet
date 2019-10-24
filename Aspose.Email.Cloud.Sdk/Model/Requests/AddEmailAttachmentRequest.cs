
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AddEmailAttachmentRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.AddEmailAttachment" /> operation.
  /// </summary>
  public class AddEmailAttachmentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEmailAttachmentRequest"/> class.
        /// </summary>
        public AddEmailAttachmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEmailAttachmentRequest"/> class.
        /// </summary>
        /// <param name="attachmentName">Attachment file name</param>
        /// <param name="fileName">Email document file name</param>
        /// <param name="request">Storage info to specify location of email document and attachment files</param>
        public AddEmailAttachmentRequest(string attachmentName, string fileName, AddAttachmentRequest request)
        {
            this.attachmentName = attachmentName;
            this.fileName = fileName;
            this.request = request;
        }

        /// <summary>
        /// Attachment file name
        /// </summary>
        public string attachmentName { get; set; }

        /// <summary>
        /// Email document file name
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// Storage info to specify location of email document and attachment files
        /// </summary>
        public AddAttachmentRequest request { get; set; }
  }
}