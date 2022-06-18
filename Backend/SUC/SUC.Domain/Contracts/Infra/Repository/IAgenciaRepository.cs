using SUC.Domain.Entities.Agenda;
using SUC.Domain.Models.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IAgenciaRepository : IBaseRepository<Agenda, Guid>
    {
    }
}
