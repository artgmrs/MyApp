using MyApp.Business.Models;
using MyApp.Business.Services;
using Xunit;

namespace MyApp.Tests.UnitTests
{
    public class JurosServiceTest
    {
        private JurosService _jurosService;

        [Theory]
        [InlineData(105.10, 100, 5)]
        public void CalculaJuros_DeveRetornarValorEsperado(double respostaEsperada, double valorInicial, int meses)
        {
            //Arrange
            _jurosService = new JurosService();
            ParametrosCalculo parametros = new ParametrosCalculo(valorInicial, meses);

            //Act
            var resultado = _jurosService.CalculaJuros(parametros);

            //Assert
            Assert.Equal(respostaEsperada, resultado);
        }

        [Theory]
        [InlineData(505, 500, 1)]
        public void CalculaJuros_DeveRetornarValorEsperado_Dois(double respostaEsperada, double valorInicial, int meses)
        {
            //Arrange
            _jurosService = new JurosService();
            ParametrosCalculo parametros = new ParametrosCalculo(valorInicial, meses);

            //Act
            var resultado = _jurosService.CalculaJuros(parametros);

            //Assert
            Assert.Equal(respostaEsperada, resultado);
        }
    }
}