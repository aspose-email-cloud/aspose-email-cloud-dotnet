using Aspose.Email.Cloud.Live.Demos.UI.Models;
using System.Web.Mvc;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
    public class HomeController : BaseController
    {
        public override string Product => "";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Default()
        {
            ViewBag.PageTitle = Resources["emailConversionPageTitle"];
            ViewBag.MetaDescription = Resources["emailConversionMetaDescription"];

            var model = new LandingPageModel(this);

            return View(model);
        }
    }
}