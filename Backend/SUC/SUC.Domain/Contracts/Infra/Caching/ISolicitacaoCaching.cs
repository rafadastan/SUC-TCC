using SUC.Domain.Models.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Caching
{
    public interface ISolicitacaoCaching : IBaseCaching<SolicitacaoModel, Guid>
    {
    }
}
