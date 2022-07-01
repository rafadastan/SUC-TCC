using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Matricula
{
    public class Matricula
    {
        public Guid IdMatricula { get; set; }
        public int NumeroMatricula { get; set; }
        public int TipoMatricula { get; set; }
        public decimal Valor { get; set; }

        public Endereco Endereco { get; set; }
    }
}
