// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailConfigApi.cs">
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
    public class EmailConfigApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailConfigApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal EmailConfigApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }

        /// <summary>
        /// Discover email accounts by email address. Does not validate discovered accounts.              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailConfigDiscoverRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public EmailAccountConfigList Discover(EmailConfigDiscoverRequest request)
        {
            // verify the required parameter 'address' is set
            if (request.Address == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'address' when calling Discover");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "address", request.Address);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fastProcessing", request.FastProcessing);
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<EmailAccountConfigList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Discover email accounts by email address. Does not validate discovered accounts.              
        /// </summary>
        /// <param name="request">Request. <see cref="EmailConfigDiscoverRequest" /></param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public async Task<EmailAccountConfigList> DiscoverAsync(EmailConfigDiscoverRequest request) =>
            await Task.Run(() => Discover(request));
        #endif


        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.              
        /// </summary>
        /// <param name="request">Discover email configuration request.</param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public EmailAccountConfigList DiscoverOauth(
            EmailConfigDiscoverOauthRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DiscoverOauth");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover/oauth";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<EmailAccountConfigList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.              
        /// </summary>
        /// <param name="request">Discover email configuration request.</param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public async Task<EmailAccountConfigList> DiscoverOauthAsync(
            EmailConfigDiscoverOauthRequest request) =>
            await Task.Run(() => DiscoverOauth(request
        ));
        #endif


        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using login and password.              
        /// </summary>
        /// <param name="request">Discover email configuration request.</param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public EmailAccountConfigList DiscoverPassword(
            EmailConfigDiscoverPasswordRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling DiscoverPassword");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/config/discover/password";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<EmailAccountConfigList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Discover email accounts by email address. Validates discovered accounts using login and password.              
        /// </summary>
        /// <param name="request">Discover email configuration request.</param>
        /// <returns><see cref="EmailAccountConfigList"/></returns>
        public async Task<EmailAccountConfigList> DiscoverPasswordAsync(
            EmailConfigDiscoverPasswordRequest request) =>
            await Task.Run(() => DiscoverPassword(request
        ));
        #endif

    }
}
