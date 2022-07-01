using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SUC.Domain.Enum.DomainEnum;

namespace SUC.Domain.Entities.Servicos
{
    public class Servico
    {
        public Guid IdServico { get; set; }
        public string NomeServico { get; set; }
        public bool Ativo { get; set; }
        public TipoServico TipoServico { get; set; }
    }
}
