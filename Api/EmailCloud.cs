namespace Aspose.Email.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    using Client.Internal.RequestHandlers;

    /// <summary>
    /// Aspose.Email for Cloud API.
    /// </summary>
    public class EmailCloud
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;
    
        /** <summary>iCalendar document operations.             </summary>*/
        public CalendarApi Calendar {get;}
    
        /** <summary>Contact document operations. Supported formats: VCard, MSG, WebDav             </summary>*/
        public ContactApi Contact {get;}
    
        /** <summary>Email document (*.eml) operations.             </summary>*/
        public EmailApi Email {get;}
    
        /** <summary>Check email address is disposable operations             </summary>*/
        public DisposableEmailApi DisposableEmail {get;}
    
        /** <summary>Email server configuration discovery.             </summary>*/
        public EmailConfigApi EmailConfig {get;}
    
    
        /** <summary>MAPI operations.             </summary>*/
        public MapiGroup Mapi {get;}
    
        /** <summary>Builtin Email client operations.             </summary>*/
        public ClientGroup Client {get;}
    
        /** <summary>AI powered operations.             </summary>*/
        public AiGroup Ai {get;}
    
        /** <summary>Cloud file storage operations.             </summary>*/
        public CloudStorageGroup CloudStorage {get;}
    

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCloud"/> class.
        /// </summary>
        /// <param name="apiKey">The api Key.</param>
        /// <param name="appSid">The app Sid.</param>
        public EmailCloud(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCloud"/> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public EmailCloud(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>
            {
                new AuthRequestHandler(this.configuration),
                new DebugLogRequestHandler(this.configuration),
                new ApiExceptionRequestHandler()
            };
            apiInvoker = new ApiInvoker(requestHandlers);

        
            Calendar = new CalendarApi(apiInvoker, this.configuration);
        
            Contact = new ContactApi(apiInvoker, this.configuration);
        
            Email = new EmailApi(apiInvoker, this.configuration);
        
            DisposableEmail = new DisposableEmailApi(apiInvoker, this.configuration);
        
            EmailConfig = new EmailConfigApi(apiInvoker, this.configuration);
        
        
            Mapi = new MapiGroup(apiInvoker, this.configuration);
        
            Client = new ClientGroup(apiInvoker, this.configuration);
        
            Ai = new AiGroup(apiInvoker, this.configuration);
        
            CloudStorage = new CloudStorageGroup(apiInvoker, this.configuration);
        
        }
    }
}
