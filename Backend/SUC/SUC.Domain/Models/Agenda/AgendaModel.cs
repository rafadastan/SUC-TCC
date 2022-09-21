using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUC.Domain.ModelsBases;

namespace SUC.Domain.Models.Agenda
{
    public class AgendaModel : TenantModel<AgendaModel>
    {
        public Guid IdAgenda { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public DateTime DataAgenda { get; set; }
        public bool Ativo { get; set; }
    }
}
