using FluentValidation;

namespace MyApp.Business.Models.Validator
{
    public class ParametrosCalculoValidator : AbstractValidator<ParametrosCalculo>
    {
        public ParametrosCalculoValidator()
        {
            RuleFor(p => p.ValorInicial).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(p => p.Meses).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(p => p.ValorInicial).Must(v => v > 0).WithMessage("Insira um valor válido para o campo {PropertyName}");
            RuleFor(p => p.Meses).Must(p => p <= 12 && p > 0).WithMessage("Insira um valor válido para o campo {PropertyName}");
        }
    }
}
