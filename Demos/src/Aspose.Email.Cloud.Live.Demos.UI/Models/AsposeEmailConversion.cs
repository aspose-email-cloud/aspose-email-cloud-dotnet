using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Model;
using System.IO;

namespace Aspose.Email.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// Aspose.Email Cloud API convert method to convert word document file to other format
    ///</Summary>

    public class AsposeEmailConversion : AsposeEmailCloudBase
    {
        ///<Summary>
        /// Convert method to convert file to other format
        ///</Summary>
        public Response Convert(string fileName, string folderName, string outputType)
        {
            EmailCloud emailApi = new EmailCloud(clientSecret: Config.Configuration.AppKey, clientId: Config.Configuration.AppSID);

            string filenamepath = Config.Configuration.WorkingDirectory + folderName + "\\" + fileName;

            string fromFormat = Path.GetExtension(fileName).Substring(1);
            string toFormat = outputType;
            string outputFileName = "";

            using (var file = File.OpenRead(filenamepath))
            {
                EmailConvertRequest ecr = new EmailConvertRequest(fromFormat, toFormat, file);
                var result = emailApi.Email.Convert(ecr);

                outputFileName = Path.GetFileNameWithoutExtension(fileName) + "." + outputType;

                UploadFileRequest ufr = new UploadFileRequest(path: outputFileName, file: result);
                emailApi.CloudStorage.File.UploadFile(ufr);
            }

            if (string.IsNullOrEmpty(outputFileName) == false)
            {
                return new Response
                {
                    FileName = outputFileName,
                    Status = "OK",
                    StatusCode = 200,
                };
            }

            return new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };
        }
    }
}
