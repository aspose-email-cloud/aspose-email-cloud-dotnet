// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientFolderApi.cs">
//   Copyright (c) 2018-2023 Aspose.Email for Cloud
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
    public class ClientFolderApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientFolderApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal ClientFolderApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }

        /// <summary>
        /// Create new folder in email account              
        /// </summary>
        /// <param name="request">Create folder request</param>
        public void Create(
            ClientFolderCreateRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Create");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/folder";
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
        /// Create new folder in email account              
        /// </summary>
        /// <param name="request">Create folder request</param>
        public async Task CreateAsync(
            ClientFolderCreateRequest request) =>
            await Task.Run(() => Create(request
        ));
        #endif


        /// <summary>
        /// Delete a folder in email account              
        /// </summary>
        /// <param name="request">Delete folder request</param>
        public void Delete(
            ClientFolderDeleteRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Delete");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/folder";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete a folder in email account              
        /// </summary>
        /// <param name="request">Delete folder request</param>
        public async Task DeleteAsync(
            ClientFolderDeleteRequest request) =>
            await Task.Run(() => Delete(request
        ));
        #endif


        /// <summary>
        /// Get folders list in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientFolderGetListRequest" /></param>
        /// <returns><see cref="MailServerFolderList"/></returns>
        public MailServerFolderList GetList(ClientFolderGetListRequest request)
        {
            // verify the required parameter 'account' is set
            if (request.Account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling GetList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/folder/list";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.Account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.AccountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentFolder", request.ParentFolder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<MailServerFolderList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get folders list in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientFolderGetListRequest" /></param>
        /// <returns><see cref="MailServerFolderList"/></returns>
        public async Task<MailServerFolderList> GetListAsync(ClientFolderGetListRequest request) =>
            await Task.Run(() => GetList(request));
        #endif

    }
}
