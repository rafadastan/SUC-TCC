using FluentValidation;
using SUC.Domain.Entities.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class AvaliacaoValidation : AbstractValidator<Avaliacao>
    {
        public AvaliacaoValidation()
        {
            RuleFor(u => u.IdAvaliacao)
                .NotEmpty()
                .WithMessage("O Id da avaliação não pode ser vazio");

            RuleFor(u => u.NumeroAvalicao)
                .NotEmpty()
                .WithMessage("O número da avaliação deve ser preenchido");
        }
    }
}
