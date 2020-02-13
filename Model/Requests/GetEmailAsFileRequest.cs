// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetEmailAsFileRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.GetEmailAsFile" /> operation.
  /// </summary>
  public class GetEmailAsFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailAsFileRequest"/> class.
        /// </summary>
        public GetEmailAsFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailAsFileRequest"/> class.
        /// </summary>
        /// <param name="fileName">Email document file name</param>
        /// <param name="format">File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html</param>
        /// <param name="storage">Storage name</param>
        /// <param name="folder">Path to folder in storage</param>
        public GetEmailAsFileRequest(string fileName, string format, string storage = null, string folder = null)
        {
            this.fileName = fileName;
            this.format = format;
            this.storage = storage;
            this.folder = folder;
        }

        /// <summary>
        /// Email document file name
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html
        /// </summary>
        public string format { get; set; }

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
