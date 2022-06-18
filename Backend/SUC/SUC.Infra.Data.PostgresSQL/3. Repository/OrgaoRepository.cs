using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class OrgaoRepository : BaseRepository<Orgao, Guid>, IOrgaoRepository
    {
        private readonly SqlContext _sqlContext;

        public OrgaoRepository(SqlContext sqlContext) 
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
