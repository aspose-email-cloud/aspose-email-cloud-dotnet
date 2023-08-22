// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailGetListRequest.cs">
//   Copyright (c) 2018-2023 Aspose.Email for Cloud
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.GetList" /> operation.
  /// </summary>
  public class EmailGetListRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGetListRequest"/> class.
        /// </summary>
        public EmailGetListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGetListRequest"/> class.
        /// </summary>
        /// <param name="format">Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft</param>
        /// <param name="folder">Path to folder in storage.</param>
        /// <param name="storage">Storage name.</param>
        /// <param name="itemsPerPage">Count of items on page.</param>
        /// <param name="pageNumber">Page number.</param>
        public EmailGetListRequest(string format, string folder = null, string storage = null, int? itemsPerPage = null, int? pageNumber = null)
        {
            Format = format;
            Folder = folder;
            Storage = storage;
            ItemsPerPage = itemsPerPage;
            PageNumber = pageNumber;
        }

        /// <summary>
        /// Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html, Tnef, Oft
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Path to folder in storage.
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Count of items on page.
        /// </summary>
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        public int? PageNumber { get; set; }
  }
}
