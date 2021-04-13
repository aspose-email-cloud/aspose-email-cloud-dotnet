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
    public class EmailTests : TestFixtureBase
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
            DeliveryNotificationOptions = new List<string>
            {
                "OnSuccess",
                "Delay"
            },
            From = new MailAddress
            {
                Address = FromAddress,
                DisplayName = "From Address"
            },
            To = new List<MailAddress>
            {
                new MailAddress
                {
                    Address = "to@aspose.com",
                    DisplayName = "To Address"
                }
            }
        };

        [Test]
        public async Task ConvertEmailTest()
        {
            var mapiStream = await Api.Email.AsFileAsync(
                new EmailAsFileRequest("Msg", Email));
            var emlStream =
                await Api.Email.ConvertAsync(new EmailConvertRequest
                {
                    FromFormat = "Msg",
                    ToFormat = "Eml",
                    File = mapiStream
                });
            using (var memoryStream = new MemoryStream())
            {
                await emlStream.CopyToAsync(memoryStream);
                var emlString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(emlString.Contains(FromAddress));
            }

            emlStream.Seek(0, SeekOrigin.Begin);
            var dto = await Api.Email.FromFileAsync(new EmailFromFileRequest
            {
                Format = "Eml",
                File = emlStream
            });
            Assert.AreEqual(FromAddress, dto.From.Address);
        }


        [Test]
        public async Task ConvertToMapiModelTest()
        {
            var mapiMessage = await Api.Email.AsMapiAsync(Email);
            Assert.AreEqual(Email.Subject, mapiMessage.Subject);
        }
    }
}
