using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities.Agenda;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class AgendaRepository : BaseRepository<Agenda, Guid>, IAgenciaRepository
    {
        private readonly SqlContext _sqlContext;

        public AgendaRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
