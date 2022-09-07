using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SUC.Domain.Entities;
using System.Threading.Tasks;
using SUC.Domain.Entities.DepartamentoEntity;
using SUC.Domain.Contracts.Base;
using FluentValidation.Results;
using SUC.Domain.Validations;

namespace SUC.Domain.Entities
{
    public class Orgao : IBaseValidations
    {
        public Guid IdOrgao { get; set; }
        public string NomeOrgao { get; set; }
        public Departamento Departamento { get; set; }

        public ValidationResult Validate 
            => new OrgaoValidator().Validate(this);
    }
}
