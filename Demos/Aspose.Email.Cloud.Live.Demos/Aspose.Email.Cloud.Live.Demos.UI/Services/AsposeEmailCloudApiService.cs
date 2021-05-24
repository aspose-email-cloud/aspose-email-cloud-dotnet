using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Model;
using System.IO;

namespace Aspose.Email.Cloud.Live.Demos.UI.Services
{
    public class AsposeEmailCloudApiService
    {
        public Stream ConversionByEmailCloudApi(EmailCloud AsposeEmailCloudApi, Stream file, string fromFormat, string toFormat)
        {
            EmailConvertRequest ecr = new EmailConvertRequest()
            {
                File = file,
                FromFormat = fromFormat,
                ToFormat = toFormat
            };

            var convertResult = AsposeEmailCloudApi.Email.Convert(ecr);
            return convertResult;
        }
    }
}