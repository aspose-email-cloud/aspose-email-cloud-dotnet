// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AddCalendarAttachmentRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.AddCalendarAttachment" /> operation.
  /// </summary>
  public class AddCalendarAttachmentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCalendarAttachmentRequest"/> class.
        /// </summary>
        public AddCalendarAttachmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCalendarAttachmentRequest"/> class.
        /// </summary>
        /// <param name="name">Calendar file name in storage</param>
        /// <param name="attachment">Attachment file name in storage</param>
        /// <param name="request">Storage name and folder path for calendar and attachment files</param>
        public AddCalendarAttachmentRequest(string name, string attachment, AddAttachmentRequest request)
        {
            this.name = name;
            this.attachment = attachment;
            this.request = request;
        }

        /// <summary>
        /// Calendar file name in storage
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Attachment file name in storage
        /// </summary>
        public string attachment { get; set; }

        /// <summary>
        /// Storage name and folder path for calendar and attachment files
        /// </summary>
        public AddAttachmentRequest request { get; set; }
  }
}
