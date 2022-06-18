using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Indice;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class IndiceCaching : IIndiceCaching
    {
        private readonly MongoDBContext _context;

        public IndiceCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(IndiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(IndiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<IndiceModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IndiceModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(IndiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
