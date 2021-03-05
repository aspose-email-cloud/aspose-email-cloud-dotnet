using System.Web.Mvc;
using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Model;

namespace Aspose.Email.Cloud.Live.Demos.UI.Controllers
{
	/// <summary>
	/// Common  API controller.
	/// </summary>

	public  class CommonController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];

		EmailCloud emailApi = new EmailCloud(Config.Configuration.AppKey, Config.Configuration.AppSID);
		/// <summary>
		/// Sends back specified file from specified folder inside OutputDirectory.
		/// </summary>
		/// <param name="folder">Folder inside OutputDirectory.</param>
		/// <param name="file">File.</param>
		/// <returns>HTTP response with file.</returns>


		public FileResult DownloadFile(string file)
		{
			DownloadFileRequest dfr = new DownloadFileRequest(file);	
			return File(emailApi.CloudStorage.File.DownloadFile(dfr), "application/octet-stream", file);
		}
		
	}
}
