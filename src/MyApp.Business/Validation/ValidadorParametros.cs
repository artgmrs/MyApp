using FluentValidation.Results;
using MyApp.Business.Interfaces;
using MyApp.Business.Models;
using MyApp.Business.Models.Validator;

namespace MyApp.Business.Validation
{
    public class ValidadorParametros : IValidador
    {
        public ValidationResult OperacaoValida(ParametrosCalculo parametros)
        {
            var validator = new ParametrosCalculoValidator();
            var resultado = validator.Validate(parametros);

            return resultado;
        }
    }
}
