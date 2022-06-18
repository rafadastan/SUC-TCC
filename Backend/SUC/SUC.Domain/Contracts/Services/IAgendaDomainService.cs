using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IAgendaDomainService : IBaseDomainService<Agenda, Guid>
    {
    }
}
