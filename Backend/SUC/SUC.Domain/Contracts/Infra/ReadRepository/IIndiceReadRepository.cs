using SUC.Domain.Models.Indice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IIndiceReadRepository : IBaseReadRepository<IndiceModel, Guid>
    {
    }
}
