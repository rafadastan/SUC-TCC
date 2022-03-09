using MongoDB.Driver;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Usuario;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class UsuarioCaching : IUsuarioCaching
    {
        private readonly MongoDBContext _context;

        public UsuarioCaching(MongoDBContext context)
        {
            _context = context;
        }

        public async Task Create(UsuarioModel entity)
        {
             await _context.Usuario.InsertOneAsync(entity);
        }

        public async Task Update(UsuarioModel entity)
        {
            var filter = Builders<UsuarioModel>.Filter.Eq(u => u.Id, entity.Id);
            await _context.Usuario.ReplaceOneAsync(filter, entity);
        }

        public async Task Delete(UsuarioModel entity)
        {
            var filter = Builders<UsuarioModel>.Filter.Eq(u => u.Id, entity.Id);
            await _context.Usuario.DeleteOneAsync(filter);
        }

        public async Task<List<UsuarioModel>> GetAll()
        {
            var filter = Builders<UsuarioModel>.Filter.Where(u => true);
            
            return await _context.Usuario.FindAsync(filter)
                .Result
                .ToListAsync();
        }

        public async Task<UsuarioModel> GetById(Guid id)
        {
            var filter = Builders<UsuarioModel>.Filter.Eq(u => u.Id, id);

            return await _context.Usuario.FindAsync(filter)
                .Result
                .FirstOrDefaultAsync();
        }
    }
}
