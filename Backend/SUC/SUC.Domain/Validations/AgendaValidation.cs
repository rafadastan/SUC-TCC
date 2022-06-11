using FluentValidation;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    class AgendaValidation : AbstractValidator<Agenda>
    {
        public AgendaValidation()
        {
            RuleFor(u => u.IdAgenda)
                .NotEmpty()
                .WithMessage("O Id da avaliação não pode ser vazio");

            RuleFor(u => u.DataAgenda)
                .NotEmpty()
                .WithMessage("O número da avaliação deve ser preenchido");
        }
    }
}
