// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateMapiRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.CreateMapi" /> operation.
  /// </summary>
  public class CreateMapiRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMapiRequest"/> class.
        /// </summary>
        public CreateMapiRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMapiRequest"/> class.
        /// </summary>
        /// <param name="name">Document file name</param>
        /// <param name="request">Create document request</param>
        public CreateMapiRequest(string name, HierarchicalObjectRequest request)
        {
            this.name = name;
            this.request = request;
        }

        /// <summary>
        /// Document file name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Create document request
        /// </summary>
        public HierarchicalObjectRequest request { get; set; }
  }
}
