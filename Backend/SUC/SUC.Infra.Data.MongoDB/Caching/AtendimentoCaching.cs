using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class AtendimentoCaching : IAtendimentoCaching
    {
        public Task Create(AtendimentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(AtendimentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AtendimentoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AtendimentoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AtendimentoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
