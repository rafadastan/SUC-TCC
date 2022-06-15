using FluentValidation;
using SUC.Domain.Entities.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class DemandaValidator : AbstractValidator<Demanda>
    {
        public DemandaValidator()
        {
            RuleFor(d => d.IdDemanda)
                .NotEmpty()
                .WithMessage("O IdDemanda não pode ser nulo");

            RuleFor(d => d.Descricao)
                .NotEmpty()
                .WithMessage("A descrição da demanda não pode ser nulo");
        }
    }
}
