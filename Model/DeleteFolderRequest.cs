// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.FolderApi.DeleteFolder" /> operation.
  /// </summary>
  public class DeleteFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
        /// </summary>
        public DeleteFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files</param>
        public DeleteFolderRequest(string path, string storageName = null, bool? recursive = null)
        {
            Path = path;
            StorageName = storageName;
            Recursive = recursive;
        }

        /// <summary>
        /// Folder path e.g. '/folder'
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>
        public string StorageName { get; set; }

        /// <summary>
        /// Enable to delete folders, subfolders and files
        /// </summary>
        public bool? Recursive { get; set; }
  }
}
