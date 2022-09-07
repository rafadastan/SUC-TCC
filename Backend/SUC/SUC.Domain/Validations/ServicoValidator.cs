using FluentValidation;
using SUC.Domain.Entities.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class ServicoValidator : AbstractValidator<Servico>
    {
        public ServicoValidator()
        {
            RuleFor(s => s.IdServico)
                .NotEmpty()
                .WithMessage("O Id não pode ser nulo");

            RuleFor(s => s.NomeServico)
                .NotEmpty()
                .WithMessage("O nome do serviço não pode ser vazio");
        }
    }
}
