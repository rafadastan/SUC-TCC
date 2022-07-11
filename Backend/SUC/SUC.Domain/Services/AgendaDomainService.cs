using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Infra.RepositoryAgenda;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class AgendaDomainService : BaseDomainService<Agenda, Guid>, IAgendaDomainService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAgendaRepository _agendaRepository;
        public AgendaDomainService(IUnitOfWork unitOfWork, 
            IAgendaRepository agendaRepository)
            : base(unitOfWork.AgenciaRepository)
        {
            _unitOfWork = unitOfWork;
            _agendaRepository = agendaRepository;
        }

        public override Task Create(Agenda entity)
        {
            return base.Create(entity);
        }

        public override Task Update(Agenda entity)
        {
            return base.Update(entity);
        }

        public override Task Delete(Agenda entity)
        {
            return base.Delete(entity);
        }
    }
}
