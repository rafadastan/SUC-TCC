using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Chamado;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class ChamadoCaching : IChamadoCaching
    {
        private readonly MongoDBContext _context;

        public ChamadoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(ChamadoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ChamadoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChamadoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ChamadoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ChamadoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
