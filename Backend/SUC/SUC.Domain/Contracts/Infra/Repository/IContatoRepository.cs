using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IContatoRepository : IBaseRepository<Contato, Guid>
    {
    }
}
