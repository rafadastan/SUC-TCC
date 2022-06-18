using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.DepartamentoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class DepartamentoDomainService : BaseDomainService<Departamento, Guid>, IDepartamentoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartamentoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.DepartamentoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
