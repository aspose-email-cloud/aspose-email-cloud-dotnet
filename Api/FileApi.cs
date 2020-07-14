// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileApi.cs">
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
    public class FileApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal FileApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    ﻿
        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public void CopyFile(CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public async Task CopyFileAsync(CopyFileRequest request) =>
            await Task.Run(() => CopyFile(request));
        #endif

                    ﻿
        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public void DeleteFile(DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public async Task DeleteFileAsync(DeleteFileRequest request) =>
            await Task.Run(() => DeleteFile(request));
        #endif

                    ﻿
        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> DownloadFileAsync(DownloadFileRequest request) =>
            await Task.Run(() => DownloadFile(request));
        #endif

                    ﻿
        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public void MoveFile(MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT");
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public async Task MoveFileAsync(MoveFileRequest request) =>
            await Task.Run(() => MoveFile(request));
        #endif

                    ﻿
        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling UploadFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                formParams: formParams);
            return response == null ? null : SerializationHelper.Deserialize<FilesUploadResult>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>
        public async Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request) =>
            await Task.Run(() => UploadFile(request));
        #endif

    }
}
