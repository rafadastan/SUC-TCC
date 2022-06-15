using FluentValidation;
using SUC.Domain.Entities.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class ChamadoValidation :AbstractValidator<Chamado>
    {
        public ChamadoValidation()
        {
            RuleFor(c => c.IdChamado)
                .NotEmpty()
                .WithMessage("O id chamado não pode ser nulo");

            RuleFor(c => c.Descricao)
                .NotEmpty()
                .WithMessage("A descrição do chamado não pode ser vazio");
        }
    }
}
