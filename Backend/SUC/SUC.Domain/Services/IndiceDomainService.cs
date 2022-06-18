using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class IndiceDomainService : BaseDomainService<Indice, Guid>, IIndiceDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IndiceDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.IndiceRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
