using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Solicitacao
{
    public class Solicitacao
    {
        public Guid IdSolicitacao { get; set; }
        public string Descricao { get; set; }
        public DomainEnum.Solicitacao Status { get; set; }
    }
}
