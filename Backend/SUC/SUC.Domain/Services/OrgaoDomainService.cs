using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class OrgaoDomainService : BaseDomainService<Orgao, Guid>, IOrgaoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrgaoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.OrgaoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
