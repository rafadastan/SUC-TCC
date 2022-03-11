using AutoMapper;
using MediatR;
using SUC.Application.Notifications;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.Handlers
{
    public class PerfilHandler : INotificationHandler<PerfilNotification>
    {
        private readonly IMapper _mapper;
        private readonly IPerfilCaching _perfilCaching;

        public PerfilHandler(IMapper mapper, IPerfilCaching perfilCaching)
        {
            _mapper = mapper;
            _perfilCaching = perfilCaching;
        }

        public Task Handle(PerfilNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var perfil = _mapper.Map<PerfilModel>(notification.Perfil);

                switch (notification.Action)
                {
                    case ActionNotification.Create:
                        _perfilCaching.Create(perfil);
                        break;

                    case ActionNotification.Update:
                        _perfilCaching.Update(perfil);
                        break;

                    case ActionNotification.Delete:
                        _perfilCaching.Delete(perfil);
                        break;

                }
            });
        }
    }
}
