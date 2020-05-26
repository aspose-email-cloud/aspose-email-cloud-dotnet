// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.CopyFolder" /> operation.
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
        /// <param name="srcPath"></param>
        /// <param name="destPath"></param>
        /// <param name="srcStorageName"></param>
        /// <param name="destStorageName"></param>
        public CopyFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.srcStorageName = srcStorageName;
            this.destStorageName = destStorageName;
        }

        /// <summary>
        /// Gets or sets srcPath
        /// </summary>
        public string srcPath { get; set; }

        /// <summary>
        /// Gets or sets destPath
        /// </summary>
        public string destPath { get; set; }

        /// <summary>
        /// Gets or sets srcStorageName
        /// </summary>
        public string srcStorageName { get; set; }

        /// <summary>
        /// Gets or sets destStorageName
        /// </summary>
        public string destStorageName { get; set; }
  }
}
