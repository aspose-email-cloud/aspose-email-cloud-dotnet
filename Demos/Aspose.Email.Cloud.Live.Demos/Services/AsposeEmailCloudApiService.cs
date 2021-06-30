using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Model;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Aspose.Email.Cloud.Live.Demos.Services
{
    public interface IAsposeEmailCloudApiService
    {
        Stream Convert(Stream file, string fromFormat, string toFormat);
    }

    public class AsposeEmailCloudApiService : IAsposeEmailCloudApiService
    {
        public readonly EmailCloud EmailCloudApi;

        public AsposeEmailCloudApiService(IConfiguration config)
        {
            string ClientId = config["AsposeEmailUserData:ClientId"];
            string ClientSecret = config["AsposeEmailUserData:ClientSecret"];

            EmailCloudApi = new EmailCloud(clientSecret: ClientSecret, clientId: ClientId);
        }

        public Stream Convert(Stream file, string fromFormat, string toFormat)
        {
            EmailConvertRequest ecr = new EmailConvertRequest()
            {
                File = file,
                FromFormat = fromFormat,
                ToFormat = toFormat
            };

            var convertResult = EmailCloudApi.Email.Convert(ecr);
            return convertResult;
        }
    }
}
