// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiContactApi.cs">
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
    public class MapiContactApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapiContactApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal MapiContactApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    ﻿
        /// <summary>
        /// Converts MAPI contact model to ContactDto model.              
        /// </summary>
        /// <param name="mapiContactDto">MAPI contact model to convert.</param>
        /// <returns><see cref="ContactDto"/></returns>
        public ContactDto AsContactDto(
            MapiContactDto mapiContactDto)
        {
            // verify the required parameter 'mapiContactDto' is set
            if (mapiContactDto == null)
                throw new ApiException(400,
                    "Missing required parameter 'mapiContactDto' when calling AsContactDto");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiContact/as-contact-dto";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(mapiContactDto); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<ContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts MAPI contact model to ContactDto model.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactAsContactDtoRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public async Task<ContactDto> AsContactDtoAsync(
            MapiContactDto mapiContactDto) =>
            await Task.Run(() => AsContactDto(mapiContactDto
        ));
        #endif

                    ﻿
        /// <summary>
        /// Converts MAPI contact model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">MAPI contact model to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AsFile(
            MapiContactAsFileRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsFile");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiContact/as-file";
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
        /// Converts MAPI contact model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> AsFileAsync(
            MapiContactAsFileRequest request) =>
            await Task.Run(() => AsFile(request
        ));
        #endif

                    ﻿
        /// <summary>
        /// Converts contact file to a MAPI model representation.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactFromFileRequest" /></param>
        /// <returns><see cref="MapiContactDto"/></returns>
        public MapiContactDto FromFile(MapiContactFromFileRequest request)
        {
            // verify the required parameter 'fileFormat' is set
            if (request.fileFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileFormat' when calling FromFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling FromFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiContact/from-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileFormat", request.fileFormat);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                formParams: formParams);
            return response == null ? null : SerializationHelper.Deserialize<MapiContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts contact file to a MAPI model representation.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactFromFileRequest" /></param>
        /// <returns><see cref="MapiContactDto"/></returns>
        public async Task<MapiContactDto> FromFileAsync(MapiContactFromFileRequest request) =>
            await Task.Run(() => FromFile(request));
        #endif

                    ﻿
        /// <summary>
        /// Get MAPI contact document.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactGetRequest" /></param>
        /// <returns><see cref="MapiContactDto"/></returns>
        public MapiContactDto Get(MapiContactGetRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling Get");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Get");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiContact";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<MapiContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get MAPI contact document.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactGetRequest" /></param>
        /// <returns><see cref="MapiContactDto"/></returns>
        public async Task<MapiContactDto> GetAsync(MapiContactGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif

                    ﻿
        /// <summary>
        /// Save MAPI Contact to storage.              
        /// </summary>
        /// <param name="request">Create/Update contact request.</param>
        public void Save(
            MapiContactSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiContact";
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
        /// Save MAPI Contact to storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiContactSaveRequest" /></param>
        public async Task SaveAsync(
            MapiContactSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

    }
}
