namespace Aspose.Email.Cloud.Sdk.Api
{

    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Model;
    using Client;
    
    /** <summary>Cloud file storage operations.             </summary>*/
    public class CloudStorageGroup
    {
    
        /** <summary>File operations controller</summary>*/
        public FileApi File { get; }
    
        /** <summary>Folder operations controller</summary>*/
        public FolderApi Folder { get; }
    
        /** <summary>Storage operations controller</summary>*/
        public StorageApi Storage { get; }
    
        internal CloudStorageGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            File = new FileApi(apiInvoker, configuration);
        
            Folder = new FolderApi(apiInvoker, configuration);
        
            Storage = new StorageApi(apiInvoker, configuration);
        
        }
    }

}