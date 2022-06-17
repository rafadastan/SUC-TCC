using AutoMapper;
using MediatR;
using SUC.Application.Commands.Indice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class IndiceRequestHandler :
        IRequestHandler<IndiceCreateCommand>,
        IRequestHandler<IndiceUpdateCommand>,
        IRequestHandler<IndiceDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public IndiceRequestHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<Unit> Handle(IndiceCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(IndiceUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(IndiceDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
