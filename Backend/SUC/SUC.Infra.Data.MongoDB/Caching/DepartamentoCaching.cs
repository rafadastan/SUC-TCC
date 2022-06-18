using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Departamento;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class DepartamentoCaching : IDepartamentoCaching
    {
        private readonly MongoDBContext _context;

        public DepartamentoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(DepartamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(DepartamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartamentoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DepartamentoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(DepartamentoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
