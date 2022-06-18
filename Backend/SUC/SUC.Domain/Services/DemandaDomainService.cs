using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class DemandaDomainService : BaseDomainService<Demanda, Guid>, IDemandaDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DemandaDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.DemandaRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
