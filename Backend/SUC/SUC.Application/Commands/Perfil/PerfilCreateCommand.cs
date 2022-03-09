using MediatR;
using SUC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Commands.Perfil
{
    public class PerfilCreateCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public PerfilEnum Perfil { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
