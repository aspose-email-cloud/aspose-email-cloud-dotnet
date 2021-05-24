using System.Collections.Generic;
using System.Web;

namespace Aspose.Email.Cloud.Live.Demos.UI.Config
{
    public class AsposeEmailCloudContext : Context
    {
        internal AsposeEmailCloudContext(HttpContext hc) : base(hc)
        {
        }

        private static AsposeEmailCloudContext _asposeCloudContext;

        internal static AsposeEmailCloudContext AsposeCloudContext
        {
            set
            {
                _asposeCloudContext = value;
            }
        }

        internal static AsposeEmailCloudContext Current
        {
            get
            {
                return _asposeCloudContext;
            }
        }

        internal new Dictionary<string, string> Resources
        {
            get
            {
                return base.Resources;
            }
        }



    }
}