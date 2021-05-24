using Aspose.Email.Cloud.Live.Demos.UI.Config;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
    public abstract class BaseController : Controller
    {
        public abstract string Product { get; }

        private AsposeEmailCloudContext _asposeCloudContext;
        public AsposeEmailCloudContext AsposeEmailCloudContext
        {
            get
            {
                if (_asposeCloudContext == null)
                {
                    _asposeCloudContext = new AsposeEmailCloudContext(HttpContext.ApplicationInstance.Context);
                }
                return _asposeCloudContext;
            }
        }

        private Dictionary<string, string> _resources;
        public Dictionary<string, string> Resources
        {
            get
            {
                if (_resources == null)
                {
                    _resources = AsposeEmailCloudContext.Resources;
                }

                return _resources;
            }
        }
    }
}