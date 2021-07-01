using Aspose.Email.Cloud.Live.Demos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Aspose.Email.Cloud.Live.Demos.Controllers
{
    public class HomeController : BaseController
    {
        public override string Product => string.Empty;

        public HomeController(IMemoryCache cache) : base(cache)
        {
        }

        public IActionResult Default()
        {
            ViewBag.PageTitle = Resources["emailConversionPageTitle"];
            ViewBag.MetaDescription = Resources["emailConversionMetaDescription"];

            var model = new LandingPageModel(this);
            return View(model);
        }
    }
}
