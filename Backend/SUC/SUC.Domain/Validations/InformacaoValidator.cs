using FluentValidation;
using SUC.Domain.Entities.Informacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class InformacaoValidator : AbstractValidator<Informacao>
    {
        public InformacaoValidator()
        {
            RuleFor(i => i.IdInformacao)
                .NotEmpty()
                .WithMessage("O IdInformação não pode ser nulo");
        }
    }
}
