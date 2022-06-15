using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Models.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepositoryEndereco
{
    public interface IEnderecoReadRepository : IBaseReadRepository<EnderecoModel, Guid>
    {
    }
}
