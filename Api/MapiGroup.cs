namespace Aspose.Email.Cloud.Sdk.Api
{

    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    
    /// <summary>
    /// Aspose.Email for Cloud API. Mapi operations. 
    /// </summary>
    public class MapiGroup
    {
    
        public MapiCalendarApi Calendar { get; internal set; }
    
        internal MapiGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Calendar = new MapiCalendarApi(apiInvoker, configuration);
        
        }
    }

}