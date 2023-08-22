// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ContactApi.cs">
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
    public class ContactApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal ContactApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }

        /// <summary>
        /// Converts contact model to specified format and returns as file              
        /// </summary>
        /// <param name="request">Contact model and format to convert</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AsFile(
            ContactAsFileRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsFile");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/as-file";
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
        /// Converts contact model to specified format and returns as file              
        /// </summary>
        /// <param name="request">Contact model and format to convert</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> AsFileAsync(
            ContactAsFileRequest request) =>
            await Task.Run(() => AsFile(request
        ));
        #endif


        /// <summary>
        /// Converts ContactDto to MapiContactDto.              
        /// </summary>
        /// <param name="contactDto">Contact model to convert</param>
        /// <returns><see cref="MapiContactDto"/></returns>
        public MapiContactDto AsMapi(
            ContactDto contactDto)
        {
            // verify the required parameter 'contactDto' is set
            if (contactDto == null)
                throw new ApiException(400,
                    "Missing required parameter 'contactDto' when calling AsMapi");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/as-mapi";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(contactDto); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<MapiContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts ContactDto to MapiContactDto.              
        /// </summary>
        /// <param name="contactDto">Contact model to convert</param>
        /// <returns><see cref="MapiContactDto"/></returns>
        public async Task<MapiContactDto> AsMapiAsync(
            ContactDto contactDto) =>
            await Task.Run(() => AsMapi(contactDto
        ));
        #endif


        /// <summary>
        /// Converts contact document to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactConvertRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream Convert(ContactConvertRequest request)
        {
            // verify the required parameter 'toFormat' is set
            if (request.ToFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'toFormat' when calling Convert");
            }

            // verify the required parameter 'fromFormat' is set
            if (request.FromFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fromFormat' when calling Convert");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling Convert");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/convert";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "toFormat", request.ToFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromFormat", request.FromFormat);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "PUT",
                null,
                null,
                formParams);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts contact document to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactConvertRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> ConvertAsync(ContactConvertRequest request) =>
            await Task.Run(() => Convert(request));
        #endif


        /// <summary>
        /// Converts contact document to a model representation              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactFromFileRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public ContactDto FromFile(ContactFromFileRequest request)
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/from-file";
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
            return response == null ? null : SerializationHelper.Deserialize<ContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts contact document to a model representation              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactFromFileRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public async Task<ContactDto> FromFileAsync(ContactFromFileRequest request) =>
            await Task.Run(() => FromFile(request));
        #endif


        /// <summary>
        /// Get contact document from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactGetRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public ContactDto Get(ContactGetRequest request)
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact";
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
            return response == null ? null : SerializationHelper.Deserialize<ContactDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get contact document from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactGetRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public async Task<ContactDto> GetAsync(ContactGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif


        /// <summary>
        /// Converts contact document from storage to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactGetAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetAsFile(ContactGetAsFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetAsFile");
            }

            // verify the required parameter 'toFormat' is set
            if (request.ToFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'toFormat' when calling GetAsFile");
            }

            // verify the required parameter 'fromFormat' is set
            if (request.FromFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fromFormat' when calling GetAsFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/as-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "toFormat", request.ToFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromFormat", request.FromFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts contact document from storage to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactGetAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetAsFileAsync(ContactGetAsFileRequest request) =>
            await Task.Run(() => GetAsFile(request));
        #endif


        /// <summary>
        /// Get contact list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactGetListRequest" /></param>
        /// <returns><see cref="ContactStorageList"/></returns>
        public ContactStorageList GetList(ContactGetListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/list";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "itemsPerPage", request.ItemsPerPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.PageNumber);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<ContactStorageList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get contact list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="ContactGetListRequest" /></param>
        /// <returns><see cref="ContactStorageList"/></returns>
        public async Task<ContactStorageList> GetListAsync(ContactGetListRequest request) =>
            await Task.Run(() => GetList(request));
        #endif


        /// <summary>
        /// Save contact to storage.              
        /// </summary>
        /// <param name="request">Create/Update contact request.</param>
        public void Save(
            ContactSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact";
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
        /// Save contact to storage.              
        /// </summary>
        /// <param name="request">Create/Update contact request.</param>
        public async Task SaveAsync(
            ContactSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

    }
}
