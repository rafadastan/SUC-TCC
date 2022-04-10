using AutoMapper;
using MediatR;
using SUC.Application.Notifications;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.Handlers
{
    public class UsuarioHandler : INotificationHandler<UsuarioNotification>
    {
        private readonly IUsuarioCaching _usuarioCaching;
        private readonly IMapper _mapper;

        public UsuarioHandler(IUsuarioCaching usuarioCaching, IMapper mapper)
        {
            _usuarioCaching = usuarioCaching;
            _mapper = mapper;
        }

        public Task Handle(UsuarioNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var usuario = _mapper.Map<UsuarioModel>(notification.Usuario);

                switch (notification.Action)
                {
                    case ActionNotification.Create:
                        _usuarioCaching.Create(usuario);
                        break;

                    case ActionNotification.Update:
                        _usuarioCaching.Update(usuario);
                        break;

                    case ActionNotification.Delete:
                        _usuarioCaching.Delete(usuario);
                        break;
                }
            }); 
        }
    }
}
