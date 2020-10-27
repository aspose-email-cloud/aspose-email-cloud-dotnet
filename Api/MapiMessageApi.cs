// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiMessageApi.cs">
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
    public class MapiMessageApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapiMessageApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal MapiMessageApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }

        /// <summary>
        /// Converts MAPI message model to EmailDto model              
        /// </summary>
        /// <param name="mapiMessage">MAPI message model to convert</param>
        /// <returns><see cref="EmailDto"/></returns>
        public EmailDto AsEmailDto(
            MapiMessageDto mapiMessage)
        {
            // verify the required parameter 'mapiMessage' is set
            if (mapiMessage == null)
                throw new ApiException(400,
                    "Missing required parameter 'mapiMessage' when calling AsEmailDto");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiMessage/as-email-dto";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(mapiMessage); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<EmailDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts MAPI message model to EmailDto model              
        /// </summary>
        /// <param name="mapiMessage">MAPI message model to convert</param>
        /// <returns><see cref="EmailDto"/></returns>
        public async Task<EmailDto> AsEmailDtoAsync(
            MapiMessageDto mapiMessage) =>
            await Task.Run(() => AsEmailDto(mapiMessage
        ));
        #endif


        /// <summary>
        /// Converts MAPI message model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">MAPI message model to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AsFile(
            MapiMessageAsFileRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsFile");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiMessage/as-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts MAPI message model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">MAPI message model to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> AsFileAsync(
            MapiMessageAsFileRequest request) =>
            await Task.Run(() => AsFile(request
        ));
        #endif


        /// <summary>
        /// Converts email file to a MAPI model representation              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiMessageFromFileRequest" /></param>
        /// <returns><see cref="MapiMessageDto"/></returns>
        public MapiMessageDto FromFile(MapiMessageFromFileRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling FromFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling FromFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiMessage/from-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                formParams: formParams);
            return response == null ? null : SerializationHelper.Deserialize<MapiMessageDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts email file to a MAPI model representation              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiMessageFromFileRequest" /></param>
        /// <returns><see cref="MapiMessageDto"/></returns>
        public async Task<MapiMessageDto> FromFileAsync(MapiMessageFromFileRequest request) =>
            await Task.Run(() => FromFile(request));
        #endif


        /// <summary>
        /// Get MAPI message document.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiMessageGetRequest" /></param>
        /// <returns><see cref="MapiMessageDto"/></returns>
        public MapiMessageDto Get(MapiMessageGetRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling Get");
            }

            // verify the required parameter 'fileName' is set
            if (request.FileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling Get");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiMessage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<MapiMessageDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get MAPI message document.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiMessageGetRequest" /></param>
        /// <returns><see cref="MapiMessageDto"/></returns>
        public async Task<MapiMessageDto> GetAsync(MapiMessageGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif


        /// <summary>
        /// Save MAPI message to storage.              
        /// </summary>
        /// <param name="request">Message create/update request.</param>
        public void Save(
            MapiMessageSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiMessage";
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
        /// Save MAPI message to storage.              
        /// </summary>
        /// <param name="request">Message create/update request.</param>
        public async Task SaveAsync(
            MapiMessageSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

    }
}
