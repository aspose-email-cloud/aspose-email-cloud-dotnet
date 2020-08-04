
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AiNameApi.cs">
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
    public class AiNameApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="AiNameApi"/> class.
        /// </summary>
        /// <param name="apiInvoker">API client</param>
        /// <param name="configuration">Configuration settings</param>
        internal AiNameApi(ApiInvoker apiInvoker, Configuration configuration)
        {
            this.configuration = configuration;
            this.apiInvoker = apiInvoker;
        }
                    
        /// <summary>
        /// The call proposes k most probable names for given starting characters.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameCompleteRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public AiNameWeightedVariants Complete(AiNameCompleteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Complete");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// The call proposes k most probable names for given starting characters.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameCompleteRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public async Task<AiNameWeightedVariants> CompleteAsync(AiNameCompleteRequest request) =>
            await Task.Run(() => Complete(request));
        #endif

                    
        /// <summary>
        /// Expands a person&#39;s name into a list of possible alternatives using options for expanding instructions.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameExpandRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public AiNameWeightedVariants Expand(AiNameExpandRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Expand");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Expands a person&#39;s name into a list of possible alternatives using options for expanding instructions.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameExpandRequest" /></param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public async Task<AiNameWeightedVariants> ExpandAsync(AiNameExpandRequest request) =>
            await Task.Run(() => Expand(request));
        #endif

                    
        /// <summary>
        /// Expands a person&#39;s parsed name into a list of possible alternatives using options for expanding instructions.              
        /// </summary>
        /// <param name="request">Parsed name with options.</param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public AiNameWeightedVariants ExpandParsed(
            AiNameParsedRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling ExpandParsed");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/expand-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<AiNameWeightedVariants>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Expands a person&#39;s parsed name into a list of possible alternatives using options for expanding instructions.              
        /// </summary>
        /// <param name="request">Parsed name with options.</param>
        /// <returns><see cref="AiNameWeightedVariants"/></returns>
        public async Task<AiNameWeightedVariants> ExpandParsedAsync(
            AiNameParsedRequest request) =>
            await Task.Run(() => ExpandParsed(request
        ));
        #endif

                    
        /// <summary>
        /// Formats a person&#39;s name in correct case and name order using options for formatting instructions.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameFormatRequest" /></param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public AiNameFormatted Format(AiNameFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Format");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameFormatted>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Formats a person&#39;s name in correct case and name order using options for formatting instructions.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameFormatRequest" /></param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public async Task<AiNameFormatted> FormatAsync(AiNameFormatRequest request) =>
            await Task.Run(() => Format(request));
        #endif

                    
        /// <summary>
        /// Formats a person&#39;s parsed name in correct case and name order using options for formatting instructions.              
        /// </summary>
        /// <param name="request">Parsed name with options.</param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public AiNameFormatted FormatParsed(
            AiNameParsedRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling FormatParsed");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/format-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<AiNameFormatted>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Formats a person&#39;s parsed name in correct case and name order using options for formatting instructions.              
        /// </summary>
        /// <param name="request">Parsed name with options.</param>
        /// <returns><see cref="AiNameFormatted"/></returns>
        public async Task<AiNameFormatted> FormatParsedAsync(
            AiNameParsedRequest request) =>
            await Task.Run(() => FormatParsed(request
        ));
        #endif

                    
        /// <summary>
        /// Detect person&#39;s gender from name string.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameGenderizeRequest" /></param>
        /// <returns><see cref="AiNameGenderHypothesisList"/></returns>
        public AiNameGenderHypothesisList Genderize(AiNameGenderizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Genderize");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameGenderHypothesisList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Detect person&#39;s gender from name string.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameGenderizeRequest" /></param>
        /// <returns><see cref="AiNameGenderHypothesisList"/></returns>
        public async Task<AiNameGenderHypothesisList> GenderizeAsync(AiNameGenderizeRequest request) =>
            await Task.Run(() => Genderize(request));
        #endif

                    
        /// <summary>
        /// Detect person&#39;s gender from parsed name.              
        /// </summary>
        /// <param name="request">Gender detection request data.</param>
        /// <returns><see cref="AiNameGenderHypothesisList"/></returns>
        public AiNameGenderHypothesisList GenderizeParsed(
            AiNameParsedRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling GenderizeParsed");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/genderize-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<AiNameGenderHypothesisList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Detect person&#39;s gender from parsed name.              
        /// </summary>
        /// <param name="request">Gender detection request data.</param>
        /// <returns><see cref="AiNameGenderHypothesisList"/></returns>
        public async Task<AiNameGenderHypothesisList> GenderizeParsedAsync(
            AiNameParsedRequest request) =>
            await Task.Run(() => GenderizeParsed(request
        ));
        #endif

                    
        /// <summary>
        /// Compare people&#39;s names. Uses options for comparing instructions.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameMatchRequest" /></param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public AiNameMatchResult Match(AiNameMatchRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Match");
            }

            // verify the required parameter 'otherName' is set
            if (request.otherName == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'otherName' when calling Match");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameMatchResult>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Compare people&#39;s names. Uses options for comparing instructions.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameMatchRequest" /></param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public async Task<AiNameMatchResult> MatchAsync(AiNameMatchRequest request) =>
            await Task.Run(() => Match(request));
        #endif

                    
        /// <summary>
        /// Compare people&#39;s parsed names and attributes. Uses options for comparing instructions.              
        /// </summary>
        /// <param name="request">Parsed names to match.</param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public AiNameMatchResult MatchParsed(
            AiNameMatchParsedRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling MatchParsed");
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/email/AiName/match-parsed";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var response = apiInvoker.InvokeApi(
                resourcePath,
                "PUT",
                postBody);
            return response == null ? null : SerializationHelper.Deserialize<AiNameMatchResult>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Compare people&#39;s parsed names and attributes. Uses options for comparing instructions.              
        /// </summary>
        /// <param name="request">Parsed names to match.</param>
        /// <returns><see cref="AiNameMatchResult"/></returns>
        public async Task<AiNameMatchResult> MatchParsedAsync(
            AiNameMatchParsedRequest request) =>
            await Task.Run(() => MatchParsed(request
        ));
        #endif

                    
        /// <summary>
        /// Parse name to components.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseRequest" /></param>
        /// <returns><see cref="AiNameComponentList"/></returns>
        public AiNameComponentList Parse(AiNameParseRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'name' when calling Parse");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameComponentList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse name to components.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseRequest" /></param>
        /// <returns><see cref="AiNameComponentList"/></returns>
        public async Task<AiNameComponentList> ParseAsync(AiNameParseRequest request) =>
            await Task.Run(() => Parse(request));
        #endif

                    
        /// <summary>
        /// Parse person&#39;s name out of an email address.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseEmailAddressRequest" /></param>
        /// <returns><see cref="AiNameExtractedList"/></returns>
        public AiNameExtractedList ParseEmailAddress(AiNameParseEmailAddressRequest request)
        {
            // verify the required parameter 'emailAddress' is set
            if (request.emailAddress == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'emailAddress' when calling ParseEmailAddress");
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
                "GET");
            return response == null ? null : SerializationHelper.Deserialize<AiNameExtractedList>(response);
        }

        #if (NET452 || NETSTANDARD2_0)
        /// <summary>
        /// Parse person&#39;s name out of an email address.              
        /// </summary>
        /// <param name="request">Request. <see cref="AiNameParseEmailAddressRequest" /></param>
        /// <returns><see cref="AiNameExtractedList"/></returns>
        public async Task<AiNameExtractedList> ParseEmailAddressAsync(AiNameParseEmailAddressRequest request) =>
            await Task.Run(() => ParseEmailAddress(request));
        #endif

    }
}
