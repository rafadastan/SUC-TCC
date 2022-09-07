using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Enum;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SUC.Domain.Enum.DomainEnum;

namespace SUC.Domain.Entities.Atendimento
{
    public class Atendimento : IBaseValidations
    {
        public Guid IdAtendimento { get; set; }
        public string NomeAtendimento { get; set; }
        public DomainEnum.Atendimento Status { get; set; }
        public TipoServico TipoServico { get; set; }
        public string Descricao { get; set; }

        public ValidationResult Validate 
            => new AtendimentoValidation().Validate(this);
    }
}
