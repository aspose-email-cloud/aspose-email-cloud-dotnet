
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteMapiAttachmentRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.DeleteMapiAttachment" /> operation.
  /// </summary>
  public class DeleteMapiAttachmentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMapiAttachmentRequest"/> class.
        /// </summary>
        public DeleteMapiAttachmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMapiAttachmentRequest"/> class.
        /// </summary>
        /// <param name="name">Document file name</param>
        /// <param name="attachment">Attachment name or index</param>
        /// <param name="storage">Document file storage location info</param>
        public DeleteMapiAttachmentRequest(string name, string attachment, StorageFolder storage)
        {
            this.name = name;
            this.attachment = attachment;
            this.storage = storage;
        }

        /// <summary>
        /// Document file name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Attachment name or index
        /// </summary>
        public string attachment { get; set; }

        /// <summary>
        /// Document file storage location info
        /// </summary>
        public StorageFolder storage { get; set; }
  }
}