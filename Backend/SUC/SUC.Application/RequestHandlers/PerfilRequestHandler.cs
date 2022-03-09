using MediatR;
using SUC.Application.Commands.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class PerfilRequestHandler :
        IRequestHandler<PerfilCreateCommand>,
        IRequestHandler<PerfilUpdateCommand>,
        IRequestHandler<PerfilDeleteCommand>
    {
        private readonly IMediator _mediator;

        public PerfilRequestHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<Unit> Handle(PerfilCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(PerfilUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(PerfilDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
