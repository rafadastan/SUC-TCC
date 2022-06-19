using AutoMapper;
using MediatR;
using SUC.Application.Notifications;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SUC.Application.Handlers
{
    public class AgendaHandler : INotificationHandler<AgendaNotification>
    {
        private IMapper _mapper;
        private IAgendaCaching _agendaCaching;

        public AgendaHandler(IMapper mapper, IAgendaCaching agendaCaching)
        {
            _mapper = mapper;
            _agendaCaching = agendaCaching;
        }

        public Task Handle(AgendaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var agenda = _mapper.Map<AgendaModel>(notification.Agenda);

                switch (notification.Action)
                {
                    case ActionNotification.Create:
                        _agendaCaching.Create(agenda);
                        break;
                    case ActionNotification.Update:
                        _agendaCaching.Update(agenda);
                        break;
                    case ActionNotification.Delete:
                        _agendaCaching.Delete(agenda);
                        break;
                }
            });
        }
    }
}
