using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities.EntityEndereco;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class EnderecoRepository : BaseRepository<Endereco, Guid>, IEnderecoRepository
    {
        private readonly SqlContext _sqlContext;

        public EnderecoRepository(SqlContext sqlContext) 
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
