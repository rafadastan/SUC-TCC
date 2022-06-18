using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Avaliacao;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class AvaliacaoCaching : IAvaliacaoCaching
    {
        private readonly MongoDBContext _context;

        public AvaliacaoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(AvaliacaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(AvaliacaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AvaliacaoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AvaliacaoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AvaliacaoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
