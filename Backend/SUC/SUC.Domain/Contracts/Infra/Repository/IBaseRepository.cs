using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetAll(Func<TEntity, bool> where);

        Task<TEntity> Get(Func<TEntity, bool> where);
        Task<TEntity> GetById(TKey id);
    }
}
