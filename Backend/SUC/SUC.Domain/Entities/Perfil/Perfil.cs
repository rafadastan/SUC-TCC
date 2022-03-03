using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string Perfis { get; set; }
        public Guid IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
