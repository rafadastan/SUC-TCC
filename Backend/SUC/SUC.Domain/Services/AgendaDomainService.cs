using SUC.Domain.Contracts.Infra.Repository;
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

        public AgendaDomainService(IUnitOfWork unitOfWork) : base(unitOfWork.AgenciaRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
