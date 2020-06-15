using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SampleRestApi.IntegrationTests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        readonly HttpClient client;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            client = factory.CreateClient();
        }

        [Theory]
        [Trait("TestCategegory", "Integration")]
        [InlineData("/weatherforecast")]
        public async Task GetWeatherForecast(string url)
        {
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
        }
    }
}
