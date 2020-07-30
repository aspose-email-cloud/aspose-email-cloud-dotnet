// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientThreadApi.cs">
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
    public class ClientThreadApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientThreadApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal ClientThreadApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    ﻿
        /// <summary>
        /// Delete thread by id. All messages from thread will also be deleted.              
        /// </summary>
        /// <param name="request">Delete email thread request.</param>
        public void Delete(
            ClientThreadDeleteRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Delete");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/thread";
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
        /// Delete thread by id. All messages from thread will also be deleted.              
        /// </summary>
        /// <param name="request">Delete email thread request.</param>
        public async Task DeleteAsync(
            ClientThreadDeleteRequest request) =>
            await Task.Run(() => Delete(request
        ));
        #endif

                    ﻿
        /// <summary>
        /// Get message threads from folder. All messages are partly fetched (without email body and some other fields).              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientThreadGetListRequest" /></param>
        /// <returns><see cref="EmailThreadList"/></returns>
        public EmailThreadList GetList(ClientThreadGetListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling GetList");
            }

            // verify the required parameter 'account' is set
            if (request.account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling GetList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/thread/list";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.accountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "updateFolderCache", request.updateFolderCache);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messagesCacheLimit", request.messagesCacheLimit);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<EmailThreadList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get message threads from folder. All messages are partly fetched (without email body and some other fields).              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientThreadGetListRequest" /></param>
        /// <returns><see cref="EmailThreadList"/></returns>
        public async Task<EmailThreadList> GetListAsync(ClientThreadGetListRequest request) =>
            await Task.Run(() => GetList(request));
        #endif

                    ﻿
        /// <summary>
        /// Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientThreadGetMessagesRequest" /></param>
        /// <returns><see cref="EmailList"/></returns>
        public EmailList GetMessages(ClientThreadGetMessagesRequest request)
        {
            // verify the required parameter 'threadId' is set
            if (request.threadId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'threadId' when calling GetMessages");
            }

            // verify the required parameter 'account' is set
            if (request.account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling GetMessages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/thread/messages";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "threadId", request.threadId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.accountStorageFolder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<EmailList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientThreadGetMessagesRequest" /></param>
        /// <returns><see cref="EmailList"/></returns>
        public async Task<EmailList> GetMessagesAsync(ClientThreadGetMessagesRequest request) =>
            await Task.Run(() => GetMessages(request));
        #endif

                    ﻿
        /// <summary>
        /// Move thread to another folder.              
        /// </summary>
        /// <param name="request">Move thread request.</param>
        public void Move(
            ClientThreadMoveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Move");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/thread/move";
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
        /// Move thread to another folder.              
        /// </summary>
        /// <param name="request">Move thread request.</param>
        public async Task MoveAsync(
            ClientThreadMoveRequest request) =>
            await Task.Run(() => Move(request
        ));
        #endif

                    ﻿
        /// <summary>
        /// Mark all messages in thread as read or unread.              
        /// </summary>
        /// <param name="request">Email account specifier and IsRead flag.</param>
        public void SetIsRead(
            ClientThreadSetIsReadRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SetIsRead");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/thread/set-is-read";
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
        /// Mark all messages in thread as read or unread.              
        /// </summary>
        /// <param name="request">Email account specifier and IsRead flag.</param>
        public async Task SetIsReadAsync(
            ClientThreadSetIsReadRequest request) =>
            await Task.Run(() => SetIsRead(request
        ));
        #endif

    }
}
