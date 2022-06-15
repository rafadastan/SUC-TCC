using FluentValidation;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class ContatoValidation : AbstractValidator<Contato>
    {
        public ContatoValidation()
        {
            RuleFor(u => u.IdContato)
                .NotEmpty()
                .WithMessage("O Id do contato não pode ser vazio");

            RuleFor(u => u.Numero)
                .NotEmpty()
                .WithMessage("O número do contato deve ser preenchido");
        }
    }
}
