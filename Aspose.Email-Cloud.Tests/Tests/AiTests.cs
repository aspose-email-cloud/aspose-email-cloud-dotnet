using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
using Aspose.Email.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Tests
{
    public class AiTests : TestFixtureBase
    {
        private const string BcrAiTestFilePath = "TestData/test_single_0001.png";

        [SetUp]
        public async Task SetUp()
        {
            //WarmUp AI
            try
            {
                await Api.Ai.Name.GenderizeAsync(new AiNameGenderizeRequest
                {
                    Name = "John Cane"
                });
            }
            catch
            {
                //ignore
            }
        }

        /// <summary>
        /// Test name gender detection
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameGenderizeTest()
        {
            var result =
                await Api.Ai.Name.GenderizeAsync(new AiNameGenderizeRequest
                {
                    Name = "John Cane"
                });
            Assert.GreaterOrEqual(result.Value.Count, 1);
            Assert.True(result.Value.Any(item => item.Gender == "Male"));
        }

        /// <summary>
        /// Test name formatting
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameFormatTest()
        {
            var result = await Api.Ai.Name.FormatAsync(
                new AiNameFormatRequest
                {
                    Name = "Mr. John Michael Cane",
                    Format = "%t%L%f%m"
                });
            Assert.AreEqual("Mr. Cane J. M.", result.Name);
        }

        /// <summary>
        /// Name match test.
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameMatchTest()
        {
            const string first = "John Michael Cane";
            const string second = "Cane J.";
            var result = await Api.Ai.Name.MatchAsync(
                new AiNameMatchRequest
                {
                    Name = first,
                    OtherName = second
                });
            Assert.True(result.Similarity > 0.5);
        }

        [Test]
        [Pipeline]
        public async Task AiNameExpandTest()
        {
            const string name = "Smith Bobby";
            var result = await Api.Ai.Name.ExpandAsync(
                new AiNameExpandRequest
                {
                    Name = name
                });
            var expandedNames = result.Names
                .Select(weightedName => weightedName.Name)
                .ToList();
            Assert.Contains("Mr. Smith", expandedNames);
            Assert.Contains("B. Smith", expandedNames);
        }

        /// <summary>
        /// Name complete test
        /// </summary>
        [Test]
        [Pipeline]
        public async Task AiNameCompleteTest()
        {
            const string prefix = "Dav";
            var result = await Api.Ai.Name.CompleteAsync(
                new AiNameCompleteRequest
                {
                    Name = prefix
                });
            var names = result.Names
                .Select(weightedName => $"{prefix}{weightedName.Name}")
                .ToList();
            Assert.Contains("David", names);
            Assert.Contains("Dave", names);
            Assert.Contains("Davis", names);
        }

        [Test]
        [Pipeline]
        public async Task AiNameParseEmailAddressTest()
        {
            const string address = "john-cane@gmail.com";
            var result = await Api.Ai.Name.ParseEmailAddressAsync(
                new AiNameParseEmailAddressRequest
                {
                    EmailAddress = address
                });
            var extractedValues = result.Value
                .SelectMany(value => value.Name)
                .ToList();
            var givenName = extractedValues.First(value => value.Category == "GivenName");
            var surName = extractedValues.First(value => value.Category == "Surname");
            Assert.AreEqual("John", givenName.Value);
            Assert.AreEqual("Cane", surName.Value);
        }

        /// <summary>
        /// Test business card recognition with storage.
        /// </summary>
        [Test]
        public async Task AiBcrParseStorageTest()
        {
            var fileName = $"{Guid.NewGuid().ToString()}.png";
            // 1) Upload business card image to storage
            using (var stream = File.OpenRead(BcrAiTestFilePath))
            {
                await Api.CloudStorage.File.UploadFileAsync(new UploadFileRequest
                {
                    Path = $"{Folder}/{fileName}",
                    File = stream,
                    StorageName = StorageName
                });
            }

            var outFolder = Guid.NewGuid().ToString();
            var outFolderPath = $"{Folder}/{outFolder}";
            await Api.CloudStorage.Folder.CreateFolderAsync(
                new CreateFolderRequest
                {
                    Path = outFolderPath,
                    StorageName = StorageName
                });
            // 2) Call business card recognition action
            var result = await Api.Ai.Bcr.ParseStorageAsync(new AiBcrParseStorageRequest
            {
                OutFolder = new StorageFolderLocation(StorageName, outFolderPath),
                Images = new List<AiBcrImageStorageFile>
                {
                    new AiBcrImageStorageFile(true,
                        new StorageFileLocation(StorageName, Folder, fileName))
                }
            });
            //Check that only one file produced
            Assert.True(result.Value.Count == 1);
            // 3) Get file name from recognition result
            var contactFile = result.Value.First();

            // 4) Download VCard file, produced by recognition method, check it contains text "Thomas"
            using (var contactFileStream = await Api.CloudStorage.File.DownloadFileAsync(
                new DownloadFileRequest
                {
                    Path = $"{contactFile.FolderPath}/{contactFile.FileName}",
                    StorageName = contactFile.Storage
                }))
            using (var memoryStream = new MemoryStream())
            {
                await contactFileStream.CopyToAsync(memoryStream);
                var contactFileContent = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.True(contactFileContent.Contains("Thomas"));
            }
        }

        [Test]
        public async Task AiBcrParseTest()
        {
            using (var file = File.OpenRead(BcrAiTestFilePath))
            {
                var result = await Api.Ai.Bcr.ParseAsync(
                    new AiBcrParseRequest
                    {
                        File = file,
                        IsSingle = true
                    });
                Assert.AreEqual("Alex Thomas", result.Value.First().DisplayName);
            }
        }
    }
}
