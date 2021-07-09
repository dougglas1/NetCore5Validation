using FluentValidation;
using NetCore5Validation.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5Validation.Validacoes
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Preencha o Código");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Preencha o Nome")
                .MinimumLength(1).WithMessage("Mínimo 1 para o Nome")
                .MaximumLength(10).WithMessage("Máximo 10 para o Nome");

            RuleFor(c => c.Status)
                .IsInEnum();
        }
    }
}
