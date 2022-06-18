using SUC.Domain.Contracts.Infra.ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL_ReadRepository
{
    public class BaseReadRepository<TEntity, Guid> : IBaseReadRepository<TEntity, Guid>
        where TEntity : class
        where Guid : struct
    {
    }
}
