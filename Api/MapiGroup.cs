namespace Aspose.Email.Cloud.Sdk.Api
{

    using Client;
    
    /** <summary>MAPI operations.</summary>*/
    public class MapiGroup
    {
    
        /** <summary>MAPI calendar operations.</summary>*/
        public MapiCalendarApi Calendar { get; }
    
        /** <summary>MAPI contact operations</summary>*/
        public MapiContactApi Contact { get; }
    
        /** <summary>MAPI message operations</summary>*/
        public MapiMessageApi Message { get; }
    
        internal MapiGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Calendar = new MapiCalendarApi(apiInvoker, configuration);
        
            Contact = new MapiContactApi(apiInvoker, configuration);
        
            Message = new MapiMessageApi(apiInvoker, configuration);
        
        }
    }

}