using SUC.Domain.Entities.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IDemandaDomainService : IBaseDomainService<Demanda, Guid>
    {
    }
}
