using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public abstract class BaseDomainService<TEntity, TKey> : IBaseDomainService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        private readonly IBaseRepository<TEntity, TKey> _repository;

        protected BaseDomainService(IBaseRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public virtual async Task Create(TEntity entity)
        {
            await _repository.Create(entity);
        }

        public virtual async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }

        public virtual async Task Delete(TEntity entity)
        {
            await _repository.Delete(entity);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task<TEntity> GetById(TKey id)
        {
            return await _repository.GetById(id);
        }
    }
}
