using SUC.Domain.Entities.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IChamadoDomainService : IBaseDomainService<Chamado, Guid>
    {
    }
}
