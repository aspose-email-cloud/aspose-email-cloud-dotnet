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

    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class EmailClientApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public EmailClientApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientApi"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public EmailClientApi(Configuration configuration)
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

        /// <summary>
        /// Get folders list in email account 
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailFoldersRequest" /></param>
        /// <returns><see cref="ListFoldersResponse"/></returns>
        public ListFoldersResponse ListEmailFolders(Model.Requests.ListEmailFoldersRequest request)
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
                return SerializationHelper.Deserialize<ListFoldersResponse>(response);
            }

            return null;
        }

        /// <summary>
        /// Get messages from folder, filtered by query The query string should have the following view.  The example of a simple expression:   &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.  The number of simple expressions can make a compound one, ex.: (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3&gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator  At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message  Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message  Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item  Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once  The field value (&lt;Field value&gt;) can take the following values: For text fields - any string, For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;, For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;
        /// </summary>
        /// <param name="request">Request. <see cref="ListEmailMessagesRequest" /></param>
        /// <returns><see cref="ListMessagesResponse"/></returns>
        public ListMessagesResponse ListEmailMessages(Model.Requests.ListEmailMessagesRequest request)
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
                return SerializationHelper.Deserialize<ListMessagesResponse>(response);
            }

            return null;
        }

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
    }
}