// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailApi.cs">
//   Copyright (c) 2018 Aspose.Email for Cloud
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

namespace Aspose.Email.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Model.Requests;
    using Client;
    using Client.Internal.RequestHandlers;

    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class CalendarApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public CalendarApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarApi"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public CalendarApi(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>
            {
                new AuthRequestHandler(this.configuration),
                new DebugLogRequestHandler(this.configuration),
                new ApiExceptionRequestHandler()
            };
            apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Adds an attachment to iCalendar file 
        /// </summary>
        /// <param name="request">Request. <see cref="AddCalendarAttachmentRequest" /></param> 
        
        public void AddCalendarAttachment(Model.Requests.AddCalendarAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AddCalendarAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling AddCalendarAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling AddCalendarAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}/attachments/{attachment}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachment", request.attachment);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        /// <summary>
        /// Create calendar file 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateCalendarRequest" /></param> 
        
        public void CreateCalendar(Model.Requests.CreateCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateCalendar");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling CreateCalendar");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        /// <summary>
        /// Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex} 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCalendarPropertyRequest" /></param> 
        
        public void DeleteCalendarProperty(Model.Requests.DeleteCalendarPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'memberName' is set
            if (request.memberName == null)
            {
                throw new ApiException(400, "Missing required parameter 'memberName' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'index' is set
            if (request.index == null)
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling DeleteCalendarProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}/properties/{memberName}/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "memberName", request.memberName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.index);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }

        /// <summary>
        /// Get calendar file properties 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarRequest" /></param> 
        /// <returns><see cref="HierarchicalObject"/></returns>
        public HierarchicalObject GetCalendar(Model.Requests.GetCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetCalendar");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return (HierarchicalObject)SerializationHelper.Deserialize(response, typeof(HierarchicalObject));
            }

            return null;
        }

        /// <summary>
        /// Get iCalendar document attachment by name 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarAttachmentRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetCalendarAttachment(Model.Requests.GetCalendarAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetCalendarAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling GetCalendarAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}/attachments/{attachment}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachment", request.attachment);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Get iCalendar files list in folder on storage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarListRequest" /></param> 
        /// <returns><see cref="ListResponseOfHierarchicalObjectResponse"/></returns>
        public ListResponseOfHierarchicalObjectResponse GetCalendarList(Model.Requests.GetCalendarListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400, "Missing required parameter 'folder' when calling GetCalendarList");
            }

            // verify the required parameter 'itemsPerPage' is set
            if (request.itemsPerPage == null)
            {
                throw new ApiException(400, "Missing required parameter 'itemsPerPage' when calling GetCalendarList");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.pageNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling GetCalendarList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar";
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
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return (ListResponseOfHierarchicalObjectResponse)SerializationHelper.Deserialize(response, typeof(ListResponseOfHierarchicalObjectResponse));
            }

            return null;
        }

        /// <summary>
        /// Update calendar file properties 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCalendarPropertiesRequest" /></param> 
        
        public void UpdateCalendarProperties(Model.Requests.UpdateCalendarPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateCalendarProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling UpdateCalendarProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
    }
}