// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientFolderGetListRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.ClientFolderApi.GetList" /> operation.
  /// </summary>
  public class ClientFolderGetListRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientFolderGetListRequest"/> class.
        /// </summary>
        public ClientFolderGetListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientFolderGetListRequest"/> class.
        /// </summary>
        /// <param name="account">Email account</param>
        /// <param name="storage">Storage name where account file located</param>
        /// <param name="accountStorageFolder">Folder in storage where account file located</param>
        /// <param name="parentFolder">Folder in which subfolders should be listed</param>
        public ClientFolderGetListRequest(string account, string storage = null, string accountStorageFolder = null, string parentFolder = null)
        {
            this.account = account;
            this.storage = storage;
            this.accountStorageFolder = accountStorageFolder;
            this.parentFolder = parentFolder;
        }

        /// <summary>
        /// Email account
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// Storage name where account file located
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        /// Folder in storage where account file located
        /// </summary>
        public string accountStorageFolder { get; set; }

        /// <summary>
        /// Folder in which subfolders should be listed
        /// </summary>
        public string parentFolder { get; set; }
  }
}
