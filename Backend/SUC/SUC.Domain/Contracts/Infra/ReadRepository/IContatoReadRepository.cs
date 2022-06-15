using SUC.Domain.Models.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IContatoReadRepository : IBaseReadRepository<ContatoModel, Guid>
    {
    }
}
