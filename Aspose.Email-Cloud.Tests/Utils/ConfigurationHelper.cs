using System.Linq;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Aspose.Email.Cloud.Sdk.Tests.Utils
{
    public static class ConfigurationHelper
    {
        public static IConfigurationRoot Get(TestParameters parameters)
        {
            var parametersDictionary = parameters.Names
                .ToDictionary(name => name, name => parameters[name]);
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddInMemoryCollection(parametersDictionary)
                .Build();
        }
    }
}