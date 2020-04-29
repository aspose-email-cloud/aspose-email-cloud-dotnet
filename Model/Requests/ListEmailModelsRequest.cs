// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListEmailModelsRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.ListEmailModels" /> operation.
  /// </summary>
  public class ListEmailModelsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmailModelsRequest"/> class.
        /// </summary>
        public ListEmailModelsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmailModelsRequest"/> class.
        /// </summary>
        /// <param name="folder">A folder in email account</param>
        /// <param name="firstAccount">Email account</param>
        /// <param name="queryString">A MailQuery search string</param>
        /// <param name="secondAccount">Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)             </param>
        /// <param name="storage">Storage name where account file(s) located</param>
        /// <param name="storageFolder">Folder in storage where account file(s) located</param>
        /// <param name="recursive">Specifies that should message be searched in subfolders recursively</param>
        public ListEmailModelsRequest(string folder, string firstAccount, string queryString = null, string secondAccount = null, string storage = null, string storageFolder = null, bool? recursive = null)
        {
            this.folder = folder;
            this.firstAccount = firstAccount;
            this.queryString = queryString;
            this.secondAccount = secondAccount;
            this.storage = storage;
            this.storageFolder = storageFolder;
            this.recursive = recursive;
        }

        /// <summary>
        /// A folder in email account
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Email account
        /// </summary>
        public string firstAccount { get; set; }

        /// <summary>
        /// A MailQuery search string
        /// </summary>
        public string queryString { get; set; }

        /// <summary>
        /// Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)             
        /// </summary>
        public string secondAccount { get; set; }

        /// <summary>
        /// Storage name where account file(s) located
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        /// Folder in storage where account file(s) located
        /// </summary>
        public string storageFolder { get; set; }

        /// <summary>
        /// Specifies that should message be searched in subfolders recursively
        /// </summary>
        public bool? recursive { get; set; }
  }
}
