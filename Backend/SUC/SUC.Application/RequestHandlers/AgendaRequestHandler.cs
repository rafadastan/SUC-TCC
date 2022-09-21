using AutoMapper;
using FluentValidation;
using MediatR;
using SUC.Application.Commands.Agenda;
using SUC.Application.Notifications;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SUC.Domain.Notifications;

namespace SUC.Application.RequestHandlers
{
    public class AgendaRequestHandler :
        IRequestHandler<AgendaCreateCommand>,
        IRequestHandler<AgendaUpdateCommand>,
        IRequestHandler<AgendaDeleteCommand>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IAgendaDomainService _agendaDomainService;
        private readonly NotificationContext _notificationContext;
        private readonly Notification _notification;

        public AgendaRequestHandler(IMediator mediator, 
            IMapper mapper,
            IAgendaDomainService agendaDomainService, 
            NotificationContext notificationContext)
        {
            _mediator = mediator;
            _mapper = mapper;
            _agendaDomainService = agendaDomainService;
            _notificationContext = notificationContext;
        }

        public async Task<Unit> Handle(AgendaCreateCommand request, CancellationToken cancellationToken)
        {
            var agenda = _mapper.Map<Agenda>(request);

            agenda.IdAgenda = Guid.NewGuid();

            var result = agenda.Validate;
            if (!result.IsValid)
                throw new ValidationException(result.Errors);

            await _agendaDomainService.Create(agenda);

            var notification = new AgendaNotification
            {
                Action = ActionNotification.Create,
                Agenda = agenda
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }

        public async Task<Unit> Handle(AgendaUpdateCommand request, CancellationToken cancellationToken)
        {
            var agenda = _mapper.Map<Agenda>(request);

            await _agendaDomainService.Update(agenda);

            var notification = new AgendaNotification
            {
                Action = ActionNotification.Update,
                Agenda = agenda
            };

            await _mediator.Publish(notification);

            return Unit.Value;
        }

        public async Task<Unit> Handle(AgendaDeleteCommand request, CancellationToken cancellationToken)
        {
            var agenda = _mapper.Map<Agenda>(request);
            
            await _agendaDomainService.Delete(agenda);

            if (_notificationContext.HasNotifications)
                return new Unit();

            var notification = new AgendaNotification
            {
                Action = ActionNotification.Delete,
                Agenda = agenda
            };
            
            await _mediator.Publish(notification, cancellationToken);

            return Unit.Value;
        }
    }
}
