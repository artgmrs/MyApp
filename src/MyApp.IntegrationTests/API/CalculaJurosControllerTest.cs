using Microsoft.AspNetCore.Mvc.Testing;
using MyApp.API;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MyApp.IntegrationTests.API
{
    public class CalculaJurosControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public CalculaJurosControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData(100, 5)]
        [InlineData(20, 7)]
        [InlineData(150, 1)]
        public async Task Get_CalculaJuros_DeveRetornarStatusOk(decimal valorInicial, int meses)
        {
            //Arrange
            using var client = _factory.CreateClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"/api/calculaJuros/?valorInicial={valorInicial}&meses={meses}");

            //Act
            var response = await client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Theory]
        [InlineData(100, 0)]
        [InlineData(-1, 5)]
        [InlineData(100, 15)]
        public async Task Get_CalculaJuros_DeveRetornarStatusBadRequest(decimal valorInicial, int meses)
        {
            //Arrange
            using var client = _factory.CreateClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"/api/calculaJuros/?valorInicial={valorInicial}&meses={meses}");

            //Act
            var response = await client.SendAsync(request);

            //Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task Get_CalculaJurosShowMeTheCode_DeveRetornarStatusOk()
        {
            //Arrange
            using var client = _factory.CreateClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"/api/calculaJuros/showMeTheCode");

            //Act
            var response = await client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
