// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientAccountApi.cs">
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

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
namespace Aspose.Email.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    #if (NET452 || NETSTANDARD2_0)
    using System.Threading.Tasks;
    #endif

    /// <summary>
    /// Aspose.Email for Cloud API.  operations.
    /// </summary>
    public class ClientAccountApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAccountApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal ClientAccountApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    ﻿
        /// <summary>
        /// Get email client account from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientAccountGetRequest" /></param>
        /// <returns><see cref="EmailClientAccount"/></returns>
        public EmailClientAccount Get(ClientAccountGetRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Get");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ClientAccount";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<EmailClientAccount>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email client account from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientAccountGetRequest" /></param>
        /// <returns><see cref="EmailClientAccount"/></returns>
        public async Task<EmailClientAccount> GetAsync(ClientAccountGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif

                    ﻿
        /// <summary>
        /// Get email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientAccountGetMultiRequest" /></param>
        /// <returns><see cref="EmailClientMultiAccount"/></returns>
        public EmailClientMultiAccount GetMulti(ClientAccountGetMultiRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMulti");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ClientAccount/multi";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<EmailClientMultiAccount>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientAccountGetMultiRequest" /></param>
        /// <returns><see cref="EmailClientMultiAccount"/></returns>
        public async Task<EmailClientMultiAccount> GetMultiAsync(ClientAccountGetMultiRequest request) =>
            await Task.Run(() => GetMulti(request));
        #endif

                    ﻿
        /// <summary>
        /// Create/update email client account file (*.account) with credentials              
        /// </summary>
        /// <param name="request">Email account information</param>
        public void Save(
            EmailClientAccountSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ClientAccount";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create/update email client account file (*.account) with credentials              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientAccountSaveRequest" /></param>
        public async Task SaveAsync(
            EmailClientAccountSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

                    ﻿
        /// <summary>
        /// Create email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.              
        /// </summary>
        /// <param name="request">Email accounts information.</param>
        public void SaveMulti(
            EmailClientMultiAccountSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SaveMulti");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ClientAccount/multi";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientAccountSaveMultiRequest" /></param>
        public async Task SaveMultiAsync(
            EmailClientMultiAccountSaveRequest request) =>
            await Task.Run(() => SaveMulti(request
        ));
        #endif

    }
}
