using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Contato;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class ContatoCaching : IContatoCaching
    {
        private readonly MongoDBContext _context;

        public ContatoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(ContatoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ContatoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContatoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ContatoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ContatoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
