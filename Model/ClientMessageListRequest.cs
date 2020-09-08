// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientMessageListRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.ClientMessageApi.List" /> operation.
  /// </summary>
  public class ClientMessageListRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageListRequest"/> class.
        /// </summary>
        public ClientMessageListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageListRequest"/> class.
        /// </summary>
        /// <param name="folder">A folder in email account</param>
        /// <param name="account">Email account</param>
        /// <param name="queryString">A MailQuery search string</param>
        /// <param name="storage">Storage name where account file located</param>
        /// <param name="accountStorageFolder">Folder in storage where account file located</param>
        /// <param name="recursive">Specifies that should message be searched in subfolders recursively</param>
        /// <param name="type">MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64</param>
        /// <param name="format">Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft</param>
        public ClientMessageListRequest(string folder, string account, string queryString = null, string storage = null, string accountStorageFolder = null, bool? recursive = null, string type = null, string format = null)
        {
            this.folder = folder;
            this.account = account;
            this.queryString = queryString;
            this.storage = storage;
            this.accountStorageFolder = accountStorageFolder;
            this.recursive = recursive;
            this.type = type;
            this.format = format;
        }

        /// <summary>
        /// A folder in email account
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Email account
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// A MailQuery search string
        /// </summary>
        public string queryString { get; set; }

        /// <summary>
        /// Storage name where account file located
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        /// Folder in storage where account file located
        /// </summary>
        public string accountStorageFolder { get; set; }

        /// <summary>
        /// Specifies that should message be searched in subfolders recursively
        /// </summary>
        public bool? recursive { get; set; }

        /// <summary>
        /// MailMessageBase type. Using this property you can get messages in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string).              Enum, available values: Dto, Mapi, Base64
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Base64 data format. Used only if type is set to Base64. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft
        /// </summary>
        public string format { get; set; }
  }
}
