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

namespace Aspose.Email.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Model.Requests;
    using Client;
    using Client.Internal.RequestHandlers;
    #if (NET452 || NETSTANDARD2_0)
    using System.Threading.Tasks;
    #endif

    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class EmailApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public EmailApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public EmailApi(Configuration configuration)
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
        /// Adds an attachment to Email document 
        /// </summary>
        /// <param name="request">Request. <see cref="AddEmailAttachmentRequest" /></param>
        /// <returns><see cref="EmailDocumentResponse"/></returns>
        public EmailDocumentResponse AddEmailAttachment(Model.Requests.AddEmailAttachmentRequest request)
        {
            // verify the required parameter 'attachmentName' is set
            if (request.attachmentName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachmentName' when calling AddEmailAttachment");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling AddEmailAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddEmailAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/attachments/{attachmentName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.attachmentName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDocumentResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Adds an attachment to Email document 
        /// </summary>
        /// <param name="request">Request. <see cref="AddEmailAttachmentRequest" /></param>
        /// <returns><see cref="EmailDocumentResponse"/></returns>
        public async Task<EmailDocumentResponse> AddEmailAttachmentAsync(Model.Requests.AddEmailAttachmentRequest request)
        {
            // verify the required parameter 'attachmentName' is set
            if (request.attachmentName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachmentName' when calling AddEmailAttachment");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling AddEmailAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddEmailAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/attachments/{attachmentName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.attachmentName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDocumentResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Create an email document 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateEmailRequest" /></param>
        /// <returns><see cref="EmailDocumentResponse"/></returns>
        public EmailDocumentResponse CreateEmail(Model.Requests.CreateEmailRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling CreateEmail");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDocumentResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create an email document 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateEmailRequest" /></param>
        /// <returns><see cref="EmailDocumentResponse"/></returns>
        public async Task<EmailDocumentResponse> CreateEmailAsync(Model.Requests.CreateEmailRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling CreateEmail");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDocumentResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get email document 
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailRequest" /></param>
        /// <returns><see cref="EmailDocument"/></returns>
        public EmailDocument GetEmail(Model.Requests.GetEmailRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDocument>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email document 
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailRequest" /></param>
        /// <returns><see cref="EmailDocument"/></returns>
        public async Task<EmailDocument> GetEmailAsync(Model.Requests.GetEmailRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDocument>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get email attachment by name 
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetEmailAttachment(Model.Requests.GetEmailAttachmentRequest request)
        {
            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetEmailAttachment");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmailAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/attachments/{attachment}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachment", request.attachment);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<System.IO.Stream>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email attachment by name 
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetEmailAttachmentAsync(Model.Requests.GetEmailAttachmentRequest request)
        {
            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetEmailAttachment");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmailAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/attachments/{attachment}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachment", request.attachment);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<System.IO.Stream>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get an email document property by its name 
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailPropertyRequest" /></param>
        /// <returns><see cref="EmailPropertyResponse"/></returns>
        public EmailPropertyResponse GetEmailProperty(Model.Requests.GetEmailPropertyRequest request)
        {
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'propertyName' when calling GetEmailProperty");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmailProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/properties/{propertyName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailPropertyResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get an email document property by its name 
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailPropertyRequest" /></param>
        /// <returns><see cref="EmailPropertyResponse"/></returns>
        public async Task<EmailPropertyResponse> GetEmailPropertyAsync(Model.Requests.GetEmailPropertyRequest request)
        {
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'propertyName' when calling GetEmailProperty");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmailProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/properties/{propertyName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailPropertyResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Set email document property value 
        /// </summary>
        /// <param name="request">Request. <see cref="SetEmailPropertyRequest" /></param>
        /// <returns><see cref="EmailPropertyResponse"/></returns>
        public EmailPropertyResponse SetEmailProperty(Model.Requests.SetEmailPropertyRequest request)
        {
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'propertyName' when calling SetEmailProperty");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling SetEmailProperty");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SetEmailProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/properties/{propertyName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailPropertyResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Set email document property value 
        /// </summary>
        /// <param name="request">Request. <see cref="SetEmailPropertyRequest" /></param>
        /// <returns><see cref="EmailPropertyResponse"/></returns>
        public async Task<EmailPropertyResponse> SetEmailPropertyAsync(Model.Requests.SetEmailPropertyRequest request)
        {
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'propertyName' when calling SetEmailProperty");
            }

            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling SetEmailProperty");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SetEmailProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/properties/{propertyName}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailPropertyResponse>(response);
            }

            return null;
        }
        #endif
    }
}