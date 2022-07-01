using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SUC.Domain.Enum.DomainEnum;

namespace SUC.Domain.Entities.Atendimento
{
    public class Atendimento
    {
        public Guid IdAtendimento { get; set; }
        public string NomeAtendimento { get; set; }
        public DomainEnum.Atendimento Status { get; set; }
        public TipoServico TipoServico { get; set; }
        public string Descricao { get; set; }
    }
}
