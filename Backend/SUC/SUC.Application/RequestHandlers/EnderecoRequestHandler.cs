using AutoMapper;
using MediatR;
using SUC.Application.Commands.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class EnderecoRequestHandler :
        IRequestHandler<EnderecoCreateCommand>,
        IRequestHandler<EnderecoUpdateCommand>,
        IRequestHandler<EnderecoDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public EnderecoRequestHandler(IMediator mediator, 
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(EnderecoDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(EnderecoUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(EnderecoCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
