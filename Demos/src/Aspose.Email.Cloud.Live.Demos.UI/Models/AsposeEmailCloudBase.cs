using System.IO;
using System.Web.Http;

namespace Aspose.Email.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// AsposeEmailCloudBase class to have base methods
    ///</Summary>

    public abstract class AsposeEmailCloudBase : ApiController
    {
        ///<Summary>
        /// Get File extension
        ///</Summary>
        protected string GetoutFileExtension(string fileName, string folderName)
        {
            string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }

    }
}
