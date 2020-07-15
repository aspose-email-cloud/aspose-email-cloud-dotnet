// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiBcrApi.cs">
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
    public class AiBcrApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="AiBcrApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal AiBcrApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    ﻿
        /// <summary>
        /// Parse images to vCard document models              
        /// </summary>
        /// <param name="rq">Request with base64 images data</param>
        /// <returns><see cref="ListResponseOfContactDto"/></returns>
        public ListResponseOfContactDto Parse(
            AiBcrBase64Rq rq)
        {
            // verify the required parameter 'rq' is set
            if (rq == null)
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling Parse");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<ListResponseOfContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseRequest" /></param>
        /// <returns><see cref="ListResponseOfContactDto"/></returns>
        public async Task<ListResponseOfContactDto> ParseAsync(
            AiBcrBase64Rq rq) =>
            await Task.Run(() => Parse(rq
        ));
        #endif

                    ﻿
        /// <summary>
        /// Parse images from storage to vCard files              
        /// </summary>
        /// <param name="rq">Request with images located on storage</param>
        /// <returns><see cref="ListResponseOfStorageFileLocation"/></returns>
        public ListResponseOfStorageFileLocation ParseStorage(
            AiBcrParseStorageRq rq)
        {
            // verify the required parameter 'rq' is set
            if (rq == null)
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling ParseStorage");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-storage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<ListResponseOfStorageFileLocation>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images from storage to vCard files              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseStorageRequest" /></param>
        /// <returns><see cref="ListResponseOfStorageFileLocation"/></returns>
        public async Task<ListResponseOfStorageFileLocation> ParseStorageAsync(
            AiBcrParseStorageRq rq) =>
            await Task.Run(() => ParseStorage(rq
        ));
        #endif

    }
}
