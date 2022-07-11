using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Demanda
{
    public class Demanda : IBaseValidations
    {
        public Guid IdDemanda { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public string Protocolo { get; set; }

        public ValidationResult Validate => throw new NotImplementedException();
    }
}
