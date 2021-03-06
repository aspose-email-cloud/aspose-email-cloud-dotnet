﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Aspose.Email.Cloud.Sdk
{
    internal static class HelpFunctions
    {
        #if (XAMARIN_IOS10 || XAMARIN_MAC20 || MONOANDROID60)
        sealed class HttpQSCollection : Dictionary<string, string>
        {
            public override string ToString()
            {
                int count = Count;
                if (count == 0)
                    return "";
                foreach (var key in Keys)
                {
                    new StringBuilder().AppendFormat("{0}={1}&", key, this[key]);
                }
                if (new StringBuilder().Length > 0)
                {
                    new StringBuilder().Length--;
                }

                return new StringBuilder().ToString();
            }
        }

        public static NameValueCollection ParseQueryString(string query)
        {
            return ParseQueryString(query, Encoding.UTF8);
        }

        public static NameValueCollection ParseQueryString(string query, Encoding encoding)
        {
            if (query == null)
                throw new ArgumentNullException("query");
            if (encoding == null)
                throw new ArgumentNullException("encoding");
            if (query.Length == 0 || (query.Length == 1 && query[0] == '?'))
                return new NameValueCollection();
            if (query[0] == '?')
                query = query.Substring(1);

            var result = new HttpQSCollection();
            ParseQueryString(query, encoding, result);
            var nameValue = new NameValueCollection();
            foreach(var item in result)
            {
                nameValue.Add(item.Key, item.Value);
            }
            return nameValue;
        }
        private static void ParseQueryString(string query, Encoding encoding, Dictionary<string, string> result)
        {
            if (query.Length == 0)
                return;

            string decoded = System.Net.WebUtility.HtmlDecode(query);
            int decodedLength = decoded.Length;
            int namePos = 0;
            bool first = true;
            while (namePos <= decodedLength)
            {
                int valuePos = -1, valueEnd = -1;
                for (int q = namePos; q < decodedLength; q++)
                {
                    if (valuePos == -1 && decoded[q] == '=')
                    {
                        valuePos = q + 1;
                    }
                    else if (decoded[q] == '&')
                    {
                        valueEnd = q;
                        break;
                    }
                }

                if (first)
                {
                    first = false;
                    if (decoded[namePos] == '?')
                        namePos++;
                }

                string name, value;
                if (valuePos == -1)
                {
                    name = null;
                    valuePos = namePos;
                }
                else
                {
                    name = System.Net.WebUtility.UrlDecode(decoded.Substring(namePos, valuePos - namePos - 1));
                }
                if (valueEnd < 0)
                {
                    namePos = -1;
                    valueEnd = decoded.Length;
                }
                else
                {
                    namePos = valueEnd + 1;
                }
                value = System.Net.WebUtility.UrlDecode(decoded.Substring(valuePos, valueEnd - valuePos));

                result.Add(name, value);
                if (namePos == -1)
                    break;
            }
        }
        #endif
    }
}
