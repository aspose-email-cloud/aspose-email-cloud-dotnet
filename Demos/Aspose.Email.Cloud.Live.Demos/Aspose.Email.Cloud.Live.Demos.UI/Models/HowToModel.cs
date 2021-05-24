using Aspose.Email.Cloud.Live.Demos.UI.Config;
using System.Collections.Generic;

namespace Aspose.Email.Cloud.Live.Demos.UI.Models
{
    public class HowToModel : BaseRootPage
    {
        public ViewModel VMParent;
        public string AppName => VMParent.AppName;
        public List<string> List { get; set; }
        public HowToModel(ViewModel parent)
        {
            VMParent = parent;

            var title = Resources[$"Howto{AppName}Title"];
            var titleEnd = VMParent.PageProductTitle + " " + AppName;
            Title = string.Format(title, "", titleEnd);

            List = new List<string>();
            var hw = "Howto" + VMParent.AppName + "Feature";
            var i = 1;

            while (Resources.ContainsKey(hw + i))
            {
                List.Add(Resources[hw + i]);
                i++;
            }
        }
    }
}