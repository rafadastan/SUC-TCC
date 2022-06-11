using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SUC.Domain.Entities;
using System.Threading.Tasks;
using SUC.Domain.Entities.DepartamentoEntity;

namespace SUC.Domain.Entities
{
    public class Orgao
    {
        public Guid IdOrgao { get; set; }
        public string NomeOrgao { get; set; }
        public Departamento Departamento { get; set; }
    }
}
