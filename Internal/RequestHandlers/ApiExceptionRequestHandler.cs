// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionRequestHandler.cs">
//   Copyright (c) 2018-2023 Aspose Pty Ltd. All rights reserved.
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

namespace Aspose.Email.Cloud.Sdk.Client.Internal.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;

    using Client;

    /// <summary>
    /// API exception request handler
    /// </summary>
    /// <seealso cref="Aspose.Email.Cloud.Sdk.Client.Internal.RequestHandlers.IRequestHandler" />
    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        #region Methods

        /// <summary>
        /// Processes the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>Processed URL.</returns>
        public string ProcessUrl(string url)
        {
            return url;
        }

        /// <summary>
        /// Processes parameters before sending.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="streamToSend">The stream to send.</param>
        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="resultStream">The result stream.</param>
        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.ThrowApiException(response, resultStream);
            }
        }

        /// <summary>
        /// Throws the API exception.
        /// </summary>
        /// <param name="webResponse">The web response.</param>
        /// <param name="resultStream">The result stream.</param>
        /// <exception cref="Aspose.Email.Cloud.Sdk.Client.ApiException"></exception>
        private void ThrowApiException(HttpWebResponse webResponse, Stream resultStream)
        {
            Exception resultException;
            string responseData = null;
            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    responseData = responseReader.ReadToEnd();
                    var error = SerializationHelper.Deserialize<ApiErrorModel>(responseData);
                    resultException = new ApiException((int)webResponse.StatusCode, error.Error.Message, error.Error);
                }
            }
            catch (Exception)
            {
                resultException = new ApiException((int)webResponse.StatusCode, responseData ?? webResponse.StatusDescription);
            }

            throw resultException;
        }

        #endregion
    }
}
