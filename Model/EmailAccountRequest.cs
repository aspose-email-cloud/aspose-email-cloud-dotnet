// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailAccountRequest.cs">
//   Copyright (c) 2016 Aspose.Email for Cloud
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

namespace Aspose.Email.Cloud.Sdk.Model
{
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Email account settings request
  /// </summary>
  public class EmailAccountRequest 
  {
        /// <summary>
        /// Email account host
        /// </summary>  
        public string Host { get; set; }

        /// <summary>
        /// Email account port
        /// </summary>  
        public int? Port { get; set; }

        /// <summary>
        /// Email account login
        /// </summary>  
        public string Login { get; set; }

        /// <summary>
        /// Email account security options
        /// </summary>  
        public Object SecurityOptions { get; set; }

        /// <summary>
        /// Email account protocol type
        /// </summary>  
        public Object ProtocolType { get; set; }

        /// <summary>
        /// Email account description
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// A storage file location info to store email account
        /// </summary>  
        public StorageFileLocation StorageFile { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailAccountRequest {\n");
          sb.Append("  Host: ").Append(this.Host).Append("\n");
          sb.Append("  Port: ").Append(this.Port).Append("\n");
          sb.Append("  Login: ").Append(this.Login).Append("\n");
          sb.Append("  SecurityOptions: ").Append(this.SecurityOptions).Append("\n");
          sb.Append("  ProtocolType: ").Append(this.ProtocolType).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  StorageFile: ").Append(this.StorageFile).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
