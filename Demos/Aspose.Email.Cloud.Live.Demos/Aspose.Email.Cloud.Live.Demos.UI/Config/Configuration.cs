using System.Configuration;

namespace Aspose.Email.Cloud.Live.Demos.UI.Config
{
    public class Configuration
    {
        private static string _resourceFileSessionName = ConfigurationManager.AppSettings["ResourceFileSessionName"];
        private static string _clientId = ConfigurationManager.AppSettings["ClientId"];
        private static string _clientSecret = ConfigurationManager.AppSettings["ClientSecret"];

        public static string ResourceFileSessionName
        {
            get
            {
                return _resourceFileSessionName;
            }
        }

        public static string ClientId
        {
            get
            {
                return _clientId;
            }
        }

        public static string ClientSecret
        {
            get
            {
                return _clientSecret;
            }
        }

        public static string SessionKeyEmailCloud
        {
            get
            {
                return "SessionKeyEmailCloud";
            }
        }

        public static string SessionKeyConvertResult
        {
            get
            {
                return "SessionKeyConvertResult";
            }
        }
    }
}