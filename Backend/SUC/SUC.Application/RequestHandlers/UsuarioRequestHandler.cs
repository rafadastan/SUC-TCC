using AutoMapper;
using FluentValidation;
using MediatR;
using SUC.Application.Commands.Usuario;
using SUC.Application.Notifications;
using SUC.Domain.Contracts.Usuarios;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.RequestHandlers
{
    public class UsuarioRequestHandler :
        IRequestHandler<UsuarioCreateCommand>,
        IRequestHandler<UsuarioUpdateCommand>,
        IRequestHandler<UsuarioDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IUsuarioDomainService _usuarioDomainService;

        public UsuarioRequestHandler(IMediator mediator, 
            IMapper mapper, 
            IUsuarioDomainService usuarioDomainService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _usuarioDomainService = usuarioDomainService;
        }

        public async Task<Unit> Handle(UsuarioCreateCommand request, CancellationToken cancellationToken)
        {
            var usuario = _mapper.Map<Usuario>(request);

            var result = usuario.Validate;
            if (!result.IsValid)
                throw new ValidationException(result.Errors);

            await _usuarioDomainService.Create(usuario);

            var notification = new UsuarioNotification
            {
                Action = ActionNotification.Create,
                Usuario = usuario
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }

        public async Task<Unit> Handle(UsuarioUpdateCommand request, CancellationToken cancellationToken)
        {
            var usuario = _mapper.Map<Usuario>(request);

            await _usuarioDomainService.Update(usuario);

            var notification = new UsuarioNotification
            {
                Action = ActionNotification.Update,
                Usuario = usuario
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }

        public async Task<Unit> Handle(UsuarioDeleteCommand request, CancellationToken cancellationToken)
        {
            var usuario = _mapper.Map<Usuario>(request);

            await _usuarioDomainService.Delete(usuario);

            var notification = new UsuarioNotification
            {
                Action = ActionNotification.Delete,
                Usuario = usuario
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }
    }
}
