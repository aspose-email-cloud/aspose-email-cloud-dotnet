namespace Aspose.Email.Cloud.Sdk.Api
{

    using Client;
    
    /** <summary>Builtin Email client operations.             </summary>*/
    public class ClientGroup
    {
    
        /** <summary>Email server account for built-in client operations.             </summary>*/
        public ClientAccountApi Account { get; }
    
        /** <summary>Email client folder operations.             </summary>*/
        public ClientFolderApi Folder { get; }
    
        /** <summary>Email client message operations.             </summary>*/
        public ClientMessageApi Message { get; }
    
        /** <summary>Email client thread operations.             </summary>*/
        public ClientThreadApi Thread { get; }
    
        internal ClientGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Account = new ClientAccountApi(apiInvoker, configuration);
        
            Folder = new ClientFolderApi(apiInvoker, configuration);
        
            Message = new ClientMessageApi(apiInvoker, configuration);
        
            Thread = new ClientThreadApi(apiInvoker, configuration);
        
        }
    }

}