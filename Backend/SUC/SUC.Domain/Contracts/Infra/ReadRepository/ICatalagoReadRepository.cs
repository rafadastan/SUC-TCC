using SUC.Domain.Models.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface ICatalagoReadRepository : IBaseReadRepository<CatalagoModel, Guid>
    {
    }
}
