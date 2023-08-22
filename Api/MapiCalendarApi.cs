// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiCalendarApi.cs">
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
    public class MapiCalendarApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapiCalendarApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal MapiCalendarApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }

        /// <summary>
        /// Converts MAPI calendar model to CalendarDto model.              
        /// </summary>
        /// <param name="mapiCalendarDto">MAPI calendar model to convert.</param>
        /// <returns><see cref="CalendarDto"/></returns>
        public CalendarDto AsCalendarDto(
            MapiCalendarDto mapiCalendarDto)
        {
            // verify the required parameter 'mapiCalendarDto' is set
            if (mapiCalendarDto == null)
                throw new ApiException(400,
                    "Missing required parameter 'mapiCalendarDto' when calling AsCalendarDto");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiCalendar/as-calendar-dto";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(mapiCalendarDto); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<CalendarDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts MAPI calendar model to CalendarDto model.              
        /// </summary>
        /// <param name="mapiCalendarDto">MAPI calendar model to convert.</param>
        /// <returns><see cref="CalendarDto"/></returns>
        public async Task<CalendarDto> AsCalendarDtoAsync(
            MapiCalendarDto mapiCalendarDto) =>
            await Task.Run(() => AsCalendarDto(mapiCalendarDto
        ));
        #endif


        /// <summary>
        /// Converts MAPI calendar model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">MAPI calendar model to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AsFile(
            MapiCalendarAsFileRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AsFile");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiCalendar/as-file";
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
        /// Converts MAPI calendar model to specified format and returns as file.              
        /// </summary>
        /// <param name="request">MAPI calendar model to convert.</param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> AsFileAsync(
            MapiCalendarAsFileRequest request) =>
            await Task.Run(() => AsFile(request
        ));
        #endif


        /// <summary>
        /// Converts calendar file to a MAPI model representation.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiCalendarFromFileRequest" /></param>
        /// <returns><see cref="MapiCalendarDto"/></returns>
        public MapiCalendarDto FromFile(MapiCalendarFromFileRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling FromFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiCalendar/from-file";
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
            return response == null ? null : SerializationHelper.Deserialize<MapiCalendarDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts calendar file to a MAPI model representation.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiCalendarFromFileRequest" /></param>
        /// <returns><see cref="MapiCalendarDto"/></returns>
        public async Task<MapiCalendarDto> FromFileAsync(MapiCalendarFromFileRequest request) =>
            await Task.Run(() => FromFile(request));
        #endif


        /// <summary>
        /// Get MAPI calendar document.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiCalendarGetRequest" /></param>
        /// <returns><see cref="MapiCalendarDto"/></returns>
        public MapiCalendarDto Get(MapiCalendarGetRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling Get");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiCalendar";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<MapiCalendarDto>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get MAPI calendar document.              
        /// </summary>
        /// <param name="request">Request. <see cref="MapiCalendarGetRequest" /></param>
        /// <returns><see cref="MapiCalendarDto"/></returns>
        public async Task<MapiCalendarDto> GetAsync(MapiCalendarGetRequest request) =>
            await Task.Run(() => Get(request));
        #endif


        /// <summary>
        /// Save MAPI Calendar to storage.              
        /// </summary>
        /// <param name="request">Calendar create/update request.</param>
        public void Save(
            MapiCalendarSaveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Save");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/MapiCalendar";
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
        /// Save MAPI Calendar to storage.              
        /// </summary>
        /// <param name="request">Calendar create/update request.</param>
        public async Task SaveAsync(
            MapiCalendarSaveRequest request) =>
            await Task.Run(() => Save(request
        ));
        #endif

    }
}
