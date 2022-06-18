using SUC.Domain.Entities.Avaliacao;
using SUC.Domain.Models.Avaliacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IAvaliacaoRepository : IBaseRepository<Avaliacao, Guid>
    {
    }
}
