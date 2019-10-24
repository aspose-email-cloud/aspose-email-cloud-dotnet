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
    public class MapiApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapiApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public MapiApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapiApi"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public MapiApi(Configuration configuration)
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
        /// Add attachment to document 
        /// </summary>
        /// <param name="request">Request. <see cref="AddMapiAttachmentRequest" /></param> 
        
        public void AddMapiAttachment(Model.Requests.AddMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AddMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling AddMapiAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling AddMapiAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/attachments/{attachment}";
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
        /// Create new document 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateMapiRequest" /></param> 
        
        public void CreateMapi(Model.Requests.CreateMapiRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateMapi");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling CreateMapi");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}";
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
        /// Remove attachment from document 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMapiAttachmentRequest" /></param> 
        
        public void DeleteMapiAttachment(Model.Requests.DeleteMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling DeleteMapiAttachment");
            }

            // verify the required parameter 'storage' is set
            if (request.storage == null)
            {
                throw new ApiException(400, "Missing required parameter 'storage' when calling DeleteMapiAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/attachments/{attachment}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachment", request.attachment);
            var postBody = SerializationHelper.Serialize(request.storage); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }

        /// <summary>
        /// Delete document properties 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMapiPropertiesRequest" /></param> 
        
        public void DeleteMapiProperties(Model.Requests.DeleteMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteMapiProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling DeleteMapiProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }

        /// <summary>
        /// Get document attachment as file stream 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiAttachmentRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetMapiAttachment(Model.Requests.GetMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling GetMapiAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/attachments/{attachment}";
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
        /// Get document attachment list 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiAttachmentsRequest" /></param> 
        /// <returns><see cref="ListResponseOfString"/></returns>
        public ListResponseOfString GetMapiAttachments(Model.Requests.GetMapiAttachmentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMapiAttachments");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/attachments";
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
                return (ListResponseOfString)SerializationHelper.Deserialize(response, typeof(ListResponseOfString));
            }

            return null;
        }

        /// <summary>
        /// Get document list from storage folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiListRequest" /></param> 
        /// <returns><see cref="ListResponseOfHierarchicalObjectResponse"/></returns>
        public ListResponseOfHierarchicalObjectResponse GetMapiList(Model.Requests.GetMapiListRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "itemsPerPage", request.itemsPerPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.pageNumber);
            
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
        /// Get document properties 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiPropertiesRequest" /></param> 
        /// <returns><see cref="HierarchicalObjectResponse"/></returns>
        public HierarchicalObjectResponse GetMapiProperties(Model.Requests.GetMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMapiProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/properties";
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
                return (HierarchicalObjectResponse)SerializationHelper.Deserialize(response, typeof(HierarchicalObjectResponse));
            }

            return null;
        }

        /// <summary>
        /// Update document properties 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateMapiPropertiesRequest" /></param> 
        
        public void UpdateMapiProperties(Model.Requests.UpdateMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateMapiProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling UpdateMapiProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/properties";
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