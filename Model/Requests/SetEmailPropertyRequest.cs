
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SetEmailPropertyRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.SetEmailProperty" /> operation.
  /// </summary>
  public class SetEmailPropertyRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetEmailPropertyRequest"/> class.
        /// </summary>
        public SetEmailPropertyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetEmailPropertyRequest"/> class.
        /// </summary>
        /// <param name="propertyName">A property name that should be changed</param>
        /// <param name="fileName">Email document file name</param>
        /// <param name="request">A property that should be changed and optional Storage info to specify             where the file located</param>
        public SetEmailPropertyRequest(string propertyName, string fileName, SetEmailPropertyRequest request)
        {
            this.propertyName = propertyName;
            this.fileName = fileName;
            this.request = request;
        }

        /// <summary>
        /// A property name that should be changed
        /// </summary>
        public string propertyName { get; set; }

        /// <summary>
        /// Email document file name
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// A property that should be changed and optional Storage info to specify             where the file located
        /// </summary>
        public SetEmailPropertyRequest request { get; set; }
  }
}
