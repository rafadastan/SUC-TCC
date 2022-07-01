using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class AvaliacaoDomainService : BaseDomainService<Avaliacao, Guid>, IAvaliacaoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AvaliacaoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.AvaliacaoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
