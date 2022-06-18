using SUC.Domain.Models.Departamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IDepartamentoReadRepository : IBaseReadRepository<DepartamentoModel, Guid>
    {
    }
}
