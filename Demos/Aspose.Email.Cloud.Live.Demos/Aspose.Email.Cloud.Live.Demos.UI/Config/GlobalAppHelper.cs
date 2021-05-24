using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using System.Xml;

namespace Aspose.Email.Cloud.Live.Demos.UI.Config
{
    public class GlobalAppHelper
    {
        public GlobalAppHelper(HttpContext hc, HttpApplicationState appState, string sessionId, string language)
        {
            AsposeEmailCloudContext.AsposeCloudContext = new AsposeEmailCloudContext(hc);

            string resourceFile = hc.Server.MapPath("~/App_Data/resources_EN" + ".xml");

            //Load info from all these files into the cache
            initResources(resourceFile, sessionId);

        }

        private void initResources(string resourceFile, string sessionId)
        {
            sessionId = "R" + sessionId;

            if (AsposeEmailCloudContext.Current.Cache[sessionId] == null)
            {
                Dictionary<string, string> resources = new Dictionary<string, string>();

                XmlDocument xd = new XmlDocument();

                if (resourceFile.Trim() != "")
                {
                    xd.Load(resourceFile);
                }

                // Use xpath to reach the res tag within resources
                XmlNodeList xl = xd.SelectNodes("resources/res");


                foreach (XmlNode n in xl)
                {
                    // Read the name attribute for key name and values from in between the tags
                    resources.Add(n.Attributes["name"].Value, n.InnerText);
                }

                // Add this dictionary into the cache with no expiration and associate a reload method in case of file change
                AsposeEmailCloudContext.Current.Cache.Add(
                    sessionId,
                    resources,
                    new CacheDependency(resourceFile),
                    Cache.NoAbsoluteExpiration,
                    Cache.NoSlidingExpiration,
                    CacheItemPriority.NotRemovable,
                    delegate (string key, object value, CacheItemRemovedReason reason)
                    {
                        initResources(resourceFile, sessionId);
                    });
            }
        }
    }
}