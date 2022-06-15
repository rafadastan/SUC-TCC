using AutoMapper;
using MediatR;
using SUC.Application.Commands.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlersContato
{
    public class ContatoRequestHandler :
        IRequestHandler<ContatoCreateCommand>,
        IRequestHandler<ContatoUpdateCommand>,
        IRequestHandler<ContatoDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ContatoRequestHandler(IMediator mediator, 
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(ContatoUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Handle(ContatoDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Handle(ContatoCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
