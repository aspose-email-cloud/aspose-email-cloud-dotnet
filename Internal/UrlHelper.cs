﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UrlHelper.cs">
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

using System.Collections.Generic;
using System.Collections.Specialized;
#if (NET452 || NETSTANDARD2_0)
using System.Web;
#endif
#if (XAMARIN_IOS10 || XAMARIN_MAC20 || MONOANDROID60)
using System.Net;
#endif

namespace Aspose.Email.Cloud.Sdk
{
    #if NET20
    using RestSharp.Contrib;
    #endif
    using System;

    internal static class UrlHelper
    {
        public static string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                url = url.Replace("/{" + parameterName + "}", string.Empty);
            }
            else
            {
                url = url.Replace("{" + parameterName + "}", parameterValue.ToString());
            }

            return url;
        }        

        public static string AddQueryParameterToUrl(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {               
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (url.Contains("%7B" + parameterName + "%7D"))
            {
                url = url.Replace("%7B", "{").Replace("%7D", "}");
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }
           
            if (parameterValue == null)
            {
                return url;
            }

            var uriBuilder = new UriBuilder(url);
            #if (XAMARIN_IOS10 || XAMARIN_MAC20 || MONOANDROID60)
            var query = HelpFunctions.ParseQueryString(uriBuilder.Query);
            #else
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            #endif

            query.Add(parameterName, parameterValue.ToString());
            uriBuilder.Query = ToUrlQuery(query);

            return uriBuilder.ToString();
        }
        
        private static string ToUrlQuery(NameValueCollection query)
        {
            var parts = new List<string>();
            foreach (var key in query.AllKeys)
            {
                #if (XAMARIN_IOS10 || XAMARIN_MAC20 || MONOANDROID60)
                var value = WebUtility.UrlEncode(query[key]);
                #else
                var value = HttpUtility.UrlEncode(query[key]);
                #endif
                parts.Add($"{key}={value}");
            }
            return string.Join(
                "&",
                parts.ToArray());
        }
    }
}