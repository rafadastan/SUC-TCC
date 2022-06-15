using FluentValidation;
using SUC.Domain.Entities.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class IndiceValidator : AbstractValidator<Indice>
    {
        public IndiceValidator()
        {
            RuleFor(i => i.IdIndice)
                .NotEmpty()
                .WithMessage("O IdIndice não pode ser nulo");

        }
    }
}
