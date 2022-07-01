using SUC.Domain.Entities.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IServicoDomainService : IBaseDomainService<Servico, Guid>
    {
    }
}
