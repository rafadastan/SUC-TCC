using SUC.Domain.Models.Avaliacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Caching
{
    public interface IAvaliacaoCaching : IBaseCaching<AvaliacaoModel, Guid>
    {
    }
}
