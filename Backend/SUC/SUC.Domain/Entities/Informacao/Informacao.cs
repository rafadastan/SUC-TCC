using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Informacoes
{
    public class Informacao : IBaseValidations
    {
        public Guid IdInformacao { get; set; }
        public string NomeSolicitacaoInformacao { get; set; }
        public string Descricao { get; set; }

        public ValidationResult Validate 
            => new InformacaoValidator().Validate(this);
    }
}
