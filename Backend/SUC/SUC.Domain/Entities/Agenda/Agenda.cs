using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Agenda
{
    public class Agenda
    {
        public Guid IdAgenda { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public DateTime DataAgenda { get; set; }
    }
}
