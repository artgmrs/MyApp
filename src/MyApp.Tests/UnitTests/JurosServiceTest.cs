using MyApp.Business.Models;
using MyApp.Business.Services;
using Xunit;

namespace MyApp.Tests.UnitTests
{
    public class JurosServiceTest
    {
        private JurosService _jurosService;

        [Theory]
        [InlineData("105,10", 100, 5)]
        public void CalculaJuros_DeveRetornarValorEsperado(string respostaEsperada, decimal valorInicial, int meses)
        {
            //Arrange
            _jurosService = new JurosService();
            ParametrosCalculo parametros = new ParametrosCalculo(valorInicial, meses);

            //Act
            string resultado = _jurosService.CalculaJuros(parametros);

            //Assert
            Assert.Equal(respostaEsperada, resultado);
        }

        [Theory]
        [InlineData("5,05", 500, 1)]
        public void CalculaJuros_DeveRetornarValorEsperado_Dois(string respostaEsperada, decimal valorInicial, int meses)
        {
            //Arrange
            _jurosService = new JurosService();
            ParametrosCalculo parametros = new ParametrosCalculo(valorInicial, meses);

            //Act
            string resultado = _jurosService.CalculaJuros(parametros);

            //Assert
            Assert.Equal(respostaEsperada, resultado);
        }

        [Fact]
        public void RetornaValorJuros_DeveRetornarOValorCorreto()
        {
            //Assert
            _jurosService = new JurosService();
            Juros juros = new Juros();

            //Act
            var jurosResultado = _jurosService.RetornaValorJuros();

            //Assert
            Assert.Equal(juros.ValorJuros, jurosResultado.ValorJuros);
        }
    }
}