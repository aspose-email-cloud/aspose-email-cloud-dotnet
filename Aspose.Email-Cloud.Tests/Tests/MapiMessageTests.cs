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
    [Pipeline]
    public class MapiMessageTests : TestFixtureBase
    {
        private static MapiMessageDto MapiMessage => new MapiMessageDto
        {
            Body = "Some body", Subject = "Re: Some subject", BodyType = "PlainText",
            DeliveryTime = DateTime.Today, DisplayTo = "To Address", MessageBody = "Some body",
            MessageClass = "IPM.Note", MessageFormat = "Ascii", NormalizedSubject = "Some subject",
            SenderName = "From Address", SubjectPrefix = "Re: ", ClientSubmitTime = DateTime.Today,
            SenderAddressType = "SMTP", SenderEmailAddress = "from@aspose.com",
            SenderSmtpAddress = "from@aspose.com",
            Attachments = new List<MapiAttachmentDto>
            {
                new MapiAttachmentDto
                {
                    DataBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("Some file text")),
                    Name = "some-file.txt"
                }
            },
            Flags = new List<string> {"MsgFlagRead", "MsgFlagUnsent", "MsgFlagHasAttach"},
            Recipients = new List<MapiRecipientDto>
            {
                new MapiRecipientDto
                {
                    AddressType = "SMTP", DisplayName = "To Address",
                    EmailAddress = "to@aspose.com", RecipientType = "MapiTo"
                }
            }
        };

        [Test]
        public async Task ModelToEmailDtoTest()
        {
            var emailDto =
                await Api.Mapi.Message.AsEmailDtoAsync(MapiMessage);
            Assert.AreEqual(MapiMessage.Subject, emailDto.Subject);
            Assert.AreEqual(MapiMessage.Body, emailDto.Body);
        }

        [Test]
        public async Task ModelToFileTest()
        {
            var emlStream =
                await Api.Mapi.Message.AsFileAsync(
                    new MapiMessageAsFileRequest("Eml", MapiMessage));
            using (var memoryStream = new MemoryStream())
            {
                await emlStream.CopyToAsync(memoryStream);
                var emlString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(emlString.Contains(MapiMessage.Subject));
            }

            emlStream.Seek(0, SeekOrigin.Begin);
            var mapiMessageConverted =
                await Api.Mapi.Message.FromFileAsync(
                    new MapiMessageFromFileRequest("Eml", emlStream));
            Assert.AreEqual(MapiMessage.Subject, mapiMessageConverted.Subject);
            //Subject is also available as MapiPropertyDto:
            var subjectProperty = mapiMessageConverted.Properties.First(p =>
                    //There are different Property descriptors supported.
                    //Some properties are known to the service, so we can find them by name:
                    (p.Descriptor as MapiKnownPropertyDescriptor)?.Name == "TagSubject")
                //Subject is a string, so it is stored in MapiStringPropertyDto:
                as MapiStringPropertyDto;
            Assert.AreEqual(MapiMessage.Subject, subjectProperty?.Value);
        }

        [Test]
        public async Task StorageTest()
        {
            var fileName = $"{Guid.NewGuid()}.msg";
            await Api.Mapi.Message.SaveAsync(new MapiMessageSaveRequest(
                new StorageFileLocation(StorageName, Folder, fileName), MapiMessage, "Msg"));
            var mapiMessageFromStorage =
                await Api.Mapi.Message.GetAsync(
                    new MapiMessageGetRequest("Msg", fileName, Folder, StorageName));
            Assert.AreEqual(MapiMessage.Subject, mapiMessageFromStorage.Subject);
        }
    }
}