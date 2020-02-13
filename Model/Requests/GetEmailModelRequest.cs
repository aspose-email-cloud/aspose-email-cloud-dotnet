// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetEmailModelRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.GetEmailModel" /> operation.
  /// </summary>
  public class GetEmailModelRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailModelRequest"/> class.
        /// </summary>
        public GetEmailModelRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailModelRequest"/> class.
        /// </summary>
        /// <param name="format">Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html</param>
        /// <param name="name">Email document file name.</param>
        /// <param name="folder">Path to folder in storage.</param>
        /// <param name="storage">Storage name.</param>
        public GetEmailModelRequest(string format, string name, string folder = null, string storage = null)
        {
            this.format = format;
            this.name = name;
            this.folder = folder;
            this.storage = storage;
        }

        /// <summary>
        /// Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// Email document file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Path to folder in storage.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string storage { get; set; }
  }
}
