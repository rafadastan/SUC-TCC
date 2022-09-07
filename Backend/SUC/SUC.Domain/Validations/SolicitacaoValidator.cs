using FluentValidation;
using SUC.Domain.Entities.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class SolicitacaoValidator : AbstractValidator<Solicitacao>
    {
        public SolicitacaoValidator()
        {
            RuleFor(s => s.IdSolicitacao)
                .NotEmpty()
                .WithMessage("O Id não pode ser nulo");

            RuleFor(s => s.Descricao)
                .NotEmpty()
                .WithMessage("A descrição da solicitação não pode ser vazio");
        }
    }
}
