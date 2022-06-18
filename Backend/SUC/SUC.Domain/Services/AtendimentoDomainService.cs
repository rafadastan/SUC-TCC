using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class AtendimentoDomainService : BaseDomainService<Atendimento, Guid>, IAtendimentoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AtendimentoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.AtendimentoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
