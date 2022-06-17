using AutoMapper;
using MediatR;
using SUC.Application.Commands.Servico;
using SUC.Application.Commands.ServicoDelete;
using SUC.Application.Commands.ServicoUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class ServicoRequestHandler :
        IRequestHandler<ServiceCreateCommand>,
        IRequestHandler<ServiceUpdateCommand>,
        IRequestHandler<ServiceDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ServicoRequestHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<Unit> Handle(ServiceCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(ServiceUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(ServiceDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
