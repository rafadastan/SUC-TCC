using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class CatalagoDomainService : BaseDomainService<Catalago, Guid>, ICatalagoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CatalagoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.CatalagoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
