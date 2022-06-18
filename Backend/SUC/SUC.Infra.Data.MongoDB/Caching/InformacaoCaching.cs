using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Informacao;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class InformacaoCaching : IInformacaoCaching
    {
        private readonly MongoDBContext _context;

        public InformacaoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(InformacaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(InformacaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<InformacaoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<InformacaoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(InformacaoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
