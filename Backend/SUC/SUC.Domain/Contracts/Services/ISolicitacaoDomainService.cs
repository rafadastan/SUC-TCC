using SUC.Domain.Entities.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface ISolicitacaoDomainService : IBaseDomainService<Solicitacao, Guid>
    {
    }
}
