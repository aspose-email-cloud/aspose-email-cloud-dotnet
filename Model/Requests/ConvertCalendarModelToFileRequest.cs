// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertCalendarModelToFileRequest.cs">
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
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.EmailApi.ConvertCalendarModelToFile" /> operation.
  /// </summary>
  public class ConvertCalendarModelToFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertCalendarModelToFileRequest"/> class.
        /// </summary>
        public ConvertCalendarModelToFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertCalendarModelToFileRequest"/> class.
        /// </summary>
        /// <param name="format">File format Enum, available values: Ics, Msg</param>
        /// <param name="calendarDto">Calendar model to convert</param>
        public ConvertCalendarModelToFileRequest(string format, CalendarDto calendarDto)
        {
            this.format = format;
            this.calendarDto = calendarDto;
        }

        /// <summary>
        /// File format Enum, available values: Ics, Msg
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// Calendar model to convert
        /// </summary>
        public CalendarDto calendarDto { get; set; }
  }
}
