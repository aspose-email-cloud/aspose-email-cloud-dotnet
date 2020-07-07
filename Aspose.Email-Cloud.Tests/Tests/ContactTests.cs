using System;
using System.Collections.Generic;
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
    public class ContactTests : TestFixtureBase
    {
        private const string Surname = "Thomas";

        private static ContactDto Contact => new ContactDto
        {
            Gender = "Male",
            Surname = Surname,
            GivenName = "Alex",
            EmailAddresses = new List<EmailAddress>
            {
                new EmailAddress
                {
                    Category = new EnumWithCustomOfEmailAddressCategory("Work", null),
                    Address = "alex.thomas@work.com",
                    Preferred = true,
                    DisplayName = "Alex Thomas"
                }
            },
            PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber
                {
                    Category = new EnumWithCustomOfPhoneNumberCategory("Work", null),
                    Number = "+49211424721",
                    Preferred = true
                }
            }
        };

        /// <summary>
        /// Contact format specified as Enum, but SDK represents it as a string.
        /// Test checks that value parsing works properly
        /// </summary>
        [Test]
        public async Task ContactFormatTest()
        {
            foreach (var format in new[] {"vcard", "msg"})
            {
                var extension = format == "vcard" ? ".vcf" : ".msg";
                var name = $"{Guid.NewGuid().ToString()}{extension}";
                await EmailApi.CreateContactAsync(new CreateContactRequest(format, name,
                    new HierarchicalObjectRequest(
                        new HierarchicalObject("CONTACT", null, new List<BaseObject>()),
                        new StorageFolderLocation(StorageName, Folder))));
                var contactExist = await IsFileExist(name);
                Assert.IsTrue(contactExist);
            }
        }

        [Test]
        public async Task ContactModelTest()
        {
            var contactFile = $"{Guid.NewGuid().ToString()}.vcf";
            await EmailApi.SaveContactModelAsync(
                new SaveContactModelRequest(
                    "VCard", contactFile,
                    new StorageModelRqOfContactDto(Contact,
                        new StorageFolderLocation(StorageName, Folder))));
            var exists = await IsFileExist(contactFile);
            Assert.True(exists);
        }

        [Test]
        public async Task ConvertContactTest()
        {
            var mapiStream = await EmailApi.ConvertContactModelToFileAsync(
                new ConvertContactModelToFileRequest(
                    "Msg", Contact));
            var vcardStream = await EmailApi.ConvertContactAsync(new ConvertContactRequest(
                "VCard", "Msg", mapiStream));
            using (var memoryStream = new MemoryStream())
            {
                await vcardStream.CopyToAsync(memoryStream);
                var vcardString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(vcardString.Contains(Surname));
            }

            vcardStream.Seek(0, SeekOrigin.Begin);
            var dto = await EmailApi.GetContactFileAsModelAsync(
                new GetContactFileAsModelRequest("VCard", vcardStream));
            Assert.AreEqual(Surname, dto.Surname);
        }
        
        [Test]
        public async Task ConvertModelToMapiModelTest()
        {
            var mapiContact = await EmailApi.ConvertContactModelToMapiModelAsync(
                new ConvertContactModelToMapiModelRequest(Contact));
            Assert.AreEqual(Contact.Surname, mapiContact.NameInfo.Surname);
        }
    }
}