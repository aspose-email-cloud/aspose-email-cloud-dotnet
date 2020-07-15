namespace Aspose.Email.Cloud.Sdk.Api
{

    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    
    /// <summary>
    /// Aspose.Email for Cloud API. Ai operations. 
    /// </summary>
    public class AiGroup
    {
    
        public AiBcrApi Bcr { get; }
    
        public AiNameApi Name { get; }
    
        internal AiGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Bcr = new AiBcrApi(apiInvoker, configuration);
        
            Name = new AiNameApi(apiInvoker, configuration);
        
        }
    }

}