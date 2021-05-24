using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using System.Web.SessionState;

namespace Aspose.Email.Cloud.Live.Demos.UI.Config
{
    public abstract class Context
    {
        protected HttpContext _context;

        public Context(HttpContext hc)
        {
            _context = hc;
        }

        public Cache Cache
        {
            get { return _context.Cache; }
        }

        public HttpSessionState Session
        {
            get { return _context.Session; }
        }

        public void PermanentAddtoCache(string key, object value)
        {
            _context.Cache.Insert(key, value, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, null);
        }

        protected Dictionary<string, string> Resources
        {
            get
            {
                string sessionID = Configuration.ResourceFileSessionName;
                return (Dictionary<string, string>)Cache["R" + sessionID];
            }
        }
    }
}