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
                    
        /// <summary>
        /// Parse images to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseRequest" /></param>
        /// <returns><see cref="ContactList"/></returns>
        public ContactList Parse(AiBcrParseRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling Parse");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countries", request.Countries);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "languages", request.Languages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isSingle", request.IsSingle);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                formParams: formParams);
            return response == null ? null : SerializationHelper.Deserialize<ContactList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseRequest" /></param>
        /// <returns><see cref="ContactList"/></returns>
        public async Task<ContactList> ParseAsync(AiBcrParseRequest request) =>
            await Task.Run(() => Parse(request));
        #endif

                    
        /// <summary>
        /// Parse images from storage to vCard files              
        /// </summary>
        /// <param name="request">Request with images located on storage</param>
        /// <returns><see cref="StorageFileLocationList"/></returns>
        public StorageFileLocationList ParseStorage(
            AiBcrParseStorageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling ParseStorage");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-storage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<StorageFileLocationList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images from storage to vCard files              
        /// </summary>
        /// <param name="request">Request with images located on storage</param>
        /// <returns><see cref="StorageFileLocationList"/></returns>
        public async Task<StorageFileLocationList> ParseStorageAsync(
            AiBcrParseStorageRequest request) =>
            await Task.Run(() => ParseStorage(request
        ));
        #endif

    }
}
