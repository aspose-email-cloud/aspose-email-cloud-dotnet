using System;
using System.IO;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Api;
using Aspose.Email.Cloud.Sdk.Client;
using Aspose.Email.Cloud.Sdk.Model;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Utils
{
    [TestFixture]
    public abstract class TestFixtureBase
    {
        protected const string StorageName = "First Storage";
        protected EmailCloud Api;
        protected string Folder;
        /// <summary>
        /// EmailApi setup.
        /// Uses ConfigurationHelper to get clientId, clientSecret and apiBaseUrl.
        /// This data can be configured using:
        /// - NUnit test parameters (command line "--params" or from runsettings file
        /// - Environment Variables
        /// - Add fields to appsettings.json 
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Folder = Guid.NewGuid().ToString();
            var configurationHelper = ConfigurationHelper.Get(TestContext.Parameters);
            var apiConfiguration = new Configuration
            {
                ApiVersion = "v4.0",
                ApiBaseUrl =
                    configurationHelper.GetValue("apiBaseUrl", "https://api-qa.aspose.cloud"),
                ClientSecret = configurationHelper.GetValue("clientSecret", string.Empty),
                ClientId = configurationHelper.GetValue("clientId", string.Empty),
                AuthUrl = configurationHelper.GetValue<string>("authUrl", null)
            };
            Api = new EmailCloud(apiConfiguration);
        }
        
        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            var existRequest = new ObjectExistsRequest(Folder, StorageName);
            var folderExist = await Api.CloudStorage.Storage.ObjectExistsAsync(existRequest);
            if (folderExist.Exists == true && folderExist.IsFolder == true)
            {
                var deleteRequest = new DeleteFolderRequest(Folder, StorageName, true);
                await Api.CloudStorage.Folder.DeleteFolderAsync(deleteRequest);
            }
        }
        protected static string FileToBase64(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(bytes);
        }
        
        protected async Task<bool> IsFileExist(string fileName, string folderPath = null)
        {
            var path = $"{folderPath ?? Folder}/{fileName}";
            var request = new ObjectExistsRequest(path, StorageName);
            var result = await Api.CloudStorage.Storage.ObjectExistsAsync(request);
            return result.IsFolder != true && result.Exists == true;
        }
    }
}