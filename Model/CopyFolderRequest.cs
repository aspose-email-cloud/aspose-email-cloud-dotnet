// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.FolderApi.CopyFolder" /> operation.
  /// </summary>
  public class CopyFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>
        public CopyFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name</param>
        /// <param name="destStorageName">Destination storage name</param>
        public CopyFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
        {
            SrcPath = srcPath;
            DestPath = destPath;
            SrcStorageName = srcStorageName;
            DestStorageName = destStorageName;
        }

        /// <summary>
        /// Source folder path e.g. '/src'
        /// </summary>
        public string SrcPath { get; set; }

        /// <summary>
        /// Destination folder path e.g. '/dst'
        /// </summary>
        public string DestPath { get; set; }

        /// <summary>
        /// Source storage name
        /// </summary>
        public string SrcStorageName { get; set; }

        /// <summary>
        /// Destination storage name
        /// </summary>
        public string DestStorageName { get; set; }
  }
}
