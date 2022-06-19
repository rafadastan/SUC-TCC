using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace SUC.Tests.API.Helpers
{
    public class HttpClientHelper
    {
        public static HttpClient Create()
        {
            #region Iniciaizando o projeto API

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var server = new TestServer(new WebHostBuilder()
                .UseConfiguration(configuration)
                .UseStartup<SUC.Api.Startup>());

            #endregion

            return server.CreateClient();
        }
    }
}
