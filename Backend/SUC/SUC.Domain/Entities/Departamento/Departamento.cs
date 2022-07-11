using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.DepartamentoEntity
{
    public class Departamento : IBaseValidations
    {
        public Guid IdDepartamento { get; set; }
        public string NomeDepartamento { get; set; }

        public ValidationResult Validate => throw new NotImplementedException();
    }
}
