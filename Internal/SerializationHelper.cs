// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SerializationHelper.cs">
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
using System.Reflection;
using Aspose.Email.Cloud.Sdk.Client;

namespace Aspose.Email.Cloud.Sdk
{
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal static class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                    ? JsonConvert.SerializeObject(
                        obj,
                        new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore})
                    : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static T Deserialize<T>(string json)
        {
            return (T) Deserialize(json, typeof(T));
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    return JsonConvert.DeserializeObject(json, type, new JsonTypeDeriveConverter());
                }

                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(json);
                return JsonConvert.SerializeXmlNode(xmlDoc);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jse)
            {
                throw new ApiException(500, jse.Message);
            }
            catch (System.Xml.XmlException xmlException)
            {
                throw new ApiException(500, xmlException.Message);
            }
        }

        private class JsonTypeDeriveConverter : JsonConverter
        {
            private const string TypeProperty = "Type";
            private static Dictionary<string, Type> models;

            public override bool CanConvert(Type objectType)
            {
                return objectType.GetProperty(TypeProperty) != null;
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                var jsonObject = JObject.Load(reader);
                var target = Create(jsonObject, objectType);
                serializer.Populate(jsonObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            /// <summary>
            /// Create an instance of objectType, based properties in the JSON object.
            /// </summary>
            /// <param name="jsonObject">
            ///     Contents of JSON object that will be deserialized.
            /// </param>
            /// <param name="objectType"></param>
            /// <returns>An instance of objectType.</returns>
            private static object Create(JObject jsonObject, Type objectType)
            {
                var properties = jsonObject.Properties();
                var derivedTypeName = string.Empty;
                foreach (var property in properties)
                {
                    if (!property.Name.Equals(TypeProperty, StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }
                    derivedTypeName = property.Value.ToString();
                    break;
                }
                var isDerived = GetModels().TryGetValue(derivedTypeName, out var derivedType);
                var type = isDerived ? derivedType : objectType;
                return Activator.CreateInstance(type);
            }

            private static Dictionary<string, Type> GetModels()
            {
                if (models != null)
                {
                    return models;
                }

                models = new Dictionary<string, Type>();
                foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    if (type.Namespace != null && type.Namespace.Equals("Aspose.Email.Cloud.Sdk.Model", StringComparison.Ordinal))
                    {
                        models.Add(type.Name, type);
                    }
                }

                return models;
            }
        }
    }
}