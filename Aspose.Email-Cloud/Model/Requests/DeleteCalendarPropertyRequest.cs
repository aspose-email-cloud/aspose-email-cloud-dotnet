
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteCalendarPropertyRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.DeleteCalendarProperty" /> operation.
  /// </summary>
  public class DeleteCalendarPropertyRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCalendarPropertyRequest"/> class.
        /// </summary>
        public DeleteCalendarPropertyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCalendarPropertyRequest"/> class.
        /// </summary>
        /// <param name="name">iCalendar file name in storage</param>
        /// <param name="memberName">Indexed property name</param>
        /// <param name="index">Property index path</param>
        /// <param name="request">Storage detail to specify iCalendar file location</param>
        public DeleteCalendarPropertyRequest(string name, string memberName, string index, StorageFolderLocation request)
        {
            this.name = name;
            this.memberName = memberName;
            this.index = index;
            this.request = request;
        }

        /// <summary>
        /// iCalendar file name in storage
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Indexed property name
        /// </summary>
        public string memberName { get; set; }

        /// <summary>
        /// Property index path
        /// </summary>
        public string index { get; set; }

        /// <summary>
        /// Storage detail to specify iCalendar file location
        /// </summary>
        public StorageFolderLocation request { get; set; }
  }
}