using AutoMapper;
using MediatR;
using SUC.Application.Commands.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class AtendimentoRequestHandler :
        IRequestHandler<AtendimentoCreateCommand>,
        IRequestHandler<AtendimentoUpdateCommand>,
        IRequestHandler<AtendimentoDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AtendimentoRequestHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<Unit> Handle(AtendimentoCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(AtendimentoUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(AtendimentoDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
