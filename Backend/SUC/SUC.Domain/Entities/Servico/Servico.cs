using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SUC.Domain.Enum.DomainEnum;

namespace SUC.Domain.Entities.Servicos
{
    public class Servico : IBaseValidations
    {
        public Guid IdServico { get; set; }
        public string NomeServico { get; set; }
        public bool Ativo { get; set; }
        public TipoServico TipoServico { get; set; }

        public ValidationResult Validate 
            => new ServicoValidator().Validate(this);
    }
}
