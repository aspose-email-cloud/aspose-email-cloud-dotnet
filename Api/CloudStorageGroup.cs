namespace Aspose.Email.Cloud.Sdk.Api
{

    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    
    /// <summary>
    /// Aspose.Email for Cloud API. CloudStorage operations. 
    /// </summary>
    public class CloudStorageGroup
    {
    
        public FileApi File { get; internal set; }
    
        public FolderApi Folder { get; internal set; }
    
        public StorageApi Storage { get; internal set; }
    
        internal CloudStorageGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            File = new FileApi(apiInvoker, configuration);
        
            Folder = new FolderApi(apiInvoker, configuration);
        
            Storage = new StorageApi(apiInvoker, configuration);
        
        }
    }

}