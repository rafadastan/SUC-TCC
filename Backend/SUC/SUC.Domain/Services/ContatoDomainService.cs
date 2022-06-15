using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class ContatoDomainService : BaseDomainService<Contato, Guid>, IContatoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContatoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.ContatoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
