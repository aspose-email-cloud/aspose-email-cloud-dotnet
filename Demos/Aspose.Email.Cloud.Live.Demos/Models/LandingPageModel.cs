using Aspose.Email.Cloud.Live.Demos.Controllers;
using System.Collections.Generic;

namespace Aspose.Email.Cloud.Live.Demos.Models
{
    public class LandingPageModel
    {
        public BaseController Controller;
        public Dictionary<string, string> Resources { get; set; }

        public LandingPageModel(BaseController controller)
        {
            Controller = controller;
            Resources = controller.Resources;
        }
    }
}
