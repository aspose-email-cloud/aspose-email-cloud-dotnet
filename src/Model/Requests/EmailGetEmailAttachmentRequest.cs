// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailGetEmailAttachmentRequest.cs">
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
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailGetEmailAttachment" /> operation.
  /// </summary>  
  public class EmailGetEmailAttachmentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGetEmailAttachmentRequest"/> class.
        /// </summary>        
        public EmailGetEmailAttachmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGetEmailAttachmentRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachName"></param>
        /// <param name="storage"></param>
        /// <param name="folder"></param>
        public EmailGetEmailAttachmentRequest(string name, string attachName, string storage = null, string folder = null)             
        {
            this.name = name;
            this.attachName = attachName;
            this.storage = storage;
            this.folder = folder;
        }

        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Gets or sets attachName
        /// </summary>  
        public string attachName { get; set; }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets folder
        /// </summary>  
        public string folder { get; set; }
  }
}
