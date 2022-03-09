using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Models.Perfil
{
    public class PerfilModel
    {
        public Guid Id { get; set; }
        public PerfilEnum Perfis { get; set; }
        public Guid IdUsuario { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
