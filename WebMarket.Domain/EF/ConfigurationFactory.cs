using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebMarket.Domain.EF
{
    public static class ConfigurationFactory
    {
        public static IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
        }
    }
}
