using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.OperadorAdm
{
    public class OperadorAdministrador
    {
        public Guid IdOperadorAdministrador { get; set; }
        public string Nome { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public Guid? LastModifierUserId { get; set; }
    }
}
