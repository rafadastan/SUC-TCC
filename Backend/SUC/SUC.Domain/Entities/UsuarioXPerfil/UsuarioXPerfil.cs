using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities
{
    public class UsuarioXPerfil
    {
        public Guid UsuarioXPerfilId { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid PerfilId { get; set; }
        public Guid CreateUserId { get; set; }
        public Guid LastModifierId { get; set; }
        public DateTime AssociateDate { get; set; }
        public DateTime DissociateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Usuario Usuario { get; set; }
        public Perfil Perfil { get; set; }
    }
}
