// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarApi.cs">
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
    public class CalendarApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal CalendarApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    
        /// <summary>
        /// Convert iCalendar to AlternateView              
        /// </summary>
        /// <param name="request">iCalendar to AlternateView request</param>
        /// <returns><see cref="AlternateView"/></returns>
        public AlternateView AsAlternate(
            CalendarAsAlternateRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsAlternate");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/as-alternate";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<AlternateView>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Convert iCalendar to AlternateView              
        /// </summary>
        /// <param name="request">iCalendar to AlternateView request</param>
        /// <returns><see cref="AlternateView"/></returns>
        public async Task<AlternateView> AsAlternateAsync(
            CalendarAsAlternateRequest request) =>
            await Task.Run(() => AsAlternate(request
        ));
        #endif

                    
        /// <summary>
        /// Converts calendar model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Calendar model and format to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AsFile(
            CalendarAsFileRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsFile");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/as-file";
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
        /// Converts calendar model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Calendar model and format to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> AsFileAsync(
            CalendarAsFileRequest request) =>
            await Task.Run(() => AsFile(request
        ));
        #endif

                    
        /// <summary>
        /// Converts CalendarDto to MapiCalendarDto.              
        /// </summary>
        /// <param name="calendarDto">iCalendar model calendar representation.</param>
        /// <returns><see cref="MapiCalendarDto"/></returns>
        public MapiCalendarDto AsMapi(
            CalendarDto calendarDto)
        {
            // verify the required parameter 'calendarDto' is set
            if (calendarDto == null)
                throw new ApiException(400,
                    "Missing required parameter 'calendarDto' when calling AsMapi");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/as-mapi";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(calendarDto); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<MapiCalendarDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts CalendarDto to MapiCalendarDto.              
        /// </summary>
        /// <param name="calendarDto">iCalendar model calendar representation.</param>
        /// <returns><see cref="MapiCalendarDto"/></returns>
        public async Task<MapiCalendarDto> AsMapiAsync(
            CalendarDto calendarDto) =>
            await Task.Run(() => AsMapi(calendarDto
        ));
        #endif

                    
        /// <summary>
        /// Converts calendar document to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarConvertRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream Convert(CalendarConvertRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling Convert");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling Convert");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/convert";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
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
        /// Converts calendar document to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarConvertRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> ConvertAsync(CalendarConvertRequest request) =>
            await Task.Run(() => Convert(request));
        #endif

                    
        /// <summary>
        /// Converts calendar document to a model representation.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarFromFileRequest" /></param>
        /// <returns><see cref="CalendarDto"/></returns>
        public CalendarDto FromFile(CalendarFromFileRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling FromFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/from-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                formParams: formParams);
            return response == null ? null : SerializationHelper.Deserialize<CalendarDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts calendar document to a model representation.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarFromFileRequest" /></param>
        /// <returns><see cref="CalendarDto"/></returns>
        public async Task<CalendarDto> FromFileAsync(CalendarFromFileRequest request) =>
            await Task.Run(() => FromFile(request));
        #endif

                    
        /// <summary>
        /// Get calendar file from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetRequest" /></param>
        /// <returns><see cref="CalendarDto"/></returns>
        public CalendarDto Get(CalendarGetRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling Get");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<CalendarDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get calendar file from storage.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetRequest" /></param>
        /// <returns><see cref="CalendarDto"/></returns>
        public async Task<CalendarDto> GetAsync(CalendarGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif

                    
        /// <summary>
        /// Get iCalendar from storage as AlternateView              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetAsAlternateRequest" /></param>
        /// <returns><see cref="AlternateView"/></returns>
        public AlternateView GetAsAlternate(CalendarGetAsAlternateRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetAsAlternate");
            }

            // verify the required parameter 'calendarAction' is set
            if (request.calendarAction == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'calendarAction' when calling GetAsAlternate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/as-alternate";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "calendarAction", request.calendarAction);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sequenceId", request.sequenceId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AlternateView>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get iCalendar from storage as AlternateView              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetAsAlternateRequest" /></param>
        /// <returns><see cref="AlternateView"/></returns>
        public async Task<AlternateView> GetAsAlternateAsync(CalendarGetAsAlternateRequest request) =>
            await Task.Run(() => GetAsAlternate(request));
        #endif

                    
        /// <summary>
        /// Converts calendar document from storage to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetAsFile(CalendarGetAsFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetAsFile");
            }

            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetAsFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/as-file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts calendar document from storage to specified format and returns as file.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetAsFileAsync(CalendarGetAsFileRequest request) =>
            await Task.Run(() => GetAsFile(request));
        #endif

                    
        /// <summary>
        /// Get iCalendar list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetListRequest" /></param>
        /// <returns><see cref="CalendarStorageList"/></returns>
        public CalendarStorageList GetList(CalendarGetListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling GetList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/list";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "itemsPerPage", request.itemsPerPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.pageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<CalendarStorageList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get iCalendar list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="CalendarGetListRequest" /></param>
        /// <returns><see cref="CalendarStorageList"/></returns>
        public async Task<CalendarStorageList> GetListAsync(CalendarGetListRequest request) =>
            await Task.Run(() => GetList(request));
        #endif

                    
        /// <summary>
        /// Save iCalendar              
        /// </summary>
        /// <param name="request">iCalendar create/update request</param>
        public void Save(
            CalendarSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar";
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
        /// Save iCalendar              
        /// </summary>
        /// <param name="request">iCalendar create/update request</param>
        public async Task SaveAsync(
            CalendarSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

    }
}
