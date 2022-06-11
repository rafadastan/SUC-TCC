using FluentValidation;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class PerfilValidation : AbstractValidator<Perfil>
    {
        public PerfilValidation()
        {
            RuleFor(p => p.IdPerfil)
                .NotEmpty()
                .WithMessage("Id do perfil é obrigatório");

            RuleFor(p => p.Description)
                .NotEmpty()
                .WithMessage("Descrição deve ser preenchido");
        }
    }
}
