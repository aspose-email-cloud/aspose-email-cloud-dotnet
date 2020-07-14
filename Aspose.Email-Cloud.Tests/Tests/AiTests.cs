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

        // /// <summary>
        // /// Test name gender detection
        // /// </summary>
        // [Test]
        // [Pipeline]
        // public async Task AiNameGenderizeTest()
        // {
        //     var result =
        //         await EmailApi.AiNameGenderizeAsync(new AiNameGenderizeRequest("John Cane"));
        //     Assert.GreaterOrEqual(result.Value.Count, 1);
        //     Assert.True(result.Value.Any(item => item.Gender == "Male"));
        // }
        //
        // /// <summary>
        // /// Test name formatting
        // /// </summary>
        // [Test]
        // [Pipeline]
        // public async Task AiNameFormatTest()
        // {
        //     var result = await EmailApi.AiNameFormatAsync(
        //         new AiNameFormatRequest("Mr. John Michael Cane", format: "%t%L%f%m"));
        //     Assert.AreEqual("Mr. Cane J. M.", result.Name);
        // }
        //
        // /// <summary>
        // /// Name match test.
        // /// </summary>
        // [Test]
        // [Pipeline]
        // public async Task AiNameMatchTest()
        // {
        //     const string first = "John Michael Cane";
        //     const string second = "Cane J.";
        //     var result = await EmailApi.AiNameMatchAsync(
        //         new AiNameMatchRequest(first, second));
        //     Assert.True(result.Similarity > 0.5);
        // }
        //
        // [Test]
        // [Pipeline]
        // public async Task AiNameExpandTest()
        // {
        //     const string name = "Smith Bobby";
        //     var result = await EmailApi.AiNameExpandAsync(
        //         new AiNameExpandRequest(name));
        //     var expandedNames = result.Names
        //         .Select(weightedName => weightedName.Name)
        //         .ToList();
        //     Assert.Contains("Mr. Smith", expandedNames);
        //     Assert.Contains("B. Smith", expandedNames);
        // }
        //
        // /// <summary>
        // /// Name complete test
        // /// </summary>
        // [Test]
        // [Pipeline]
        // public async Task AiNameCompleteTest()
        // {
        //     const string prefix = "Dav";
        //     var result = await EmailApi.AiNameCompleteAsync(
        //         new AiNameCompleteRequest(prefix));
        //     var names = result.Names
        //         .Select(weightedName => $"{prefix}{weightedName.Name}")
        //         .ToList();
        //     Assert.Contains("David", names);
        //     Assert.Contains("Dave", names);
        //     Assert.Contains("Davis", names);
        // }
        //
        // [Test]
        // [Pipeline]
        // public async Task AiNameParseEmailAddressTest()
        // {
        //     const string address = "john-cane@gmail.com";
        //     var result = await EmailApi.AiNameParseEmailAddressAsync(
        //         new AiNameParseEmailAddressRequest(address));
        //     var extractedValues = result.Value
        //         .SelectMany(value => value.Name)
        //         .ToList();
        //     var givenName = extractedValues.First(value => value.Category == "GivenName");
        //     var surName = extractedValues.First(value => value.Category == "Surname");
        //     Assert.AreEqual("John", givenName.Value);
        //     Assert.AreEqual("Cane", surName.Value);
        // }
        //
        // /// <summary>
        // /// Test business card recognition with storage.
        // /// </summary>
        // [Test]
        // public async Task AiBcrParseStorageTest()
        // {
        //     var fileName = $"{Guid.NewGuid().ToString()}.png";
        //     // 1) Upload business card image to storage
        //     using (var stream = File.OpenRead(BcrAiTestFilePath))
        //     {
        //         await EmailApi.UploadFileAsync(new UploadFileRequest($"{Folder}/{fileName}", stream,
        //             StorageName));
        //     }
        //
        //     var outFolder = Guid.NewGuid().ToString();
        //     var outFolderPath = $"{Folder}/{outFolder}";
        //     await EmailApi.CreateFolderAsync(new CreateFolderRequest(outFolderPath, StorageName));
        //     // 2) Call business card recognition action
        //     var result = await EmailApi.AiBcrParseStorageAsync(new AiBcrParseStorageRequest(
        //         new AiBcrParseStorageRq(null,
        //             new List<AiBcrImageStorageFile>
        //             {
        //                 new AiBcrImageStorageFile(true,
        //                     new StorageFileLocation(StorageName, Folder, fileName))
        //             },
        //             new StorageFolderLocation(StorageName, outFolderPath))));
        //     //Check that only one file produced
        //     Assert.True(result.Value.Count == 1);
        //     // 3) Get file name from recognition result
        //     var contactFile = result.Value.First();
        //
        //     // 4) Download VCard file, produced by recognition method, check it contains text "Thomas"
        //     using (var contactFileStream = await EmailApi.DownloadFileAsync(new DownloadFileRequest(
        //         $"{contactFile.FolderPath}/{contactFile.FileName}", contactFile.Storage)))
        //     using (var memoryStream = new MemoryStream())
        //     {
        //         await contactFileStream.CopyToAsync(memoryStream);
        //         var contactFileContent = Encoding.UTF8.GetString(memoryStream.ToArray());
        //         Assert.True(contactFileContent.Contains("Thomas"));
        //     }
        //
        //     // 5) Get VCard object properties list, check that there are 3 properties or more
        //     var contactProperties = await EmailApi.GetContactPropertiesAsync(
        //         new GetContactPropertiesRequest(
        //             "vcard", contactFile.FileName, contactFile.FolderPath, contactFile.Storage));
        //     Assert.GreaterOrEqual(contactProperties.InternalProperties.Count, 3);
        // }
        //
        // /// <summary>
        // ///     Test business card recognition without storage.
        // ///     Send image as Base64 string and get VCard properties without producing any files in storage.
        // /// </summary>
        // [Test]
        // public async Task AiBcrParseTest()
        // {
        //     var result = await EmailApi.AiBcrParseAsync(new AiBcrParseRequest(new AiBcrBase64Rq(
        //         null,
        //         new List<AiBcrBase64Image>
        //             {new AiBcrBase64Image(true, FileToBase64(BcrAiTestFilePath))})));
        //     Assert.AreEqual(1, result.Value.Count);
        //     Assert.True(result.Value
        //         .First()
        //         .InternalProperties
        //         .Where(property => property.Type == nameof(PrimitiveObject))
        //         .Select(property => (PrimitiveObject) property)
        //         .Any(property => property.Value?.Contains("Thomas") ?? false));
        // }
        //
        // [Test]
        // public async Task AiBcrParseModelTest()
        // {
        //     var result = await EmailApi.AiBcrParseModelAsync(
        //         new AiBcrParseModelRequest(
        //             new AiBcrBase64Rq(
        //                 null,
        //                 new List<AiBcrBase64Image>
        //                 {
        //                     new AiBcrBase64Image(true, FileToBase64(BcrAiTestFilePath))
        //                 })));
        //     Assert.AreEqual("Alex Thomas", result.Value.First().DisplayName);
        // }
    }
}