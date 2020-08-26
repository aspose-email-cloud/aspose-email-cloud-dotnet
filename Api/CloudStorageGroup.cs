namespace Aspose.Email.Cloud.Sdk.Api
{

    using Client;
    
    /** <summary>Cloud file storage operations.</summary>*/
    public class CloudStorageGroup
    {
    
        /** <summary></summary>*/
        public FileApi File { get; }
    
        /** <summary></summary>*/
        public FolderApi Folder { get; }
    
        /** <summary></summary>*/
        public StorageApi Storage { get; }
    
        internal CloudStorageGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            File = new FileApi(apiInvoker, configuration);
        
            Folder = new FolderApi(apiInvoker, configuration);
        
            Storage = new StorageApi(apiInvoker, configuration);
        
        }
    }

}