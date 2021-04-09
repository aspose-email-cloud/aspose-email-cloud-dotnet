using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
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


        [Test]
        public async Task ContactModelTest()
        {
            var contactFile = $"{Guid.NewGuid().ToString()}.vcf";
            await Api.Contact.SaveAsync(
                new ContactSaveRequest
                {
                    StorageFile = new StorageFileLocation(StorageName, Folder, contactFile),
                    Value = Contact,
                    Format = "VCard"
                });
            var exists = await IsFileExist(contactFile);
            Assert.True(exists);
        }

        [Test]
        public async Task ConvertContactTest()
        {
            var mapiStream = await Api.Contact.AsFileAsync(
                new ContactAsFileRequest
                {
                    Format = "Msg",
                    Value = Contact
                });
            var vcardStream = await Api.Contact.ConvertAsync(
                new ContactConvertRequest
                {
                    ToFormat = "VCard",
                    FromFormat = "Msg",
                    File = mapiStream
                });
            using (var memoryStream = new MemoryStream())
            {
                await vcardStream.CopyToAsync(memoryStream);
                var vcardString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(vcardString.Contains(Surname));
            }

            vcardStream.Seek(0, SeekOrigin.Begin);
            var dto = await Api.Contact.FromFileAsync(
                new ContactFromFileRequest
                {
                    Format = "VCard",
                    File = vcardStream
                });
            Assert.AreEqual(Surname, dto.Surname);
        }

        [Test]
        public async Task ConvertModelToMapiModelTest()
        {
            var mapiContact = await Api.Contact.AsMapiAsync(
                Contact);
            Assert.AreEqual(Contact.Surname, mapiContact.NameInfo.Surname);
        }
    }
}
