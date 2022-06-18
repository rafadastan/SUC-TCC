using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class SolicitacaoDomainService : BaseDomainService<Solicitacao, Guid>, ISolicitacaoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SolicitacaoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.SolicitacaoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
