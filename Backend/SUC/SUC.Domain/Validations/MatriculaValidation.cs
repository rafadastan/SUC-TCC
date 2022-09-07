using FluentValidation;
using SUC.Domain.Entities.Matricula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class MatriculaValidation : AbstractValidator<Matricula>
    {
        public MatriculaValidation()
        {
            RuleFor(m => m.IdMatricula)
                .NotEmpty()
                .WithMessage("O Id não pode ser nulo");
        }
    }
}
