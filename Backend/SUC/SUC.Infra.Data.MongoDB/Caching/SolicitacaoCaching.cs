using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Solicitacao;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class SolicitacaoCaching : ISolicitacaoCaching
    {
        private readonly MongoDBContext _context;

        public SolicitacaoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(SolicitacaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(SolicitacaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<SolicitacaoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SolicitacaoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(SolicitacaoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
