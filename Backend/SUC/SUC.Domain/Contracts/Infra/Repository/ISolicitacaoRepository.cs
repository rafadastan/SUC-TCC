using SUC.Domain.Entities.Solicitacao;
using SUC.Domain.Models.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface ISolicitacaoRepository : IBaseRepository<Solicitacao, Guid>
    {
    }
}
