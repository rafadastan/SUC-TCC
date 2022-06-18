using SUC.Domain.Entities.Chamado;
using SUC.Domain.Models.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IChamadoRepository : IBaseRepository<Chamado, Guid>
    {
    }
}
