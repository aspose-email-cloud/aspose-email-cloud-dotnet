// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiBcrOcrDataPart.cs">
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
    /// Recognized text block             
    /// </summary>
    public class AiBcrOcrDataPart 
    {
        /// <summary>
        /// X position of text block             
        /// </summary>  
        public double? X { get; set; }

        /// <summary>
        /// Y position of text block             
        /// </summary>  
        public double? Y { get; set; }

        /// <summary>
        /// Width of text block             
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// Height of text block             
        /// </summary>  
        public double? Height { get; set; }

        /// <summary>
        /// Recognized text             
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Additional recognition result details             
        /// </summary>  
        public Dictionary<string, string> Details { get; set; }

        /// <summary>AiBcrOcrDataPart constructor</summary>
        public AiBcrOcrDataPart() {}

        /// <summary>AiBcrOcrDataPart constructor</summary>
        /// <param name="x">X position of text block             </param>
        /// <param name="y">Y position of text block             </param>
        /// <param name="width">Width of text block             </param>
        /// <param name="height">Height of text block             </param>
        /// <param name="text">Recognized text             </param>
        /// <param name="details">Additional recognition result details             </param>
        public AiBcrOcrDataPart(double? x, double? y, double? width, double? height, string text, Dictionary<string, string> details)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Text = text;
            Details = details;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AiBcrOcrDataPart {\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Details: ").Append(this.Details).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
