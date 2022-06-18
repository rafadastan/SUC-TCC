using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.Informacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class InformacaoDomainService : BaseDomainService<Informacao, Guid>, IInformacaoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InformacaoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.InformacaoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
