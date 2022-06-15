using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IEnderecoRepository : IBaseRepository<Endereco, Guid>
    {
    }
}
