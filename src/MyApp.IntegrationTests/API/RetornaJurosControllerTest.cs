using Microsoft.AspNetCore.Mvc.Testing;
using MyApp.API;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MyApp.IntegrationTests.API
{
    public class RetornaJurosControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public RetornaJurosControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_RetornaJuros_DeveRetornarStatusOk()
        {
            //Arrange
            var client = _factory.CreateClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/api/retornaJuros/");

            //Act
            var response = await client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
    }
}
