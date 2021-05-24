using Newtonsoft.Json;
using System.Collections.Generic;

namespace Aspose.Email.Cloud.Live.Demos.UI.Models
{
    public class JSOptions
    {
        private readonly ViewModel Parent;
        private Dictionary<string, string> Resources => Parent.Resources;

        //public string AppUrl => Parent.AppUrl;
        //public string AppName => Parent.AppName;

        string GetUIBasePath()
        {
            var request = Parent.Controller.Request;
            string strBasePath = request.Url.Scheme + "://" + request.Url.Authority + "/";
            return strBasePath;
        }

        public string UIBasePath => GetUIBasePath();

        public int MaximumUploadFiles => Parent.MaximumUploadFiles;

        public string FileWrongTypeMessage { get; }

        public string FileSelectMessage => Resources["FileSelectMessage"];
        public string FileAmountMessage => Resources["FileAmountMessageOne"];

        #region FileDrop
        public bool Multiple => true;
        public string DropFilesPrompt => Resources["DropOrUploadFile"];
        public string Accept => Parent.ExtensionsString.Replace("|.", ",.");
        #endregion

        public IEnumerable<string> UploadOptions => Parent.ExtensionsString.Replace(".", "").ToUpper().Split('|');

        public JSOptions(ViewModel model)
        {
            Parent = model;
            FileWrongTypeMessage = Resources["FileWrongTypeMessage"];
        }

        public override string ToString()
        {
            string strJson = JsonConvert.SerializeObject(this, Formatting.None);
            return strJson;
        }
    }
}