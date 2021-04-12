using Aspose.Email.Cloud.Live.Demos.UI.Config;
using Aspose.Email.Cloud.Live.Demos.UI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected Response BadDocumentResponse = new Response()
        {
            Status = "Some of your documents are corrupted",
            StatusCode = 500
        };

        public abstract string Product { get; }

        protected override void OnActionExecuted(ActionExecutedContext ctx)
        {
            base.OnActionExecuted(ctx);
            ViewBag.Title = ViewBag.Title ?? Resources["ApplicationTitle"];
            ViewBag.MetaDescription = ViewBag.MetaDescription ?? "Save time and software maintenance costs by running single instance of software, but serving multiple tenants/websites. Customization available for Joomla, Wordpress, Discourse, Confluence and other popular applications.";
        }

        private AsposeEmailCloudContext _atcContext;

        public AsposeEmailCloudContext AsposeEmailCloudContext
        {
            get
            {
                if (_atcContext == null) _atcContext = new AsposeEmailCloudContext(HttpContext.ApplicationInstance.Context);
                return _atcContext;
            }
        }

        private Dictionary<string, string> _resources;

        public Dictionary<string, string> Resources
        {
            get
            {
                if (_resources == null) _resources = AsposeEmailCloudContext.Resources;
                return _resources;
            }
        }
    }
}
