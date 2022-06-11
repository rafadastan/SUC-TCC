using AutoMapper;
using FluentValidation;
using MediatR;
using SUC.Application.Commands.Perfil;
using SUC.Application.Notifications;
using SUC.Domain.Contracts.Perfils;
using SUC.Domain.Entities;
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
        private readonly IMapper _mapper;
        private readonly IPerfilDomainService _perfilDomainService;

        public PerfilRequestHandler(IMediator mediator, 
            IMapper mapper, 
            IPerfilDomainService perfilDomainService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _perfilDomainService = perfilDomainService;
        }

        public async Task<Unit> Handle(PerfilCreateCommand request, CancellationToken cancellationToken)
        {
            var perfil = _mapper.Map<Perfil>(request);

            perfil.IdPerfil = Guid.NewGuid();

            var result = perfil.Validate;
            if(!result.IsValid)
                throw new ValidationException(result.Errors);

            await _perfilDomainService.Create(perfil);

            var notification = new PerfilNotification
            {
                Action = ActionNotification.Create,
                Perfil = perfil
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }

        public async Task<Unit> Handle(PerfilUpdateCommand request, CancellationToken cancellationToken)
        {
            var perfil = _mapper.Map<Perfil>(request);

            await _perfilDomainService.Update(perfil);

            var notification = new PerfilNotification
            {
                Action = ActionNotification.Update,
                Perfil = perfil
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }

        public async Task<Unit> Handle(PerfilDeleteCommand request, CancellationToken cancellationToken)
        {
            var perfil = _mapper.Map<Perfil>(request);

            await _perfilDomainService.Delete(perfil);

            var notification = new PerfilNotification
            {
                Action = ActionNotification.Delete,
                Perfil = perfil
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }
    }
}
