using FluentValidation;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(u => u.IdUsuario)
                .NotEmpty()
                .WithMessage("O Id do usuário não pode ser vazio");

            RuleFor(u => u.Nome)
                .NotEmpty()
                .WithMessage("O nome do usuário deve ser preenchido");
        }
    }
}
