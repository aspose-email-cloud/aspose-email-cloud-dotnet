using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
using Aspose.Email.Cloud.Sdk.Model.Requests;
using Aspose.Email.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Tests
{
    [Pipeline]
    public class OtherTests : TestFixtureBase
    {
        [Test]
        public async Task DiscoverEmailConfigTest()
        {
            var configs = await EmailApi.DiscoverEmailConfigAsync(
                new DiscoverEmailConfigRequest("example@gmail.com", true));
            var protocols = configs.Value
                .Select(config => config.ProtocolType)
                .ToList();
            Assert.Contains("SMTP", protocols);
            Assert.Contains("IMAP", protocols);
            Assert.AreEqual("smtp.gmail.com", configs.Value
                .First(config => config.ProtocolType == "SMTP").Host);
        }

        [Test]
        public async Task IsDisposableEmailTest()
        {
            var disposable = await EmailApi.IsEmailAddressDisposableAsync(
                new IsEmailAddressDisposableRequest("example@mailcatch.com"));
            Assert.IsTrue(disposable.Value);
            var regular = await EmailApi.IsEmailAddressDisposableAsync(
                new IsEmailAddressDisposableRequest("example@gmail.com"));
            Assert.IsFalse(regular.Value);
        }

        [Test]
        public async Task EmailClientAccountTest()
        {
            var emailClientAccount = new EmailClientAccount
            {
                Host = "smtp.gmail.com",
                Port = 511,
                ProtocolType = "SMTP",
                SecurityOptions = "SSLAuto",
                Credentials = new EmailClientAccountPasswordCredentials
                {
                    Login = "example@gmail.com",
                    Password = "password"
                }
            };
            var fileName = $"{Guid.NewGuid().ToString()}.account";
            await EmailApi.SaveEmailClientAccountAsync(new SaveEmailClientAccountRequest(
                new StorageFileRqOfEmailClientAccount(
                    emailClientAccount,
                    new StorageFileLocation(StorageName, Folder, fileName))));
            var response = await EmailApi.GetEmailClientAccountAsync(
                new GetEmailClientAccountRequest(
                    fileName, Folder, StorageName));
            Assert.IsTrue(response.Credentials.GetType() ==
                          typeof(EmailClientAccountPasswordCredentials));
            Assert.AreEqual(emailClientAccount.Host, response.Host);
        }

        [Test]
        public async Task EmailClientMultiAccountTest()
        {
            var multiAccount = new EmailClientMultiAccount
            {
                ReceiveAccounts = new List<EmailClientAccount>
                {
                    new EmailClientAccount
                    {
                        Host = "imap.gmail.com",
                        Port = 993,
                        ProtocolType = "IMAP",
                        SecurityOptions = "SSLAuto",
                        Credentials = new EmailClientAccountOauthCredentials
                        {
                            Login = "example@gmail.com",
                            ClientId = "client-id",
                            ClientSecret = "clientSecret",
                            RefreshToken = "refreshToken"
                        }
                    },
                    new EmailClientAccount
                    {
                        Host = "exchange.outlook.com",
                        Port = 443,
                        ProtocolType = "EWS",
                        SecurityOptions = "SSLAuto",
                        Credentials = new EmailClientAccountPasswordCredentials
                        {
                            Login = "example@outlook.com",
                            Password = "password"
                        }
                    }
                },
                SendAccount = new EmailClientAccount
                {
                    Host = "smtp.gmail.com",
                    Port = 465,
                    ProtocolType = "SMTP",
                    SecurityOptions = "SSLAuto",
                    Credentials = new EmailClientAccountOauthCredentials
                    {
                        Login = "example@gmail.com",
                        ClientId = "client-id",
                        ClientSecret = "clientSecret",
                        RefreshToken = "refreshToken"
                    }
                }
            };
            var fileName = $"{Guid.NewGuid()}.multi.account";
            await EmailApi.SaveEmailClientMultiAccountAsync(
                new SaveEmailClientMultiAccountRequest(
                    new StorageFileRqOfEmailClientMultiAccount(
                        multiAccount,
                        new StorageFileLocation(StorageName, Folder, fileName))));
            var multiAccountFromStorage = await EmailApi.GetEmailClientMultiAccountAsync(
                new GetEmailClientMultiAccountRequest(
                    fileName, Folder, StorageName));
            Assert.AreEqual(2, multiAccountFromStorage.ReceiveAccounts.Count);
            Assert.AreEqual(multiAccount.SendAccount.Credentials.Discriminator,
                multiAccountFromStorage.SendAccount.Credentials.Discriminator);
        }

        [Test]
        public async Task ConvertEmailTest()
        {
            const string from = "from@aspose.com";
            var emailDto = new EmailDto
            {
                From = new MailAddress {Address = from},
                To = new List<MailAddress> {new MailAddress {Address = "to@aspose.com"}},
                Subject = "Some subject",
                Body = "Some body",
                Date = DateTime.MinValue.AddDays(1)
            };
            var mapiStream = await EmailApi.ConvertEmailModelToFileAsync(
                new ConvertEmailModelToFileRequest(
                    "Msg", emailDto));
            var emlStream = await EmailApi.ConvertEmailAsync(new ConvertEmailRequest(
                "Eml", mapiStream));
            using (var memoryStream = new MemoryStream())
            {
                await emlStream.CopyToAsync(memoryStream);
                var emlString = Encoding.UTF8.GetString(memoryStream.ToArray());
                Assert.IsTrue(emlString.Contains(from));
            }

            emlStream.Seek(0, SeekOrigin.Begin);
            var dto = await EmailApi.GetEmailFileAsModelAsync(
                new GetEmailFileAsModelRequest(emlStream));
            Assert.AreEqual(from, dto.From.Address);
        }
    }
}