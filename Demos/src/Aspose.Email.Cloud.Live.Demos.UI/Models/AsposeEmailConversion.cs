using System.IO;
//using Aspose.Email.Cloud.Sdk.Model.Requests;
using Aspose.Email.Cloud.Sdk.Model;
using Aspose.Email.Cloud.Sdk.Api;

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
            EmailCloud emailApi = new EmailCloud(Config.Configuration.AppKey, Config.Configuration.AppSID);

            string filenamepath = Config.Configuration.WorkingDirectory + folderName + "\\"+ fileName;

            string fromFormat = Path.GetExtension(fileName).Substring(1);
            string toFormat = outputType;
            string outputFileName = "";

            using (var file = File.OpenRead(filenamepath))
            {
                //eml to msg, eml to oft, msg to eml, msg to oft, msg to tnf done
                EmailConvertRequest ecr = new EmailConvertRequest(fromFormat, toFormat, file);
                var result = emailApi.Email.Convert(ecr);

                //byte[] buff = new byte[result.Length];
                //result.Read(buff, 0, buff.Length);

                outputFileName = Path.GetFileNameWithoutExtension(fileName) + "." + outputType;

                UploadFileRequest ufr = new UploadFileRequest(path: outputFileName, file:result);
                emailApi.CloudStorage.File.UploadFile(ufr);
            }

            if (string.IsNullOrEmpty(outputFileName)==false)
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
