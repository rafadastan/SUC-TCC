using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Demanda;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class DemandaCaching : IDemandaCaching
    {
        private readonly MongoDBContext _context;

        public DemandaCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(DemandaModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(DemandaModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<DemandaModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DemandaModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(DemandaModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
