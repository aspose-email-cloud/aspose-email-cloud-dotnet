namespace Aspose.Email.Cloud.Sdk.Api
{

    using Client;
    
    /** <summary>AI powered operations.</summary>*/
    public class AiGroup
    {
    
        /** <summary>AI Business card recognition operations.</summary>*/
        public AiBcrApi Bcr { get; }
    
        /** <summary>AI Name operations.</summary>*/
        public AiNameApi Name { get; }
    
        internal AiGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Bcr = new AiBcrApi(apiInvoker, configuration);
        
            Name = new AiNameApi(apiInvoker, configuration);
        
        }
    }

}