using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace FakeStoreApi.Core
{
   

    public class ConfigReader
    {
        private IConfiguration configuration;

        public ConfigReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();
        }

        public string GetBaseUrl()
        {
            return configuration["baseUrl"];
        }
    }
}
