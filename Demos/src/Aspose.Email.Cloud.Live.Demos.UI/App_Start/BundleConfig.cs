using System.Web.Optimization;
using System.Web.UI;

namespace Aspose.Email.Cloud.Live.Demos.UI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/jquery").
                    Include(
                        "~/Scripts/jquery.form.min.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"
                    )
            );

            ScriptManager.ScriptResourceMapping.AddDefinition(
                "respond",
                new ScriptResourceDefinition
                {
                    Path = "~/js/respond.min.js",
                    DebugPath = "~/js/respond.js",
                });

        }
    }
}
