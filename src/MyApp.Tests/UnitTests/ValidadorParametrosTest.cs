using MyApp.Business.Models;
using MyApp.Business.Validation;
using Xunit;

namespace MyApp.Tests.UnitTests
{
    public class ValidadorParametrosTest
    {
        private ValidadorParametros _validadorParametros;
        private ParametrosCalculo _parametrosCalculo;

        [Theory]
        [InlineData(100, 5)]
        [InlineData(1, 12)]
        [InlineData(500, 2)]
        public void OperacaoValida_AdicionoValoresValidos_DeveRetornarOperacaoValida(decimal valorInicial, int meses)
        {
            //Arrange
            _validadorParametros = new ValidadorParametros();
            _parametrosCalculo = new ParametrosCalculo(valorInicial, meses);

            //Act
            var resultado = _validadorParametros.OperacaoValida(_parametrosCalculo);

            //Assert
            Assert.True(resultado.IsValid);
        }

        [Theory]
        [InlineData(-1, 0.2)]
        [InlineData(100, 13)]
        [InlineData(0, 0)]
        public void OperacaoValida_AdicionoValoresInvalidos_DeveRetornarOperacaoInvalida(decimal valorInicial, int meses)
        {
            //Arrange
            _validadorParametros = new ValidadorParametros();
            _parametrosCalculo = new ParametrosCalculo(valorInicial, meses);

            //Act
            var resultado = _validadorParametros.OperacaoValida(_parametrosCalculo);

            //Assert
            Assert.False(resultado.IsValid);
        }
    }
}
