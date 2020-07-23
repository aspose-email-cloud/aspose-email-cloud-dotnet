using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
using Aspose.Email.Cloud.Sdk.Model.Requests;
using Aspose.Email.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Tests
{
    [Pipeline]
    public class MapiContactTests : TestFixtureBase
    {
        private static MapiContactDto MapiContact => new MapiContactDto
        {
            ElectronicAddresses = new MapiContactElectronicAddressPropertySetDto
            {
                DefaultEmailAddress = new MapiContactElectronicAddressDto
                    {EmailAddress = "email@aspose.com"}
            },
            NameInfo = new MapiContactNamePropertySetDto {GivenName = "Alex", Surname = "Thomas"},
            PersonalInfo = new MapiContactPersonalInfoPropertySetDto
                {BusinessHomePage = "www.aspose.com"},
            ProfessionalInfo = new MapiContactProfessionalPropertySetDto
                {Profession = "GENERAL DIRECTOR"},
            Telephones = new MapiContactTelephonePropertySetDto
                {PrimaryTelephoneNumber = "+49 211 4247 21"}
        };

        [Test]
        public async Task ModelToContactDtoTest()
        {
            var contactDto =
                await EmailApi.ConvertMapiContactModelToContactModelAsync(
                    new ConvertMapiContactModelToContactModelRequest(
                        MapiContact));
            Assert.AreEqual(MapiContact.NameInfo.GivenName, contactDto.GivenName);
            Assert.AreEqual(MapiContact.NameInfo.Surname, contactDto.Surname);
        }

        [Test]
        public async Task ModelToFileTest()
        {
            var vcardStream = await EmailApi.ConvertMapiContactModelToFileAsync(
                new ConvertMapiContactModelToFileRequest(
                    "VCard", MapiContact));
            using (var memoryStream = new MemoryStream())
            {
                await vcardStream.CopyToAsync(memoryStream);
                var vcardString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(vcardString.Contains(MapiContact.NameInfo.GivenName));
            }

            vcardStream.Seek(0, SeekOrigin.Begin);
            var mapiContactConverted = await EmailApi.GetContactFileAsMapiModelAsync(
                new GetContactFileAsMapiModelRequest("VCard", vcardStream));
            Assert.AreEqual(MapiContact.NameInfo.Surname, mapiContactConverted.NameInfo.Surname);
        }

        [Test]
        public async Task StorageTest()
        {
            var fileName = $"{Guid.NewGuid()}.msg";
            await EmailApi.SaveMapiContactModelAsync(
                new SaveMapiContactModelRequest(
                    "Msg", fileName, new StorageModelRqOfMapiContactDto(
                        MapiContact, new StorageFolderLocation(StorageName, Folder))));
            var mapiContactFromStorage = await EmailApi.GetMapiContactModelAsync(
                new GetMapiContactModelRequest(
                    "Msg", fileName, Folder, StorageName));
            Assert.AreEqual(MapiContact.NameInfo.Surname, mapiContactFromStorage.NameInfo.Surname);
        }
    }
}