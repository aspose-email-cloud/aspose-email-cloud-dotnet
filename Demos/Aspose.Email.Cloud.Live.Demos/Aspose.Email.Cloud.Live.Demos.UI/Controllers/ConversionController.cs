using Aspose.Email.Cloud.Live.Demos.UI.Models;
using Aspose.Email.Cloud.Live.Demos.UI.Services;
using Aspose.Email.Cloud.Sdk.Api;
using System.IO;
using System.Web.Mvc;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
    public class ConversionController : BaseController
    {
        public override string Product => (string)RouteData.Values["product"];

        public EmailCloud EmailCloudApi
        {
            get
            {
                string strEmailCloudSessionKey = Config.Configuration.SessionKeyEmailCloud;
                if (Session[strEmailCloudSessionKey] == null)
                {
                    string clientId = Config.Configuration.ClientId;
                    string clientSecret = Config.Configuration.ClientSecret;

                    Session[strEmailCloudSessionKey] = new EmailCloud(clientSecret: clientSecret, clientId: clientId);
                }

                return Session[strEmailCloudSessionKey] as EmailCloud;
            }
        }

        [HttpPost]
        public Response Conversion(string outputType)
        {
            var postedFile = Request.Files[0];
            string fileName = postedFile.FileName;

            string fromFormat = Path.GetExtension(fileName).Substring(1);
            string toFormat = outputType;
            var file = postedFile.InputStream;
            string outputFileName = Path.GetFileNameWithoutExtension(fileName) + "." + outputType;

            AsposeEmailCloudApiService asposeEmailCloudApiService = new AsposeEmailCloudApiService();
            var convertResult = asposeEmailCloudApiService.ConversionByEmailCloudApi(EmailCloudApi, file, fromFormat, toFormat);

            Session[Config.Configuration.SessionKeyConvertResult] = convertResult;

            return new Response
            {
                StatusCode = 200,
                FileName = outputFileName
            };
        }

        [HttpGet]
        public ActionResult Conversion()
        {
            var model = new ViewModel(this, "Conversion")
            {
                SaveAsComponent = true,
                MaximumUploadFiles = 1
            };

            return View(model);
        }
    }
}