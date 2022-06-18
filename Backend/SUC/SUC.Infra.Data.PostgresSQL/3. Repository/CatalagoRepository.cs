using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities.Catalago;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class CatalagoRepository : BaseRepository<Catalago, Guid>, ICatalagoRepository
    {
        private readonly SqlContext _sqlContext;

        public CatalagoRepository(SqlContext sqlContext) 
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
