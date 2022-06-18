using SUC.Domain.Entities.DepartamentoEntity;
using SUC.Domain.Models.Departamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IDepartamentoRepository : IBaseRepository<Departamento, Guid>
    {
    }
}
