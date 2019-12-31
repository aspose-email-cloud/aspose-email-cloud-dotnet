﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AuthRequestHandler.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Client;

    using Newtonsoft.Json;

    /// <summary>
    /// Auth request handler.
    /// </summary>
    /// <seealso cref="Aspose.Email.Cloud.Sdk.Client.Internal.RequestHandlers.IRequestHandler" />
    internal class AuthRequestHandler : IRequestHandler
    {
        #region Fields

        /// <summary>
        /// The configuration
        /// </summary>
        private readonly Configuration configuration;

        /// <summary>
        /// The API invoker
        /// </summary>
        private readonly ApiInvoker apiInvoker;

        /// <summary>
        /// The access token
        /// </summary>
        private string accessToken;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthRequestHandler"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public AuthRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>
            {
                new DebugLogRequestHandler(this.configuration), new ApiExceptionRequestHandler()
            };
            apiInvoker = new ApiInvoker(requestHandlers);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Processes the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// Processed URL.
        /// </returns>
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
            if (string.IsNullOrEmpty(this.accessToken))
            {
                this.RequestJwtToken();
            }

            request.Headers.Add("Authorization", "Bearer " + this.accessToken);
        }

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="resultStream">The result stream.</param>
        /// <exception cref="NeedRepeatRequestException"></exception>
        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RequestJwtToken();

                throw new NeedRepeatRequestException();
            }
        }


        /// <summary>
        /// Requests the JWT token.
        /// </summary>
        private void RequestJwtToken()
        {
            var requestUrl = configuration.AuthUrl + "connect/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + configuration.AppSid;
            postData += "&client_secret=" + configuration.AppKey;

            RequestToken(requestUrl, postData);
        }

        /// <summary>
        /// Requests the token.
        /// </summary>
        private void RequestToken(string tokenUrl, string postData)
        {
            var responseString = apiInvoker.InvokeApi(
                tokenUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded");
            var result =
                SerializationHelper.Deserialize<GetAccessTokenResult>(responseString);

            accessToken = result.AccessToken;
        }

        #endregion

        /// <summary>
        /// Token access result class.
        /// </summary>
        private class GetAccessTokenResult
        {
            /// <summary>
            /// Gets or sets the access token.
            /// </summary>
            /// <value>
            /// The access token.
            /// </value>
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }
        }        
    }
}