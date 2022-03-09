using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Caching
{
    public interface IBaseCaching<TModel, TKey>
        where TModel : class
        where TKey : struct
    {
        Task Create(TModel entity);
        Task Update(TModel entity);
        Task Delete(TModel entity);

        Task<List<TModel>> GetAll();
        Task<TModel> GetById(TKey id);
    }
}
