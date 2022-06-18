using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class ServicoDomainService : BaseDomainService<Servico, Guid>, IServicoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServicoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.ServicoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
