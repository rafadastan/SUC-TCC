using AutoMapper;
using MediatR;
using SUC.Application.Commands.Catalago;
using SUC.Application.Commands.CatalagoDelete;
using SUC.Application.Commands.CatalagoUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class CatalagoRequestHandler :
        IRequestHandler<CatalogoCreateCommand>,
        IRequestHandler<CatalogoUpdateCommand>,
        IRequestHandler<CatalogoDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CatalagoRequestHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CatalogoCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(CatalogoUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(CatalogoDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
