using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Atendimento
{
    public class Atendimento
    {
        public Guid IdAtendimento { get; set; }
        public DomainEnum.Atendimento Status { get; set; }
        public string Descricao { get; set; }
    }
}
