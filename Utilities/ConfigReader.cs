using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace FakeStoreApi.Core
{
    public class ConfigReader
    {
        private IConfiguration configuration;

        public ConfigReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appconfig.json");

            configuration = builder.Build();
        }

        public string GetBaseUrl()
        {
            return configuration["baseUrl"];
        }
    }
}
