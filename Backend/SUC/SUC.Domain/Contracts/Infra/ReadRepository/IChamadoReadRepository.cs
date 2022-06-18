using SUC.Domain.Models.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IChamadoReadRepository : IBaseReadRepository<ChamadoModel, Guid>
    {
    }
}
