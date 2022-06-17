using AutoMapper;
using MediatR;
using SUC.Application.Commands.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class SolicitacaoRequestHandler :
        IRequestHandler<SolicitacaoCreateCommand>,
        IRequestHandler<SolicitacaoUpdateCommand>,
        IRequestHandler<SolicitacaoDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public SolicitacaoRequestHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(SolicitacaoUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Handle(SolicitacaoCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Handle(SolicitacaoDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
