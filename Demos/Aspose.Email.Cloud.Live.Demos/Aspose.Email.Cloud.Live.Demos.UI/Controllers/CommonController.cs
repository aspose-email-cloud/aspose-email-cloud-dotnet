using System.IO;
using System.Web.Mvc;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
    public class CommonController : BaseController
    {
        public override string Product => "";

        public FileResult DownloadFile(string file)
        {
            MemoryStream mstream = Session[Config.Configuration.SessionKeyConvertResult] as MemoryStream;
            mstream.Position = 0;

            MemoryStream newstream = new MemoryStream();
            mstream.CopyTo(newstream);
            newstream.Position = 0;

            return File(newstream, "application/octet-stream", file);
        }
    }
}