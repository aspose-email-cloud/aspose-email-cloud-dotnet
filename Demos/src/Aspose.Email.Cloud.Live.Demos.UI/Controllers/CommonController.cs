using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Model;
using System.Web.Mvc;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
    public class CommonController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];

        EmailCloud emailApi = new EmailCloud(Config.Configuration.AppKey, Config.Configuration.AppSID);

        public FileResult DownloadFile(string file)
        {
            DownloadFileRequest dfr = new DownloadFileRequest(file);
            return File(emailApi.CloudStorage.File.DownloadFile(dfr), "application/octet-stream", file);
        }
    }
}
