// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientMessageApi.cs">
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
    public class ClientMessageApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal ClientMessageApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    
        /// <summary>
        /// Add email message to specified folder in email account.              
        /// </summary>
        /// <param name="request">Append email request.</param>
        /// <returns><see cref="ValueTOfString"/></returns>
        public ValueTOfString Append(
            ClientMessageAppendRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Append");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/append";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<ValueTOfString>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Add email message to specified folder in email account.              
        /// </summary>
        /// <param name="request">Append email request.</param>
        /// <returns><see cref="ValueTOfString"/></returns>
        public async Task<ValueTOfString> AppendAsync(
            ClientMessageAppendRequest request) =>
            await Task.Run(() => Append(request
        ));
        #endif

                    
        /// <summary>
        /// Add email message from file to specified folder in email account.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageAppendFileRequest" /></param>
        /// <returns><see cref="ValueTOfString"/></returns>
        public ValueTOfString AppendFile(ClientMessageAppendFileRequest request)
        {
            // verify the required parameter 'account' is set
            if (request.Account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling AppendFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling AppendFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/file/append";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.Account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.AccountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "markAsSent", request.MarkAsSent);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                formParams: formParams);
            return response == null ? null : SerializationHelper.Deserialize<ValueTOfString>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Add email message from file to specified folder in email account.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageAppendFileRequest" /></param>
        /// <returns><see cref="ValueTOfString"/></returns>
        public async Task<ValueTOfString> AppendFileAsync(ClientMessageAppendFileRequest request) =>
            await Task.Run(() => AppendFile(request));
        #endif

                    
        /// <summary>
        /// Delete message.              
        /// </summary>
        /// <param name="request">Delete message request.</param>
        public void Delete(
            ClientMessageDeleteRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Delete");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "DELETE",
                postBody);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Delete message.              
        /// </summary>
        /// <param name="request">Delete message request.</param>
        public async Task DeleteAsync(
            ClientMessageDeleteRequest request) =>
            await Task.Run(() => Delete(request
        ));
        #endif

                    
        /// <summary>
        /// Fetch message from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageFetchRequest" /></param>
        /// <returns><see cref="MailMessageBase"/></returns>
        public MailMessageBase Fetch(ClientMessageFetchRequest request)
        {
            // verify the required parameter 'messageId' is set
            if (request.MessageId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'messageId' when calling Fetch");
            }

            // verify the required parameter 'account' is set
            if (request.Account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling Fetch");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.MessageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.Account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.AccountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<MailMessageBase>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Fetch message from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageFetchRequest" /></param>
        /// <returns><see cref="MailMessageBase"/></returns>
        public async Task<MailMessageBase> FetchAsync(ClientMessageFetchRequest request) =>
            await Task.Run(() => Fetch(request));
        #endif

                    
        /// <summary>
        /// Fetch message as file from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageFetchFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream FetchFile(ClientMessageFetchFileRequest request)
        {
            // verify the required parameter 'messageId' is set
            if (request.MessageId == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'messageId' when calling FetchFile");
            }

            // verify the required parameter 'account' is set
            if (request.Account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling FetchFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.MessageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.Account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.AccountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            return apiInvoker.InvokeBinaryApi(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Fetch message as file from email account              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageFetchFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public async Task<System.IO.Stream> FetchFileAsync(ClientMessageFetchFileRequest request) =>
            await Task.Run(() => FetchFile(request));
        #endif

                    
        /// <summary>
        /// Get messages from folder, filtered by query              The query string should have the following view.      The example of a simple expression:       &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3     &gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator      At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once      The field value (&lt;Field value&gt;) can take the following values:     For text fields - any string,     For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;,     For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageListRequest" /></param>
        /// <returns><see cref="MailMessageBaseList"/></returns>
        public MailMessageBaseList List(ClientMessageListRequest request)
        {
            // verify the required parameter 'folder' is set
            if (request.Folder == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling List");
            }

            // verify the required parameter 'account' is set
            if (request.Account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling List");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/list";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.Account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "queryString", request.QueryString);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.AccountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.Recursive);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<MailMessageBaseList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Get messages from folder, filtered by query              The query string should have the following view.      The example of a simple expression:       &#39;&lt;Field name&gt;&#39; &lt;Comparison operator&gt; &#39;&lt;Field value&gt;&#39;,  where &amp;lt;Field Name&amp;gt; - the name of a message field through which filtering is made, &amp;lt;Comparison operator&amp;gt; - comparison operators, as their name implies, allow to compare message field and specified value, &amp;lt;Field value&amp;gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (&lt;Simple expression 1&gt; &amp; &lt;Simple expression 2&gt;) | &lt;Simple expression 3     &gt;,  where \&quot;&amp;amp;\&quot; - logical-AND operator, \&quot;|\&quot; - logical-OR operator      At present the following values are allowed as a field name (&lt;Field name&gt;):  \&quot;To\&quot; - represents a TO field of message, \&quot;Text\&quot; - represents string in the header or body of the message, \&quot;Bcc\&quot; - represents a BCC field of message, \&quot;Body\&quot; - represents a string in the body of message, \&quot;Cc\&quot; - represents a CC field of message, \&quot;From\&quot; - represents a From field of message, \&quot;Subject\&quot; - represents a string in the subject of message, \&quot;InternalDate\&quot; - represents an internal date of message, \&quot;SentDate\&quot; - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \&quot;Answered\&quot; - represents an /Answered flag of message \&quot;Seen\&quot; - represents a /Seen flag of message \&quot;Flagged\&quot; - represents a /Flagged flag of message \&quot;Draft\&quot; - represents a /Draft flag of message \&quot;Deleted\&quot; - represents a Deleted/ flag of message \&quot;Recent\&quot; - represents a Deleted/ flag of message \&quot;MessageSize\&quot; - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \&quot;IsRead\&quot; - Indicates whether the message has been read \&quot;HasAttachment\&quot; - Indicates whether or not the message has attachments \&quot;IsSubmitted\&quot; - Indicates whether the message has been submitted to the Outbox \&quot;ContentClass\&quot; - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \&quot;MessageClass\&quot; - Represents a message class \&quot;ContainerClass\&quot; - Represents a folder container class \&quot;Importance\&quot; - Represents a message importance \&quot;MessageSize\&quot; - represents a size (in bytes) of message \&quot;FolderName\&quot; - represents a folder name \&quot;ContentsCount\&quot; - represents a total number of items in the folder \&quot;UnreadContentsCount\&quot; - represents the number of unread items in the folder. \&quot;Subfolders\&quot; - Indicates whether or not the folder has subfolders \&quot;Read\&quot; - the message is marked as having been read \&quot;HasAttachment\&quot; - the message has at least one attachment \&quot;Unsent\&quot; - the message is still being composed \&quot;Unmodified\&quot; - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \&quot;FromMe\&quot; - the user receiving the message was also the user who sent the message \&quot;Resend\&quot; - the message includes a request for a resend operation with a non-delivery report \&quot;NotifyRead\&quot; - the user who sent the message has requested notification when a recipient first reads it \&quot;NotifyUnread\&quot; - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \&quot;EverRead\&quot; - the message has been read at least once      The field value (&lt;Field value&gt;) can take the following values:     For text fields - any string,     For date type fields - the string of \&quot;d-MMM-yyy\&quot; format, ex. \&quot;10-Feb-2009\&quot;,     For flags (fields of boolean type) - either \&quot;True\&quot;, or \&quot;False\&quot;              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageListRequest" /></param>
        /// <returns><see cref="MailMessageBaseList"/></returns>
        public async Task<MailMessageBaseList> ListAsync(ClientMessageListRequest request) =>
            await Task.Run(() => List(request));
        #endif

                    
        /// <summary>
        /// Move message to another folder.              
        /// </summary>
        /// <param name="request">Move message request.</param>
        public void Move(
            ClientMessageMoveRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Move");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/move";
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
        /// Move message to another folder.              
        /// </summary>
        /// <param name="request">Move message request.</param>
        public async Task MoveAsync(
            ClientMessageMoveRequest request) =>
            await Task.Run(() => Move(request
        ));
        #endif

                    
        /// <summary>
        /// Send an email specified by model in request.              
        /// </summary>
        /// <param name="request">Send email request.</param>
        public void Send(
            ClientMessageSendRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling Send");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Send an email specified by model in request.              
        /// </summary>
        /// <param name="request">Send email request.</param>
        public async Task SendAsync(
            ClientMessageSendRequest request) =>
            await Task.Run(() => Send(request
        ));
        #endif

                    
        /// <summary>
        /// Send an email file.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageSendFileRequest" /></param>
        public void SendFile(ClientMessageSendFileRequest request)
        {
            // verify the required parameter 'account' is set
            if (request.Account == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'account' when calling SendFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'file' when calling SendFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/file";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "account", request.Account);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountStorageFolder", request.AccountStorageFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            if (request.File != null)
            {
                formParams.Add("file",
                    apiInvoker.ToFileInfo(request.File, "File"));
                
            }
            apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                formParams: formParams);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Send an email file.              
        /// </summary>
        /// <param name="request">Request. <see cref="ClientMessageSendFileRequest" /></param>
        public async Task SendFileAsync(ClientMessageSendFileRequest request) =>
            await Task.Run(() => SendFile(request));
        #endif

                    
        /// <summary>
        /// Mark message as read or unread.              
        /// </summary>
        /// <param name="request">Delete message request.</param>
        public void SetIsRead(
            ClientMessageSetIsReadRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling SetIsRead");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/message/set-is-read";
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
        /// Mark message as read or unread.              
        /// </summary>
        /// <param name="request">Delete message request.</param>
        public async Task SetIsReadAsync(
            ClientMessageSetIsReadRequest request) =>
            await Task.Run(() => SetIsRead(request
        ));
        #endif

    }
}
