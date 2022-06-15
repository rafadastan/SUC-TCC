using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class EnderecoDomainService : BaseDomainService<Endereco, Guid>, IEnderecoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EnderecoDomainService(IUnitOfWork unitOfWork) 
            : base(unitOfWork.EnderecoRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
