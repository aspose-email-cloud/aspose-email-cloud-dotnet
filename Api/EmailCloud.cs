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
    
        /** <summary>Check email address is disposable operations</summary>*/
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
        /// <param name="apiKey">The api Key.</param>
        /// <param name="appSid">The app Sid.</param>
        public EmailCloud(string apiKey, string appSid)
            : this(new Configuration { ClientSecret = apiKey, ClientId = appSid })
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
