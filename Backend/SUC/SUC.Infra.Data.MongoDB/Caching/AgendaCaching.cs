using MongoDB.Driver;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Agenda;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class AgendaCaching : IAgendaCaching
    {
        private readonly MongoDBContext _context;

        public AgendaCaching(MongoDBContext context)
        {
            _context = context;
        }

        public async Task Create(AgendaModel entity)
        {
            await _context.Agenda.InsertOneAsync(entity);
        }
        public async Task Update(AgendaModel entity)
        {
            var filter = Builders<AgendaModel>.Filter.Eq(u => u.IdAgenda, entity.IdAgenda);
            await _context.Agenda.ReplaceOneAsync(filter, entity);
        }

        public async Task Delete(AgendaModel entity)
        {
            var filter = Builders<AgendaModel>.Filter.Eq(u => u.IdAgenda, entity.IdAgenda);
            await _context.Agenda.DeleteOneAsync(filter);
        }

        public async Task<List<AgendaModel>> GetAll()
        {
            var filter = Builders<AgendaModel>.Filter.Where(u => true);

            return await _context.Agenda.FindAsync(filter)
                .Result
                .ToListAsync();
        }

        public async Task<AgendaModel> GetById(Guid id)
        {
            var filter = Builders<AgendaModel>.Filter.Eq(u => u.IdAgenda, id);

            return await _context.Agenda.FindAsync(filter)
                .Result
                .FirstOrDefaultAsync();
        }
    }
}
