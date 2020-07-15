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
    
        public CalendarApi Calendar {get;}
    
        public ContactApi Contact {get;}
    
        public EmailApi Email {get;}
    
        public FileApi File {get;}
    
        public FolderApi Folder {get;}
    
        public StorageApi Storage {get;}
    
    
        public AiGroup Ai {get;}
    

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
        
            File = new FileApi(apiInvoker, this.configuration);
        
            Folder = new FolderApi(apiInvoker, this.configuration);
        
            Storage = new StorageApi(apiInvoker, this.configuration);
        
        
            Ai = new AiGroup(apiInvoker, this.configuration);
        
        }
    }
}
