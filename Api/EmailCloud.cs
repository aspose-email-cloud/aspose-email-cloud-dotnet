// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmailCloud.cs">
//   Copyright (c) 2018-2023 Aspose.Email for Cloud
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
    using Client;
    using Client.Internal.RequestHandlers;

    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class EmailCloud
    {
    
        /** <summary>iCalendar document operations.</summary>*/
        public CalendarApi Calendar {get;}
    
        /** <summary>Contact document operations. Supported formats: VCard, MSG, WebDav</summary>*/
        public ContactApi Contact {get;}
    
        /** <summary>Email document (*.eml) operations.</summary>*/
        public EmailApi Email {get;}
    
        /** <summary>Checks if an email is a disposable one</summary>*/
        public DisposableEmailApi DisposableEmail {get;}
    
        /** <summary>Email server configuration discovery.</summary>*/
        public EmailConfigApi EmailConfig {get;}
    
    
        /** <summary>MAPI operations.</summary>*/
        public MapiGroup Mapi {get;}
    
        /** <summary>Builtin Email client operations.</summary>*/
        public ClientGroup Client {get;}
    
        /** <summary>AI powered operations.</summary>*/
        public AiGroup Ai {get;}
    
        /** <summary>Cloud file storage operations.</summary>*/
        public CloudStorageGroup CloudStorage {get;}
    

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCloud"/> class.
        /// </summary>
        /// <param name="clientSecret">The Client secret.</param>
        /// <param name="clientId">The Client id.</param>
        public EmailCloud(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCloud"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public EmailCloud(Configuration configuration)
        {
            var requestHandlers = new List<IRequestHandler>
            {
                new AuthRequestHandler(configuration),
                new DebugLogRequestHandler(configuration),
                new ApiExceptionRequestHandler()
            };
            var apiInvoker = new ApiInvoker(requestHandlers);

        
            Calendar = new CalendarApi(apiInvoker, configuration);
        
            Contact = new ContactApi(apiInvoker, configuration);
        
            Email = new EmailApi(apiInvoker, configuration);
        
            DisposableEmail = new DisposableEmailApi(apiInvoker, configuration);
        
            EmailConfig = new EmailConfigApi(apiInvoker, configuration);
        
        
            Mapi = new MapiGroup(apiInvoker, configuration);
        
            Client = new ClientGroup(apiInvoker, configuration);
        
            Ai = new AiGroup(apiInvoker, configuration);
        
            CloudStorage = new CloudStorageGroup(apiInvoker, configuration);
        
        }
    }
}
