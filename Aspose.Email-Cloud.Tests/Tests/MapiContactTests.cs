using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
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
                {
                    EmailAddress = "email@aspose.com"
                }
            },
            NameInfo = new MapiContactNamePropertySetDto
            {
                GivenName = "Alex",
                Surname = "Thomas"
            },
            PersonalInfo = new MapiContactPersonalInfoPropertySetDto
            {
                BusinessHomePage = "www.aspose.com"
            },
            ProfessionalInfo = new MapiContactProfessionalPropertySetDto
            {
                Profession = "GENERAL DIRECTOR"
            },
            Telephones = new MapiContactTelephonePropertySetDto
            {
                PrimaryTelephoneNumber = "+49 211 4247 21"
            }
        };

        [Test]
        public async Task ModelToContactDtoTest()
        {
            var contactDto =
                await Api.Mapi.Contact.AsContactDtoAsync(MapiContact);
            Assert.AreEqual(MapiContact.NameInfo.GivenName, contactDto.GivenName);
            Assert.AreEqual(MapiContact.NameInfo.Surname, contactDto.Surname);
        }

        [Test]
        public async Task ModelToFileTest()
        {
            var vcardStream =
                await Api.Mapi.Contact.AsFileAsync(
                    new MapiContactAsFileRequest
                    {
                        Format = "VCard",
                        Value = MapiContact
                    });
            using (var memoryStream = new MemoryStream())
            {
                await vcardStream.CopyToAsync(memoryStream);
                var vcardString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(vcardString.Contains(MapiContact.NameInfo.GivenName));
            }

            vcardStream.Seek(0, SeekOrigin.Begin);
            var mapiContactConverted =
                await Api.Mapi.Contact.FromFileAsync(
                    new MapiContactFromFileRequest
                    {
                        Format = "VCard",
                        File = vcardStream
                    });
            Assert.AreEqual(MapiContact.NameInfo.Surname, mapiContactConverted.NameInfo.Surname);
        }

        [Test]
        public async Task StorageTest()
        {
            var fileName = $"{Guid.NewGuid()}.msg";
            await Api.Mapi.Contact.SaveAsync(new MapiContactSaveRequest
            {
                StorageFile = new StorageFileLocation(StorageName, Folder, fileName),
                Value = MapiContact,
                Format = "Msg"
            });
            var mapiContactFromStorage =
                await Api.Mapi.Contact.GetAsync(
                    new MapiContactGetRequest
                    {
                        Format = "Msg",
                        FileName = fileName,
                        Folder = Folder,
                        Storage = StorageName
                    });
            Assert.AreEqual(MapiContact.NameInfo.Surname, mapiContactFromStorage.NameInfo.Surname);
        }
    }
}
