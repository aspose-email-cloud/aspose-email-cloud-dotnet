namespace Aspose.Email.Cloud.Sdk.Api
{

    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    
    /// <summary>
    /// Aspose.Email for Cloud API. Client operations. 
    /// </summary>
    public class ClientGroup
    {
    
        public ClientAccountApi Account { get; }
    
        internal ClientGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Account = new ClientAccountApi(apiInvoker, configuration);
        
        }
    }

}