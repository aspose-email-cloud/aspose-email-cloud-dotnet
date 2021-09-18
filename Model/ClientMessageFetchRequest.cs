// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientMessageFetchRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.ClientMessageApi.Fetch" /> operation.
  /// </summary>
  public class ClientMessageFetchRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageFetchRequest"/> class.
        /// </summary>
        public ClientMessageFetchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageFetchRequest"/> class.
        /// </summary>
        /// <param name="messageId">Message identifier</param>
        /// <param name="account">Email account</param>
        /// <param name="folder">Account folder to fetch from (should be specified for some protocols such as IMAP)             </param>
        /// <param name="storage">Storage name where account file located.</param>
        /// <param name="accountStorageFolder">Folder in storage where account file located.</param>
        /// <param name="type">MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string)./nEnum, available values: Dto, Mapi, Base64</param>
        /// <param name="format">Base64 data format. Used only if type is set to Base64./nEnum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft</param>
        public ClientMessageFetchRequest(string messageId, string account, string folder = null, string storage = null, string accountStorageFolder = null, string type = null, string format = null)
        {
            MessageId = messageId;
            Account = account;
            Folder = folder;
            Storage = storage;
            AccountStorageFolder = accountStorageFolder;
            Type = type;
            Format = format;
        }

        /// <summary>
        /// Message identifier
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Email account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Account folder to fetch from (should be specified for some protocols such as IMAP)             
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Storage name where account file located.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Folder in storage where account file located.
        /// </summary>
        public string AccountStorageFolder { get; set; }

        /// <summary>
        /// MailMessageBase type. Using this property you can fetch message in different formats (as EmailDto, MapiMessageDto or a file represented as Base64 string)./nEnum, available values: Dto, Mapi, Base64
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Base64 data format. Used only if type is set to Base64./nEnum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft
        /// </summary>
        public string Format { get; set; }
  }
}
