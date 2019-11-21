
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteMapiPropertiesRequest.cs">
//   Copyright (c) 2018 Aspose.Email for Cloud
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.MapiApi.DeleteMapiProperties" /> operation.
  /// </summary>
  public class DeleteMapiPropertiesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMapiPropertiesRequest"/> class.
        /// </summary>
        public DeleteMapiPropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMapiPropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">Document file name</param>
        /// <param name="request">Properties that should be deleted</param>
        public DeleteMapiPropertiesRequest(string name, HierarchicalObjectRequest request)
        {
            this.name = name;
            this.request = request;
        }

        /// <summary>
        /// Document file name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Properties that should be deleted
        /// </summary>
        public HierarchicalObjectRequest request { get; set; }
  }
}