using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class AgendaCaching : IAgendaCaching
    {
        public Task Create(AgendaModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(AgendaModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AgendaModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AgendaModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AgendaModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
