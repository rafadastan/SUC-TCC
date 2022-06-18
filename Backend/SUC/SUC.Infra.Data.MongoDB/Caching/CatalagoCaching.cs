using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Catalago;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class CatalagoCaching : ICatalagoCaching
    {
        private readonly MongoDBContext _context;

        public CatalagoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(CatalagoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CatalagoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CatalagoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CatalagoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CatalagoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
