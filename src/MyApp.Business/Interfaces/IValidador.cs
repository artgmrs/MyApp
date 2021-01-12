using FluentValidation.Results;
using MyApp.Business.Models;

namespace MyApp.Business.Interfaces
{
    public interface IValidador
    {
        public ValidationResult OperacaoValida(ParametrosCalculo parametros);
    }
}
