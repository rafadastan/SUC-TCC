using FluentValidation;
using SUC.Domain.Entities.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class AtendimentoValidation : AbstractValidator<Atendimento>
    {
        public AtendimentoValidation()
        {
            RuleFor(a => a.IdAtendimento)
                .NotEmpty()
                .WithMessage("O Id não pode ser nulo");
        }
    }
}
