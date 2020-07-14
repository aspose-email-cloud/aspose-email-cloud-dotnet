// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderApi.cs">
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
    public class FolderApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal FolderApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    ﻿
        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public void CopyFolder(CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public async Task CopyFolderAsync(CopyFolderRequest request) =>
            await Task.Run(() => CopyFolder(request));
        #endif

                    ﻿
        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public void CreateFolder(CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public async Task CreateFolderAsync(CreateFolderRequest request) =>
            await Task.Run(() => CreateFolder(request));
        #endif

                    ﻿
        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public void DeleteFolder(DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public async Task DeleteFolderAsync(DeleteFolderRequest request) =>
            await Task.Run(() => DeleteFolder(request));
        #endif

                    ﻿
        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<FilesList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>
        public async Task<FilesList> GetFilesListAsync(GetFilesListRequest request) =>
            await Task.Run(() => GetFilesList(request));
        #endif

                    ﻿
        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public void MoveFolder(MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public async Task MoveFolderAsync(MoveFolderRequest request) =>
            await Task.Run(() => MoveFolder(request));
        #endif

    }
}
