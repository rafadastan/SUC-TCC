using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Commands.Usuario
{
    public class UsuarioDeleteCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
