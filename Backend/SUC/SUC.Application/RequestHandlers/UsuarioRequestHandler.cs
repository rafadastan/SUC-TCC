using MediatR;
using SUC.Application.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class UsuarioRequestHandler :
        IRequestHandler<UsuarioCreateCommand>,
        IRequestHandler<UsuarioUpdateCommand>,
        IRequestHandler<UsuarioDeleteCommand>
    {
        public Task<Unit> Handle(UsuarioCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(UsuarioUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(UsuarioDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
