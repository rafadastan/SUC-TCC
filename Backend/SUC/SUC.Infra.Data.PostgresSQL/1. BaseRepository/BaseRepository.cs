using Microsoft.EntityFrameworkCore;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Infra.Data.PostgresSQL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL_BaseRepository
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        private readonly SqlContext _sqlContext;

        protected BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public virtual async Task Create(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Added;
            await _sqlContext.SaveChangesAsync();    
        }

        public virtual async Task Update(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Modified;
            await _sqlContext.SaveChangesAsync();
        }

        public virtual async Task Delete(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Deleted;
            await _sqlContext.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _sqlContext.Set<TEntity>()
                .ToListAsync();
        }

        public virtual async Task<List<TEntity>> GetAll(Func<TEntity, bool> where)
        {
            return _sqlContext.Set<TEntity>()
                .Where(where)
                .ToList();
        }

        public virtual async Task<TEntity> Get(Func<TEntity, bool> where)
        {
            return _sqlContext.Set<TEntity>()
                    .Where(where)
                    .FirstOrDefault();
        }

        public virtual async Task<TEntity> GetById(TKey id)
        {
            return await _sqlContext.Set<TEntity>()
                    .FindAsync(id);
        }
    }
}
