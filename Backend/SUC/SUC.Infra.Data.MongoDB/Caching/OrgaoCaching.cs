using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Orgao;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class OrgaoCaching : IOrgaoCaching
    {
        private readonly MongoDBContext _context;

        public OrgaoCaching(MongoDBContext context)
        {
            _context = context;
        }

        public Task Create(OrgaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(OrgaoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrgaoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrgaoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(OrgaoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
