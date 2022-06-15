using FluentValidation;
using SUC.Domain.Entities.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class CatalagoValidation : AbstractValidator<Catalago>
    {
        public CatalagoValidation()
        {
            RuleFor(c => c.IdCatalogo)
                .NotEmpty()
                .WithMessage("O Id do catalado não pode ser vazio");

            RuleFor(c => c.NomeCatalogo)
                .NotEmpty()
                .WithMessage("Nome do catalogo não pode ser vazio.");
        }
    }
}
