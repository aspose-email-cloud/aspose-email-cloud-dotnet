
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetCalendarAttachmentRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.GetCalendarAttachment" /> operation.
  /// </summary>
  public class GetCalendarAttachmentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCalendarAttachmentRequest"/> class.
        /// </summary>
        public GetCalendarAttachmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCalendarAttachmentRequest"/> class.
        /// </summary>
        /// <param name="name">iCalendar document file name</param>
        /// <param name="attachment">Attachment name or index</param>
        /// <param name="folder">Path to folder in storage</param>
        /// <param name="storage">Storage name</param>
        public GetCalendarAttachmentRequest(string name, string attachment, string folder = null, string storage = null)
        {
            this.name = name;
            this.attachment = attachment;
            this.folder = folder;
            this.storage = storage;
        }

        /// <summary>
        /// iCalendar document file name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Attachment name or index
        /// </summary>
        public string attachment { get; set; }

        /// <summary>
        /// Path to folder in storage
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>
        public string storage { get; set; }
  }
}