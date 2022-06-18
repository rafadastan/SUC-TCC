using SUC.Domain.Entities.Servico;
using SUC.Domain.Models.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IServicoRepository : IBaseRepository<Servico, Guid>
    {
    }
}
