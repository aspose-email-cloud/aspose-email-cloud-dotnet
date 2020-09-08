// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientThreadGetListRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.ClientThreadApi.GetList" /> operation.
  /// </summary>
  public class ClientThreadGetListRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientThreadGetListRequest"/> class.
        /// </summary>
        public ClientThreadGetListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientThreadGetListRequest"/> class.
        /// </summary>
        /// <param name="folder">A folder in email account.             </param>
        /// <param name="account">Email account</param>
        /// <param name="storage">Storage name where account file located</param>
        /// <param name="accountStorageFolder">Folder in storage where account file located</param>
        /// <param name="updateFolderCache">This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account             </param>
        /// <param name="messagesCacheLimit">Limit messages cache size if CacheFile is used. Ignored in accounts without limits support             </param>
        public ClientThreadGetListRequest(string folder, string account, string storage = null, string accountStorageFolder = null, bool? updateFolderCache = null, int? messagesCacheLimit = null)
        {
            Folder = folder;
            Account = account;
            Storage = storage;
            AccountStorageFolder = accountStorageFolder;
            UpdateFolderCache = updateFolderCache;
            MessagesCacheLimit = messagesCacheLimit;
        }

        /// <summary>
        /// A folder in email account.             
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Email account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Storage name where account file located
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Folder in storage where account file located
        /// </summary>
        public string AccountStorageFolder { get; set; }

        /// <summary>
        /// This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account             
        /// </summary>
        public bool? UpdateFolderCache { get; set; }

        /// <summary>
        /// Limit messages cache size if CacheFile is used. Ignored in accounts without limits support             
        /// </summary>
        public int? MessagesCacheLimit { get; set; }
  }
}
