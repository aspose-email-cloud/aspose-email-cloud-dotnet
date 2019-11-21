// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailApi.cs">
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

namespace Aspose.Email.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Model.Requests;
    using Client;
    using Client.Internal.RequestHandlers;
    #if (NET452 || NETSTANDARD2_0)
    using System.Threading.Tasks;
    #endif

    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class StorageApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public StorageApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public StorageApi(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>
            {
                new AuthRequestHandler(this.configuration),
                new DebugLogRequestHandler(this.configuration),
                new ApiExceptionRequestHandler()
            };
            apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage"/></returns>
        public DiscUsage GetDiscUsage(Model.Requests.GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/disc";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<DiscUsage>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage"/></returns>
        public async Task<DiscUsage> GetDiscUsageAsync(Model.Requests.GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/disc";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<DiscUsage>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions"/></returns>
        public FileVersions GetFileVersions(Model.Requests.GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/version/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FileVersions>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions"/></returns>
        public async Task<FileVersions> GetFileVersionsAsync(Model.Requests.GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/version/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FileVersions>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist"/></returns>
        public ObjectExist ObjectExists(Model.Requests.ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/exist/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ObjectExist>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist"/></returns>
        public async Task<ObjectExist> ObjectExistsAsync(Model.Requests.ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/exist/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ObjectExist>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist"/></returns>
        public StorageExist StorageExists(Model.Requests.StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/{storageName}/exist";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<StorageExist>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist"/></returns>
        public async Task<StorageExist> StorageExistsAsync(Model.Requests.StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/{storageName}/exist";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<StorageExist>(response);
            }

            return null;
        }
        #endif
    }
}