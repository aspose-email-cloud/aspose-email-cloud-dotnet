using Aspose.Email.Cloud.Live.Demos.UI.Config;
using Aspose.Email.Cloud.Live.Demos.UI.Controllers;
using System.Collections.Generic;
using System.Web;

namespace Aspose.Email.Cloud.Live.Demos.UI.Models
{
    public class LandingPageModel
    {
        public BaseController Controller;
        /// <summary>
        /// Name of the product (e.g., words)
        /// </summary>
        public string Product { get; set; }
        private AsposeEmailCloudContext _atcContext;
        public AsposeEmailCloudContext AsposeEmailCloudContext
        {
            get
            {
                if (_atcContext == null) _atcContext = new AsposeEmailCloudContext(HttpContext.Current);
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
            set
            {
                _resources = value;
            }
        }

        public string UIBasePath => Configuration.AsposeEmailCloudLiveDemosPath;

        public LandingPageModel(BaseController controller)
        {
            Controller = controller;
            Resources = controller.Resources;

        }
        private string GetFromResources(string key, string defaultKey = null)
        {
            if (Resources.ContainsKey(key))
                return Resources[key];
            if (!string.IsNullOrEmpty(defaultKey) && Resources.ContainsKey(defaultKey))
                return Resources[defaultKey];
            return "";
        }


    }
}
