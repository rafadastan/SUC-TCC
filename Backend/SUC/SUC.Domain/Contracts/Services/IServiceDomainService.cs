using SUC.Domain.Entities.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IServiceDomainService : IBaseDomainService<Servico, Guid>
    {
    }
}
