using FluentValidation;
using SUC.Domain.Entities.DepartamentoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class DepartamentoValidator : AbstractValidator<Departamento>
    {
        public DepartamentoValidator()
        {
            RuleFor(d => d.IdDepartamento)
                .NotEmpty()
                .WithMessage("O IdDepartamento não pode ser nulo");

            RuleFor(d => d.NomeDepartamento)
                .NotEmpty()
                .WithMessage("O Nome do departamento não pode ser vazio");
        }
    }
}
