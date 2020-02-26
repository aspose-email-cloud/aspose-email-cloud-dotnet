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
        /// Adds an attachment to iCalendar file              
        /// </summary>
        /// <param name="request">Request. <see cref="AddCalendarAttachmentRequest" /></param>
        public void AddCalendarAttachment(Model.Requests.AddCalendarAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AddCalendarAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling AddCalendarAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddCalendarAttachment");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Adds an attachment to iCalendar file              
        /// </summary>
        /// <param name="request">Request. <see cref="AddCalendarAttachmentRequest" /></param>
        public async Task AddCalendarAttachmentAsync(Model.Requests.AddCalendarAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AddCalendarAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling AddCalendarAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddCalendarAttachment");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Add attachment to contact document              
        /// </summary>
        /// <param name="request">Request. <see cref="AddContactAttachmentRequest" /></param>
        public void AddContactAttachment(Model.Requests.AddContactAttachmentRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling AddContactAttachment");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AddContactAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling AddContactAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddContactAttachment");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Add attachment to contact document              
        /// </summary>
        /// <param name="request">Request. <see cref="AddContactAttachmentRequest" /></param>
        public async Task AddContactAttachmentAsync(Model.Requests.AddContactAttachmentRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling AddContactAttachment");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AddContactAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling AddContactAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddContactAttachment");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

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
        /// Add attachment to document              
        /// </summary>
        /// <param name="request">Request. <see cref="AddMapiAttachmentRequest" /></param>
        public void AddMapiAttachment(Model.Requests.AddMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AddMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling AddMapiAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddMapiAttachment");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Add attachment to document              
        /// </summary>
        /// <param name="request">Request. <see cref="AddMapiAttachmentRequest" /></param>
        public async Task AddMapiAttachmentAsync(Model.Requests.AddMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AddMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling AddMapiAttachment");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AddMapiAttachment");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Ocr images              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrOcrRequest" /></param>
        /// <returns><see cref="ListResponseOfAiBcrOcrData"/></returns>
        public ListResponseOfAiBcrOcrData AiBcrOcr(Model.Requests.AiBcrOcrRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrOcr");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/ocr";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiBcrOcrData>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Ocr images              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrOcrRequest" /></param>
        /// <returns><see cref="ListResponseOfAiBcrOcrData"/></returns>
        public async Task<ListResponseOfAiBcrOcrData> AiBcrOcrAsync(Model.Requests.AiBcrOcrRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrOcr");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/ocr";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiBcrOcrData>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Ocr images from storage              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrOcrStorageRequest" /></param>
        /// <returns><see cref="ListResponseOfAiBcrOcrData"/></returns>
        public ListResponseOfAiBcrOcrData AiBcrOcrStorage(Model.Requests.AiBcrOcrStorageRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrOcrStorage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/ocr-storage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiBcrOcrData>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Ocr images from storage              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrOcrStorageRequest" /></param>
        /// <returns><see cref="ListResponseOfAiBcrOcrData"/></returns>
        public async Task<ListResponseOfAiBcrOcrData> AiBcrOcrStorageAsync(Model.Requests.AiBcrOcrStorageRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrOcrStorage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/ocr-storage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiBcrOcrData>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Parse images to vCard properties              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseRequest" /></param>
        /// <returns><see cref="ListResponseOfHierarchicalObject"/></returns>
        public ListResponseOfHierarchicalObject AiBcrParse(Model.Requests.AiBcrParseRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParse");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObject>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images to vCard properties              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseRequest" /></param>
        /// <returns><see cref="ListResponseOfHierarchicalObject"/></returns>
        public async Task<ListResponseOfHierarchicalObject> AiBcrParseAsync(Model.Requests.AiBcrParseRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParse");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObject>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Parse images to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseModelRequest" /></param>
        /// <returns><see cref="ListResponseOfContactDto"/></returns>
        public ListResponseOfContactDto AiBcrParseModel(Model.Requests.AiBcrParseModelRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParseModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-model";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfContactDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseModelRequest" /></param>
        /// <returns><see cref="ListResponseOfContactDto"/></returns>
        public async Task<ListResponseOfContactDto> AiBcrParseModelAsync(Model.Requests.AiBcrParseModelRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParseModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-model";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfContactDto>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Parse OCR data to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseOcrDataModelRequest" /></param>
        /// <returns><see cref="ListResponseOfContactDto"/></returns>
        public ListResponseOfContactDto AiBcrParseOcrDataModel(Model.Requests.AiBcrParseOcrDataModelRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParseOcrDataModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-ocr-data-model";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfContactDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse OCR data to vCard document models              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseOcrDataModelRequest" /></param>
        /// <returns><see cref="ListResponseOfContactDto"/></returns>
        public async Task<ListResponseOfContactDto> AiBcrParseOcrDataModelAsync(Model.Requests.AiBcrParseOcrDataModelRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParseOcrDataModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-ocr-data-model";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfContactDto>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Parse images from storage to vCard files              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseStorageRequest" /></param>
        /// <returns><see cref="ListResponseOfStorageFileLocation"/></returns>
        public ListResponseOfStorageFileLocation AiBcrParseStorage(Model.Requests.AiBcrParseStorageRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParseStorage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-storage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfStorageFileLocation>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse images from storage to vCard files              
        /// </summary>
        /// <param name="request">Request. <see cref="AiBcrParseStorageRequest" /></param>
        /// <returns><see cref="ListResponseOfStorageFileLocation"/></returns>
        public async Task<ListResponseOfStorageFileLocation> AiBcrParseStorageAsync(Model.Requests.AiBcrParseStorageRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiBcrParseStorage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiBcr/parse-storage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfStorageFileLocation>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// The call proposes k most probable names for given starting characters              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameCompleteRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public AiNameWeightedVariants AiNameComplete(Model.Requests.AiNameCompleteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameComplete");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/complete";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// The call proposes k most probable names for given starting characters              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameCompleteRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public async Task<AiNameWeightedVariants> AiNameCompleteAsync(Model.Requests.AiNameCompleteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameComplete");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/complete";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Expands a person&#39;s name into a list of possible alternatives using options for expanding instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameExpandRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public AiNameWeightedVariants AiNameExpand(Model.Requests.AiNameExpandRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameExpand");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/expand";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Expands a person&#39;s name into a list of possible alternatives using options for expanding instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameExpandRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public async Task<AiNameWeightedVariants> AiNameExpandAsync(Model.Requests.AiNameExpandRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameExpand");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/expand";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Expands a person&#39;s parsed name into a list of possible alternatives using options for expanding instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameExpandParsedRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public AiNameWeightedVariants AiNameExpandParsed(Model.Requests.AiNameExpandParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameExpandParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/expand-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Expands a person&#39;s parsed name into a list of possible alternatives using options for expanding instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameExpandParsedRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public async Task<AiNameWeightedVariants> AiNameExpandParsedAsync(Model.Requests.AiNameExpandParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameExpandParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/expand-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Formats a person&#39;s name in correct case and name order using options for formatting instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameFormatRequest" /></param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public AiNameFormatted AiNameFormat(Model.Requests.AiNameFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/format";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameFormatted>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Formats a person&#39;s name in correct case and name order using options for formatting instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameFormatRequest" /></param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public async Task<AiNameFormatted> AiNameFormatAsync(Model.Requests.AiNameFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/format";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameFormatted>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Formats a person&#39;s parsed name in correct case and name order using options for formatting instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameFormatParsedRequest" /></param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public AiNameFormatted AiNameFormatParsed(Model.Requests.AiNameFormatParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameFormatParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/format-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameFormatted>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Formats a person&#39;s parsed name in correct case and name order using options for formatting instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameFormatParsedRequest" /></param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public async Task<AiNameFormatted> AiNameFormatParsedAsync(Model.Requests.AiNameFormatParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameFormatParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/format-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameFormatted>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Detect person&#39;s gender from name string              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameGenderizeRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameGenderHypothesis"/></returns>
        public ListResponseOfAiNameGenderHypothesis AiNameGenderize(Model.Requests.AiNameGenderizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameGenderize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/genderize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameGenderHypothesis>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Detect person&#39;s gender from name string              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameGenderizeRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameGenderHypothesis"/></returns>
        public async Task<ListResponseOfAiNameGenderHypothesis> AiNameGenderizeAsync(Model.Requests.AiNameGenderizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameGenderize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/genderize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameGenderHypothesis>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Detect person&#39;s gender from parsed name              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameGenderizeParsedRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameGenderHypothesis"/></returns>
        public ListResponseOfAiNameGenderHypothesis AiNameGenderizeParsed(Model.Requests.AiNameGenderizeParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameGenderizeParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/genderize-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameGenderHypothesis>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Detect person&#39;s gender from parsed name              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameGenderizeParsedRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameGenderHypothesis"/></returns>
        public async Task<ListResponseOfAiNameGenderHypothesis> AiNameGenderizeParsedAsync(Model.Requests.AiNameGenderizeParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameGenderizeParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/genderize-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameGenderHypothesis>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Compare people&#39;s names. Uses options for comparing instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameMatchRequest" /></param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public AiNameMatchResult AiNameMatch(Model.Requests.AiNameMatchRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameMatch");
            }

            // verify the required parameter 'otherName' is set
            if (request.otherName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'otherName' when calling AiNameMatch");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/match";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "otherName", request.otherName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameMatchResult>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Compare people&#39;s names. Uses options for comparing instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameMatchRequest" /></param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public async Task<AiNameMatchResult> AiNameMatchAsync(Model.Requests.AiNameMatchRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameMatch");
            }

            // verify the required parameter 'otherName' is set
            if (request.otherName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'otherName' when calling AiNameMatch");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/match";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "otherName", request.otherName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameMatchResult>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Compare people&#39;s parsed names and attributes. Uses options for comparing instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameMatchParsedRequest" /></param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public AiNameMatchResult AiNameMatchParsed(Model.Requests.AiNameMatchParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameMatchParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/match-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameMatchResult>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Compare people&#39;s parsed names and attributes. Uses options for comparing instructions              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameMatchParsedRequest" /></param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public async Task<AiNameMatchResult> AiNameMatchParsedAsync(Model.Requests.AiNameMatchParsedRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AiNameMatchParsed");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/match-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AiNameMatchResult>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Parse name to components              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameComponent"/></returns>
        public ListResponseOfAiNameComponent AiNameParse(Model.Requests.AiNameParseRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameParse");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/parse";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameComponent>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse name to components              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameComponent"/></returns>
        public async Task<ListResponseOfAiNameComponent> AiNameParseAsync(Model.Requests.AiNameParseRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling AiNameParse");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/parse";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameComponent>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Parse person&#39;s name out of an email address              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseEmailAddressRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameExtracted"/></returns>
        public ListResponseOfAiNameExtracted AiNameParseEmailAddress(Model.Requests.AiNameParseEmailAddressRequest request)
        {
            // verify the required parameter 'emailAddress' is set
            if (request.emailAddress == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'emailAddress' when calling AiNameParseEmailAddress");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/parse-email-address";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "emailAddress", request.emailAddress);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameExtracted>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse person&#39;s name out of an email address              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseEmailAddressRequest" /></param>
        /// <returns><see cref="ListResponseOfAiNameExtracted"/></returns>
        public async Task<ListResponseOfAiNameExtracted> AiNameParseEmailAddressAsync(Model.Requests.AiNameParseEmailAddressRequest request)
        {
            // verify the required parameter 'emailAddress' is set
            if (request.emailAddress == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'emailAddress' when calling AiNameParseEmailAddress");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/parse-email-address";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "emailAddress", request.emailAddress);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "location", request.location);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "encoding", request.encoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "script", request.script);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "style", request.style);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfAiNameExtracted>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Adds an email from *.eml file to specified folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="AppendEmailMessageRequest" /></param>
        /// <returns><see cref="EmailPropertyResponse"/></returns>
        public EmailPropertyResponse AppendEmailMessage(Model.Requests.AppendEmailMessageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AppendEmailMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Append";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
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
        /// Adds an email from *.eml file to specified folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="AppendEmailMessageRequest" /></param>
        /// <returns><see cref="EmailPropertyResponse"/></returns>
        public async Task<EmailPropertyResponse> AppendEmailMessageAsync(Model.Requests.AppendEmailMessageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AppendEmailMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Append";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
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

        /// <summary>
        /// Adds an email from model to specified folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="AppendEmailModelMessageRequest" /></param>
        /// <returns><see cref="ValueResponse"/></returns>
        public ValueResponse AppendEmailModelMessage(Model.Requests.AppendEmailModelMessageRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AppendEmailModelMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/AppendModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ValueResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Adds an email from model to specified folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="AppendEmailModelMessageRequest" /></param>
        /// <returns><see cref="ValueResponse"/></returns>
        public async Task<ValueResponse> AppendEmailModelMessageAsync(Model.Requests.AppendEmailModelMessageRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling AppendEmailModelMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/AppendModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ValueResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Adds an email from MIME to specified folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="AppendMimeMessageRequest" /></param>
        /// <returns><see cref="ValueResponse"/></returns>
        public ValueResponse AppendMimeMessage(Model.Requests.AppendMimeMessageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AppendMimeMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/AppendMime";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ValueResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Adds an email from MIME to specified folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="AppendMimeMessageRequest" /></param>
        /// <returns><see cref="ValueResponse"/></returns>
        public async Task<ValueResponse> AppendMimeMessageAsync(Model.Requests.AppendMimeMessageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling AppendMimeMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/AppendMime";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ValueResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Convert iCalendar to AlternateView              
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertCalendarModelToAlternateRequest" /></param>
        /// <returns><see cref="AlternateView"/></returns>
        public AlternateView ConvertCalendarModelToAlternate(Model.Requests.ConvertCalendarModelToAlternateRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling ConvertCalendarModelToAlternate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/as-alternate";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AlternateView>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Convert iCalendar to AlternateView              
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertCalendarModelToAlternateRequest" /></param>
        /// <returns><see cref="AlternateView"/></returns>
        public async Task<AlternateView> ConvertCalendarModelToAlternateAsync(Model.Requests.ConvertCalendarModelToAlternateRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling ConvertCalendarModelToAlternate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/as-alternate";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AlternateView>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Converts email document to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertEmailRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertEmail(Model.Requests.ConvertEmailRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling ConvertEmail");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling ConvertEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/convert/{format}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                formParams);
            if (response != null)
            {
                return SerializationHelper.Deserialize<System.IO.Stream>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Converts email document to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertEmailRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> ConvertEmailAsync(Model.Requests.ConvertEmailRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling ConvertEmail");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling ConvertEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/convert/{format}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                formParams);
            if (response != null)
            {
                return SerializationHelper.Deserialize<System.IO.Stream>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public void CopyFile(Model.Requests.CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public async Task CopyFileAsync(Model.Requests.CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public void CopyFolder(Model.Requests.CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public async Task CopyFolderAsync(Model.Requests.CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Create calendar file              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateCalendarRequest" /></param>
        public void CreateCalendar(Model.Requests.CreateCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling CreateCalendar");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateCalendar");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create calendar file              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateCalendarRequest" /></param>
        public async Task CreateCalendarAsync(Model.Requests.CreateCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling CreateCalendar");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateCalendar");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Create contact document              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateContactRequest" /></param>
        public void CreateContact(Model.Requests.CreateContactRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling CreateContact");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling CreateContact");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateContact");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create contact document              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateContactRequest" /></param>
        public async Task CreateContactAsync(Model.Requests.CreateContactRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling CreateContact");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling CreateContact");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateContact");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
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
        /// Create new folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateEmailFolderRequest" /></param>
        public void CreateEmailFolder(Model.Requests.CreateEmailFolderRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateEmailFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/CreateFolder";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create new folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateEmailFolderRequest" /></param>
        public async Task CreateEmailFolderAsync(Model.Requests.CreateEmailFolderRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateEmailFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/CreateFolder";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public void CreateFolder(Model.Requests.CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public async Task CreateFolderAsync(Model.Requests.CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Create new document              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateMapiRequest" /></param>
        public void CreateMapi(Model.Requests.CreateMapiRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling CreateMapi");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateMapi");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create new document              
        /// </summary>
        /// <param name="request">Request. <see cref="CreateMapiRequest" /></param>
        public async Task CreateMapiAsync(Model.Requests.CreateMapiRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling CreateMapi");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling CreateMapi");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCalendarPropertyRequest" /></param>
        public void DeleteCalendarProperty(Model.Requests.DeleteCalendarPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'memberName' is set
            if (request.memberName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'memberName' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'index' is set
            if (request.index == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'index' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteCalendarProperty");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCalendarPropertyRequest" /></param>
        public async Task DeleteCalendarPropertyAsync(Model.Requests.DeleteCalendarPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'memberName' is set
            if (request.memberName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'memberName' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'index' is set
            if (request.index == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'index' when calling DeleteCalendarProperty");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteCalendarProperty");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Delete property from indexed property list              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteContactPropertyRequest" /></param>
        public void DeleteContactProperty(Model.Requests.DeleteContactPropertyRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling DeleteContactProperty");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteContactProperty");
            }

            // verify the required parameter 'memberName' is set
            if (request.memberName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'memberName' when calling DeleteContactProperty");
            }

            // verify the required parameter 'index' is set
            if (request.index == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'index' when calling DeleteContactProperty");
            }

            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling DeleteContactProperty");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete property from indexed property list              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteContactPropertyRequest" /></param>
        public async Task DeleteContactPropertyAsync(Model.Requests.DeleteContactPropertyRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling DeleteContactProperty");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteContactProperty");
            }

            // verify the required parameter 'memberName' is set
            if (request.memberName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'memberName' when calling DeleteContactProperty");
            }

            // verify the required parameter 'index' is set
            if (request.index == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'index' when calling DeleteContactProperty");
            }

            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling DeleteContactProperty");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Delete a folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteEmailFolderRequest" /></param>
        public void DeleteEmailFolder(Model.Requests.DeleteEmailFolderRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteEmailFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/DeleteFolder";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete a folder in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteEmailFolderRequest" /></param>
        public async Task DeleteEmailFolderAsync(Model.Requests.DeleteEmailFolderRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteEmailFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/DeleteFolder";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Delete message from email account by id              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteEmailMessageRequest" /></param>
        public void DeleteEmailMessage(Model.Requests.DeleteEmailMessageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteEmailMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/DeleteMessage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete message from email account by id              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteEmailMessageRequest" /></param>
        public async Task DeleteEmailMessageAsync(Model.Requests.DeleteEmailMessageRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteEmailMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/DeleteMessage";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public void DeleteFile(Model.Requests.DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public async Task DeleteFileAsync(Model.Requests.DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public void DeleteFolder(Model.Requests.DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public async Task DeleteFolderAsync(Model.Requests.DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Remove attachment from document              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMapiAttachmentRequest" /></param>
        public void DeleteMapiAttachment(Model.Requests.DeleteMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling DeleteMapiAttachment");
            }

            // verify the required parameter 'storage' is set
            if (request.storage == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'storage' when calling DeleteMapiAttachment");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Remove attachment from document              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMapiAttachmentRequest" /></param>
        public async Task DeleteMapiAttachmentAsync(Model.Requests.DeleteMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling DeleteMapiAttachment");
            }

            // verify the required parameter 'storage' is set
            if (request.storage == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'storage' when calling DeleteMapiAttachment");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Delete document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMapiPropertiesRequest" /></param>
        public void DeleteMapiProperties(Model.Requests.DeleteMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteMapiProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteMapiProperties");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMapiPropertiesRequest" /></param>
        public async Task DeleteMapiPropertiesAsync(Model.Requests.DeleteMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling DeleteMapiProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DeleteMapiProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/properties";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Discover email accounts by email address. Does not validate discovered accounts.              
        /// </summary>
        /// <param name="request">Request. <see cref="DiscoverEmailConfigRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public EmailAccountConfigList DiscoverEmailConfig(Model.Requests.DiscoverEmailConfigRequest request)
        {
            // verify the required parameter 'address' is set
            if (request.address == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'address' when calling DiscoverEmailConfig");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "address", request.address);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fastProcessing", request.fastProcessing);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailAccountConfigList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Discover email accounts by email address. Does not validate discovered accounts.              
        /// </summary>
        /// <param name="request">Request. <see cref="DiscoverEmailConfigRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public async Task<EmailAccountConfigList> DiscoverEmailConfigAsync(Model.Requests.DiscoverEmailConfigRequest request)
        {
            // verify the required parameter 'address' is set
            if (request.address == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'address' when calling DiscoverEmailConfig");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "address", request.address);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fastProcessing", request.fastProcessing);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailAccountConfigList>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.              
        /// </summary>
        /// <param name="request">Request. <see cref="DiscoverEmailConfigOauthRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public EmailAccountConfigList DiscoverEmailConfigOauth(Model.Requests.DiscoverEmailConfigOauthRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling DiscoverEmailConfigOauth");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover/oauth";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailAccountConfigList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.              
        /// </summary>
        /// <param name="request">Request. <see cref="DiscoverEmailConfigOauthRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public async Task<EmailAccountConfigList> DiscoverEmailConfigOauthAsync(Model.Requests.DiscoverEmailConfigOauthRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling DiscoverEmailConfigOauth");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover/oauth";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailAccountConfigList>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using login and password.              
        /// </summary>
        /// <param name="request">Request. <see cref="DiscoverEmailConfigPasswordRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public EmailAccountConfigList DiscoverEmailConfigPassword(Model.Requests.DiscoverEmailConfigPasswordRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling DiscoverEmailConfigPassword");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover/password";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailAccountConfigList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using login and password.              
        /// </summary>
        /// <param name="request">Request. <see cref="DiscoverEmailConfigPasswordRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public async Task<EmailAccountConfigList> DiscoverEmailConfigPasswordAsync(Model.Requests.DiscoverEmailConfigPasswordRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling DiscoverEmailConfigPassword");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover/password";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailAccountConfigList>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream DownloadFile(Model.Requests.DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> DownloadFileAsync(Model.Requests.DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            return await apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }
        #endif

        /// <summary>
        /// Fetch message mime from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="FetchEmailMessageRequest" /></param>
        /// <returns><see cref="MimeResponse"/></returns>
        public MimeResponse FetchEmailMessage(Model.Requests.FetchEmailMessageRequest request)
        {
            // verify the required parameter 'messageId' is set
            if (request.messageId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'messageId' when calling FetchEmailMessage");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling FetchEmailMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Fetch";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<MimeResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Fetch message mime from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="FetchEmailMessageRequest" /></param>
        /// <returns><see cref="MimeResponse"/></returns>
        public async Task<MimeResponse> FetchEmailMessageAsync(Model.Requests.FetchEmailMessageRequest request)
        {
            // verify the required parameter 'messageId' is set
            if (request.messageId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'messageId' when calling FetchEmailMessage");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling FetchEmailMessage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Fetch";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<MimeResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Fetch message model from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="FetchEmailModelRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public EmailDto FetchEmailModel(Model.Requests.FetchEmailModelRequest request)
        {
            // verify the required parameter 'messageId' is set
            if (request.messageId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'messageId' when calling FetchEmailModel");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling FetchEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/FetchModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Fetch message model from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="FetchEmailModelRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public async Task<EmailDto> FetchEmailModelAsync(Model.Requests.FetchEmailModelRequest request)
        {
            // verify the required parameter 'messageId' is set
            if (request.messageId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'messageId' when calling FetchEmailModel");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling FetchEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/FetchModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDto>(response);
            }

            return null;
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendar");
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
                return SerializationHelper.Deserialize<HierarchicalObject>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get calendar file properties              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarRequest" /></param>
        /// <returns><see cref="HierarchicalObject"/></returns>
        public async Task<HierarchicalObject> GetCalendarAsync(Model.Requests.GetCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendar");
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<HierarchicalObject>(response);
            }

            return null;
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendarAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetCalendarAttachment");
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
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get iCalendar document attachment by name              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetCalendarAttachmentAsync(Model.Requests.GetCalendarAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendarAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetCalendarAttachment");
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
            return await apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling GetCalendarList");
            }

            // verify the required parameter 'itemsPerPage' is set
            if (request.itemsPerPage == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'itemsPerPage' when calling GetCalendarList");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.pageNumber == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'pageNumber' when calling GetCalendarList");
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
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObjectResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get iCalendar files list in folder on storage              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarListRequest" /></param>
        /// <returns><see cref="ListResponseOfHierarchicalObjectResponse"/></returns>
        public async Task<ListResponseOfHierarchicalObjectResponse> GetCalendarListAsync(Model.Requests.GetCalendarListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling GetCalendarList");
            }

            // verify the required parameter 'itemsPerPage' is set
            if (request.itemsPerPage == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'itemsPerPage' when calling GetCalendarList");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.pageNumber == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'pageNumber' when calling GetCalendarList");
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObjectResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get calendar file              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarModelRequest" /></param>
        /// <returns><see cref="CalendarDto"/></returns>
        public CalendarDto GetCalendarModel(Model.Requests.GetCalendarModelRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendarModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/{name}";
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
                return SerializationHelper.Deserialize<CalendarDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get calendar file              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarModelRequest" /></param>
        /// <returns><see cref="CalendarDto"/></returns>
        public async Task<CalendarDto> GetCalendarModelAsync(Model.Requests.GetCalendarModelRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendarModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<CalendarDto>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get iCalendar from storage as AlternateView              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarModelAsAlternateRequest" /></param>
        /// <returns><see cref="AlternateView"/></returns>
        public AlternateView GetCalendarModelAsAlternate(Model.Requests.GetCalendarModelAsAlternateRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendarModelAsAlternate");
            }

            // verify the required parameter 'calendarAction' is set
            if (request.calendarAction == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'calendarAction' when calling GetCalendarModelAsAlternate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/{name}/as-alternate/{calendarAction}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarAction", request.calendarAction);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sequenceId", request.sequenceId);
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
                return SerializationHelper.Deserialize<AlternateView>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get iCalendar from storage as AlternateView              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarModelAsAlternateRequest" /></param>
        /// <returns><see cref="AlternateView"/></returns>
        public async Task<AlternateView> GetCalendarModelAsAlternateAsync(Model.Requests.GetCalendarModelAsAlternateRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetCalendarModelAsAlternate");
            }

            // verify the required parameter 'calendarAction' is set
            if (request.calendarAction == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'calendarAction' when calling GetCalendarModelAsAlternate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/{name}/as-alternate/{calendarAction}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarAction", request.calendarAction);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sequenceId", request.sequenceId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<AlternateView>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get iCalendar list from storage folder              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarModelListRequest" /></param>
        /// <returns><see cref="CalendarDtoList"/></returns>
        public CalendarDtoList GetCalendarModelList(Model.Requests.GetCalendarModelListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling GetCalendarModelList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel";
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
                return SerializationHelper.Deserialize<CalendarDtoList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get iCalendar list from storage folder              
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarModelListRequest" /></param>
        /// <returns><see cref="CalendarDtoList"/></returns>
        public async Task<CalendarDtoList> GetCalendarModelListAsync(Model.Requests.GetCalendarModelListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling GetCalendarModelList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "itemsPerPage", request.itemsPerPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.pageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<CalendarDtoList>(response);
            }

            return null;
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactAttachment");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetContactAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetContactAttachment");
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
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get attachment file by name              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetContactAttachmentAsync(Model.Requests.GetContactAttachmentRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactAttachment");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetContactAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetContactAttachment");
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
            return await apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactList");
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
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObjectResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get contact list from storage folder              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactListRequest" /></param>
        /// <returns><see cref="ListResponseOfHierarchicalObjectResponse"/></returns>
        public async Task<ListResponseOfHierarchicalObjectResponse> GetContactListAsync(Model.Requests.GetContactListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactList");
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObjectResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get contact document.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactModelRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public ContactDto GetContactModel(Model.Requests.GetContactModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetContactModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ContactModel/{format}/{name}";
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
                return SerializationHelper.Deserialize<ContactDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get contact document.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactModelRequest" /></param>
        /// <returns><see cref="ContactDto"/></returns>
        public async Task<ContactDto> GetContactModelAsync(Model.Requests.GetContactModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetContactModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ContactModel/{format}/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ContactDto>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get contact list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactModelListRequest" /></param>
        /// <returns><see cref="ContactDtoList"/></returns>
        public ContactDtoList GetContactModelList(Model.Requests.GetContactModelListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactModelList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ContactModel/{format}";
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
                return SerializationHelper.Deserialize<ContactDtoList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get contact list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactModelListRequest" /></param>
        /// <returns><see cref="ContactDtoList"/></returns>
        public async Task<ContactDtoList> GetContactModelListAsync(Model.Requests.GetContactModelListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactModelList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ContactModel/{format}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "itemsPerPage", request.itemsPerPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.pageNumber);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ContactDtoList>(response);
            }

            return null;
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactProperties");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetContactProperties");
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
                return SerializationHelper.Deserialize<HierarchicalObject>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get contact document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="GetContactPropertiesRequest" /></param>
        /// <returns><see cref="HierarchicalObject"/></returns>
        public async Task<HierarchicalObject> GetContactPropertiesAsync(Model.Requests.GetContactPropertiesRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetContactProperties");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetContactProperties");
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<HierarchicalObject>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage"/></returns>
        public DiscUsage GetDiscUsage(Model.Requests.GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/disc";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<DiscUsage>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage"/></returns>
        public async Task<DiscUsage> GetDiscUsageAsync(Model.Requests.GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/disc";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<DiscUsage>(response);
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
        /// Converts email document from storage to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetEmailAsFile(Model.Requests.GetEmailAsFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmailAsFile");
            }

            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetEmailAsFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/as-file/{format}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
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
        /// Converts email document from storage to specified format and returns as file              
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailAsFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetEmailAsFileAsync(Model.Requests.GetEmailAsFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.fileName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'fileName' when calling GetEmailAsFile");
            }

            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetEmailAsFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/{fileName}/as-file/{format}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.fileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            return await apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
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
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
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
            return await apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }
        #endif

        /// <summary>
        /// Get email document.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailModelRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public EmailDto GetEmailModel(Model.Requests.GetEmailModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetEmailModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/model/{format}/{name}";
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
                return SerializationHelper.Deserialize<EmailDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email document.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailModelRequest" /></param>
        /// <returns><see cref="EmailDto"/></returns>
        public async Task<EmailDto> GetEmailModelAsync(Model.Requests.GetEmailModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetEmailModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/model/{format}/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDto>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get email list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailModelListRequest" /></param>
        /// <returns><see cref="EmailDtoList"/></returns>
        public EmailDtoList GetEmailModelList(Model.Requests.GetEmailModelListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetEmailModelList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/model/{format}";
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
                return SerializationHelper.Deserialize<EmailDtoList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get email list from storage folder.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetEmailModelListRequest" /></param>
        /// <returns><see cref="EmailDtoList"/></returns>
        public async Task<EmailDtoList> GetEmailModelListAsync(Model.Requests.GetEmailModelListRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling GetEmailModelList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/model/{format}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "itemsPerPage", request.itemsPerPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.pageNumber);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<EmailDtoList>(response);
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
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions"/></returns>
        public FileVersions GetFileVersions(Model.Requests.GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/version/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FileVersions>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions"/></returns>
        public async Task<FileVersions> GetFileVersionsAsync(Model.Requests.GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/version/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FileVersions>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>
        public FilesList GetFilesList(Model.Requests.GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FilesList>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>
        public async Task<FilesList> GetFilesListAsync(Model.Requests.GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FilesList>(response);
            }

            return null;
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetMapiAttachment");
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
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get document attachment as file stream              
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> GetMapiAttachmentAsync(Model.Requests.GetMapiAttachmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMapiAttachment");
            }

            // verify the required parameter 'attachment' is set
            if (request.attachment == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'attachment' when calling GetMapiAttachment");
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
            return await apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMapiAttachments");
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
                return SerializationHelper.Deserialize<ListResponseOfString>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get document attachment list              
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiAttachmentsRequest" /></param>
        /// <returns><see cref="ListResponseOfString"/></returns>
        public async Task<ListResponseOfString> GetMapiAttachmentsAsync(Model.Requests.GetMapiAttachmentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMapiAttachments");
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfString>(response);
            }

            return null;
        }
        #endif

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
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObjectResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get document list from storage folder              
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiListRequest" /></param>
        /// <returns><see cref="ListResponseOfHierarchicalObjectResponse"/></returns>
        public async Task<ListResponseOfHierarchicalObjectResponse> GetMapiListAsync(Model.Requests.GetMapiListRequest request)
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfHierarchicalObjectResponse>(response);
            }

            return null;
        }
        #endif

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
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMapiProperties");
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
                return SerializationHelper.Deserialize<HierarchicalObjectResponse>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="GetMapiPropertiesRequest" /></param>
        /// <returns><see cref="HierarchicalObjectResponse"/></returns>
        public async Task<HierarchicalObjectResponse> GetMapiPropertiesAsync(Model.Requests.GetMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling GetMapiProperties");
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
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<HierarchicalObjectResponse>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get folders list in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailFoldersRequest" /></param>
        /// <returns><see cref="ListResponseOfMailServerFolder"/></returns>
        public ListResponseOfMailServerFolder ListEmailFolders(Model.Requests.ListEmailFoldersRequest request)
        {
            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling ListEmailFolders");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListFolders";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentFolder", request.parentFolder);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfMailServerFolder>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get folders list in email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailFoldersRequest" /></param>
        /// <returns><see cref="ListResponseOfMailServerFolder"/></returns>
        public async Task<ListResponseOfMailServerFolder> ListEmailFoldersAsync(Model.Requests.ListEmailFoldersRequest request)
        {
            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling ListEmailFolders");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListFolders";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentFolder", request.parentFolder);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfMailServerFolder>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get messages from folder, filtered by query              The query string should have the following view.      The example of a simple expression:       &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3     &gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator      At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once      The field value (&lt;Field value&gt;) can take the following values:     For text fields - any string,     For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;,     For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;              
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailMessagesRequest" /></param>
        /// <returns><see cref="ListResponseOfString"/></returns>
        public ListResponseOfString ListEmailMessages(Model.Requests.ListEmailMessagesRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling ListEmailMessages");
            }

            // verify the required parameter 'queryString' is set
            if (request.queryString == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'queryString' when calling ListEmailMessages");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling ListEmailMessages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListMessages";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "queryString", request.queryString);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfString>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get messages from folder, filtered by query              The query string should have the following view.      The example of a simple expression:       &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3     &gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator      At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once      The field value (&lt;Field value&gt;) can take the following values:     For text fields - any string,     For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;,     For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;              
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailMessagesRequest" /></param>
        /// <returns><see cref="ListResponseOfString"/></returns>
        public async Task<ListResponseOfString> ListEmailMessagesAsync(Model.Requests.ListEmailMessagesRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling ListEmailMessages");
            }

            // verify the required parameter 'queryString' is set
            if (request.queryString == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'queryString' when calling ListEmailMessages");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling ListEmailMessages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListMessages";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "queryString", request.queryString);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfString>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Get messages from folder, filtered by query              The query string should have the following view.      The example of a simple expression:       &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3     &gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator      At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once      The field value (&lt;Field value&gt;) can take the following values:     For text fields - any string,     For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;,     For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;              
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailModelsRequest" /></param>
        /// <returns><see cref="ListResponseOfEmailDto"/></returns>
        public ListResponseOfEmailDto ListEmailModels(Model.Requests.ListEmailModelsRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling ListEmailModels");
            }

            // verify the required parameter 'queryString' is set
            if (request.queryString == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'queryString' when calling ListEmailModels");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling ListEmailModels");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListMessagesModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "queryString", request.queryString);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfEmailDto>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get messages from folder, filtered by query              The query string should have the following view.      The example of a simple expression:       &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3     &gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator      At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once      The field value (&lt;Field value&gt;) can take the following values:     For text fields - any string,     For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;,     For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;              
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailModelsRequest" /></param>
        /// <returns><see cref="ListResponseOfEmailDto"/></returns>
        public async Task<ListResponseOfEmailDto> ListEmailModelsAsync(Model.Requests.ListEmailModelsRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling ListEmailModels");
            }

            // verify the required parameter 'queryString' is set
            if (request.queryString == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'queryString' when calling ListEmailModels");
            }

            // verify the required parameter 'firstAccount' is set
            if (request.firstAccount == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'firstAccount' when calling ListEmailModels");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListMessagesModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "queryString", request.queryString);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstAccount", request.firstAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "secondAccount", request.secondAccount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageFolder", request.storageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ListResponseOfEmailDto>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public void MoveFile(Model.Requests.MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public async Task MoveFileAsync(Model.Requests.MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public void MoveFolder(Model.Requests.MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public async Task MoveFolderAsync(Model.Requests.MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/folder/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist"/></returns>
        public ObjectExist ObjectExists(Model.Requests.ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/exist/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ObjectExist>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist"/></returns>
        public async Task<ObjectExist> ObjectExistsAsync(Model.Requests.ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/exist/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<ObjectExist>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Save iCalendar              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveCalendarModelRequest" /></param>
        public void SaveCalendarModel(Model.Requests.SaveCalendarModelRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling SaveCalendarModel");
            }

            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SaveCalendarModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Save iCalendar              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveCalendarModelRequest" /></param>
        public async Task SaveCalendarModelAsync(Model.Requests.SaveCalendarModelRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling SaveCalendarModel");
            }

            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SaveCalendarModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/CalendarModel/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Save contact.              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveContactModelRequest" /></param>
        public void SaveContactModel(Model.Requests.SaveContactModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling SaveContactModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling SaveContactModel");
            }

            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SaveContactModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ContactModel/{format}/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Save contact.              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveContactModelRequest" /></param>
        public async Task SaveContactModelAsync(Model.Requests.SaveContactModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling SaveContactModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling SaveContactModel");
            }

            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SaveContactModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/ContactModel/{format}/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Save email document.              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveEmailModelRequest" /></param>
        public void SaveEmailModel(Model.Requests.SaveEmailModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling SaveEmailModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling SaveEmailModel");
            }

            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SaveEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/model/{format}/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Save email document.              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveEmailModelRequest" /></param>
        public async Task SaveEmailModelAsync(Model.Requests.SaveEmailModelRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling SaveEmailModel");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling SaveEmailModel");
            }

            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SaveEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/model/{format}/{name}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Create email account file (*.account) with login/password authentication              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveMailAccountRequest" /></param>
        public void SaveMailAccount(Model.Requests.SaveMailAccountRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SaveMailAccount");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SaveMailAccount";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create email account file (*.account) with login/password authentication              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveMailAccountRequest" /></param>
        public async Task SaveMailAccountAsync(Model.Requests.SaveMailAccountRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SaveMailAccount");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SaveMailAccount";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Create email account file (*.account) with OAuth              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveMailOAuthAccountRequest" /></param>
        public void SaveMailOAuthAccount(Model.Requests.SaveMailOAuthAccountRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SaveMailOAuthAccount");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SaveMailOAuthAccount";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Create email account file (*.account) with OAuth              
        /// </summary>
        /// <param name="request">Request. <see cref="SaveMailOAuthAccountRequest" /></param>
        public async Task SaveMailOAuthAccountAsync(Model.Requests.SaveMailOAuthAccountRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SaveMailOAuthAccount");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SaveMailOAuthAccount";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Send an email from *.eml file located on storage              
        /// </summary>
        /// <param name="request">Request. <see cref="SendEmailRequest" /></param>
        public void SendEmail(Model.Requests.SendEmailRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SendEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Send";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Send an email from *.eml file located on storage              
        /// </summary>
        /// <param name="request">Request. <see cref="SendEmailRequest" /></param>
        public async Task SendEmailAsync(Model.Requests.SendEmailRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SendEmail");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Send";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Send an email specified by MIME in request              
        /// </summary>
        /// <param name="request">Request. <see cref="SendEmailMimeRequest" /></param>
        public void SendEmailMime(Model.Requests.SendEmailMimeRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SendEmailMime");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SendMime";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Send an email specified by MIME in request              
        /// </summary>
        /// <param name="request">Request. <see cref="SendEmailMimeRequest" /></param>
        public async Task SendEmailMimeAsync(Model.Requests.SendEmailMimeRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SendEmailMime");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SendMime";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Send an email specified by model in request              
        /// </summary>
        /// <param name="request">Request. <see cref="SendEmailModelRequest" /></param>
        public void SendEmailModel(Model.Requests.SendEmailModelRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SendEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SendModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Send an email specified by model in request              
        /// </summary>
        /// <param name="request">Request. <see cref="SendEmailModelRequest" /></param>
        public async Task SendEmailModelAsync(Model.Requests.SendEmailModelRequest request)
        {
            // verify the required parameter 'rq' is set
            if (request.rq == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'rq' when calling SendEmailModel");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SendModel";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.rq); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
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

        /// <summary>
        /// Sets \&quot;Message is read\&quot; flag              
        /// </summary>
        /// <param name="request">Request. <see cref="SetEmailReadFlagRequest" /></param>
        public void SetEmailReadFlag(Model.Requests.SetEmailReadFlagRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SetEmailReadFlag");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SetReadFlag";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Sets \&quot;Message is read\&quot; flag              
        /// </summary>
        /// <param name="request">Request. <see cref="SetEmailReadFlagRequest" /></param>
        public async Task SetEmailReadFlagAsync(Model.Requests.SetEmailReadFlagRequest request)
        {
            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SetEmailReadFlag");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SetReadFlag";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist"/></returns>
        public StorageExist StorageExists(Model.Requests.StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/{storageName}/exist";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<StorageExist>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist"/></returns>
        public async Task<StorageExist> StorageExistsAsync(Model.Requests.StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/{storageName}/exist";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
            if (response != null)
            {
                return SerializationHelper.Deserialize<StorageExist>(response);
            }

            return null;
        }
        #endif

        /// <summary>
        /// Update calendar file properties              
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCalendarPropertiesRequest" /></param>
        public void UpdateCalendarProperties(Model.Requests.UpdateCalendarPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling UpdateCalendarProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UpdateCalendarProperties");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Update calendar file properties              
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCalendarPropertiesRequest" /></param>
        public async Task UpdateCalendarPropertiesAsync(Model.Requests.UpdateCalendarPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling UpdateCalendarProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UpdateCalendarProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Calendar/{name}/properties";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Update contact document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateContactPropertiesRequest" /></param>
        public void UpdateContactProperties(Model.Requests.UpdateContactPropertiesRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling UpdateContactProperties");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling UpdateContactProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UpdateContactProperties");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Update contact document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateContactPropertiesRequest" /></param>
        public async Task UpdateContactPropertiesAsync(Model.Requests.UpdateContactPropertiesRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'format' when calling UpdateContactProperties");
            }

            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling UpdateContactProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UpdateContactProperties");
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
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Update document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateMapiPropertiesRequest" /></param>
        public void UpdateMapiProperties(Model.Requests.UpdateMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling UpdateMapiProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UpdateMapiProperties");
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

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Update document properties              
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateMapiPropertiesRequest" /></param>
        public async Task UpdateMapiPropertiesAsync(Model.Requests.UpdateMapiPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling UpdateMapiProperties");
            }

            // verify the required parameter 'request' is set
            if (request.request == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UpdateMapiProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/Mapi/{name}/properties";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            var postBody = SerializationHelper.Serialize(request.request); // http body (model) parameter
            await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                postBody,
                null,
                null);
        }
        #endif

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>
        public FilesUploadResult UploadFile(Model.Requests.UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling UploadFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                null,
                null,
                formParams);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FilesUploadResult>(response);
            }

            return null;
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>
        public async Task<FilesUploadResult> UploadFileAsync(Model.Requests.UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'path' when calling UploadFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = await apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                formParams);
            if (response != null)
            {
                return SerializationHelper.Deserialize<FilesUploadResult>(response);
            }

            return null;
        }
        #endif
    }
}