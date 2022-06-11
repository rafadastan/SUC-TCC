using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Servico
{
    public class Servico
    {
        public Guid IdServico { get; set; }
        public string NomeServico { get; set; }
        public bool Ativo { get; set; }

    }
}
