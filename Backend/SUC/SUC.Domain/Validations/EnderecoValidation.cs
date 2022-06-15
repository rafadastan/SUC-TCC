using FluentValidation;
using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(u => u.IdEndereco)
                .NotEmpty()
                .WithMessage("O Id do endereço não pode ser vazio");

            RuleFor(u => u.Cidade)
                .NotEmpty()
                .WithMessage("A cidade do endereço deve ser preenchido");

            RuleFor(u => u.Estado)
                .NotEmpty()
                .WithMessage("O Estado do endereço não pode ser vazio");
        }
    }
}
