using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Perfils;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class PerfilDomainService : BaseDomainService<Perfil, Guid>, IPerfilDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PerfilDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.PerfilRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
