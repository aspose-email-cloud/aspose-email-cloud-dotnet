// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarGetListRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.CalendarApi.GetList" /> operation.
  /// </summary>
  public class CalendarGetListRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarGetListRequest"/> class.
        /// </summary>
        public CalendarGetListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarGetListRequest"/> class.
        /// </summary>
        /// <param name="folder">Path to folder in storage.</param>
        /// <param name="itemsPerPage">Count of items on page.</param>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="storage">Storage name.</param>
        public CalendarGetListRequest(string folder, int? itemsPerPage = null, int? pageNumber = null, string storage = null)
        {
            this.folder = folder;
            this.itemsPerPage = itemsPerPage;
            this.pageNumber = pageNumber;
            this.storage = storage;
        }

        /// <summary>
        /// Path to folder in storage.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Count of items on page.
        /// </summary>
        public int? itemsPerPage { get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        public int? pageNumber { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string storage { get; set; }
  }
}
