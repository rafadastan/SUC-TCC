using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(TKey id);
    }
}
