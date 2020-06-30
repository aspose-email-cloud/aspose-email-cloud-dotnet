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
            var contact = new ContactDto
            {
                Gender = "Male",
                Surname = "Thomas",
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

            var contactFile = $"{Guid.NewGuid().ToString()}.vcf";
            await EmailApi.SaveContactModelAsync(
                new SaveContactModelRequest(
                    "VCard", contactFile,
                    new StorageModelRqOfContactDto(contact,
                        new StorageFolderLocation(StorageName, Folder))));
            var exists = await IsFileExist(contactFile);
            Assert.True(exists);
        }

        [Test]
        public async Task ConvertContactTest()
        {
            const string surname = "Cane";
            var contactDto = new ContactDto
            {
                Gender = "Male",
                Surname = surname,
                GivenName = "John",
                EmailAddresses = new List<EmailAddress>
                {
                    new EmailAddress {Address = "address@aspose.com"}
                },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Number = "+47235345346"}
                }
            };
            var mapiStream = await EmailApi.ConvertContactModelToFileAsync(
                new ConvertContactModelToFileRequest(
                    "Msg", contactDto));
            var vcardStream = await EmailApi.ConvertContactAsync(new ConvertContactRequest(
                "VCard", "Msg", mapiStream));
            using (var memoryStream = new MemoryStream())
            {
                await vcardStream.CopyToAsync(memoryStream);
                var vcardString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(vcardString.Contains(surname));
            }

            vcardStream.Seek(0, SeekOrigin.Begin);
            var dto = await EmailApi.GetContactFileAsModelAsync(
                new GetContactFileAsModelRequest("VCard", vcardStream));
            Assert.AreEqual(surname, dto.Surname);
        }
    }
}