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
    using Aspose.Email.Cloud.Sdk.Model;
    using Aspose.Email.Cloud.Sdk.Model.Requests;
    using Aspose.Email.Cloud.Sdk.RequestHandlers;
    
    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class EmailClientApi
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
        public EmailClientApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public EmailClientApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Append message 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientAppendMessageRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientAppendMessage(EmailClientAppendMessageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Append";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mailPath", request.mailPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "markAsSent", request.markAsSent);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Append mime message 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientAppendMimeMessageRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientAppendMimeMessage(EmailClientAppendMimeMessageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/AppendMime";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "markAsSent", request.markAsSent);
            var postBody = SerializationHelper.Serialize(request.base64MimeMessage); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Create folder 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientCreateFolderRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientCreateFolder(EmailClientCreateFolderRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/CreateFolder";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentFolder", request.parentFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.name);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientDeleteFolderRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientDeleteFolder(EmailClientDeleteFolderRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/DeleteFolder";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "deletePermanently", request.deletePermanently);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete message 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientDeleteMessageRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientDeleteMessage(EmailClientDeleteMessageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/DeleteMessage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "deletePermanently", request.deletePermanently);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Fetch message 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientFetchMessageRequest" /></param> 
        /// <returns><see cref="MimeResponse"/></returns>            
        public MimeResponse EmailClientFetchMessage(EmailClientFetchMessageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Fetch";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (MimeResponse)SerializationHelper.Deserialize(response, typeof(MimeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// List folders 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientListFoldersRequest" /></param> 
        /// <returns><see cref="ListFoldersResponse"/></returns>            
        public ListFoldersResponse EmailClientListFolders(EmailClientListFoldersRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListFolders";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentFolder", request.parentFolder);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ListFoldersResponse)SerializationHelper.Deserialize(response, typeof(ListFoldersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// List messages 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientListMessagesRequest" /></param> 
        /// <returns><see cref="ListResponse"/></returns>            
        public ListResponse EmailClientListMessages(EmailClientListMessagesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/ListMessages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "queryString", request.queryString);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ListResponse)SerializationHelper.Deserialize(response, typeof(ListResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Save mail account 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientSaveMailAccountRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientSaveMailAccount(EmailClientSaveMailAccountRequest request)
        {
            // verify the required parameter 'storage' is set
            if (request.storage == null) 
            {
                throw new ApiException(400, "Missing required parameter 'storage' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'accountName' is set
            if (request.accountName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'accountName' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'host' is set
            if (request.host == null) 
            {
                throw new ApiException(400, "Missing required parameter 'host' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'port' is set
            if (request.port == null) 
            {
                throw new ApiException(400, "Missing required parameter 'port' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'login' is set
            if (request.login == null) 
            {
                throw new ApiException(400, "Missing required parameter 'login' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'password' is set
            if (request.password == null) 
            {
                throw new ApiException(400, "Missing required parameter 'password' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'securityOptions' is set
            if (request.securityOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'securityOptions' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'protocolType' is set
            if (request.protocolType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protocolType' when calling EmailClientSaveMailAccount");
            }

            // verify the required parameter 'description' is set
            if (request.description == null) 
            {
                throw new ApiException(400, "Missing required parameter 'description' when calling EmailClientSaveMailAccount");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SaveMailAccount";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName", request.accountName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "host", request.host);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "port", request.port);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "login", request.login);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "securityOptions", request.securityOptions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "protocolType", request.protocolType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "description", request.description);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Save mail oauth account 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientSaveMailOAuthAccountRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientSaveMailOAuthAccount(EmailClientSaveMailOAuthAccountRequest request)
        {
            // verify the required parameter 'storage' is set
            if (request.storage == null) 
            {
                throw new ApiException(400, "Missing required parameter 'storage' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'accountName' is set
            if (request.accountName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'accountName' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'host' is set
            if (request.host == null) 
            {
                throw new ApiException(400, "Missing required parameter 'host' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'port' is set
            if (request.port == null) 
            {
                throw new ApiException(400, "Missing required parameter 'port' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'login' is set
            if (request.login == null) 
            {
                throw new ApiException(400, "Missing required parameter 'login' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'clientId' is set
            if (request.clientId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'clientId' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'clientSecret' is set
            if (request.clientSecret == null) 
            {
                throw new ApiException(400, "Missing required parameter 'clientSecret' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'refreshToken' is set
            if (request.refreshToken == null) 
            {
                throw new ApiException(400, "Missing required parameter 'refreshToken' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'securityOptions' is set
            if (request.securityOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'securityOptions' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'protocolType' is set
            if (request.protocolType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protocolType' when calling EmailClientSaveMailOAuthAccount");
            }

            // verify the required parameter 'description' is set
            if (request.description == null) 
            {
                throw new ApiException(400, "Missing required parameter 'description' when calling EmailClientSaveMailOAuthAccount");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SaveMailOAuthAccount";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName", request.accountName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "host", request.host);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "port", request.port);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "login", request.login);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "clientId", request.clientId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "clientSecret", request.clientSecret);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "refreshToken", request.refreshToken);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "securityOptions", request.securityOptions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "protocolType", request.protocolType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "description", request.description);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Send 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientSendRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientSend(EmailClientSendRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/Send";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mailPath", request.mailPath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Send Mime 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientSendMimeRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientSendMime(EmailClientSendMimeRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SendMime";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            var postBody = SerializationHelper.Serialize(request.base64MimeMessage); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Set read flag 
        /// </summary>
        /// <param name="request">Request. <see cref="EmailClientSetReadFlagRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse EmailClientSetReadFlag(EmailClientSetReadFlagRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/client/SetReadFlag";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName1", request.accountName1);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "accountName2", request.accountName2);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "messageId", request.messageId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isRead", request.isRead);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientAppendMessageRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientAppendMessage" /> operation.
  /// </summary>  
  public class EmailClientAppendMessageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientAppendMessageRequest"/> class.
        /// </summary>        
        public EmailClientAppendMessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientAppendMessageRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="folder"></param>
        /// <param name="mailPath"></param>
        /// <param name="markAsSent"></param>
        public EmailClientAppendMessageRequest(string storage = null, string accountName1 = null, string accountName2 = null, string folder = null, string mailPath = null, bool? markAsSent = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.folder = folder;
            this.mailPath = mailPath;
            this.markAsSent = markAsSent;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets mailPath
        /// </summary>  
        public string mailPath { get; set; }

        /// <summary>
        /// Gets or sets markAsSent
        /// </summary>  
        public bool? markAsSent { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientAppendMimeMessageRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientAppendMimeMessage" /> operation.
  /// </summary>  
  public class EmailClientAppendMimeMessageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientAppendMimeMessageRequest"/> class.
        /// </summary>        
        public EmailClientAppendMimeMessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientAppendMimeMessageRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="folder"></param>
        /// <param name="base64MimeMessage"></param>
        /// <param name="markAsSent"></param>
        public EmailClientAppendMimeMessageRequest(string storage = null, string accountName1 = null, string accountName2 = null, string folder = null, string base64MimeMessage = null, bool? markAsSent = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.folder = folder;
            this.base64MimeMessage = base64MimeMessage;
            this.markAsSent = markAsSent;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets base64MimeMessage
        /// </summary>  
        public string base64MimeMessage { get; set; }

        /// <summary>
        /// Gets or sets markAsSent
        /// </summary>  
        public bool? markAsSent { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientCreateFolderRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientCreateFolder" /> operation.
  /// </summary>  
  public class EmailClientCreateFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientCreateFolderRequest"/> class.
        /// </summary>        
        public EmailClientCreateFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientCreateFolderRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="parentFolder"></param>
        /// <param name="name"></param>
        public EmailClientCreateFolderRequest(string storage = null, string accountName1 = null, string accountName2 = null, string parentFolder = null, string name = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.parentFolder = parentFolder;
            this.name = name;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets parentFolder
        /// </summary>  
        public string parentFolder { get; set; }

        /// <summary>
        /// Gets or sets name
        /// </summary>  
        public string name { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientDeleteFolderRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientDeleteFolder" /> operation.
  /// </summary>  
  public class EmailClientDeleteFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientDeleteFolderRequest"/> class.
        /// </summary>        
        public EmailClientDeleteFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientDeleteFolderRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="folder"></param>
        /// <param name="deletePermanently"></param>
        public EmailClientDeleteFolderRequest(string storage = null, string accountName1 = null, string accountName2 = null, string folder = null, bool? deletePermanently = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.folder = folder;
            this.deletePermanently = deletePermanently;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets deletePermanently
        /// </summary>  
        public bool? deletePermanently { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientDeleteMessageRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientDeleteMessage" /> operation.
  /// </summary>  
  public class EmailClientDeleteMessageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientDeleteMessageRequest"/> class.
        /// </summary>        
        public EmailClientDeleteMessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientDeleteMessageRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="messageId"></param>
        /// <param name="deletePermanently"></param>
        public EmailClientDeleteMessageRequest(string storage = null, string accountName1 = null, string accountName2 = null, string messageId = null, bool? deletePermanently = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.messageId = messageId;
            this.deletePermanently = deletePermanently;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets messageId
        /// </summary>  
        public string messageId { get; set; }

        /// <summary>
        /// Gets or sets deletePermanently
        /// </summary>  
        public bool? deletePermanently { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientFetchMessageRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientFetchMessage" /> operation.
  /// </summary>  
  public class EmailClientFetchMessageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientFetchMessageRequest"/> class.
        /// </summary>        
        public EmailClientFetchMessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientFetchMessageRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="messageId"></param>
        public EmailClientFetchMessageRequest(string storage = null, string accountName1 = null, string accountName2 = null, string messageId = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.messageId = messageId;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets messageId
        /// </summary>  
        public string messageId { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientListFoldersRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientListFolders" /> operation.
  /// </summary>  
  public class EmailClientListFoldersRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientListFoldersRequest"/> class.
        /// </summary>        
        public EmailClientListFoldersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientListFoldersRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="parentFolder"></param>
        public EmailClientListFoldersRequest(string storage = null, string accountName1 = null, string accountName2 = null, string parentFolder = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.parentFolder = parentFolder;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets parentFolder
        /// </summary>  
        public string parentFolder { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientListMessagesRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientListMessages" /> operation.
  /// </summary>  
  public class EmailClientListMessagesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientListMessagesRequest"/> class.
        /// </summary>        
        public EmailClientListMessagesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientListMessagesRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="folder"></param>
        /// <param name="recursive"></param>
        /// <param name="queryString"></param>
        public EmailClientListMessagesRequest(string storage = null, string accountName1 = null, string accountName2 = null, string folder = null, bool? recursive = null, string queryString = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.folder = folder;
            this.recursive = recursive;
            this.queryString = queryString;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets folder
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets recursive
        /// </summary>  
        public bool? recursive { get; set; }

        /// <summary>
        /// Gets or sets queryString
        /// </summary>  
        public string queryString { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientSaveMailAccountRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientSaveMailAccount" /> operation.
  /// </summary>  
  public class EmailClientSaveMailAccountRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSaveMailAccountRequest"/> class.
        /// </summary>        
        public EmailClientSaveMailAccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSaveMailAccountRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="securityOptions"></param>
        /// <param name="protocolType"></param>
        /// <param name="description"></param>
        public EmailClientSaveMailAccountRequest(string storage, string accountName, string host, int? port, string login, string password, int? securityOptions, int? protocolType, string description)             
        {
            this.storage = storage;
            this.accountName = accountName;
            this.host = host;
            this.port = port;
            this.login = login;
            this.password = password;
            this.securityOptions = securityOptions;
            this.protocolType = protocolType;
            this.description = description;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName
        /// </summary>  
        public string accountName { get; set; }

        /// <summary>
        /// Gets or sets host
        /// </summary>  
        public string host { get; set; }

        /// <summary>
        /// Gets or sets port
        /// </summary>  
        public int? port { get; set; }

        /// <summary>
        /// Gets or sets login
        /// </summary>  
        public string login { get; set; }

        /// <summary>
        /// Gets or sets password
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Gets or sets securityOptions
        /// </summary>  
        public int? securityOptions { get; set; }

        /// <summary>
        /// Gets or sets protocolType
        /// </summary>  
        public int? protocolType { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>  
        public string description { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientSaveMailOAuthAccountRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientSaveMailOAuthAccount" /> operation.
  /// </summary>  
  public class EmailClientSaveMailOAuthAccountRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSaveMailOAuthAccountRequest"/> class.
        /// </summary>        
        public EmailClientSaveMailOAuthAccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSaveMailOAuthAccountRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="login"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="refreshToken"></param>
        /// <param name="securityOptions"></param>
        /// <param name="protocolType"></param>
        /// <param name="description"></param>
        public EmailClientSaveMailOAuthAccountRequest(string storage, string accountName, string host, int? port, string login, string clientId, string clientSecret, string refreshToken, int? securityOptions, int? protocolType, string description)             
        {
            this.storage = storage;
            this.accountName = accountName;
            this.host = host;
            this.port = port;
            this.login = login;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.refreshToken = refreshToken;
            this.securityOptions = securityOptions;
            this.protocolType = protocolType;
            this.description = description;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName
        /// </summary>  
        public string accountName { get; set; }

        /// <summary>
        /// Gets or sets host
        /// </summary>  
        public string host { get; set; }

        /// <summary>
        /// Gets or sets port
        /// </summary>  
        public int? port { get; set; }

        /// <summary>
        /// Gets or sets login
        /// </summary>  
        public string login { get; set; }

        /// <summary>
        /// Gets or sets clientId
        /// </summary>  
        public string clientId { get; set; }

        /// <summary>
        /// Gets or sets clientSecret
        /// </summary>  
        public string clientSecret { get; set; }

        /// <summary>
        /// Gets or sets refreshToken
        /// </summary>  
        public string refreshToken { get; set; }

        /// <summary>
        /// Gets or sets securityOptions
        /// </summary>  
        public int? securityOptions { get; set; }

        /// <summary>
        /// Gets or sets protocolType
        /// </summary>  
        public int? protocolType { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>  
        public string description { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientSendRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientSend" /> operation.
  /// </summary>  
  public class EmailClientSendRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSendRequest"/> class.
        /// </summary>        
        public EmailClientSendRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSendRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="mailPath"></param>
        public EmailClientSendRequest(string storage = null, string accountName1 = null, string accountName2 = null, string mailPath = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.mailPath = mailPath;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets mailPath
        /// </summary>  
        public string mailPath { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientSendMimeRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientSendMime" /> operation.
  /// </summary>  
  public class EmailClientSendMimeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSendMimeRequest"/> class.
        /// </summary>        
        public EmailClientSendMimeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSendMimeRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="base64MimeMessage"></param>
        public EmailClientSendMimeRequest(string storage = null, string accountName1 = null, string accountName2 = null, string base64MimeMessage = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.base64MimeMessage = base64MimeMessage;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets base64MimeMessage
        /// </summary>  
        public string base64MimeMessage { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailClientSetReadFlagRequest.cs">
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
namespace Aspose.Email.Cloud.Sdk.Model.Requests 
{
  using Aspose.Email.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Email.Cloud.Sdk.Api.EmailApi.EmailClientSetReadFlag" /> operation.
  /// </summary>  
  public class EmailClientSetReadFlagRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSetReadFlagRequest"/> class.
        /// </summary>        
        public EmailClientSetReadFlagRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientSetReadFlagRequest"/> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="accountName1"></param>
        /// <param name="accountName2"></param>
        /// <param name="messageId"></param>
        /// <param name="isRead"></param>
        public EmailClientSetReadFlagRequest(string storage = null, string accountName1 = null, string accountName2 = null, string messageId = null, bool? isRead = null)             
        {
            this.storage = storage;
            this.accountName1 = accountName1;
            this.accountName2 = accountName2;
            this.messageId = messageId;
            this.isRead = isRead;
        }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets accountName1
        /// </summary>  
        public string accountName1 { get; set; }

        /// <summary>
        /// Gets or sets accountName2
        /// </summary>  
        public string accountName2 { get; set; }

        /// <summary>
        /// Gets or sets messageId
        /// </summary>  
        public string messageId { get; set; }

        /// <summary>
        /// Gets or sets isRead
        /// </summary>  
        public bool? isRead { get; set; }
  }
}
