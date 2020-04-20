// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FetchEmailMessageRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.FetchEmailMessage" /> operation.
  /// </summary>
  public class FetchEmailMessageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchEmailMessageRequest"/> class.
        /// </summary>
        public FetchEmailMessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchEmailMessageRequest"/> class.
        /// </summary>
        /// <param name="messageId">Message identifier</param>
        /// <param name="firstAccount">Email account</param>
        /// <param name="secondAccount">Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)             </param>
        /// <param name="folder">Account folder to fetch from (should be specified for some protocols such as IMAP)             </param>
        /// <param name="storage">Storage name where account file(s) located</param>
        /// <param name="storageFolder">Folder in storage where account file(s) located</param>
        public FetchEmailMessageRequest(string messageId, string firstAccount, string secondAccount = null, string folder = null, string storage = null, string storageFolder = null)
        {
            this.messageId = messageId;
            this.firstAccount = firstAccount;
            this.secondAccount = secondAccount;
            this.folder = folder;
            this.storage = storage;
            this.storageFolder = storageFolder;
        }

        /// <summary>
        /// Message identifier
        /// </summary>
        public string messageId { get; set; }

        /// <summary>
        /// Email account
        /// </summary>
        public string firstAccount { get; set; }

        /// <summary>
        /// Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)             
        /// </summary>
        public string secondAccount { get; set; }

        /// <summary>
        /// Account folder to fetch from (should be specified for some protocols such as IMAP)             
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Storage name where account file(s) located
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        /// Folder in storage where account file(s) located
        /// </summary>
        public string storageFolder { get; set; }
  }
}
