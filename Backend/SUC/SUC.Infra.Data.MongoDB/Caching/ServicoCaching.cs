using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Servico;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class ServicoCaching : IServicoCaching
    {
        private readonly MongoDBContext _context;

        public ServicoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(ServicoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ServicoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServicoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServicoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ServicoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
