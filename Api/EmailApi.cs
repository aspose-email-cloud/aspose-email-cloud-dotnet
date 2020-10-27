// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailApi.cs">
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
    public class EmailApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal EmailApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }

        /// <summary>
        /// Converts Email model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Email model and format to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AsFile(
            EmailAsFileRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsFile");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/as-file";
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
        /// Converts Email model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Email model and format to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> AsFileAsync(
            EmailAsFileRequest request) =>
            await Task.Run(() => AsFile(request
        ));
        #endif


        /// <summary>
        /// Converts EmailDto to MapiMessageDto.              
        /// </summary>
        /// <param name="emailDto">Email model to convert</param>
        /// <returns><see cref="MapiMessageDto"/></returns>
        public MapiMessageDto AsMapi(
            EmailDto emailDto)
        {
            // verify the required parameter 'emailDto' is set
            if (emailDto == null)
                throw new ApiException(400,
                    "Missing required parameter 'emailDto' when calling AsMapi");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/as-mapi";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(emailDto); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<MapiMessageDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts EmailDto to MapiMessageDto.              
        /// </summary>
        /// <param name="emailDto">Email model to convert</param>
        /// <returns><see cref="MapiMessageDto"/></returns>
        public async Task<MapiMessageDto> AsMapiAsync(
            EmailDto emailDto) =>
            await Task.Run(() => AsMapi(emailDto
        ));
        #endif


        /// <summary>
        /// Converts email document to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailConvertRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream Convert(EmailConvertRequest request)
        {
            // verify the required parameter 'fromFormat' is set
            if (request.FromFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fromFormat' when calling Convert");
            }

            // verify the required parameter 'toFormat' is set
            if (request.ToFormat == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'toFormat' when calling Convert");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling Convert");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/convert";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromFormat", request.FromFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "toFormat", request.ToFormat);
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
        /// Converts email document to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailConvertRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> ConvertAsync(EmailConvertRequest request) =>
            await Task.Run(() => Convert(request));
        #endif


        /// <summary>
        /// Converts email document to a model representation              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailFromFileRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public EmailDto FromFile(EmailFromFileRequest request)
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/from-file";
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
            return response == null ? null : SerializationHelper.Deserialize<EmailDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts email document to a model representation              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailFromFileRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public async Task<EmailDto> FromFileAsync(EmailFromFileRequest request) =>
            await Task.Run(() => FromFile(request));
        #endif


        /// <summary>
        /// Get email document from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailGetRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public EmailDto Get(EmailGetRequest request)
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/email";
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
            return response == null ? null : SerializationHelper.Deserialize<EmailDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email document from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailGetRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public async Task<EmailDto> GetAsync(EmailGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif


        /// <summary>
        /// Converts email document from storage to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailGetAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetAsFile(EmailGetAsFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetAsFile");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetAsFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/as-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
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
        /// Converts email document from storage to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailGetAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetAsFileAsync(EmailGetAsFileRequest request) =>
            await Task.Run(() => GetAsFile(request));
        #endif


        /// <summary>
        /// Get email list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailGetListRequest" /></param>
        /// <returns><see cref="EmailStorageList"/></returns>
        public EmailStorageList GetList(EmailGetListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/list";
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
            return response == null ? null : SerializationHelper.Deserialize<EmailStorageList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailGetListRequest" /></param>
        /// <returns><see cref="EmailStorageList"/></returns>
        public async Task<EmailStorageList> GetListAsync(EmailGetListRequest request) =>
            await Task.Run(() => GetList(request));
        #endif


        /// <summary>
        /// Save email document to storage.              
        /// </summary>
        /// <param name="request">Email document create/update request.</param>
        public void Save(
            EmailSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email";
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
        /// Save email document to storage.              
        /// </summary>
        /// <param name="request">Email document create/update request.</param>
        public async Task SaveAsync(
            EmailSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

    }
}
