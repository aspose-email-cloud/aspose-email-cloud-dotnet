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
    public class EmailModelTests : TestFixtureBase
    {
        private const string FromAddress = "from@aspose.com";

        private static EmailDto Email => new EmailDto
        {
            Subject = "Re: Some subject",
            Body = "Some body",
            IsBodyHtml = true,
            HtmlBody = "<b>Some body</b>",
            BodyType = "Html",
            IsDraft = true,
            Attachments = new List<Attachment>
            {
                new Attachment
                {
                    Base64Data =
                        Convert.ToBase64String(Encoding.UTF8.GetBytes("Some file content")),
                    Name = "some-file.txt"
                }
            },
            DeliveryNotificationOptions = new List<string> {"OnSuccess", "Delay"},
            From = new MailAddress {Address = FromAddress, DisplayName = "From Address"},
            To = new List<MailAddress>
                {new MailAddress {Address = "to@aspose.com", DisplayName = "To Address"}}
        };

        [Test]
        public async Task ConvertEmailTest()
        {
            var mapiStream = await EmailApi.ConvertEmailModelToFileAsync(
                new ConvertEmailModelToFileRequest(
                    "Msg", Email));
            var emlStream = await EmailApi.ConvertEmailAsync(new ConvertEmailRequest(
                "Eml", mapiStream));
            using (var memoryStream = new MemoryStream())
            {
                await emlStream.CopyToAsync(memoryStream);
                var emlString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(emlString.Contains(FromAddress));
            }

            emlStream.Seek(0, SeekOrigin.Begin);
            var dto = await EmailApi.GetEmailFileAsModelAsync(
                new GetEmailFileAsModelRequest(emlStream));
            Assert.AreEqual(FromAddress, dto.From.Address);
        }

        [Test]
        public async Task ConvertToMapiModelTest()
        {
            var mapiMessage = await EmailApi.ConvertEmailModelToMapiModelAsync(
                new ConvertEmailModelToMapiModelRequest(Email));
            Assert.AreEqual(Email.Subject, mapiMessage.Subject);
        }
    }
}