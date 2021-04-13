using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Email.Cloud.Sdk.Model;
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
            var configs = await Api.EmailConfig.DiscoverAsync(
                new EmailConfigDiscoverRequest("example@gmail.com", true));
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
            var disposable = await Api.DisposableEmail.IsDisposableAsync(
                new DisposableEmailIsDisposableRequest
                {
                    Address = "example@mailcatch.com"
                });
            Assert.IsTrue(disposable.Value);
            var regular = await Api.DisposableEmail.IsDisposableAsync(
                new DisposableEmailIsDisposableRequest
                {
                    Address = "example@gmail.com"
                });
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
            await Api.Client.Account.SaveAsync(new ClientAccountSaveRequest
            {
                StorageFile = new StorageFileLocation(StorageName, Folder, fileName),
                Value = emailClientAccount
            });
            var response = await Api.Client.Account.GetAsync(
                new ClientAccountGetRequest
                {
                    FileName = fileName,
                    Folder = Folder,
                    Storage = StorageName
                });
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
            await Api.Client.Account.SaveMultiAsync(
                new ClientAccountSaveMultiRequest
                {
                    StorageFile = new StorageFileLocation(StorageName, Folder, fileName),
                    Value = multiAccount
                });
            var multiAccountFromStorage = await Api.Client.Account.GetMultiAsync(
                new ClientAccountGetMultiRequest
                {
                    FileName = fileName,
                    Folder = Folder,
                    Storage = StorageName
                });
            Assert.AreEqual(2, multiAccountFromStorage.ReceiveAccounts.Count);
            Assert.AreEqual(multiAccount.SendAccount.Credentials.Discriminator,
                multiAccountFromStorage.SendAccount.Credentials.Discriminator);
        }
    }
}
