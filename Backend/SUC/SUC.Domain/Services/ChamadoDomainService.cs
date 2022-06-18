using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class ChamadoDomainService : BaseDomainService<Chamado, Guid>, IChamadoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChamadoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.ChamadoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
