using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Catalago
{
    public class Catalago
    {
        public Guid IdCatalogo { get; set; }
        public string NomeCatalogo { get; set; }
        public string Image { get; set; }
        public string Descricao { get; set; }

        public Endereco Endereco { get; set; }
    }
}
