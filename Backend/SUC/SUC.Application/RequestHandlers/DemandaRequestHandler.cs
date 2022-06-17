using AutoMapper;
using MediatR;
using SUC.Application.Commands.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class DemandaRequestHandler :
        IRequestHandler<DemandaCreateCommand>,
        IRequestHandler<DemandaUpdateCommand>,
        IRequestHandler<DemandaDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public DemandaRequestHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<Unit> Handle(DemandaCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(DemandaUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(DemandaDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
