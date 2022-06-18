using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities.Chamado;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class ChamadoRepository : BaseRepository<Chamado, Guid>, IChamadoRepository
    {
        private readonly SqlContext _sqlContext;

        public ChamadoRepository(SqlContext sqlContext) 
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
