using MongoDB.Driver;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Perfil;
using SUC.Infra.Data.MongoDB.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class PerfilCaching : IPerfilCaching
    {
        private readonly MongoDBContext _context;

        public PerfilCaching(MongoDBContext context)
        {
            _context = context;
        }

        public async Task Create(PerfilModel entity)
        {
            await _context.Perfil.InsertOneAsync(entity);
        }

        public async Task Update(PerfilModel entity)
        {
            var filter = Builders<PerfilModel>.Filter.Eq(p => p.IdPerfil, entity.IdPerfil);
            await _context.Perfil.ReplaceOneAsync(filter, entity);
        }

        public async Task Delete(PerfilModel entity)
        {
            var filter = Builders<PerfilModel>.Filter.Eq(p => p.IdPerfil, entity.IdPerfil);
            await _context.Perfil.DeleteOneAsync(filter);
        }

        public async Task<List<PerfilModel>> GetAll()
        {
            var filter = Builders<PerfilModel>.Filter.Where(p => true);

            return await _context.Perfil.FindAsync(filter)
                .Result
                .ToListAsync();
        }

        public async Task<PerfilModel> GetById(Guid id)
        {
            var filter = Builders<PerfilModel>.Filter.Eq(p => p.IdPerfil, id);

            return await _context.Perfil.FindAsync(filter)
                .Result
                .FirstOrDefaultAsync();
        }
    }
}
