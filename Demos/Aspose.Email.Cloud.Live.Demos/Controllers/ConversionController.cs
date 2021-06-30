using Aspose.Email.Cloud.Live.Demos.Models;
using Aspose.Email.Cloud.Live.Demos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.IO;
using System.Threading.Tasks;


namespace Aspose.Email.Cloud.Live.Demos.Controllers
{
    public class ConversionController : BaseController
    {
        public ConversionController(IMemoryCache cache, IAsposeEmailCloudApiService emailService) : base(cache)
        {
            EmailService = emailService;
        }

        public override string Product => (string)RouteData.Values["product"];

        public IAsposeEmailCloudApiService EmailService { get; }

        public IActionResult Conversion()
        {
            var model = new ViewModel(this, nameof(Conversion))
            {
                SaveAsComponent = true,
                MaximumUploadFiles = 1,
                UseSorting = false
            };

            return View(model);
        }

        [HttpPost]
        public async Task<Response> Conversion(string outputType)
        {
            MemoryStream ms = new MemoryStream();

            IFormFile postedFile = Request.Form.Files[0];
            string fileName = postedFile.FileName;
            await postedFile.CopyToAsync(ms);
            ms.Position = 0;

            string fromFormat = Path.GetExtension(fileName).Substring(1);
            string toFormat = outputType;
            var file = ms;
            string outputFileName = Path.GetFileNameWithoutExtension(fileName) + "." + outputType;

            MemoryStream convertResult = EmailService.Convert(file, fromFormat, toFormat) as MemoryStream;

            string fileData = Convert.ToHexString(convertResult.ToArray());

            return new Response
            {
                StatusCode = 200,
                FileName = outputFileName,
                FileData = fileData
            };
        }

    }
}
