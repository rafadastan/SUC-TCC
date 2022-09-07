using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Indices
{
    public class Indice : IBaseValidations
    {
        public Guid IdIndice { get; set; }
        public int Percentual { get; set; }
        public int Media { get; set; }

        public ValidationResult Validate 
            => new IndiceValidator().Validate(this);
    }
}
