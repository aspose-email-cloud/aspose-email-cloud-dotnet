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
    public class ContactApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public ContactApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactApi"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public ContactApi(Configuration configuration)
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
        /// Add attachment to contact document 
        /// </summary>
        /// <param name="request">Request. <see cref="AddContactAttachmentRequest" /></param> 
        
        public void AddContactAttachment(Model.Requests.AddContactAttachmentRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling AddContactAttachment");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AddContactAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling AddContactAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling AddContactAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}/{name}/attachments/{attachment}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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
        /// Create contact document 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateContactRequest" /></param> 
        
        public void CreateContact(Model.Requests.CreateContactRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling CreateContact");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateContact");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling CreateContact");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}/{name}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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
        /// Delete property from indexed property list 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteContactPropertyRequest" /></param> 
        
        public void DeleteContactProperty(Model.Requests.DeleteContactPropertyRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling DeleteContactProperty");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteContactProperty");
            }

            // verify the required parameter 'memberName' is set
            if (request.memberName == null)
            {
                throw new ApiException(400, "Missing required parameter 'memberName' when calling DeleteContactProperty");
            }

            // verify the required parameter 'index' is set
            if (request.index == null)
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteContactProperty");
            }

            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400, "Missing required parameter 'folder' when calling DeleteContactProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}/{name}/properties/{memberName}/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "memberName", request.memberName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.index);
            var postBody = SerializationHelper.Serialize(request.folder); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }

        /// <summary>
        /// Get attachment file by name 
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactAttachmentRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetContactAttachment(Model.Requests.GetContactAttachmentRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetContactAttachment");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetContactAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400, "Missing required parameter 'attachment' when calling GetContactAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}/{name}/attachments/{attachment}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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
        /// Get contact list from storage folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactListRequest" /></param> 
        /// <returns><see cref="ListResponseOfHierarchicalObjectResponse"/></returns>
        public ListResponseOfHierarchicalObjectResponse GetContactList(Model.Requests.GetContactListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetContactList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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
        /// Get contact document properties 
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactPropertiesRequest" /></param> 
        /// <returns><see cref="HierarchicalObject"/></returns>
        public HierarchicalObject GetContactProperties(Model.Requests.GetContactPropertiesRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetContactProperties");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetContactProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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
        /// Update contact document properties 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateContactPropertiesRequest" /></param> 
        
        public void UpdateContactProperties(Model.Requests.UpdateContactPropertiesRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateContactProperties");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateContactProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling UpdateContactProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Contact/{format}/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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