using System.Collections.Generic;
using System.Web;

namespace Aspose.Email.Cloud.Live.Demos.UI.Config
{
    public class BaseRootPage : System.Web.UI.Page
    {
        private AsposeEmailCloudContext _asposeCloudContext;
        public AsposeEmailCloudContext AsposeEmailCloudContext
        {
            get
            {
                if (_asposeCloudContext == null)
                {
                    _asposeCloudContext = new AsposeEmailCloudContext(HttpContext.Current);
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