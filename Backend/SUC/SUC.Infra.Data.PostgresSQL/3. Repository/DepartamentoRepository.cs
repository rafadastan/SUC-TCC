using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities.DepartamentoEntity;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class DepartamentoRepository : BaseRepository<Departamento, Guid>, IDepartamentoRepository
    {
        private readonly SqlContext _sqlContext;

        public DepartamentoRepository(SqlContext sqlContext) 
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
