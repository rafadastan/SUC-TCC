using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Infra.RepositoryAgenda;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SUC.Domain.Notifications;

namespace SUC.Domain.Services
{
    public class AgendaDomainService : BaseDomainService<Agenda, Guid>, IAgendaDomainService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAgendaRepository _agendaRepository;
        private readonly NotificationContext _notificationContext;

        public AgendaDomainService(IUnitOfWork unitOfWork, 
            IAgendaRepository agendaRepository, 
            NotificationContext notificationContext)
            : base(unitOfWork.AgenciaRepository)
        {
            _unitOfWork = unitOfWork;
            _agendaRepository = agendaRepository;
            _notificationContext = notificationContext;
        }

        public override async Task Create(Agenda entity)
        {
            await base.Create(entity);
        }

        public override async Task Update(Agenda entity)
        {
            await base.Update(entity);
        }

        public override async Task Delete(Agenda entity)
        {
            if (await _agendaRepository.GetById(entity.IdAgenda) == null)
                _notificationContext.AddNotification(entity.IdAgenda.ToString(), "Error ao deletar");

            if (!_notificationContext.HasNotifications)
                await _unitOfWork.AgenciaRepository.Delete(entity);
            else
                return;
        }
    }
}
