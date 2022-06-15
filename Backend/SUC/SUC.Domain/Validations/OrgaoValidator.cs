using FluentValidation;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class OrgaoValidator : AbstractValidator<Orgao>
    {
        public OrgaoValidator()
        {
            RuleFor(o => o.IdOrgao)
                .NotEmpty()
                .WithMessage("O IdOrgao não pode ser nulo");

            RuleFor(o => o.NomeOrgao)
                .NotEmpty()
                .WithMessage("O nome do orgão não pode ser vazio");
        }
    }
}
