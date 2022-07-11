using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Chamado
{
    public class Chamado : IBaseValidations
    {
        public Guid IdChamado { get; set; }
        public DomainEnum.Chamado Status { get; set; }
        public string Descricao { get; set; }

        public ValidationResult Validate => throw new NotImplementedException();
    }
}
