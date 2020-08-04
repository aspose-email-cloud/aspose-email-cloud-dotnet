
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientMessageAppendFileRequest.cs">
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
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedType.Global
// ReSharper disable RedundantUsingDirective
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
namespace Aspose.Email.Cloud.Sdk.Model
{
  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.ClientMessageApi.AppendFile" /> operation.
  /// </summary>
  public class ClientMessageAppendFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageAppendFileRequest"/> class.
        /// </summary>
        public ClientMessageAppendFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageAppendFileRequest"/> class.
        /// </summary>
        /// <param name="account">Email account.</param>
        /// <param name="file">Message file to append.</param>
        /// <param name="storage">Storage name where account file located.</param>
        /// <param name="accountStorageFolder">Folder in storage where account file located.</param>
        /// <param name="format">Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef</param>
        /// <param name="folder">Path to folder on email server to append message to.</param>
        /// <param name="markAsSent">Determines that appended message should be market as sent or not.</param>
        public ClientMessageAppendFileRequest(string account, System.IO.Stream file, string storage = null, string accountStorageFolder = null, string format = null, string folder = null, bool? markAsSent = null)
        {
            this.account = account;
            this.File = file;
            this.storage = storage;
            this.accountStorageFolder = accountStorageFolder;
            this.format = format;
            this.folder = folder;
            this.markAsSent = markAsSent;
        }

        /// <summary>
        /// Email account.
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// Message file to append.
        /// </summary>
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Storage name where account file located.
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        /// Folder in storage where account file located.
        /// </summary>
        public string accountStorageFolder { get; set; }

        /// <summary>
        /// Email file format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// Path to folder on email server to append message to.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Determines that appended message should be market as sent or not.
        /// </summary>
        public bool? markAsSent { get; set; }
  }
}
