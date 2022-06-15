using FluentValidation;
using SUC.Domain.Entities.Servico;
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
                .WithMessage("O IdServico não pode ser nulo");

            RuleFor(s => s.NomeServico)
                .NotEmpty()
                .WithMessage("O nome do serviço não pode ser vazio");
        }
    }
}
