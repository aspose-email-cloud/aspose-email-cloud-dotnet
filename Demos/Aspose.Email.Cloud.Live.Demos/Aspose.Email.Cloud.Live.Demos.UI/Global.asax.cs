using Aspose.Email.Cloud.Live.Demos.UI.Config;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Aspose.Email.Cloud.Live.Demos.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterCustomRoutes(RouteTable.Routes);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        {
            string _language = "EN";
            SetResourceFile(_language);
        }

        private void SetResourceFile(string strLanguage)
        {
            string strKey = "AsposeEmailCloudResources";

            if (Session[strKey] == null)
            {
                Session[strKey] = new GlobalAppHelper(HttpContext.Current, Application, Configuration.ResourceFileSessionName, strLanguage);
            }
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {
            //routes.RouteExistingFiles = true;
            routes.Ignore("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "AsposeConversionRoute",
                "{product}/Conversion",
                 new { controller = "Conversion", action = "Conversion" }
            );

            routes.MapRoute(
                "DownloadFileRoute",
                "common/download",
                new { controller = "Common", action = "DownloadFile" }

            );
        }
    }
}
