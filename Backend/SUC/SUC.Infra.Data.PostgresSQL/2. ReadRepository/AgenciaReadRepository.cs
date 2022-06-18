using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Models.Agenda;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.ReadRepository
{
    public class AgenciaReadRepository : BaseReadRepository<AgendaModel, Guid>, IAgenciaReadRepository
    {
    }
}
